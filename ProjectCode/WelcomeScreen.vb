Imports System.Net.Mail

Public Class WelcomeScreen
    Private Sub WelcomeLoginBtn_Click(sender As Object, e As EventArgs) Handles WelcomeLoginBtn.Click
        Me.Hide() 'hides the welcome screen
        login.Show() 'displays the login
    End Sub

    Private Sub WelcomeExitBtn_Click(sender As Object, e As EventArgs) Handles WelcomeExitBtn.Click
        Try
            Dim ProgExit As DialogResult 'defines the variable to be able to indicate the return value of a dialog box
            ProgExit = MessageBox.Show("Are you sure you want to exit?", "",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If (ProgExit = DialogResult.Yes) Then
                Application.Exit() ' fully exits program
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class