Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class login
    Public Shared accesslevel As Boolean ' defines the access level of the user
    Public Shared employeeEmailstr As String
    Public Shared employeeName As String
    Public Shared employeeID As String
    Public Shared employeephone As String
    Private Sub passwrdBtn_Click(sender As Object, e As EventArgs) Handles passwrdBtn.Click
        Me.Hide()
        forgotpassword.Show()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If (CheckBox1.Checked = True) Then ' if the eye next to the password box is clicked then the password char becomes empty instead of being an asterisk, displaying the actual text rather than it being hidden
                TxtBxPsword.PasswordChar = String.Empty 'displays the password so it is readable
                DoubleEntryTxtBx.PasswordChar = String.Empty 'displays the password so it is readable
                CheckBox1.Image = My.Resources.Resources.eye_open 'changes the eye to being open, linked to the resources.resx file

            ElseIf (CheckBox1.Checked = False) Then 'if it is clicked again, or if checked is false anyway, then password char is an asterisk hiding the password
                TxtBxPsword.PasswordChar = "*" 'password is hidden behind asterisks
                DoubleEntryTxtBx.PasswordChar = "*" 'password is hidden behind asterisks
                CheckBox1.Image = My.Resources.Resources.eye_close 'changes the eye to being closed, linked to the resources.resx file
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message) 'messages the error to you
        End Try
    End Sub

    Private Sub WelcomeLoginBtn_Click(sender As Object, e As EventArgs) Handles WelcomeLoginBtn.Click
        Dim cmd As OleDbCommand 'used in order to make sql queries to get information from the database in access
        Dim dr As OleDbDataReader 'reads data from the database
        Dim checker As Integer 'checks to make sure program is working
        Dim adminstatus As String  'access level from database is read into this string
        Dim password As String


        Dim userid As String = TxtBxUser.Text
        

        Try
            conn.Open() 'opens database connection

            cmd = conn.CreateCommand() 'creates the command
            cmd.CommandType = CommandType.Text 'command string is converted to .text
            cmd.CommandText = "SELECT * FROM Employees WHERE EmployeeID = '" + TxtBxUser.Text + "' and EmployeePassword = '" + TxtBxPsword.Text + "'" 'defines the query to be used in order to retrieve necessary data from tables in access

            dr = cmd.ExecuteReader() 'executes and returns a datareader object/s using the sql query
            checker = 0

            Do While (dr.Read())
                'reads values of items in db into global and local variables, so they can be used in other forms or in this form.
                adminstatus = dr("Admin") 'access level is equal to data reader object 'admin' in the employees table
                employeeEmailstr = dr("Email")
                employeeName = dr("First Name")
                employeeID = dr("EmployeeID")
                employeephone = dr("ContactNumber")
                password = dr("EmployeePassword")

                checker = checker + 1 ' makes sure is working
            Loop

            dr.Close()
            conn.close()
            Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GC.Collect()
        End Try


        If TxtBxPsword.Text = DoubleEntryTxtBx.Text And (checker) = 1 And adminstatus = "1" And password = TxtBxPsword.Text And employeeID = TxtBxUser.Text Then 'double entry check and if checker has gone up by one which means loop has worked and the connection has closed, and the admin status for that employee is one then it is an admin login
            accesslevel = True 'access level is true
            loginVerifyMenu.Show()
            Me.Hide()
            TxtBxPsword.Clear()
            DoubleEntryTxtBx.Clear()
            TxtBxUser.Clear()

        ElseIf TxtBxPsword.Text = DoubleEntryTxtBx.Text And (checker) = 1 And adminstatus = "0" And password = TxtBxPsword.Text And employeeID = TxtBxUser.Text Then 'double entry check and if checker has gone up by one which means loop has worked and the connection has closed, and the admin status for that employee is zero then it is a normal user login
            accesslevel = False 'access level is false
            loginVerifyMenu.Show()
            Me.Hide()
            TxtBxPsword.Clear()
            DoubleEntryTxtBx.Clear()
            TxtBxUser.Clear()

        ElseIf (checker > 1) Then
            MsgBox("Duplicated login details")
            TxtBxUser.Clear() 'clears text box
            TxtBxPsword.Clear() 'clears text box


        ElseIf TxtBxUser.Text = "" And TxtBxPsword.Text = "" Then
            MsgBox("please fill in both the user ID and password fields")

        ElseIf TxtBxUser.Text = "" Then ' selection for if text box is empty
            MsgBox("please enter the user's ID")
        ElseIf EmployeeIDCheck(userid) = False Then ' validation to ensure that the format of the id is E followed by 4 digits
            MsgBox("Please enter a valid user ID")
            TxtBxUser.Clear() 'clears text box
            TxtBxPsword.Clear() 'clears text box
            DoubleEntryTxtBx.Clear()

        ElseIf TxtBxPsword.Text = "" Then ' selection for if text box is empty, give error
            MsgBox("Please enter a password")
            TxtBxPsword.Focus()
            DoubleEntryTxtBx.Clear()

        ElseIf PasswordCheck(TxtBxPsword.Text) = False Then 'selection for if greater than 20, give error
            MsgBox("Please enter a valid password, between 8 and 30 characters with at least one uppercase letter, one lowercase letter, one number and one special character")
            TxtBxPsword.Clear() 'clears text box
            DoubleEntryTxtBx.Clear()
            
        ElseIf TxtBxPsword.Text <> DoubleEntryTxtBx.Text Then
                MsgBox("the passwords do not match, please try again")
                TxtBxPsword.Clear()
                DoubleEntryTxtBx.Clear()
            Else
                MsgBox("incorrect login")
                TxtBxUser.Clear() 'clears text box
                TxtBxPsword.Clear() 'clears text box
                DoubleEntryTxtBx.Clear()
                TxtBxUser.Focus()
            End If
    End Sub

    Private Sub WelcomeExitBtn_Click(sender As Object, e As EventArgs) Handles WelcomeExitBtn.Click
            Dim ProgExit As DialogResult 'defines the variable to be able to indicate the return value of a dialog box
            ProgExit = MessageBox.Show("are you sure you want to exit?", "",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If (ProgExit = DialogResult.Yes) Then
                Application.Exit() ' fully exits program
            End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Dim companyemail As New MailAddress("enfeysmarket@outlook.com")

        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("enfeysmarket@outlook.com", "Ycc87$Nucy4nai4")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp-mail.outlook.com"

        e_mail.From = companyemail
        e_mail.To.Add("frileykay@outlook.com")
        e_mail.Subject = "test"
        e_mail.IsBodyHtml = True
        e_mail.Body = "<html>
  <body>
    <h1>Thank you for your purchase!</h1>
    <p>Dear [customer name],</p>
    <p>Thank you for your recent purchase from our online store. Your order details are listed below:</p>
    <table>
      <tr>
        <th>Item</th>
        <th>Quantity</th>
        <th>Price</th>
      </tr>
      <tr>
        <td>Product A</td>
        <td>2</td>
        <td>$10.00</td>
      </tr>
      <tr>
        <td>Product B</td>
        <td>1</td>
        <td>$5.00</td>
      </tr>
      <tr>
        <td colspan= 2 >Total</td>
        <td>$15.00</td>
      </tr>
    </table>
    <p>Your order will be shipped to the following address:</p>
    <p>[shipping address]</p>
    <p>Thank you for your business. If you have any questions or concerns, please don't hesitate to contact us.</p>
    <p>Sincerely,</p>
    <p>[Your name]</p>
  </body>
</html>"
            

        Smtp_Server.Send(e_mail)
    End Sub
end class