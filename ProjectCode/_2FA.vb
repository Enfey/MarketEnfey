Imports System.Net.Mail
Public Class _2fa
    Private code As String
    Private rand As New Random
    Private credentials As New Dictionary(Of String, String) From {
        {"username", "enfeysmarket@outlook.com"},
        {"password", "Ycc87$Nucy4nai4"}
        }
    Private Sub _2fa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emailSend()
    End Sub

    Private Sub EmailResendBtn_Click(sender As Object, e As EventArgs) Handles ResendBtn.Click
        emailSend()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
        login.Show()
        VerificationTxtBx.Clear()
    End Sub

    Private Sub VerifyBtn_Click(sender As Object, e As EventArgs) Handles VerifyBtn.Click
        If VerificationTxtBx.Text = code And employeeAccessLevel_ = True Then
            MsgBox("Welcome Admin " & employeeName_)
            VerificationTxtBx.Clear()
            Me.Close()
            captcha.Show()

        ElseIf VerificationTxtBx.Text = code And employeeAccessLevel_ = False Then
            MsgBox("Welcome " & employeeName_)
            VerificationTxtBx.Clear()
            Me.Close()
            captcha.Show()

        ElseIf VerificationTxtBx.Text = "" Then
            MsgBox("Please enter a verification code")
            VerificationTxtBx.Focus()
        ElseIf IsNumeric(VerificationTxtBx.Text) = False Then
            MsgBox("Please a valid verification code, only numerical format is accepted.")
            VerificationTxtBx.Clear()
            VerificationTxtBx.Focus()
        ElseIf Len(VerificationTxtBx.Text) <> 6 Then
            MsgBox("please enter the correct length of the verification code")
            VerificationTxtBx.Clear()
            VerificationTxtBx.Focus()
        Else
            MsgBox("The code is incorrect, please try again")
            VerificationTxtBx.Clear()
            VerificationTxtBx.Focus()
        End If
    End Sub
    Private Sub emailSend()
        code = rand.Next(100000, 999999).ToString
        Dim sender As New MailAddress("enfeysmarket@outlook.com")
        Dim receipient As String = employeeEmail_

        GlobalLogic.SendEmail(code, "Verification Code", credentials, sender, receipient)
    End Sub
End Class