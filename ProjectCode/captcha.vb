Imports System.Drawing.Drawing2D
Public Class captcha
    Private str As String ' classwide string, given value on each call of captchaDraw, and used to verify the user input by comparing it
    Private Const captchanum As String = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
    Private rand As New Random
    Private Sub captcha_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'draw captcha everytime form loads
        captchadraw()
    End Sub

    Private Sub VerifyBtn_Click(sender As Object, e As EventArgs) Handles VerifyBtn.Click
        If UserCaptchaTxtBx.Text = str And employeeAccessLevel_ = True Then
            MsgBox("Captcha verified, success! Welcome Admin!" & employeeName_)
            Me.Close()
            MenuMain.Show()
            UserCaptchaTxtBx.Clear()
        ElseIf UserCaptchaTxtBx.Text = str And employeeAccessLevel_ = False Then
            MsgBox("Captcha verified, success! Welcome " & employeeName_)
            Me.Close()
            MenuMain.Show()
            UserCaptchaTxtBx.Clear()
        ElseIf UserCaptchaTxtBx.Text = "" Then
            MsgBox("Please enter a captcha code")
            UserCaptchaTxtBx.Clear()
            captchadraw()
        Else
            MsgBox("Captcha incorrect, please try again")
            UserCaptchaTxtBx.Clear()
            captchadraw()
        End If
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        captchadraw()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
        login.Show()
        UserCaptchaTxtBx.Clear()
    End Sub

    Private Sub captchadraw()
        str = ""
        For i = 0 To 6
            str = str + captchanum(rand.Next(0, 60))
        Next
        Dim image As New Bitmap(400, 200, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(image)
        g.Clear(Color.Lavender)

        Dim font As New Font("Monotype Corsiva", 40, FontStyle.Strikeout)
        Dim brush As New SolidBrush(Color.Black)

        ' Distort the text by applying a random warp
        Dim path As New GraphicsPath()
        path.AddString(str, font.FontFamily, font.Style, font.Size, New Point(rand.Next(0, 100), rand.Next(0, 25)), StringFormat.GenericDefault)
        Dim matrix As New Matrix()
        matrix.Translate(0, 0)
        path.Warp(New PointF() {New PointF(0, 0), New PointF(image.Width, image.Height / 3), New PointF(image.Width / 2, image.Height)}, New RectangleF(0, 0, image.Width, image.Height), matrix, WarpMode.Perspective, 0)

        ' Draw the distorted text on the image
        g.DrawPath(New Pen(brush, 2), path)
        g.FillPath(brush, path)

        CaptchaPicBox.Image = image
    End Sub
End Class