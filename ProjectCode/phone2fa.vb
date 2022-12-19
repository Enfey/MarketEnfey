Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types
Public Class phone2fa
    Dim code As String
    Private Sub phoneverification()
        Const accountSid = "AC59a3a3ce8835cc444d07127964220e93"
        Const authToken = "5a12b5a8f4765c44df052c5a83735951"
        TwilioClient.Init(accountSid, authToken)

        Dim rand As New Random
        code = rand.Next(100000, 999999).ToString
        Dim toNumber = New PhoneNumber(login.employeephone)
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
        ElseIf verificationtxtbx.text = "" Then
            MsgBox("Please enter the code")
        ElseIf isnumeric(verificationtxtbx.text) = False Then
            MsgBox("Please a valid verification code, only numerical format is accepted.")
            VerificationTxtBx.Clear()
        ElseIf Len(VerificationTxtBx.text) <> 6 Then
            MsgBox("please enter the corret length of the verification code")
            VerificationTxtBx.Clear()
        Else
            MsgBox("The code is incorrect, please try again")
            VerificationTxtBx.Clear()
        End If
    End Sub

    Private Sub EmailResendBtn_Click(sender As Object, e As EventArgs) Handles EmailResendBtn.Click
        Try
            phoneverification()
            MsgBox("Text Sent")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        login.Show()
        Me.Hide()
        VerificationTxtBx.Clear()
    End Sub
End Class