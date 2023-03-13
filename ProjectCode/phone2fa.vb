Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types
Public Class phone2fa
    Dim code As String
    Private Sub phoneverification()
        Const accountSid = "AC59a3a3ce8835cc444d07127964220e93"
        Const authToken = ""
        TwilioClient.Init(accountSid, authToken)

        Dim rand As New Random
        code = rand.Next(100000, 999999).ToString
        Dim toNumber = New PhoneNumber(employeePhone_)
        Dim message = MessageResource.Create(
            toNumber, from:=New PhoneNumber("+12534003915"),
        body:="your code is " & code & " Do not reply to this message, do not share this code with anyone")
    End Sub

    Private Sub phone2fa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            phoneverification()
            MsgBox("Text Sent")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub VerifyBtn_Click(sender As Object, e As EventArgs) Handles VerifyBtn.Click
        If VerificationCodeTxtBx.Text = code And employeeAccessLevel_ = True Then
            MsgBox("Welcome Admin " & employeeName_)
            VerificationCodeTxtBx.Clear()
            Me.Close()
            captcha.Show()
        ElseIf VerificationCodeTxtBx.Text = code And employeeAccessLevel_ = False Then
            MsgBox("Welcome " & employeeName_)
            VerificationCodeTxtBx.Clear()
            Me.Close()
            captcha.Show()
        ElseIf VerificationCodeTxtBx.text = "" Then
            MsgBox("Please enter the code")
        ElseIf isnumeric(VerificationCodeTxtBx.text) = False Then
            MsgBox("Please a valid verification code, only numerical format is accepted.")
            VerificationCodeTxtBx.Clear()
        ElseIf Len(VerificationCodeTxtBx.text) <> 6 Then
            MsgBox("please enter the correct length of the verification code")
            VerificationCodeTxtBx.Clear()
        Else
            MsgBox("The code is incorrect, please try again")
            VerificationCodeTxtBx.Clear()
        End If
    End Sub

    Private Sub EmailResendBtn_Click(sender As Object, e As EventArgs) Handles ResendBtn.Click
        Try
            phoneverification()
            MsgBox("Text Sent")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        login.Show()
        me.close()
        VerificationCodeTxtBx.Clear()
    End Sub
End Class
