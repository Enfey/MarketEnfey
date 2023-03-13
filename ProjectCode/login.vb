Imports System.Data.OleDb
Public Class login
    Private loginAttempts As Integer
    Private shutdownElapsed As Integer = 0
    Private controlElapsed As Integer = 0
    Private Sub WelcomeLoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        loginAttempts += 1
        dim user as string= UsernameTxtBx.Text
        Dim pass As String = PasswordTxtBx.Text

        If loginAttempts = 3 Then 'if the user has entered the wrong password 3 times, then the program will lock them out for 60 seconds, but only if the username and password are not correct
            MessageBox.Show("You have entered the wrong login details 3 times, you will be locked out for 60 seconds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clearAllControls(Me)
            controlDisable()

        ElseIf loginAttempts = 5 Then  'if the user has entered the wrong login details 5 times, then the system will shut down, but only if the username and password is not correct
            MsgBox("You have entered the wrong login details 5 times, the system will shut down in one minute", MsgBoxStyle.Critical, "Error")
            clearAllControls(Me)
            systemShut()

        ElseIf user = "" And pass = "" Then
            MsgBox("please fill in both the user ID and password fields")
            UsernameTxtBx.focus()

        ElseIf user = "" Then ' selection for if text box is empty
            MsgBox("please enter the user's ID")
            UsernameTxtBx.Focus()

        ElseIf EmployeeIDCheck(user) = False Then ' validation to ensure that the format of the id is E followed by 4 digits
            MsgBox("Please enter a valid user ID")
            UsernameTxtBx.Clear()
            PasswordTxtBx.Clear()
            DoubleEntryTxtBx.Clear()

        ElseIf pass = "" Then ' selection for if text box is empty, give error
            MsgBox("Please enter a password")
            PasswordTxtBx.Focus()
            DoubleEntryTxtBx.Clear()

        ElseIf passwordCheck(pass) = False Then 'selection for if greater than 20, give error
            MsgBox("Please enter a valid password, between 8 and 30 characters with at least one uppercase letter, one lowercase letter, one number and one special character")
            PasswordTxtBx.Clear()
            DoubleEntryTxtBx.Clear()

        ElseIf pass <> DoubleEntryTxtBx.Text Then
            MsgBox("the passwords do not match, please try again")
            PasswordTxtBx.Clear()
            DoubleEntryTxtBx.Clear()

        ElseIf EmployeeIDCheck(user) = True And passwordCheck(pass) = True And pass = doubleentrytxtbx.text Then

            Dim query = "SELECT * FROM Employees WHERE EmployeeID = @ID AND EmployeePassword = @pass"
            Dim parameters As OleDbParameter() = {
                                                     New OleDbParameter("@ID", user),
                                                     New OleDbParameter("@pass", pass)
                                                 }

            Dim result = ExecuteQueryAndReturnData(query, parameters)

            If result.success Then
                Dim employeedata = New EmployeeData() '''create new instance of the employeedata class
                Dim row = result.data(0) '''local version of data returned, needed to populate properties of the employee data class

                '''Populate properties of the employeedata class
                employeedata.Admin = row("Admin")
                employeedata.Email = row("Email")
                employeedata.FirstName = row("First Name")
                employeedata.EmployeeID = row("EmployeeID")
                employeedata.ContactNumber = row("ContactNumber")
                employeedata.Password = row("EmployeePassword")

                If pass = employeedata.password And user = employeedata.employeeID And employeedata.Admin = "1" Then
                    '''populate global variables
                    employeeAccessLevel_ = True
                    employeeID_ = employeedata.employeeID
                    employeeEmail_ = employeedata.Email
                    employeePhone_ = employeedata.contactNumber
                    employeeName_ = employeedata.FirstName

                    loginVerifyMenu.Show()
                    clearAllControls(Me)
                    Me.Close()

                ElseIf pass = employeedata.password And user = employeedata.employeeID And employeedata.Admin = "0" Then
                    '''populate global variables
                    employeeAccessLevel_ = False
                    employeeID_ = employeedata.employeeID
                    employeeEmail_ = employeedata.Email
                    employeePhone_ = employeedata.contactNumber
                    employeeName_ = employeedata.FirstName

                    loginVerifyMenu.Show()
                    clearAllControls(Me)
                    Me.Close()
                Else
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'unlikely to ever be shown, because if a non existent username and password is entered, success will evaluate to false, still implemented to ensure graceful error handling
                    clearAllControls(Me)
                    UsernameTxtBx.Focus()
                End If
            End If
        Else
            MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'unlikely to ever be shown, because if a non existent username and password is entered, success will evaluate to false, still implemented to ensure graceful error handling
            clearAllControls(Me)
            UsernameTxtBx.Focus()
        End If
    End Sub


    ''' <summary>
    ''' Shutdown and its timer + background worker
    ''' </summary>
    Private Sub systemShut()
        ProgressBar.Show()
        ProgressBar.Maximum = 60 'sets the maximum value of the progress bar to the total delay
        For Each control In Controls
            If TypeOf control Is ProgressBar Then
                Continue For
            Else
                control.hide()
            End If
        Next
        Shutdown.Start() 'starts the timer
        BackgroundWorker.RunWorkerAsync() 'starts the background worker
    End Sub
    Private Sub ShutdownTimer_Tick(sender As Object, e As EventArgs) Handles Shutdown.Tick
        shutdownElapsed += 1
        ProgressBar.Value = shutdownElapsed
    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Dim process As New Process()
        process.StartInfo.FileName = "shutdown.exe"
        process.StartInfo.Arguments = "/s /t " & 60
        process.Start()
    End Sub


    ''' <summary>
    ''' Control disable timer
    ''' </summary>
    Private Sub controlDisable()
        ProgressBar.Show()
        ProgressBar.Maximum = 60
        For Each control In Controls
            If TypeOf control Is ProgressBar Then
                Continue For
            Else
                control.hide()
            End If
        Next
        HideControls.Start()
    End Sub

    Private Sub HideControls_Tick(sender As Object, e As EventArgs) Handles HideControls.Tick
        controlElapsed += 1
        ProgressBar.Value = controlElapsed
        If controlElapsed = ProgressBar.Maximum Then
            HideControls.Stop()
            For Each control In Controls
                control.show()
            Next
            ProgressBar.Hide()
        End If
    End Sub



    Private Sub passwrdBtn_Click(sender As Object, e As EventArgs) Handles ForgotPasswordBtn.Click
        Me.Hide()
        clearAllControls(Me)
        forgotpassword.Show()
    End Sub
    Private Sub PasswordHide_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordHide.CheckedChanged
        If (PasswordHide.Checked = True) Then
            PasswordTxtBx.PasswordChar = String.Empty
            DoubleEntryTxtBx.PasswordChar = String.Empty
            PasswordHide.Image = My.Resources.Resources.eye_open

        ElseIf (PasswordHide.Checked = False) Then
            PasswordTxtBx.PasswordChar = "*"
            DoubleEntryTxtBx.PasswordChar = "*"
            PasswordHide.Image = My.Resources.Resources.eye_close
        End If
    End Sub

    Private Sub loginExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim ProgExit As DialogResult 'defines the variable to be able to indicate the return value of a dialog box
        ProgExit = MessageBox.Show("Are you sure you want to exit?", "",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (ProgExit = DialogResult.Yes) Then
            Application.Exit() ' fully exits program
        End If
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Hide()
        loginAttempts = 0
        clearAllControls(Me)
    End Sub
end class

