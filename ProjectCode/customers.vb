Imports System.Text.RegularExpressions

Public Class customers
    Dim MaxColumns As Integer '
    Dim maxrows As Integer ' defines the maximum amount of rows,
    Dim curRow As Integer 'defines the current rows, used within most of the code
    Dim ds As New DataSet ' same as a table and is just defined as a set of data
    Dim da As OleDb.OleDbDataAdapter ' used to send data between access and visual studio
    Dim sql As String
    Private Sub navigaterecords()
        'shows fields of the current row that is selected
        IdTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(0)
        NameTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(1)
        SrnameTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(2)
        AddressTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(3)
        PhoneTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(4)
        EmailTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(5)
        PostcodeTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(6)
    End Sub
    Private Sub customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            sql = "SELECT * FROM Customers" 'sql statement to be used and retrieve data from access

            da = New OleDb.OleDbDataAdapter(sql, conn) 'connects the dataset with the info from the sql query and uses the connection to the database

            da.Fill(ds, "Customers") 'fills it with info from the query

            conn.Close() 'closes the connection

            maxrows = ds.Tables("Customers").Rows.Count 'counts the rows in customers
            curRow = 0

            MsgBox("The number of rows is " & maxrows)

            MaxColumns = ds.Tables("Customers").Columns.Count 'counts the columns in customers
            MsgBox("The number of fields is " & MaxColumns)

            navigaterecords()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        AddBtn.Hide()
        BtnDelete.Hide()
        UpdateBtn.Hide()
        ClearBtn.Hide()

        If login.accesslevel = True Then
            AddBtn.Show()
            BtnDelete.Show()
            UpdateBtn.Show()
            ClearBtn.Show()
        End If
    End Sub
    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Try
            ' navigates the table and cycles between the rows within the database
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

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim customerid As String = IdTxtBx.Text
        Dim email As String = EmailTxtBx.Text
        Dim postcode As String = PostcodeTxtBx.Text
        Dim phone As String = PhoneTxtBx.Text
        
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        If IdTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the id of the customer")
            IdTxtBx.Focus()
        ElseIf CustomerIDCheck(customerid) = False Then
            MsgBox("Please enter a valid id, the format is N followed by 4 digits.")
            IdTxtBx.Clear()
            IdTxtBx.Focus()

        ElseIf NameTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the first name of the customer.")
            NameTxtBx.Focus()
        ElseIf NameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then
            MsgBox("Please enter a valid first name, alphabetical characters only")
            NameTxtBx.Clear()
            NameTxtBx.Focus()
        ElseIf LengthCheck(NameTxtBx.Text, 20, 2) = false Then 'validation
            MsgBox("Please enter a valid name, the name must be between 2 and 20 characters.")
            NameTxtBx.Clear()
            NameTxtBx.Focus()

        ElseIf SrnameTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the surname.")
            SrnameTxtBx.Focus()
        ElseIf SrnameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then
            MsgBox("Please enter a valid first name, alphabetical characters only")
            SrnameTxtBx.Clear()
            SrnameTxtBx.Focus()
        ElseIf LengthCheck(SrnameTxtBx.Text, 20, 2) = false Then 'validation
            MsgBox("Please enter a valid surname, the surname must be between 2 and 20 characters.")
            SrnameTxtBx.Clear()
            SrnameTxtBx.Focus()

        ElseIf AddressTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the address.")
            AddressTxtBx.Focus()
        ElseIf LengthCheck(AddressTxtBx.Text, 50, 5) = false Then 'validation
            MsgBox("Please enter a valid address, the address must be between 5 and 50 characters.")
            AddressTxtBx.Clear()
            AddressTxtBx.Focus()

        ElseIf PhoneTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the contact number of the customer.")
            PhoneTxtBx.Focus()
        ElseIf phonecheck(phone) = False Then
            MsgBox("The phone number is invalid, please ensure there are no spaces and a maximum of 15 digits. Include the country code.")
            PhoneTxtBx.Clear()
            PhoneTxtBx.Focus()

        ElseIf EmailTxtBx.Text = "" Then 'validation
            MsgBox("Please enter a valid email, please ensure there is a proper email suffix with a '.' and a domain, and that an @ sign is included. Max of 50 chars for email prefix, 10 for domain and 5 for domain suffix.")
            EmailTxtBx.Focus()
        ElseIf emailCheck(email) = False Then
            MsgBox("Please enter a valid email address.")
            EmailTxtBx.Clear()
            PhoneTxtBx.Focus()

        ElseIf PostcodeTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the postcode")
            PostcodeTxtBx.Focus()
        ElseIf postcodeCheck(postcode) = False Then
            MsgBox("Please enter a valid postcode, following UK postcode format.")
            PostcodeTxtBx.Clear()
            PostcodeTxtBx.Focus()

            Else
                try
                conn.Open()
                ds.Tables("Customers").Rows(curRow).Item(0) = IdTxtBx.Text  ' the current row and this item is populated into the text box
                ds.Tables("Customers").Rows(curRow).Item(1) = NameTxtBx.Text ' the current row and this item is populated into the text box
                ds.Tables("Customers").Rows(curRow).Item(2) = SrnameTxtBx.Text ' the current row and this item is populated into the text box
                ds.Tables("Customers").Rows(curRow).Item(3) = AddressTxtBx.Text ' the current row and this item is populated into the text box
                ds.Tables("Customers").Rows(curRow).Item(4) = PhoneTxtBx.Text ' the current row and this item is populated into the text box
                ds.Tables("Customers").Rows(curRow).Item(5) = EmailTxtBx.Text ' the current row and this item is populated into the text box
                ds.Tables("Customers").Rows(curRow).Item(6) = PostcodeTxtBx.Text ' the current row and this item is populated into the text box

                cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access

                da.Update(ds, "Customers") 'updates dataset customers
                MsgBox("record updated")
                conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        
       
            If curRow <> -1 Then
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                Dim dsnewrow As DataRow 'represents a row of data being added to a table

                Dim customerid As String = IdTxtBx.Text
                Dim email As String = EmailTxtBx.Text
                Dim postcode As String = PostcodeTxtBx.Text
                Dim phone As String = PhoneTxtBx.Text
                
                If IdTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the id of the customer")
            IdTxtBx.Focus()
        ElseIf CustomerIDCheck(customerid) = False Then
            MsgBox("Please enter a valid id, the format is N followed by 4 digits.")
            IdTxtBx.Clear()
            IdTxtBx.Focus()

        ElseIf NameTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the first name of the customer.")
            NameTxtBx.Focus()
        ElseIf NameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then
            MsgBox("Please enter a valid first name, alphabetical characters only")
            NameTxtBx.Clear()
            NameTxtBx.Focus()
        ElseIf LengthCheck(NameTxtBx.Text, 20, 2) = false Then 'validation
            MsgBox("Please enter a valid name, the name must be between 2 and 20 characters.")
            NameTxtBx.Clear()
            NameTxtBx.Focus()

        ElseIf SrnameTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the surname.")
            SrnameTxtBx.Focus()
        ElseIf SrnameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then
            MsgBox("Please enter a valid first name, alphabetical characters only")
            SrnameTxtBx.Clear()
            SrnameTxtBx.Focus()
        ElseIf LengthCheck(SrnameTxtBx.Text, 20, 2) = false Then 'validation
            MsgBox("Please enter a valid surname, the surname must be between 2 and 20 characters.")
            SrnameTxtBx.Clear()
            SrnameTxtBx.Focus()

        ElseIf AddressTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the address.")
            AddressTxtBx.Focus()
        ElseIf LengthCheck(AddressTxtBx.Text, 50, 5) = false Then 'validation
            MsgBox("Please enter a valid address, the address must be between 5 and 50 characters.")
            AddressTxtBx.Clear()
            AddressTxtBx.Focus()

        ElseIf PhoneTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the contact number of the customer.")
            PhoneTxtBx.Focus()
        ElseIf phonecheck(phone) = False Then
            MsgBox("The phone number is invalid, please ensure there are no spaces and a maximum of 15 digits. Include the country code.")
            PhoneTxtBx.Clear()
            PhoneTxtBx.Focus()

        ElseIf EmailTxtBx.Text = "" Then 'validation
            MsgBox("Please enter a valid email, please ensure there is a proper email suffix with a '.' and a domain, and that an @ sign is included. Max of 50 chars for email prefix, 10 for domain and 5 for domain suffix.")
            EmailTxtBx.Focus()
        ElseIf emailCheck(email) = False Then
            MsgBox("Please enter a valid email address.")
            EmailTxtBx.Clear()
            PhoneTxtBx.Focus()

        ElseIf PostcodeTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the postcode")
            PostcodeTxtBx.Focus()
        ElseIf postcodeCheck(postcode) = False Then
            MsgBox("Please enter a valid postcode, following UK postcode format.")
            PostcodeTxtBx.Clear()
            PostcodeTxtBx.Focus()

                Else
                    try
                    conn.Open()
                    dsnewrow = ds.Tables("Customers").NewRow() 'equal to a new rom in the table customers

                    dsnewrow.Item("CustomerID") = IdTxtBx.Text 'What is in the table (which is currently empty text) fills into the text boxes
                    dsnewrow.Item("FirstName") = NameTxtBx.Text
                    dsnewrow.Item("Surname") = SrnameTxtBx.Text
                    dsnewrow.Item("Address") = AddressTxtBx.Text
                    dsnewrow.Item("Phone number") = PhoneTxtBx.Text
                    dsnewrow.Item("EmailAddress") = EmailTxtBx.Text
                    dsnewrow.Item("Postcode") = PostcodeTxtBx.Text

                    ds.Tables("Customers").Rows.Add(dsnewrow) ' adds a new row

                    cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                    cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access

                    da.Update(ds, "Customers") 'updates dataset customers
                    MsgBox("new record added to the database")
                    conn.Close()
                    Catch ex As Exception 
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End If
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Try
            ' deletes the current row being viewed
            Dim cb As New OleDb.OleDbCommandBuilder(da)

            If MessageBox.Show("Do you really want to delete this record",
                               "delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning) = DialogResult.No Then ' displays a message box with a prompt to delete the records using yes or no buttons, if no is pressed the subroutine is exited, if yes then the row is deleted from the dataset

                MsgBox("operation cancelled")
                Exit Sub

            ElseIf DialogResult.Yes Then

                ds.Tables("Customers").Rows(curRow).Delete() ' connects customers and looks at the current row being viewed via currentrow and deletes it
                maxrows = maxrows - 1 ' needs to be done so that next and previous will work

                curRow = 0
                navigaterecords()

                cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                da.Update(ds, "Customers") ' updates the dataset named customers
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Try
            IdTxtBx.Text = ""
            NameTxtBx.Text = ""
            SrnameTxtBx.Text = ""
            AddressTxtBx.Text = ""
            PhoneTxtBx.Text = ""
            EmailTxtBx.Text = ""
            PostcodeTxtBx.Text = ""
            'sets a row to be empty
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MenuMain.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MenuMain.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Employees.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Orders.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        postal.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Products.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SimpleCustomerSearch.Show()
        Me.Hide()
    End Sub
End Class