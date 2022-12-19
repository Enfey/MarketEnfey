Imports System.Net.Mail
Public Class _2fa
    Dim code As String
    Private Sub emailsend()
        Dim rand As New Random
        code = rand.Next(100000, 999999).ToString
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Dim address As New MailAddress("enfeysmarket@outlook.com")

            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("enfeysmarket@outlook.com", "Ycc87$Nucy4nai4")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp-mail.outlook.com"

            e_mail.From = address
            e_mail.To.Add(login.employeeEmailstr)
            e_mail.Subject = "Verification Code"
            e_mail.IsBodyHtml = False
            e_mail.Body = code
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub _2fa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emailsend()
    End Sub
    Private Sub EmailResendBtn_Click(sender As Object, e As EventArgs) Handles EmailResendBtn.Click
        emailsend()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        login.Show()
        VerificationTxtBx.Clear()
        Me.Hide()
    End Sub

    Private Sub VerifyBtn_Click(sender As Object, e As EventArgs) Handles VerifyBtn.Click
        Try
            If VerificationTxtBx.Text = code And login.accesslevel = True Then
                MsgBox("Welcome Admin " & login.employeeName)
                VerificationTxtBx.Clear()
                captcha.Show()
                Me.Hide()
            ElseIf VerificationTxtBx.Text = code And login.accesslevel = False Then
                MsgBox("Welcome " & login.employeeName)
                VerificationTxtBx.Clear()
                captcha.Show()
                Me.Hide()
            ElseIf VerificationTxtBx.Text = "" Then
                MsgBox("Please enter a verification code")
            ElseIf isnumeric(verificationtxtbx.text) = False Then
                MsgBox("Please a valid verification code, only numerical format is accepted.")
                VerificationTxtBx.Clear()
            ElseIf Len(VerificationTxtBx.Text) <> 6 Then
                MsgBox("please enter the correct length of the verification code")
                VerificationTxtBx.Clear()
            Else
                MsgBox("The code is incorrect, please try again")
                VerificationTxtBx.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class