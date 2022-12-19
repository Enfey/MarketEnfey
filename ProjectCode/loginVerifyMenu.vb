Public Class loginVerifyMenu
    Private Sub CaptchaBtn_Click(sender As Object, e As EventArgs) Handles CaptchaBtn.Click
        _2fa.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        phone2fa.Show()
        Me.Hide()
    End Sub
End Class