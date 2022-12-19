Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class Employees
    Dim MaxColumns As Integer '
    Dim maxrows As Integer ' defines the maximum amount of rows,
    Dim curRow As Integer 'defines the current rows, used within most of the code
    Dim ds As New DataSet ' same as a table and is just defined as a set of data
    Dim da As OleDb.OleDbDataAdapter ' used to send data between access and visual studio
    Dim sql As String

    Private Sub navigaterecords()
        'shows fields of the current row that is selected
        EmployeeIdTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(0)
        EmployeePasswordTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(1)
        SecretQuestion.Text = ds.Tables("Employees").Rows(curRow).Item(2)
        SecretAnswer.Text = ds.Tables("Employees").Rows(curRow).Item(3)
        FirstNameTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(4)
        SurnameTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(5)
        ContactNumberTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(6)
        AddressTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(7)
        PostcodeTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(8)
        EmailTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(9)
        Admin.Text = ds.Tables("Employees").Rows(curRow).Item(10)
        EmployeePicture.Image = Image.FromFile(Application.StartupPath & "\employeepictures\" & FirstNameTxtBx.Text & ".png")
    End Sub
    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If login.accesslevel = False Then
                NextBtn.Hide()
                PrevBtn.Hide()
                AddBtn.Hide()
                BackupBtn.Hide()
                
                conn.open()

                sql = "SELECT * FROM employees WHERE EmployeeID = '" + login.employeeID + "'"
                
                Admin.ReadOnly = True
                da = New OleDb.OleDbDataAdapter(sql, conn)

                da.Fill(ds, "Employees")

                conn.Close()
                
                navigaterecords()
            End If
            conn.open()

            sql = "SELECT * FROM Employees"

            da = New OleDb.OleDbDataAdapter(sql, conn)

            da.Fill(ds, "Employees")

            conn.Close()

            maxrows = ds.Tables("Employees").Rows.Count
            curRow = 0

            MsgBox("The number of rows is " & maxrows)

            MaxColumns = ds.Tables("Employees").Columns.Count
            MsgBox("The number of fields is " & MaxColumns)
            navigaterecords()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If login.accesslevel = True Then
            AddBtn.Show()
            BtnDelete.Show()
            UpdateBtn.Show()
            ClearBtn.Show()
        End If
    End Sub

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        Try
            If curRow > 0 Then
                curRow = curRow - 1 'minuses from current row therefore displaying the previous row
                navigaterecords()
            ElseIf curRow = -1 Then
                MsgBox("No records yet")
            ElseIf curRow = 0 Then
                MsgBox("first record")
            End If
            UpdateBtn.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Try
            If curRow <> maxrows - 1 Then
                curRow = curRow + 1 'counts current row, going forward in rows and then displaying it
                navigaterecords()
            Else
                MsgBox("no more rows") ' if the max number of rows is reached, then no more rows is displayed
            End If
            UpdateBtn.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        

            Dim employeeid As String = EmployeeIdTxtBx.Text
            Dim password As String = EmployeePasswordTxtBx.Text
            Dim email As String = EmailTxtBx.Text
            Dim postcode As String = PostcodeTxtBx.Text
            Dim phone As String = ContactNumberTxtBx.Text
            Dim adminR As String = Admin.Text
            Dim secretA As String = SecretAnswer.Text
            Dim secretQ As String = SecretQuestion.Text

            Dim cb As New OleDb.OleDbCommandBuilder(da)

            If EmployeeIdTxtBx.Text = "" Then
                MsgBox("Please enter the id of the employee")
                EmployeeIdTxtBx.Focus()
            ElseIf EmployeeIDCheck(employeeid) = False Then
                MsgBox("Please enter the correct format of the ID, the ID format is E followed by 4 digits.")
                EmployeeIdTxtBx.Clear()
                EmployeeIdTxtBx.Focus()

            ElseIf EmployeePasswordTxtBx.Text = "" Then
                MsgBox("Please enter the password")
                EmployeePasswordTxtBx.Focus()
            ElseIf PasswordCheck(password) = False Then
                MsgBox("Please enter a valid password, it must contain at least 8 characters, 1 uppercase, 1 lowercase, 1 number and 1 special character and a miniumum of 8 characters is to be used, and a maximum of 30 characters is to be used")
                EmployeePasswordTxtBx.Clear()
                EmployeePasswordTxtBx.Focus()

            ElseIf SecretQuestion.Text = "" Then
                MsgBox("Please enter the secret question")
                SecretQuestion.Focus()
            ElseIf CharacterCheck(secretQ) = False Then
                MsgBox("Please enter a valid secret question, it can only contain alphabetical characters and whitespaces")
                SecretQuestion.Clear()
                SecretQuestion.Focus()
            ElseIf LengthCheck(secretQ, 50, 10) = false Then
                MsgBox("Please enter a valid secret question, it must be between 10 and 50 characters")
                SecretQuestion.Clear()
                SecretQuestion.Focus()

            ElseIf SecretAnswer.Text = "" Then
                MsgBox("Please enter the secret answer")
                SecretAnswer.Focus()
            ElseIf CharacterCheck(secretA) = False Then
                MsgBox("Please enter a valid secret answer, it can only contain alphabetical characters and whitespaces")
                SecretAnswer.Clear()
                SecretAnswer.Focus()
            ElseIf LengthCheck(secretA, 30, 4) = false Then
                MsgBox("Please enter a valid answer, 30 characters maximum and 4 characters minimum")
                SecretAnswer.Clear()
                SecretAnswer.Focus()

            ElseIf FirstNameTxtBx.Text = "" Then
                MsgBox("Please enter the first name of the employee.")
                FirstNameTxtBx.Focus()
            ElseIf FirstNameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then
                MsgBox("Please enter a valid first name, alphabetical characters only")
                FirstNameTxtBx.Clear()
                FirstNameTxtBx.Focus()
            ElseIf Lengthcheck(FirstNameTxtBx.Text, 20, 2) = false Then
                MsgBox("Please enter a name in the proper format, 20 characters is the maximum, 2 characters is the minimum.")
                FirstNameTxtBx.Clear()
                FirstNameTxtBx.Focus()

            ElseIf SurnameTxtBx.Text = "" Then
                MsgBox("Please enter the surname of the employee.")
                SurnameTxtBx.Focus()
            ElseIf surnametxtbx.Text.All(Function(c) Char.IsLetter(c)) = False Then
                MsgBox("Please enter a valid surname, alphabetic characters only")
                SurnameTxtBx.Clear()
                SurnameTxtBx.Focus()
            ElseIf Lengthcheck(SurnameTxtBx.Text, 20, 2) = false then
                MsgBox("Please enter a surname in the proper format, 20 characters is the maximum, 2 characters is the minimum")
                SurnameTxtBx.Clear()
                SurnameTxtBx.Focus()

            ElseIf ContactNumberTxtBx.Text = "" Then
                MsgBox("please enter a phone number")
                ContactNumberTxtBx.Focus()
            ElseIf phoneCheck(phone) = False Then
                MsgBox("The phone number is invalid, please enter the country code starting with a + followed by the actual number. 15 digits maximum")
                ContactNumberTxtBx.Clear()
                ContactNumberTxtBx.Focus()

            ElseIf AddressTxtBx.Text = "" Then
                MsgBox("Please enter the address.")
                AddressTxtBx.Focus()
            ElseIf LengthCheck(AddressTxtBx.text, 50, 5) = False Then
                MsgBox("Please enter an address in the proper format, 50 characters is the maximum, 5 is the minimum.")
                AddressTxtBx.Clear()
                AddressTxtBx.Focus()
                
            ElseIf PostcodeTxtBx.Text = "" Then
                MsgBox("Please enter the postcode")
                PostcodeTxtBx.Focus()
            ElseIf postcodeCheck(postcode) = False Then
                MsgBox("Please enter a valid postcode following UK postcode format.")
                PostcodeTxtBx.Clear()
                PostcodeTxtBx.Focus()

            ElseIf EmailTxtBx.Text = "" Then
                MsgBox("Please enter the email of the employee.")
                EmailTxtBx.Focus()
            ElseIf emailCheck(email) = False Then
                MsgBox("Please enter a valid email, please ensure there is a proper email suffix with a '.' and a domain, and that an @ sign is included. Max of 50 chars for email prefix, 10 for domain and 5 for domain suffix.")
                EmailTxtBx.Clear()
                EmailTxtBx.Focus()
                'do regex for fake emails here
            ElseIf Admin.Text = "" Then
                MsgBox("please enter the admin status of the employee")
                Admin.Focus()
            ElseIf admincheck(adminR) = False Then
                MsgBox("please enter a valid admin status")
                Admin.Clear()
                Admin.Focus()

            Else
                try
                conn.open()

                ds.Tables("Employees").Rows(curRow).Item(1) = EmployeePasswordTxtBx.Text
                ds.Tables("Employees").Rows(curRow).Item(2) = SecretQuestion.Text
                ds.Tables("Employees").Rows(curRow).Item(3) = SecretAnswer.Text
                ds.Tables("Employees").Rows(curRow).Item(4) = FirstNameTxtBx.Text
                ds.Tables("Employees").Rows(curRow).Item(5) = SurnameTxtBx.Text
                ds.Tables("Employees").Rows(curRow).Item(6) = ContactNumberTxtBx.Text
                ds.Tables("Employees").Rows(curRow).Item(7) = AddressTxtBx.Text
                ds.Tables("Employees").Rows(curRow).Item(8) = PostcodeTxtBx.Text
                ds.Tables("Employees").Rows(curRow).Item(9) = EmailTxtBx.Text
                ds.Tables("Employees").Rows(curRow).Item(10) = Admin.Text

                cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                da.Update(ds, "Employees")

            MsgBox("record updated")
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End try
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            If curRow <> -1 Then
                
                Dim employeeid As String = EmployeeIdTxtBx.Text
                Dim password As String = EmployeePasswordTxtBx.Text
                Dim email As String = EmailTxtBx.Text
                Dim postcode As String = PostcodeTxtBx.Text
                Dim phone As String = ContactNumberTxtBx.Text
                Dim adminR As String = Admin.Text
                Dim secretA As String = SecretAnswer.Text
                Dim secretQ As String = SecretQuestion.Text


                Dim cb As New OleDb.OleDbCommandBuilder(da)
                Dim dsnewrow As DataRow

If EmployeeIdTxtBx.Text = "" Then
                MsgBox("Please enter the id of the employee")
                EmployeeIdTxtBx.Focus()
            ElseIf EmployeeIDCheck(employeeid) = False Then
                MsgBox("Please enter the correct format of the ID, the ID format is E followed by 4 digits.")
                EmployeeIdTxtBx.Clear()
                EmployeeIdTxtBx.Focus()

            ElseIf EmployeePasswordTxtBx.Text = "" Then
                MsgBox("Please enter the password")
                EmployeePasswordTxtBx.Focus()
            ElseIf PasswordCheck(password) = False Then
                MsgBox("Please enter a valid password, it must contain at least 8 characters, 1 uppercase, 1 lowercase, 1 number and 1 special character and a miniumum of 8 characters is to be used, and a maximum of 30 characters is to be used")
                EmployeePasswordTxtBx.Clear()
                EmployeePasswordTxtBx.Focus()

            ElseIf SecretQuestion.Text = "" Then
                MsgBox("Please enter the secret question")
                SecretQuestion.Focus()
            ElseIf CharacterCheck(secretQ) = False Then
                MsgBox("Please enter a valid secret question, it can only contain alphabetical characters and whitespaces")
                SecretQuestion.Clear()
                SecretQuestion.Focus()
            ElseIf LengthCheck(secretQ, 50, 10) = false Then
                MsgBox("Please enter a valid secret question, it must be between 10 and 50 characters")
                SecretQuestion.Clear()
                SecretQuestion.Focus()

            ElseIf SecretAnswer.Text = "" Then
                MsgBox("Please enter the secret answer")
                SecretAnswer.Focus()
            ElseIf CharacterCheck(secretA) = False Then
                MsgBox("Please enter a valid secret answer, it can only contain alphabetical characters and whitespaces")
                SecretAnswer.Clear()
                SecretAnswer.Focus()
            ElseIf LengthCheck(secretA, 30, 4) = false Then
                MsgBox("Please enter a valid answer, 30 characters maximum and 4 characters minimum")
                SecretAnswer.Clear()
                SecretAnswer.Focus()

            ElseIf FirstNameTxtBx.Text = "" Then
                MsgBox("Please enter the first name of the employee.")
                FirstNameTxtBx.Focus()
            ElseIf FirstNameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then
                MsgBox("Please enter a valid first name, alphabetical characters only")
                FirstNameTxtBx.Clear()
                FirstNameTxtBx.Focus()
            ElseIf Lengthcheck(FirstNameTxtBx.Text, 20, 2) = false Then
                MsgBox("Please enter a name in the proper format, 20 characters is the maximum, 2 characters is the minimum.")
                FirstNameTxtBx.Clear()
                FirstNameTxtBx.Focus()

            ElseIf SurnameTxtBx.Text = "" Then
                MsgBox("Please enter the surname of the employee.")
                SurnameTxtBx.Focus()
            ElseIf surnametxtbx.Text.All(Function(c) Char.IsLetter(c)) = False Then
                MsgBox("Please enter a valid surname, alphabetic characters only")
                SurnameTxtBx.Clear()
                SurnameTxtBx.Focus()
            ElseIf Lengthcheck(SurnameTxtBx.Text, 20, 2) = false then
                MsgBox("Please enter a surname in the proper format, 20 characters is the maximum, 2 characters is the minimum")
                SurnameTxtBx.Clear()
                SurnameTxtBx.Focus()

            ElseIf ContactNumberTxtBx.Text = "" Then
                MsgBox("please enter a phone number")
                ContactNumberTxtBx.Focus()
            ElseIf phoneCheck(phone) = False Then
                MsgBox("The phone number is invalid, please enter the country code starting with a + followed by the actual number. 15 digits maximum")
                ContactNumberTxtBx.Clear()
                ContactNumberTxtBx.Focus()

            ElseIf AddressTxtBx.Text = "" Then
                MsgBox("Please enter the address.")
                AddressTxtBx.Focus()
            ElseIf LengthCheck(AddressTxtBx.text, 50, 5) = False Then
                MsgBox("Please enter an address in the proper format, 50 characters is the maximum, 5 is the minimum.")
                AddressTxtBx.Clear()
                AddressTxtBx.Focus()
                
            ElseIf PostcodeTxtBx.Text = "" Then
                MsgBox("Please enter the postcode")
                PostcodeTxtBx.Focus()
            ElseIf postcodeCheck(postcode) = False Then
                MsgBox("Please enter a valid postcode following UK postcode format.")
                PostcodeTxtBx.Clear()
                PostcodeTxtBx.Focus()

            ElseIf EmailTxtBx.Text = "" Then
                MsgBox("Please enter the email of the employee.")
                EmailTxtBx.Focus()
            ElseIf emailCheck(email) = False Then
                MsgBox("Please enter a valid email, please ensure there is a proper email suffix with a '.' and a domain, and that an @ sign is included. Max of 50 chars for email prefix, 10 for domain and 5 for domain suffix.")
                EmailTxtBx.Clear()
                EmailTxtBx.Focus()
                'do regex for fake emails here
            ElseIf Admin.Text = "" Then
                MsgBox("please enter the admin status of the employee")
                Admin.Focus()
            ElseIf admincheck(adminR) = False Then
                MsgBox("please enter a valid admin status")
                Admin.Clear()
                Admin.Focus()
                
                Else
                    dsnewrow = ds.Tables("Employees").NewRow()

                    dsnewrow.Item("EmployeeID") = EmployeeIdTxtBx.Text
                    dsnewrow.Item("EmployeePassword") = EmployeePasswordTxtBx.Text
                    dsnewrow.Item("SecretQuestion") = SecretQuestion.Text
                    dsnewrow.Item("SecretAnswer") = SecretAnswer.Text
                    dsnewrow.Item("FirstName") = FirstNameTxtBx.Text
                    dsnewrow.Item("Surname") = SurnameTxtBx.Text
                    dsnewrow.Item("ContactNumber") = ContactNumberTxtBx.Text
                    dsnewrow.Item("Address") = AddressTxtBx.Text
                    dsnewrow.Item("Postcode") = PostcodeTxtBx.Text
                    dsnewrow.Item("Email") = EmailTxtBx.Text
                    dsnewrow.Item("Admin") = Admin.Text

                    ds.Tables("Employees").Rows.Add(dsnewrow)

                    cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                    cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access

                    da.Update(ds, "Employees") 'updates dataset customers
                    MsgBox("New employee record added to the database")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MenuMain.Show()
    End Sub

    Private Sub BackupBtn_Click(sender As Object, e As EventArgs) Handles BackupBtn.Click
        Try
            BackupEmployees()
            BackupCustomers()
            BackupOrders()
            BackupProducts()
            BackupPostal()
            FileWrite()
            emailbackup()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub BackupEmployees()
        Dim OBExcel As Object
        Dim OBBook As Object
        Dim OBSheet As Object

        OBExcel = CreateObject("Excel.Application")
        OBBook = OBExcel.workbooks.add

        OBSheet = OBBook.worksheets(1)

        OBSheet.range("A1").value = "EmployeeID"
        OBSheet.range("B1").value = "EmployeePassword"
        OBSheet.range("C1").value = "SecretQuestion"
        OBSheet.range("D1").value = "SecretAnswer"
        OBSheet.range("E1").value = "First Name"
        OBSheet.range("F1").value = "Surname"
        OBSheet.range("G1").value = "ContactNumber"
        OBSheet.range("H1").value = "Address"
        OBSheet.range("I1").value = "Postcode"
        OBSheet.range("J1").value = "Email"
        OBSheet.range("K1").value = "Admin"

        For i = 0 To maxrows - 1
            OBSheet.range("A" & i + 2).value = ds.Tables("Employees").Rows(i).Item(0)
            OBSheet.range("B" & i + 2).value = ds.Tables("Employees").Rows(i).Item(1)
            OBSheet.range("C" & i + 2).value = ds.Tables("Employees").Rows(i).Item(2)
            OBSheet.range("D" & i + 2).value = ds.Tables("Employees").Rows(i).Item(3)
            OBSheet.range("E" & i + 2).value = ds.Tables("Employees").Rows(i).Item(4)
            OBSheet.range("F" & i + 2).value = ds.Tables("Employees").Rows(i).Item(5)
            OBSheet.range("G" & i + 2).value = ds.Tables("Employees").Rows(i).Item(6)
            OBSheet.range("H" & i + 2).value = ds.Tables("Employees").Rows(i).Item(7)
            OBSheet.range("I" & i + 2).value = ds.Tables("Employees").Rows(i).Item(8)
            OBSheet.range("J" & i + 2).value = ds.Tables("Employees").Rows(i).Item(9)
            OBSheet.range("K" & i + 2).value = ds.Tables("Employees").Rows(i).Item(10)
        Next
        OBBook.saveas(System.Windows.Forms.Application.StartupPath & "\Backupstorage\employeesbackup.xlsx")
        OBExcel.quit

        conn.Open()
        sql = "SELECT * FROM Employees"
        da = New OleDb.OleDbDataAdapter(sql, conn)

        da.Fill(ds, "Employees")

        conn.Close()

        maxrows = ds.Tables("Employees").Rows.Count
        curRow = 0
    End Sub
    Private Sub BackupCustomers()
        conn.Open()
        sql = "SELECT * FROM Customers"
        da = New OleDb.OleDbDataAdapter(sql, conn)

        da.Fill(ds, "Customers")

        maxrows = ds.Tables("customers").Rows.Count
        customers.IdTxtBx.Text = ds.Tables("Customers").Rows(0).Item(0)
        customers.NameTxtBx.Text = ds.Tables("Customers").Rows(0).Item(1)
        customers.SrnameTxtBx.Text = ds.Tables("Customers").Rows(0).Item(2)
        customers.AddressTxtBx.Text = ds.Tables("Customers").Rows(0).Item(3)
        customers.PhoneTxtBx.Text = ds.Tables("Customers").Rows(0).Item(4)
        customers.EmailTxtBx.Text = ds.Tables("Customers").Rows(0).Item(5)
        customers.PostcodeTxtBx.Text = ds.Tables("Customers").Rows(0).Item(6)

        conn.Close()

        maxrows = ds.Tables("Customers").Rows.Count
        curRow = 0

        Dim OBExcel As Object
        Dim OBBook As Object
        Dim OBSheet As Object

        OBExcel = CreateObject("Excel.Application")
        OBBook = OBExcel.workbooks.add

        OBSheet = OBBook.worksheets(1)

        OBSheet.range("A1").value = "CustomerID"
        OBSheet.range("B1").value = "FirstName"
        OBSheet.range("C1").value = "Surname"
        OBSheet.range("D1").value = "Address"
        OBSheet.range("E1").value = "Phone Number"
        OBSheet.range("F1").value = "EmailAddress"
        OBSheet.range("G1").value = "Postcode"

        For i = 0 To maxrows - 1
            OBSheet.range("A" & i + 2).value = ds.Tables("Customers").Rows(i).Item(0)
            OBSheet.range("B" & i + 2).value = ds.Tables("Customers").Rows(i).Item(1)
            OBSheet.range("C" & i + 2).value = ds.Tables("Customers").Rows(i).Item(2)
            OBSheet.range("D" & i + 2).value = ds.Tables("Customers").Rows(i).Item(3)
            OBSheet.range("E" & i + 2).value = ds.Tables("Customers").Rows(i).Item(4)
            OBSheet.range("F" & i + 2).value = ds.Tables("Customers").Rows(i).Item(5)
            OBSheet.range("G" & i + 2).value = ds.Tables("Customers").Rows(i).Item(6)
        Next

        OBBook.saveas(Application.StartupPath & "\Backupstorage\customersbackup.xlsx")
        OBExcel.quit
    End Sub
    Private Sub BackupOrders()
        conn.Open()
        sql = "SELECT * FROM ORDERS"
        da = New OleDb.OleDbDataAdapter(sql, conn)

        da.Fill(ds, "Orders")

        maxrows = ds.Tables("Orders").Rows.Count
        Orders.SaleIdTxtBx.Text = ds.Tables("Orders").Rows(0).Item(0)
        Orders.CustIdTxtBx.Text = ds.Tables("Orders").Rows(0).Item(1)
        Orders.DateTxtBx.Text = ds.Tables("Orders").Rows(0).Item(2)
        Orders.QuantityTxtBx.Text = ds.Tables("Orders").Rows(0).Item(3)
        Orders.TotalTxtBx.Text = ds.Tables("Orders").Rows(0).Item(4)
        Orders.EmployeeIDTxtBx.Text = ds.Tables("Orders").Rows(0).Item(5)
        Orders.PostalIDtxtBx.Text = ds.Tables("Orders").Rows(0).Item(6)

        conn.Close()

        maxrows = ds.Tables("Orders").Rows.Count
        curRow = 0

        Dim OBExcel As Object
        Dim OBBook As Object
        Dim OBSheet As Object

        OBExcel = CreateObject("Excel.Application")
        OBBook = OBExcel.workbooks.add

        OBSheet = OBBook.worksheets(1)

        OBSheet.range("A1").value = "SalesID"
        OBSheet.range("B1").value = "CustomerID"
        OBSheet.range("C1").value = "Date"
        OBSheet.range("D1").value = "Quantity"
        OBSheet.range("E1").value = "Total"
        OBSheet.range("F1").value = "EmployeeID"
        OBSheet.range("G1").value = "PostalID"

        For i = 0 To maxrows - 1
            OBSheet.range("A" & i + 2).value = ds.Tables("Orders").Rows(i).Item(0)
            OBSheet.range("B" & i + 2).value = ds.Tables("Orders").Rows(i).Item(1)
            OBSheet.range("C" & i + 2).value = ds.Tables("Orders").Rows(i).Item(2)
            OBSheet.range("D" & i + 2).value = ds.Tables("Orders").Rows(i).Item(3)
            OBSheet.range("E" & i + 2).value = ds.Tables("Orders").Rows(i).Item(4)
            OBSheet.range("F" & i + 2).value = ds.Tables("Orders").Rows(i).Item(5)
            OBSheet.range("G" & i + 2).value = ds.Tables("Orders").Rows(i).Item(6)
        Next

        OBBook.saveas(Application.StartupPath & "\Backupstorage\ordersbackup.xlsx")
        OBExcel.quit
    End Sub
    Private Sub BackupProducts()
        sql = "SELECT * FROM Products"
        da = New OleDb.OleDbDataAdapter(sql, conn)

        da.Fill(ds, "Products")

        maxrows = ds.Tables("Products").Rows.Count
        Products.ProductIdTxtBx.Text = ds.Tables("Products").Rows(0).Item(0)
        Products.ProdNameTxtBx.Text = ds.Tables("Products").Rows(0).Item(1)
        Products.ProdGenreTxtBx.Text = ds.Tables("Products").Rows(0).Item(2)
        Products.ProdPriceTxtBx.Text = ds.Tables("Products").Rows(0).Item(3)
        Products.ProdQuantityTxtBx.Text = ds.Tables("Products").Rows(0).Item(4)

        conn.Close()

        maxrows = ds.Tables("Products").Rows.Count
        curRow = 0

        Dim OBExcel As Object
        Dim OBBook As Object
        Dim OBSheet As Object

        OBExcel = CreateObject("Excel.Application")
        OBBook = OBExcel.workbooks.add

        OBSheet = OBBook.worksheets(1)

        OBSheet.range("A1").value = "ProductID"
        OBSheet.range("B1").value = "Product Name"
        OBSheet.range("C1").value = "Genre"
        OBSheet.range("D1").value = "Price"
        OBSheet.range("E1").value = "Quantity"


        For i = 0 To maxrows - 1
            OBSheet.range("A" & i + 2).value = ds.Tables("Products").Rows(i).Item(0)
            OBSheet.range("B" & i + 2).value = ds.Tables("Products").Rows(i).Item(1)
            OBSheet.range("C" & i + 2).value = ds.Tables("Products").Rows(i).Item(2)
            OBSheet.range("D" & i + 2).value = ds.Tables("Products").Rows(i).Item(3)
            OBSheet.range("E" & i + 2).value = ds.Tables("Products").Rows(i).Item(4)
        Next

        OBBook.saveas(Application.StartupPath & "\Backupstorage\productsbackup.xlsx")
        OBExcel.quit
    End Sub
    Private Sub BackupPostal()
        conn.Open()
        sql = "SELECT * FROM Postal"
        da = New OleDb.OleDbDataAdapter(sql, conn)

        da.Fill(ds, "Postal")

        conn.Close()

        maxrows = ds.Tables("Postal").Rows.Count
        curRow = 0

        Dim OBExcel As Object
        Dim OBBook As Object
        Dim OBSheet As Object

        OBExcel = CreateObject("Excel.Application")
        OBBook = OBExcel.workbooks.add

        OBSheet = OBBook.worksheets(1)

        OBSheet.range("A1").value = "PostalID"
        OBSheet.range("B1").value = "Postalservice"
        OBSheet.range("C1").value = "DeliveryTime"
        OBSheet.range("D1").value = "Centimetres"
        OBSheet.range("E1").value = "Weight"
        OBSheet.range("F1").value = "Cost"

        For i = 0 To maxrows - 1
            OBSheet.range("A" & i + 2).value = ds.Tables("Postal").Rows(i).Item(0)
            OBSheet.range("B" & i + 2).value = ds.Tables("Postal").Rows(i).Item(1)
            OBSheet.range("C" & i + 2).value = ds.Tables("Postal").Rows(i).Item(2)
            OBSheet.range("D" & i + 2).value = ds.Tables("Postal").Rows(i).Item(3)
            OBSheet.range("E" & i + 2).value = ds.Tables("Postal").Rows(i).Item(4)
            OBSheet.range("F" & i + 2).value = ds.Tables("Postal").Rows(i).Item(5)
        Next

        OBBook.saveas(Application.StartupPath & "\Backupstorage\postalbackup.xlsx")
        OBExcel.quit
    End Sub
    Private Sub FileWrite()
        Dim path As String = "C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\ProjectCode\bin\Debug\backupstorage\backupsaves.txt"
        Dim dateAndTime As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") 'the current date and time
        Dim writeText As String = dateAndTime 'the text to be written to the file
        Dim newLine As String = Environment.NewLine

        IO.File.AppendAllText(path, newLine & "Backup occured on " & writeText)
    End Sub
    Private Sub emailbackup()
        Dim SmtpServer As New SmtpClient
        Dim MessageMail As New MailMessage()
        Dim address As New MailAddress("Enfeysmarket@outlook.com")

        SmtpServer.EnableSsl = True
        SmtpServer.UseDefaultCredentials = False
        SmtpServer.Credentials = New Net.NetworkCredential("enfeysmarket@outlook.com", "Ycc87$Nucy4nai4")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp-mail.outlook.com"

        MessageMail.From = address
        MessageMail.To.Add(address)
        MessageMail.Subject = "Backup Confirmation "
        MessageMail.IsBodyHtml = False
        MessageMail.Body = ("A file with all system backups has been attached")

        Dim attachment As Attachment = New Attachment("C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\ProjectCode\bin\Debug\backupstorage\backupsaves.txt")
        attachment.Name = "backupsaves.txt"
        MessageMail.Attachments.Add(attachment)

        SmtpServer.Send(MessageMail)
        MsgBox("Mail Sent")
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'clear all text boxesars all textboxes
        EmployeeIdTxtBx.Clear()
        EmployeePasswordTxtBx.Clear()
        SecretQuestion.Clear()
        SecretAnswer.Clear()
        FirstNameTxtBx.Clear()
        SurnameTxtBx.Clear()
        ContactNumberTxtBx.Clear()
        AddressTxtBx.Clear()
        PostcodeTxtBx.Clear()
        EmailTxtBx.Clear()
        Admin.Clear()
    End Sub

    Private Sub btndelete_click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            ' deletes the current row being viewed
            Dim cb As New OleDb.OleDbCommandBuilder(da)

            If MessageBox.Show("Do you really want to delete this record?",
                               "delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning) = DialogResult.No Then ' displays a message box with a prompt to delete the records using yes or no buttons, if no is pressed the subroutine is exited, if yes then the row is deleted from the dataset

                MsgBox("operation cancelled")
                Exit Sub

            ElseIf DialogResult.Yes Then

                ds.Tables("Employees").Rows(curRow).Delete() ' connects employees and looks at the current row being viewed via currentrow and deletes it
                maxrows = maxrows - 1 ' needs to be done so that next and previous will work

                curRow = 0
                navigaterecords()

                cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                da.Update(ds, "Employees") ' updates the dataset employees
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class