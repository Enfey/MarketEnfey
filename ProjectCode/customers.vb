Imports System.Data.OleDb
Public Class customers
    Private maxColumns As Integer
    Private maxRows As Integer 'set later to define the maximum amount of rows
    Private curRow As Integer 'self explanatory
    Private ds As New DataSet ' our in memory representation of data
    Private sql As String = "SELECT * FROM Customers" 'query as string to be passed to db engine
    Private connPrivate As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
    Private dAdapterClassWide As New OleDbDataAdapter(sql, connPrivate) 'class wide, that doesn't employ the using keyword and so must be disposed of manually, passed to command builders later, da is for the using and actual operations

    Private Sub navigaterecords()
        'shows fields of the current row that is selected, called whenever we make a change to the current row variable
        CustomerIdTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(0)
        FirstNameTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(1)
        SurnameTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(2)
        AddressTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(3)
        PhoneTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(4)
        EmailTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(5)
        PostcodeTxtBx.Text = ds.Tables("Customers").Rows(curRow).Item(6)
    End Sub
    Private Sub customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb") 'initialise automatically disposed of connection object
                Using da As New OleDbDataAdapter(sql, conn) ' needs to be separate, if the using is used on the same object, it will be disposed of before the command builder can use it, or will break the program in case of an exception
                    da.Fill(ds, "Customers")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        maxRows = ds.Tables("Customers").Rows.Count
        MessageBox.Show($"The number of rows is {maxRows}", "Rows", MessageBoxButtons.OK, MessageBoxIcon.Information)

        maxColumns = ds.Tables("Customers").Columns.Count
        MessageBox.Show($"The number of fields is {maxColumns}", "Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)

        curRow = 0
        navigaterecords()

        If employeeAccessLevel_ = True Then
            AddBtn.Show()
            DeleteBtn.Show()
            UpdateBtn.Show()
            ClearBtn.Show()
        Else
            AddBtn.Hide()
            DeleteBtn.Hide()
            UpdateBtn.Hide()
            ClearBtn.Hide()
        End If
    End Sub
    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click 'navigates our dataset, by incrementing current row based on selection
        Try

            If curRow <> maxrows - 1 Then
                curRow = curRow + 1
                navigaterecords()
            Else
                MsgBox("no more rows")
            End If
            UpdateBtn.Enabled = True
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click 'navigates our dataset, by decrementing current row based on selection
        '(alternate actions to be taken based on conditions regarding current row)
        Try
            If curRow > 0 Then
                curRow = curRow - 1
                navigaterecords()
            ElseIf curRow = -1 Then
                MsgBox("No records yet")
            ElseIf curRow = 0 Then
                MsgBox("first record")
            End If
            UpdateBtn.Enabled = True
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'only present as it is accessing dataset, some scope to crash the program
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim cb As New OleDbCommandBuilder(dAdapterClassWide)

        If validateFields() Then
            ds.Tables("Customers").Rows(curRow).Item(0) = CustomerIdTxtBx.Text
            ds.Tables("Customers").Rows(curRow).Item(1) = FirstNameTxtBx.Text
            ds.Tables("Customers").Rows(curRow).Item(2) = SurnameTxtBx.Text
            ds.Tables("Customers").Rows(curRow).Item(3) = AddressTxtBx.Text
            ds.Tables("Customers").Rows(curRow).Item(4) = PhoneTxtBx.Text
            ds.Tables("Customers").Rows(curRow).Item(5) = EmailTxtBx.Text
            ds.Tables("Customers").Rows(curRow).Item(6) = PostcodeTxtBx.Text

            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            Try
                Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
                    Using da As New OleDbDataAdapter(sql, conn)
                        da.UpdateCommand = cb.GetUpdateCommand
                        da.Update(ds, "Customers")
                        MsgBox("record updated")
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click


        If curRow <> -1 Then
            Dim cb As New OleDbCommandBuilder(dAdapterClassWide)
            Dim dsnewrow As DataRow

            If validateFields() Then
                dsnewrow = ds.Tables("Customers").NewRow()

                dsnewrow.Item("CustomerID") = CustomerIdTxtBx.Text
                dsnewrow.Item("FirstName") = FirstNameTxtBx.Text
                dsnewrow.Item("Surname") = SurnameTxtBx.Text
                dsnewrow.Item("Address") = AddressTxtBx.Text
                dsnewrow.Item("Phone number") = PhoneTxtBx.Text
                dsnewrow.Item("EmailAddress") = EmailTxtBx.Text
                dsnewrow.Item("Postcode") = PostcodeTxtBx.Text

                ds.Tables("Customers").Rows.Add(dsnewrow)

                Try
                    Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
                        Using da As New OleDbDataAdapter(sql, conn)
                            da.Update(ds, "Customers")
                            MsgBox("record updated")
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        ' deletes the current row being viewed
        Dim cb As New OleDb.OleDbCommandBuilder(dAdapterClassWide)

        If MessageBox.Show("Do you really want to delete this record?",
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
            Try
                dAdapterClassWide.Update(ds, "Customers")
                'Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
                '    Using da As New OleDbDataAdapter(sql, conn)
                '        da.Update(ds, "Customers") ' updates the dataset named customers
                '        MsgBox("record deleted")
                '    End Using
                'End Using
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        clearTextBoxes(Me)
    End Sub
    Private Sub searchCustomersBtn_Click(sender As Object, e As EventArgs) Handles SearchCustomersBtn.Click
        SimpleCustomerSearch.Show()
        Me.Hide()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Hide()
        MenuMain.Show()
    End Sub

    Private Function validateFields() As Boolean

        '''<summary>
        ''' Validation block for data attempting to be used to update the database
        ''' </summary>

        '''ID validation
        If CustomerIdTxtBx.Text = "" Then
            MsgBox("Please enter the id of the customer")
            CustomerIdTxtBx.Focus()
            Return False
        ElseIf customerIDCheck(CustomerIdTxtBx.Text) = False Then
            MsgBox("Please enter a valid id, the format Is N followed by 4 digits.")
            CustomerIdTxtBx.Clear()
            CustomerIdTxtBx.Focus()
            Return False

            '''First name validation
        ElseIf FirstNameTxtBx.Text = "" Then
            MsgBox("Please enter the first name of the customer.")
            FirstNameTxtBx.Focus()
            Return False
        ElseIf FirstNameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then 'validates the name, ensures only alphabetical characters are used
            MsgBox("Please enter a valid first name, alphabetical characters only")
            FirstNameTxtBx.Clear()
            FirstNameTxtBx.Focus()
            Return False
        ElseIf LengthCheck(FirstNameTxtBx.Text, 20, 2) = False Then
            MsgBox("Please enter a valid name, the name must be between 2 And 20 characters.")
            FirstNameTxtBx.Clear()
            FirstNameTxtBx.Focus()
            Return False

            '''Surname validation
        ElseIf SurnameTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the surname.")
            SurnameTxtBx.Focus()
            Return False
        ElseIf SurnameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then
            MsgBox("Please enter a valid first name, alphabetical characters only")
            SurnameTxtBx.Clear()
            SurnameTxtBx.Focus()
            Return False
        ElseIf LengthCheck(SurnameTxtBx.Text, 20, 2) = False Then 'validation
            MsgBox("Please enter a valid surname, the surname must be between 2 And 20 characters.")
            SurnameTxtBx.Clear()
            SurnameTxtBx.Focus()
            Return False

            '''Address validation
        ElseIf AddressTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the address.")
            AddressTxtBx.Focus()
            Return False
        ElseIf LengthCheck(AddressTxtBx.Text, 50, 5) = False Then 'validation
            MsgBox("Please enter a valid address, the address must be between 5 And 50 characters.")
            AddressTxtBx.Clear()
            AddressTxtBx.Focus()
            Return False

            '''Phone number validation
        ElseIf PhoneTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the contact number of the customer.")
            PhoneTxtBx.Focus()
            Return False
        ElseIf phoneCheck(PhoneTxtBx.Text) = False Then
            MsgBox("The phone number Is invalid, please ensure there are no spaces And a maximum of 15 digits. Include the country code.")
            PhoneTxtBx.Clear()
            PhoneTxtBx.Focus()
            Return False

            '''Email validation
        ElseIf EmailTxtBx.Text = "" Then 'validation
            MsgBox("Please enter a valid email, please ensure there Is a proper email suffix with a '.' and a domain, and that an @ sign is included. Max of 50 chars for email prefix, 10 for domain and 5 for domain suffix.")
            EmailTxtBx.Focus()
            Return False
        ElseIf emailCheck(EmailTxtBx.Text) = False Then
            MsgBox("Please enter a valid email address.")
            EmailTxtBx.Clear()
            PhoneTxtBx.Focus()
            Return False

            '''Postcode validation
        ElseIf PostcodeTxtBx.Text = "" Then 'validation
            MsgBox("Please enter the postcode")
            PostcodeTxtBx.Focus()
            Return False
        ElseIf postcodeCheck(PostcodeTxtBx.Text) = False Then
            MsgBox("Please enter a valid postcode, following UK postcode format.")
            PostcodeTxtBx.Clear()
            PostcodeTxtBx.Focus()
            Return False
        Else
            Return True
        End If
    End Function
End Class