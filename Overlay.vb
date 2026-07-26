Imports System.Drawing
Imports System.Windows.Forms
Imports Skye.WinAPI

Friend Class Overlay

    Private hWnd As IntPtr = IntPtr.Zero

    Private _icon As Image
    Private _title As String
    Private _text As String

    Private ReadOnly TitleFont As New Font("Segoe UI", 10.5F, FontStyle.Bold)
    Private ReadOnly TextFont As New Font("Segoe UI", 10.0F, FontStyle.Regular)

    Private Const PaddingSize As Integer = 12
    Private Const IconSize As Integer = 32

    Friend Sub CreateWindow()
        If hWnd <> IntPtr.Zero Then Exit Sub

        Dim exStyle As Integer =
        WS_EX_TOPMOST Or WS_EX_TOOLWINDOW Or WS_EX_NOACTIVATE Or WS_EX_LAYERED

        Dim style As Integer = WS_POPUP

        hWnd = CreateWindowEx(exStyle, "STATIC", String.Empty, style, 0, 0, 200, 80, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero)

        If hWnd = IntPtr.Zero Then
            Throw New Exception("Overlay window creation failed.")
        End If

        ' Remove STATIC border
        Dim s As Integer = GetWindowLong(hWnd, GWL_STYLE)
        Dim HResult As Integer = SetWindowLong(hWnd, GWL_STYLE, s And Not WS_BORDER)

        ' Set opacity to fully visible
        SetLayeredWindowAttributes(hWnd, 0, 255, LWA_ALPHA)

        ApplyDwmAttributes()
    End Sub


    Private Sub ApplyDwmAttributes()
        Const DWMWA_WINDOW_CORNER_PREFERENCE As Integer = 33
        Const DWMWCP_ROUND As Integer = 2
        Const DWMWA_USE_IMMERSIVE_DARK_MODE As Integer = 20
        Dim HResult As Integer

        Dim cornerPref As Integer = DWMWCP_ROUND
        HResult = DwmSetWindowAttribute(hWnd, DWMWA_WINDOW_CORNER_PREFERENCE, cornerPref, 4)

        Dim darkMode As Integer = 1
        HResult = DwmSetWindowAttribute(hWnd, DWMWA_USE_IMMERSIVE_DARK_MODE, darkMode, 4)
    End Sub
    Friend Sub ShowOverlay(parent As Form, icon As Image, title As String, text As String)
        If hWnd = IntPtr.Zero Then CreateWindow()

        _icon = icon
        _title = title
        _text = text

        Dim size As System.Drawing.Size = MeasureContentSize()

        Dim x As Integer = parent.Left
        Dim y As Integer = parent.Top

        ClampToScreen(x, y, size.Width, size.Height)

        MoveWindow(hWnd, x, y, size.Width, size.Height, True)

        ShowWindow(hWnd, SW_SHOWNOACTIVATE)

        SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 0, 0,
                 SWP_NOMOVE Or SWP_NOSIZE Or SWP_NOACTIVATE Or SWP_SHOWWINDOW)

        UpdateWindow(hWnd)
        DrawContent()
    End Sub
    Private Function MeasureContentSize() As System.Drawing.Size
        Using bmp As New Bitmap(1, 1)
            Using g As Graphics = Graphics.FromImage(bmp)

                Dim titleToMeasure As String = _title.Replace(vbCr, vbCrLf)
                Dim textToMeasure As String = _text.Replace(vbCr, vbCrLf)

                Dim titleSize As SizeF = g.MeasureString(titleToMeasure, TitleFont)
                Dim textSize As SizeF = g.MeasureString(textToMeasure, TextFont)

                Dim titleWidth As Single = PaddingSize + IconSize + PaddingSize + titleSize.Width + PaddingSize
                Dim textWidth As Single = PaddingSize + textSize.Width + PaddingSize

                Dim width As Single = Math.Max(titleWidth, textWidth)
                Dim height As Single = PaddingSize + Math.Max(IconSize, titleSize.Height) + PaddingSize + textSize.Height + PaddingSize

                Return New System.Drawing.Size(CInt(Math.Ceiling(width)), CInt(Math.Ceiling(height)))
            End Using
        End Using
    End Function
    Private Sub DrawContent()

        Dim BackColor As Color = Skye.UI.ThemeManager.CurrentTheme.TextBack
        Dim TextColor As Color = Skye.UI.ThemeManager.CurrentTheme.TextFore
        Dim rc As RECT
        If Not GetClientRect(hWnd, rc) Then Exit Sub

        Dim w As Integer = rc.Right - rc.Left
        Dim h As Integer = rc.Bottom - rc.Top

        Dim hDC As IntPtr = GetDC(hWnd)
        If hDC = IntPtr.Zero Then Exit Sub

        Using g As Graphics = Graphics.FromHdc(hDC)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

            Using bg As New SolidBrush(BackColor)
                g.FillRectangle(bg, 0, 0, w, h)
            End Using

            Dim x As Integer = PaddingSize
            Dim y As Integer = PaddingSize

            If _icon IsNot Nothing Then
                g.DrawImage(_icon, New Rectangle(x, y, IconSize, IconSize))
            End If

            Dim titleX As Integer = x + IconSize + PaddingSize
            Dim titleY As Integer = y + CInt((IconSize - TitleFont.GetHeight(g)) / 2)

            Dim titleToDraw As String = _title.Replace(vbCr, vbCrLf)
            Dim textToDraw As String = _text.Replace(vbCr, vbCrLf)

            Using br As New SolidBrush(TextColor)
                g.DrawString(titleToDraw, TitleFont, br, titleX, titleY)
                g.DrawString(textToDraw, TextFont, br, x, y + IconSize + PaddingSize)
            End Using
        End Using

        Dim HResult As Integer = ReleaseDC(hWnd, hDC)
    End Sub
    Private Shared Sub ClampToScreen(ByRef x As Integer, ByRef y As Integer, ByVal w As Integer, ByVal h As Integer)
        Dim wa As Rectangle = Screen.PrimaryScreen.WorkingArea

        If x + w > wa.Right Then x = wa.Right - w
        If y + h > wa.Bottom Then y = wa.Bottom - h
    End Sub
    Friend Sub HideOverlay()
        If hWnd <> IntPtr.Zero Then
            ShowWindow(hWnd, SW_HIDE)
        End If
    End Sub

End Class
