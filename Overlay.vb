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

    Private ReadOnly BackColor As Color = Skye.UI.ThemeManager.CurrentTheme.BackColor 'Color.FromArgb(32, 32, 32)
    Private ReadOnly TextColor As Color = Skye.UI.ThemeManager.CurrentTheme.ForeColor 'Color.White

    Friend Sub CreateWindow()
        If hWnd <> IntPtr.Zero Then Exit Sub

        Dim exStyle As Integer =
            WS_EX_TOPMOST Or WS_EX_TOOLWINDOW Or WS_EX_NOACTIVATE Or WS_EX_LAYERED Or WS_EX_TRANSPARENT

        Dim style As Integer = WS_POPUP

        hWnd = CreateWindowEx(
            exStyle,
            "STATIC",
            String.Empty,
            style,
            0, 0, 200, 80,
            IntPtr.Zero,
            IntPtr.Zero,
            IntPtr.Zero,
            IntPtr.Zero)

        If hWnd = IntPtr.Zero Then
            Throw New Exception("Overlay window creation failed.")
        End If

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
    Friend Sub ShowOverlay(ByVal parent As Form, ByVal icon As Image, ByVal title As String, ByVal text As String)
        If hWnd = IntPtr.Zero Then CreateWindow()

        _icon = icon
        _title = title
        _text = text

        Dim size As System.Drawing.Size = MeasureContentSize()

        Dim x As Integer = parent.Left
        Dim y As Integer = parent.Top

        ClampToScreen(x, y, size.Width, size.Height)

        MoveWindow(hWnd, x, y, size.Width, size.Height, True)

        DrawContent()

        ShowWindow(hWnd, SW_SHOWNOACTIVATE)
        UpdateWindow(hWnd)
    End Sub
    Private Function MeasureContentSize() As System.Drawing.Size
        Using bmp As New Bitmap(1, 1)
            Using g As Graphics = Graphics.FromImage(bmp)
                Dim titleSize As SizeF = g.MeasureString(_title, TitleFont)
                Dim textSize As SizeF = g.MeasureString(_text, TextFont)

                Dim width As Single =
                    Math.Max(IconSize + PaddingSize * 2 + titleSize.Width,
                             PaddingSize * 2 + textSize.Width)

                Dim height As Single =
                    PaddingSize * 2 + IconSize + PaddingSize + textSize.Height

                Return New System.Drawing.Size(CInt(Math.Ceiling(width)), CInt(Math.Ceiling(height)))
            End Using
        End Using
    End Function
    Private Sub DrawContent()
        Dim rc As RECT
        GetClientRect(hWnd, rc)

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

            Using br As New SolidBrush(TextColor)
                g.DrawString(_title, TitleFont, br, titleX, titleY)
                g.DrawString(_text, TextFont, br, x, y + IconSize + PaddingSize)
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
