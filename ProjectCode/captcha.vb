Imports System.Drawing.Drawing2D
Public Class captcha
    Dim str As String
    Private Sub captchaDelete() 'Needed to properly clear captcha if the form is left
        Dim Map As New Bitmap(320, 80, Imaging.PixelFormat.Format32bppArgb) 
        CaptchaPicBox.Image = Map
    End Sub
    Private Sub captchaDraw()

        Dim captchanum As String = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        str = ""
        Dim Q As New Random
        For i As Integer = 0 To 6
            str = str + captchanum(Q.Next(0, 60))
        Next
        Dim Map As New Bitmap(320, 80, Imaging.PixelFormat.Format32bppArgb)
        Dim graphic As Graphics = Graphics.FromImage(Map)
        Dim hb As New HatchBrush(HatchStyle.NarrowHorizontal, Color.FromArgb(255, 128, 0), Color.White)
        graphic.DrawString(str, New Font("Monotype Corsiva", 30, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 6, 6)
        CaptchaPicBox.Image = Map
        UserCaptchaTxtBx.Clear()
    End Sub
    Private Sub captcha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        captchaDraw()
    End Sub

    Private Sub VerifyBtn_Click(sender As Object, e As EventArgs) Handles VerifyBtn.Click
        If UserCaptchaTxtBx.Text = str And login.accesslevel = True Then
            MsgBox("captcha verified success, welcome admin")
            Me.Hide()
            login.Hide()
            MenuMain.Show()
            UserCaptchaTxtBx.Clear()
            captchaDelete()
            captchaDraw()
        ElseIf UserCaptchaTxtBx.Text = str And login.accesslevel = False Then
            MsgBox("captcha verified success")
            MenuMain.Show()
            Me.Hide()
            login.Hide()
            UserCaptchaTxtBx.Clear()
            captchaDelete()
            captchaDraw()
        ElseIf usercaptchatxtbx.text = "" Then
            MsgBox("Please enter a captcha code")
            UserCaptchaTxtBx.Clear()
            captchaDraw()
        Else
            MsgBox("Captcha incorrect, please try again")
            UserCaptchaTxtBx.Clear()
            captchaDraw()
        End If

    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        captchaDraw()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Hide()
        login.Show()
        UserCaptchaTxtBx.Clear()
        captchaDelete()
        captchaDraw()
    End Sub
End Class