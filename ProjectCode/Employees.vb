'Imports System.Net.Mail
'Imports System.Data.OleDb

'Public Class Employees
'    Private maxColumns As Integer
'    Private maxRows As Integer 'set later to define the maximum amount of rows
'    Private curRow As Integer 'self explanatory
'    Private ds As New DataSet ' our in memory representation of data
'    Private sql As String 'query as string to be passed to db engine

'    Private connPrivate As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
'    Private dAdapterClassWide As New OleDbDataAdapter(sql, connPrivate)
'    Private Sub navigaterecords()
'        'shows fields of the current row that is selected
'        EmployeeIdTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(0)
'        EmployeePasswordTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(1)
'        SecretQuestionTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(2)
'        SecretAnswerTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(3)
'        FirstNameTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(4)
'        SurnameTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(5)
'        PhoneTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(6)
'        AddressTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(7)
'        PostcodeTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(8)
'        EmailTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(9)
'        AdminStatusTxtBx.Text = ds.Tables("Employees").Rows(curRow).Item(10)
'        EmployeePicture.Image = Image.FromFile(Application.StartupPath & "\employeepictures\" & FirstNameTxtBx.Text & ".png")
'    End Sub
'    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        If employeeAccessLevel_ = False Then
'            NextBtn.Hide()
'            PrevBtn.Hide()
'            AddBtn.Hide()
'            BackupBtn.Hide()
'            AdminStatusTxtBx.ReadOnly = True
'            AdminStatusTxtBx.Text = $"False"
'            Try
'                Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
'                    sql = "SELECT * FROM employees WHERE EmployeeID = @EmployeeID"
'                    dAdapterClassWide.SelectCommand.Parameters.AddWithValue("@EmployeeID", employeeID_)
'                    Using da As New OleDbDataAdapter(sql, conn)
'                        da.Fill(ds, "Employees")
'                    End Using
'                End Using
'                navigaterecords()
'            Catch ex As Exception
'                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try


'        ElseIf employeeAccessLevel_ = True Then
'            AddBtn.Show()
'            DeleteBtn.Show()
'            UpdateBtn.Show()
'            ClearBtn.Show()

'            Try
'                Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
'                    sql = "SELECT * FROM Employees"
'                    Using da As New OleDbDataAdapter(sql, conn)
'                        da.Fill(ds, "Employees")
'                    End Using
'                End Using
'            Catch ex As Exception
'                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try

'            maxRows = ds.Tables("Employees").Rows.Count
'            MessageBox.Show($"The number of rows is {maxRows}", "Rows", MessageBoxButtons.OK, MessageBoxIcon.Information)

'            maxColumns = ds.Tables("Employees").Columns.Count
'            MessageBox.Show($"The number of fields is {maxColumns}", "Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)

'            curRow = 0

'            navigaterecords()
'        End If
'    End Sub
'    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
'        Try
'            If curRow <> maxRows - 1 Then
'                curRow = curRow + 1 'counts current row, going forward in rows and then displaying it
'                navigaterecords()
'            Else
'                MsgBox("no more rows") ' if the max number of rows is reached, then no more rows is displayed
'            End If
'        Catch ex As Exception
'            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub
'    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
'        Try
'            If curRow > 0 Then
'                curRow = curRow - 1 'minuses from current row therefore displaying the previous row
'                navigaterecords()
'            ElseIf curRow = -1 Then
'                MsgBox("No records yet")
'            ElseIf curRow = 0 Then
'                MsgBox("first record")
'            End If
'        Catch ex As Exception
'            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub
'    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click

'        Dim cb As New OleDbCommandBuilder(dAdapterClassWide)

'        If validateFields() Then
'            ds.Tables("Employees").Rows(curRow).Item(1) = EmployeePasswordTxtBx.Text
'            ds.Tables("Employees").Rows(curRow).Item(2) = SecretQuestionTxtBx.Text
'            ds.Tables("Employees").Rows(curRow).Item(3) = SecretAnswerTxtBx.Text
'            ds.Tables("Employees").Rows(curRow).Item(4) = FirstNameTxtBx.Text
'            ds.Tables("Employees").Rows(curRow).Item(5) = SurnameTxtBx.Text
'            ds.Tables("Employees").Rows(curRow).Item(6) = PhoneTxtBx.Text
'            ds.Tables("Employees").Rows(curRow).Item(7) = AddressTxtBx.Text
'            ds.Tables("Employees").Rows(curRow).Item(8) = PostcodeTxtBx.Text
'            ds.Tables("Employees").Rows(curRow).Item(9) = EmailTxtBx.Text
'            ds.Tables("Employees").Rows(curRow).Item(10) = AdminStatusTxtBx.Text

'            cb.QuotePrefix = "["
'            cb.QuoteSuffix = "]"

'            Try
'                Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
'                    Using da As New OleDbDataAdapter(sql, conn)
'                        da.UpdateCommand = cb.GetUpdateCommand
'                        da.Update(ds, "Employees")
'                        MsgBox("record updated")
'                    End Using
'                End Using
'            Catch ex As Exception
'                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End If
'    End Sub

'    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
'        If curRow <> -1 Then
'            Dim cb As New OleDbCommandBuilder(dAdapterClassWide)

'            If validateFields() Then
'                Dim dsnewrow As DataRow

'                dsnewrow = ds.Tables("Employees").NewRow()

'                dsnewrow.Item("EmployeeID") = EmployeeIdTxtBx.Text
'                dsnewrow.Item("EmployeePassword") = EmployeePasswordTxtBx.Text
'                dsnewrow.Item("SecretQuestion") = SecretQuestionTxtBx.Text
'                dsnewrow.Item("SecretAnswer") = SecretAnswerTxtBx.Text
'                dsnewrow.Item("First Name") = FirstNameTxtBx.Text
'                dsnewrow.Item("Surname") = SurnameTxtBx.Text
'                dsnewrow.Item("ContactNumber") = PhoneTxtBx.Text
'                dsnewrow.Item("Address") = AddressTxtBx.Text
'                dsnewrow.Item("Postcode") = PostcodeTxtBx.Text
'                dsnewrow.Item("Email") = EmailTxtBx.Text
'                dsnewrow.Item("Admin") = AdminStatusTxtBx.Text

'                ds.Tables("Employees").Rows.Add(dsnewrow)

'                cb.QuotePrefix = "["
'                cb.QuoteSuffix = "]"

'                Try
'                    Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
'                        Using da As New OleDbDataAdapter(sql, conn)
'                            da.UpdateCommand = cb.GetUpdateCommand
'                            da.Update(ds, "Employees")
'                            MsgBox("record updated")
'                        End Using
'                    End Using
'                Catch ex As Exception
'                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                End Try
'            End If
'        End If
'    End Sub

'    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
'        Me.Hide()
'        MenuMain.Show()
'    End Sub

'    Private Sub BackupBtn_Click(sender As Object, e As EventArgs) Handles BackupBtn.Click
'        Try
'            BackupEmployees()
'            BackupCustomers()
'            BackupOrders()
'            BackupProducts()
'            BackupPostal()
'            FileWrite()
'            emailbackup()
'        Catch ex As Exception
'            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            GC.Collect()
'        End Try
'    End Sub

'    Private Sub BackupEmployees()
'        Dim OBExcel As Object
'        Dim OBBook As Object
'        Dim OBSheet As Object

'        OBExcel = CreateObject("Excel.Application")
'        OBBook = OBExcel.workbooks.add

'        OBSheet = OBBook.worksheets(1)

'        OBSheet.range("A1").value = "EmployeeID"
'        OBSheet.range("B1").value = "EmployeePassword"
'        OBSheet.range("C1").value = "SecretQuestion"
'        OBSheet.range("D1").value = "SecretAnswer"
'        OBSheet.range("E1").value = "First Name"
'        OBSheet.range("F1").value = "Surname"
'        OBSheet.range("G1").value = "ContactNumber"
'        OBSheet.range("H1").value = "Address"
'        OBSheet.range("I1").value = "Postcode"
'        OBSheet.range("J1").value = "Email"
'        OBSheet.range("K1").value = "Admin"

'        For i = 0 To maxrows - 1
'            OBSheet.range("A" & i + 2).value = ds.Tables("Employees").Rows(i).Item(0)
'            OBSheet.range("B" & i + 2).value = ds.Tables("Employees").Rows(i).Item(1)
'            OBSheet.range("C" & i + 2).value = ds.Tables("Employees").Rows(i).Item(2)
'            OBSheet.range("D" & i + 2).value = ds.Tables("Employees").Rows(i).Item(3)
'            OBSheet.range("E" & i + 2).value = ds.Tables("Employees").Rows(i).Item(4)
'            OBSheet.range("F" & i + 2).value = ds.Tables("Employees").Rows(i).Item(5)
'            OBSheet.range("G" & i + 2).value = ds.Tables("Employees").Rows(i).Item(6)
'            OBSheet.range("H" & i + 2).value = ds.Tables("Employees").Rows(i).Item(7)
'            OBSheet.range("I" & i + 2).value = ds.Tables("Employees").Rows(i).Item(8)
'            OBSheet.range("J" & i + 2).value = ds.Tables("Employees").Rows(i).Item(9)
'            OBSheet.range("K" & i + 2).value = ds.Tables("Employees").Rows(i).Item(10)
'        Next
'        OBBook.saveas(Application.StartupPath & "\Backupstorage\employeesbackup.xlsx")
'        OBExcel.quit
'    End Sub
'    Private Sub BackupCustomers()
'        Try
'            Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
'                conn.Open()
'                sql = "SELECT * FROM Customers"
'                Using da As New OleDbDataAdapter(sql, conn)
'                    da.Fill(ds, "Customers")
'                End Using
'                conn.Close()
'            End Using
'        Catch ex As Exception
'            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try


'        maxRows = ds.Tables("Customers").Rows.Count
'        customers.CustomerIdTxtBx.Text = ds.Tables("Customers").Rows(0).Item(0)
'        customers.FirstNameTxtBx.Text = ds.Tables("Customers").Rows(0).Item(1)
'        customers.SurnameTxtBx.Text = ds.Tables("Customers").Rows(0).Item(2)
'        customers.AddressTxtBx.Text = ds.Tables("Customers").Rows(0).Item(3)
'        customers.PhoneTxtBx.Text = ds.Tables("Customers").Rows(0).Item(4)
'        customers.EmailTxtBx.Text = ds.Tables("Customers").Rows(0).Item(5)
'        customers.PostcodeTxtBx.Text = ds.Tables("Customers").Rows(0).Item(6)

'        Dim OBExcel As Object
'        Dim OBBook As Object
'        Dim OBSheet As Object

'        OBExcel = CreateObject("Excel.Application")
'        OBBook = OBExcel.workbooks.add

'        OBSheet = OBBook.worksheets(1)

'        OBSheet.range("A1").value = "CustomerID"
'        OBSheet.range("B1").value = "FirstName"
'        OBSheet.range("C1").value = "Surname"
'        OBSheet.range("D1").value = "Address"
'        OBSheet.range("E1").value = "Phone Number"
'        OBSheet.range("F1").value = "EmailAddress"
'        OBSheet.range("G1").value = "Postcode"

'        For i = 0 To maxrows - 1
'            OBSheet.range("A" & i + 2).value = ds.Tables("Customers").Rows(i).Item(0)
'            OBSheet.range("B" & i + 2).value = ds.Tables("Customers").Rows(i).Item(1)
'            OBSheet.range("C" & i + 2).value = ds.Tables("Customers").Rows(i).Item(2)
'            OBSheet.range("D" & i + 2).value = ds.Tables("Customers").Rows(i).Item(3)
'            OBSheet.range("E" & i + 2).value = ds.Tables("Customers").Rows(i).Item(4)
'            OBSheet.range("F" & i + 2).value = ds.Tables("Customers").Rows(i).Item(5)
'            OBSheet.range("G" & i + 2).value = ds.Tables("Customers").Rows(i).Item(6)
'        Next

'        OBBook.saveas(Application.StartupPath & "\Backupstorage\customersbackup.xlsx")
'        OBExcel.quit
'    End Sub
'    Private Sub BackupOrders()
'        Try
'            Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
'                conn.Open()
'                sql = "SELECT * FROM Customers"
'                Using da As New OleDbDataAdapter(sql, conn)
'                    da.Fill(ds, "Customers")
'                End Using
'                conn.Close()
'            End Using
'        Catch ex As Exception
'            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try



'        maxRows = ds.Tables("Orders").Rows.Count
'        Orders.SalesIDTxtBx.Text = ds.Tables("Orders").Rows(0).Item(0)
'        Orders.CustomerIDTxtBx.Text = ds.Tables("Orders").Rows(0).Item(1)
'        Orders.DateTxtBx.Text = ds.Tables("Orders").Rows(0).Item(2)
'        Orders.QuantityTxtBx.Text = ds.Tables("Orders").Rows(0).Item(3)
'        Orders.TotalTxtBx.Text = ds.Tables("Orders").Rows(0).Item(4)
'        Orders.EmployeeIDTxtBx.Text = ds.Tables("Orders").Rows(0).Item(5)
'        Orders.PostalIDtxtBx.Text = ds.Tables("Orders").Rows(0).Item(6)

'        Dim OBExcel As Object
'        Dim OBBook As Object
'        Dim OBSheet As Object

'        OBExcel = CreateObject("Excel.Application")
'        OBBook = OBExcel.workbooks.add

'        OBSheet = OBBook.worksheets(1)

'        OBSheet.range("A1").value = "SalesID"
'        OBSheet.range("B1").value = "CustomerID"
'        OBSheet.range("C1").value = "Date"
'        OBSheet.range("D1").value = "Quantity"
'        OBSheet.range("E1").value = "Total"
'        OBSheet.range("F1").value = "EmployeeID"
'        OBSheet.range("G1").value = "PostalID"

'        For i = 0 To maxrows - 1
'            OBSheet.range("A" & i + 2).value = ds.Tables("Orders").Rows(i).Item(0)
'            OBSheet.range("B" & i + 2).value = ds.Tables("Orders").Rows(i).Item(1)
'            OBSheet.range("C" & i + 2).value = ds.Tables("Orders").Rows(i).Item(2)
'            OBSheet.range("D" & i + 2).value = ds.Tables("Orders").Rows(i).Item(3)
'            OBSheet.range("E" & i + 2).value = ds.Tables("Orders").Rows(i).Item(4)
'            OBSheet.range("F" & i + 2).value = ds.Tables("Orders").Rows(i).Item(5)
'            OBSheet.range("G" & i + 2).value = ds.Tables("Orders").Rows(i).Item(6)
'        Next

'        OBBook.saveas(Application.StartupPath & "\Backupstorage\ordersbackup.xlsx")
'        OBExcel.quit
'    End Sub
'    Private Sub BackupProducts()
'        Try
'            Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
'                conn.Open()
'                sql = "SELECT * FROM Customers"
'                Using da As New OleDbDataAdapter(sql, conn)
'                    da.Fill(ds, "Customers")
'                End Using
'                conn.Close()
'            End Using
'        Catch ex As Exception
'            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try


'        maxRows = ds.Tables("Products").Rows.Count
'        Products.ProductIdTxtBx.Text = ds.Tables("Products").Rows(0).Item(0)
'        Products.ProductNameTxtBx.Text = ds.Tables("Products").Rows(0).Item(1)
'        Products.GenreTxtBx.Text = ds.Tables("Products").Rows(0).Item(2)
'        Products.PriceTxtBx.Text = ds.Tables("Products").Rows(0).Item(3)
'        Products.QuantityTxtBx.Text = ds.Tables("Products").Rows(0).Item(4)

'        Dim OBExcel As Object
'        Dim OBBook As Object
'        Dim OBSheet As Object

'        OBExcel = CreateObject("Excel.Application")
'        OBBook = OBExcel.workbooks.add

'        OBSheet = OBBook.worksheets(1)

'        OBSheet.range("A1").value = "ProductID"
'        OBSheet.range("B1").value = "Product Name"
'        OBSheet.range("C1").value = "Genre"
'        OBSheet.range("D1").value = "Price"
'        OBSheet.range("E1").value = "Quantity"


'        For i = 0 To maxrows - 1
'            OBSheet.range("A" & i + 2).value = ds.Tables("Products").Rows(i).Item(0)
'            OBSheet.range("B" & i + 2).value = ds.Tables("Products").Rows(i).Item(1)
'            OBSheet.range("C" & i + 2).value = ds.Tables("Products").Rows(i).Item(2)
'            OBSheet.range("D" & i + 2).value = ds.Tables("Products").Rows(i).Item(3)
'            OBSheet.range("E" & i + 2).value = ds.Tables("Products").Rows(i).Item(4)
'        Next

'        OBBook.saveas(Application.StartupPath & "\Backupstorage\productsbackup.xlsx")
'        OBExcel.quit
'    End Sub
'    Private Sub BackupPostal()
'        Try
'            Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
'                conn.Open()
'                sql = "SELECT * FROM Customers"
'                Using da As New OleDbDataAdapter(sql, conn)
'                    da.Fill(ds, "Customers")
'                End Using
'                conn.Close()
'            End Using
'        Catch ex As Exception
'            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try


'        Dim OBExcel As Object
'        Dim OBBook As Object
'        Dim OBSheet As Object

'        OBExcel = CreateObject("Excel.Application")
'        OBBook = OBExcel.workbooks.add

'        OBSheet = OBBook.worksheets(1)

'        OBSheet.range("A1").value = "PostalID"
'        OBSheet.range("B1").value = "Postalservice"
'        OBSheet.range("C1").value = "DeliveryTime"
'        OBSheet.range("D1").value = "Centimetres"
'        OBSheet.range("E1").value = "Weight"
'        OBSheet.range("F1").value = "Cost"

'        For i = 0 To maxrows - 1
'            OBSheet.range("A" & i + 2).value = ds.Tables("Postal").Rows(i).Item(0)
'            OBSheet.range("B" & i + 2).value = ds.Tables("Postal").Rows(i).Item(1)
'            OBSheet.range("C" & i + 2).value = ds.Tables("Postal").Rows(i).Item(2)
'            OBSheet.range("D" & i + 2).value = ds.Tables("Postal").Rows(i).Item(3)
'            OBSheet.range("E" & i + 2).value = ds.Tables("Postal").Rows(i).Item(4)
'            OBSheet.range("F" & i + 2).value = ds.Tables("Postal").Rows(i).Item(5)
'        Next

'        OBBook.saveas(Application.StartupPath & "\Backupstorage\postalbackup.xlsx")
'        OBExcel.quit
'    End Sub
'    Private Sub FileWrite()
'        Dim path As String = "C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\ProjectCode\bin\Debug\backupstorage\backupsaves.txt"
'        Dim dateAndTime As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") 'the current date and time
'        Dim writeText As String = dateAndTime 'the text to be written to the file
'        Dim newLine As String = Environment.NewLine

'        IO.File.AppendAllText(path, newLine & "Backup occured on " & writeText)
'    End Sub
'    Private Sub emailbackup()
'        Dim message As String = "A file with all system backups has been attached"
'        Dim subject As String = "Backup Confirmation"
'        Dim credentials As New Dictionary(Of String, String) From {
'                    {"username", "enfeysmarket@outlook.com"},
'                    {"password", "Ycc87$Nucy4nai4"}
'                    }
'        Dim recipient As String = "Enfeysmarket@outlook.com"
'        Dim sender As New MailAddress("Enfeysmarket@outlook.com")
'        Dim mailAttachment As Attachment = New Attachment("C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\ProjectCode\bin\Debug\backupstorage\backupsaves.txt")
'        Dim attachmentName = "backupsaves.txt"

'        SendEmail(message, subject, credentials, sender, recipient, mailAttachment, attachmentName)
'    End Sub

'    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
'        clearTextBoxes(Me)
'    End Sub

'    Private Sub deleteBtn_click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

'        ' deletes the current row being viewed
'        Dim cb As New OleDbCommandBuilder(da)

'        If MessageBox.Show("Do you really want to delete this record?",
'                           "delete", MessageBoxButtons.YesNo,
'                           MessageBoxIcon.Warning) = DialogResult.No Then ' displays a message box with a prompt to delete the records using yes or no buttons, if no is pressed the subroutine is exited, if yes then the row is deleted from the dataset

'            MsgBox("Operation cancelled")
'            Exit Sub

'        ElseIf DialogResult.Yes Then
'            ds.Tables("Employees").Rows(curRow).Delete() ' connects employees and looks at the current row being viewed via currentrow and deletes it
'            maxRows = maxRows - 1 ' needs to be done so that next and previous will work

'            curRow = 0
'            navigaterecords()

'            cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
'            cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
'            Try
'                da.Update(ds, "Employees") ' updates the dataset employees
'            Catch ex As Exception
'                da.Dispose()
'                MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End If
'    End Sub


'    Private Function validateFields() As Boolean
'        '''<summary>
'        ''' Validation block for data attempting to be used to update the database
'        ''' </summary>

'        If EmployeeIdTxtBx.Text = "" Then
'            MsgBox("Please enter the id of the employee")
'            EmployeeIdTxtBx.Focus()
'            Return False
'        ElseIf EmployeeIDCheck(EmployeeIdTxtBx.Text) = False Then
'            MsgBox("Please enter the correct format of the ID, the ID format is E followed by 4 digits.")
'            EmployeeIdTxtBx.Clear()
'            EmployeeIdTxtBx.Focus()
'            Return False

'        ElseIf EmployeePasswordTxtBx.Text = "" Then
'            MsgBox("Please enter the password")
'            EmployeePasswordTxtBx.Focus()
'            Return False
'        ElseIf passwordDictionaryCheck(EmployeePasswordTxtBx.text) = True Then
'            MsgBox("Please enter a valid password, it must not contain any commonly used passwords, please try again")
'            EmployeePasswordTxtBx.Clear()
'            EmployeePasswordTxtBx.Focus()
'            Return False
'        ElseIf passwordCheck(EmployeePasswordTxtBx.text) = False Then
'            MsgBox("Please enter a valid password, it must contain at least 8 characters, 1 uppercase, 1 lowercase, 1 number and 1 special character and a miniumum of 8 characters is to be used, and a maximum of 30 characters is to be used")
'            EmployeePasswordTxtBx.Clear()
'            EmployeePasswordTxtBx.Focus()
'            Return False

'        ElseIf SecretQuestionTxtBx.Text = "" Then
'            MsgBox("Please enter the secret question")
'            SecretQuestionTxtBx.Focus()
'            Return False
'        ElseIf characterCheck(SecretQuestionTxtBx.Text) = False Then
'            MsgBox("Please enter a valid secret question, it can only contain alphabetical characters and whitespaces")
'            SecretQuestionTxtBx.Clear()
'            SecretQuestionTxtBx.Focus()
'            Return False
'        ElseIf LengthCheck(SecretQuestionTxtBx.Text, 50, 10) = False Then
'            MsgBox("Please enter a valid secret question, it must be between 10 and 50 characters")
'            SecretQuestionTxtBx.Clear()
'            SecretQuestionTxtBx.Focus()
'            Return False

'        ElseIf SecretAnswerTxtBx.Text = "" Then
'            MsgBox("Please enter the secret answer")
'            SecretAnswerTxtBx.Focus()
'            Return False
'        ElseIf characterCheck(SecretAnswerTxtBx.Text) = False Then
'            MsgBox("Please enter a valid secret answer, it can only contain alphabetical characters and whitespaces")
'            SecretAnswerTxtBx.Clear()
'            SecretAnswerTxtBx.Focus()
'            Return False
'        ElseIf LengthCheck(SecretAnswerTxtBx.Text, 30, 4) = False Then
'            MsgBox("Please enter a valid answer, 30 characters maximum and 4 characters minimum")
'            SecretAnswerTxtBx.Clear()
'            SecretAnswerTxtBx.Focus()
'            Return False

'        ElseIf FirstNameTxtBx.Text = "" Then
'            MsgBox("Please enter the first name of the employee.")
'            FirstNameTxtBx.Focus()
'            Return False
'        ElseIf FirstNameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then
'            MsgBox("Please enter a valid first name, alphabetical characters only")
'            FirstNameTxtBx.Clear()
'            FirstNameTxtBx.Focus()
'            Return False
'        ElseIf LengthCheck(FirstNameTxtBx.Text, 20, 2) = False Then
'            MsgBox("Please enter a name in the proper format, 20 characters is the maximum, 2 characters is the minimum.")
'            FirstNameTxtBx.Clear()
'            FirstNameTxtBx.Focus()
'            Return False

'        ElseIf SurnameTxtBx.Text = "" Then
'            MsgBox("Please enter the surname of the employee.")
'            SurnameTxtBx.Focus()
'            Return False
'        ElseIf SurnameTxtBx.Text.All(Function(c) Char.IsLetter(c)) = False Then
'            MsgBox("Please enter a valid surname, alphabetic characters only")
'            SurnameTxtBx.Clear()
'            SurnameTxtBx.Focus()
'            Return False
'        ElseIf LengthCheck(SurnameTxtBx.Text, 20, 2) = False Then
'            MsgBox("Please enter a surname in the proper format, 20 characters is the maximum, 2 characters is the minimum")
'            SurnameTxtBx.Clear()
'            SurnameTxtBx.Focus()
'            Return False

'        ElseIf PhoneTxtBx.Text = "" Then
'            MsgBox("please enter a phone number")
'            PhoneTxtBx.Focus()
'            Return False
'        ElseIf phoneCheck(PhoneTxtBx.Text) = False Then
'            MsgBox("The phone number is invalid, please enter the country code starting with a + followed by the actual number. 15 digits maximum")
'            PhoneTxtBx.Clear()
'            PhoneTxtBx.Focus()
'            Return False

'        ElseIf AddressTxtBx.Text = "" Then
'            MsgBox("Please enter the address.")
'            AddressTxtBx.Focus()
'            Return False
'        ElseIf LengthCheck(AddressTxtBx.Text, 50, 5) = False Then
'            MsgBox("Please enter an address in the proper format, 50 characters is the maximum, 5 is the minimum.")
'            AddressTxtBx.Clear()
'            AddressTxtBx.Focus()
'            Return False

'        ElseIf PostcodeTxtBx.Text = "" Then
'            MsgBox("Please enter the postcode")
'            PostcodeTxtBx.Focus()
'            Return False
'        ElseIf postcodeCheck(PostcodeTxtBx.Text) = False Then
'            MsgBox("Please enter a valid postcode following UK postcode format.")
'            PostcodeTxtBx.Clear()
'            PostcodeTxtBx.Focus()
'            Return False

'        ElseIf EmailTxtBx.Text = "" Then
'            MsgBox("Please enter the email of the employee.")
'            EmailTxtBx.Focus()
'            Return False
'        ElseIf emailCheck(EmailTxtBx.Text) = False Then
'            MsgBox("Please enter a valid email, please ensure only 1-40 characters for the email prefix, ensure an @ is used, and a valid domain is used with only 1-61 characters being used with a proper suffix with only 2-6 characters being used.")
'            EmailTxtBx.Clear()
'            EmailTxtBx.Focus()
'            Return False

'        ElseIf AdminStatusTxtBx.Text = "" Then
'            MsgBox("please enter the admin status of the employee")
'            AdminStatusTxtBx.Focus()
'            Return False
'        ElseIf adminCheck(AdminStatusTxtBx.Text) = False Then
'            MsgBox("please enter a valid admin status")
'            AdminStatusTxtBx.Clear()
'            AdminStatusTxtBx.Focus()
'            Return False
'        Else
'            Return True
'        End If
'    End Function
'End Class