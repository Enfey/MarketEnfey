'Imports System.Data.OleDb
'Public Class forgotpassword 
'    Private Sub UserCheckBtn_Click(sender As Object, e As EventArgs) Handles UsernameCheckBtn.Click

'        Dim cmd As OleDbCommand 'used in order to make sql queries to get information from the database in access
'        Dim dr As OleDbDataReader 'reads data from the database
'        Dim checker As Integer 'checks to make sure program is working
'        Dim question As String 'question from database is read into this string
'        Dim userid As String = UsernameTxtBx.Text

'        Try
'            conn.Open() 'opens database connection

'            cmd = conn.CreateCommand()
'            cmd.CommandType = CommandType.Text
'            cmd.CommandText = "SELECT EmployeeID, SecretQuestion, SecretAnswer FROM Employees WHERE EmployeeID = '" + UsernameTxtBx.Text + "'" 'defines the query to be used in order to retrieve necessary data from tables in access

'            dr = cmd.ExecuteReader() 'executes and returns a datareader object/s using the sql query
'            checker = 0

'            Do While (dr.Read())
'                checker = checker + 1
'                question = dr("SecretQuestion") 'question string is equal to secret question matching the query in the database
'                QuestionTxtBx.Text = question 'then written into the text box
'            Loop
'            dr.close()
'            conn.Close()
'        Catch ex As Exception
'            If conn.State = ConnectionState.Open Then
'                conn.Dispose()
'            End If
'            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'        If checker = 1 Then 'checks if working
'            MsgBox("Username is correct")
'            AnswerCheckBtn.Show() 'shows the next set of buttons and text boxes and labels
'            AnswerPicBox.Show()
'            AnswerTxtBx.Show()
'        ElseIf (checker > 1) Then
'            MsgBox("Error")
'            UsernameTxtBx.Clear()
'            UsernameTxtBx.Focus()
'        ElseIf UsernameTxtBx.Text = "" Then 'validation
'            MsgBox("please enter a username")
'        ElseIf EmployeeIDCheck(userid) = False Then 'validation
'            MsgBox("Please enter a valid username in the format 'E' followed by 4 numbers")
'            UsernameTxtBx.Clear()
'            UsernameTxtBx.Focus()
'        Else
'            MsgBox("Username does not exist, please try again")
'            UsernameTxtBx.Clear()
'            UsernameTxtBx.Focus()
'        End If
'    End Sub
'    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
'        'returns to login and removes all info from the fields
'        AnswerPicBox.Hide()
'        PasswordPicBox.Hide()
'        AnswerCheckBtn.Hide()
'        NewPassTxtBx.Hide()
'        ChangePasswordBtn.Hide()
'        AnswerTxtBx.Hide()
'        DoubleEntryTxtBx.Hide()
'        PasswordEnter2PicBx.Hide()
'        AnswerTxtBx.Clear()
'        UsernameTxtBx.Clear()
'        QuestionTxtBx.Clear()
'        NewPassTxtBx.Clear()
'        DoubleEntryTxtBx.Clear()
'        login.Show()
'        Me.Hide()
'    End Sub

'    Private Sub forgotpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        'hides all unnecessary info on form load as to not overwhelm the user
'        AnswerPicBox.Hide()
'        PasswordPicBox.Hide()
'        AnswerCheckBtn.Hide()
'        NewPassTxtBx.Hide()
'        ChangePasswordBtn.Hide()
'        AnswerTxtBx.Hide()
'        DoubleEntryTxtBx.Hide()
'        PasswordEnter2PicBx.Hide()
'    End Sub

'    Private Sub AnswerBtn_Click(sender As Object, e As EventArgs) Handles AnswerCheckBtn.Click

'        Dim cmd As OleDbCommand
'        Dim dr As OleDbDataReader
'        Dim checker As Integer
'        Dim Answer As String
'        Try
'            conn.Open()
'            cmd = conn.CreateCommand()
'            cmd.CommandType = CommandType.Text
'            cmd.CommandText = "SELECT EmployeeID, SecretQuestion, SecretAnswer FROM Employees WHERE EmployeeID = '" + UsernameTxtBx.Text + "'"

'            dr = cmd.ExecuteReader()
'            checker = 0

'            Do While (dr.Read())
'                checker = checker + 1
'                Answer = dr("SecretAnswer")
'            Loop
'            dr.Close()
'            conn.Close()
'        Catch ex As Exception
'            If conn.State = ConnectionState.Open Then
'                conn.Dispose()
'            End If
'            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'        If checker = 1 And Answer = AnswerTxtBx.Text Then 'if answer inputted is equal to the one for that user in the database then the answer is deemed correct
'            MsgBox("correct answer")
'            'next set of buttons is shown
'            NewPassTxtBx.Show()
'            PasswordPicBox.Show()
'            ChangePasswordBtn.Show()
'            DoubleEntryTxtBx.Show()
'            PasswordEnter2PicBx.Show()

'        ElseIf (checker > 1) Then
'            MsgBox("Error, please try again")
'            AnswerTxtBx.Clear()
'            AnswerTxtBx.Focus()

'        ElseIf LengthCheck(AnswerTxtBx.Text, 30, 4) = False Then
'            MsgBox("Please enter an answer between 4 and 30 characters")
'            AnswerTxtBx.Clear()
'            AnswerTxtBx.Focus()

'        ElseIf CharacterCheck(AnswerTxtBx.Text) = false Then
'            MsgBox("Please enter a valid answer, only alphabetical characters and whitespaces are permitted")
'            AnswerTxtBx.Clear()
'            AnswerTxtBx.Focus()

'        ElseIf AnswerTxtBx.Text = "" Then
'            MsgBox("Please enter an answer")
'            answertxtbx.focus()
'        Else
'            MsgBox("Incorrect Answer")
'            AnswerTxtBx.Clear()
'            AnswerTxtBx.Focus()
'        End If
'    End Sub

'    Private Sub ChangePswordBtn_Click(sender As Object, e As EventArgs) Handles ChangePasswordBtn.Click
'        Dim sql As String 'needed to write the sql query
'        Dim da As OleDbDataAdapter  'used To send data between access And visual studio
'        Dim ds As New DataSet 'in memory representation of data that data is stored in
'        Dim Counter As Integer 'checks if working

'            If NewPassTxtBx.Text = "" And DoubleEntryTxtBx.Text = "" Then
'                MsgBox("Please enter a password.")
'                NewPassTxtBx.Focus()
'            ElseIf passwordDictionaryCheck(NewPassTxtBx.Text) Then
'                MsgBox("Please enter a password that is not a common password")
'                NewPassTxtBx.Clear()
'                DoubleEntryTxtBx.Clear()
'                NewPassTxtBx.Focus()

'            ElseIf PasswordCheck(NewPassTxtBx.Text) = False Then
'                MsgBox("Please enter a valid password, between 8 and 30 characters, with at least one uppercase letter, one lowercase letter, one number and one special character.")
'                NewPassTxtBx.Clear()
'                DoubleEntryTxtBx.Clear()
'                NewPassTxtBx.Focus()

'            ElseIf DoubleEntryTxtBx.Text <> NewPassTxtBx.Text Then 'double entry check
'                MsgBox("The passwords do not match, please try again")
'                NewPassTxtBx.Clear()
'                DoubleEntryTxtBx.Clear()
'                NewPassTxtBx.Focus()

'            ElseIf DoubleEntryTxtBx.Text = NewPassTxtBx.Text Then
'                Try
'                sql = "UPDATE Employees SET EmployeePassword = '" + NewPassTxtBx.Text + "' WHERE EmployeeID = '" + UsernameTxtBx.Text + "'" 'update sql query, password is updated where the employee id is equal to what was inputted by the user at the start

'                da = New OleDbDataAdapter(sql, conn)

'                da.Fill(ds, "Employees")

'                Counter = 0
'                Counter = Counter + 1
'                conn.Close() 'closes connection to database
'                Catch ex As Exception
'                    If conn.State = ConnectionState.Open Then
'                        conn.dispose()
'                    End If
'                    MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                End Try
'            End If
'        If Counter = 1 Then
'            MsgBox("Password successfully changed!")
'            Me.Hide()
'            AnswerPicBox.Hide()
'            PasswordPicBox.Hide()
'            AnswerCheckBtn.Hide()
'            NewPassTxtBx.Hide()
'            ChangePasswordBtn.Hide()
'            AnswerTxtBx.Hide()
'            DoubleEntryTxtBx.Hide()
'            PasswordEnter2PicBx.Hide()
'            AnswerTxtBx.Clear()
'            UsernameTxtBx.Clear()
'            QuestionTxtBx.Clear()
'            NewPassTxtBx.Clear()
'            DoubleEntryTxtBx.Clear()
'            login.Show()
'        End if
'    End Sub








'End Class