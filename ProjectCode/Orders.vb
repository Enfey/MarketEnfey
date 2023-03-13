'Imports System.Data.OleDb
'Imports System.Net.Mail

'Public Class Orders
'    Dim MaxColumns As Integer '
'    Dim maxrows As Integer ' defines the maximum amount of rows,
'    Dim curRow As Integer 'defines the current rows, used within most of the code
'    Dim ds As New DataSet ' same as a table and is just defined as a set of data
'    Dim da As OleDbDataAdapter ' used to send data between access and visual studio
'    Dim sql As String
'    Private Sub navigaterecords()
'        'shows fields of the current row that is selected
'        SalesIDTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(0)
'        CustomerIDTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(1)
'        DateTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(2)
'        QuantityTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(3)
'        TotalTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(4)
'        EmployeeIDTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(5)
'        PostalIDtxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(6)
'        ProductIDTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(7)
'        Dim totalval As Decimal = TotalTxtBx.Text
'        TotalTxtBx.Text = FormatCurrency(totalval)
'        If ds.Tables("Orders").Rows(curRow).Item(8) = True Then
'            ReceiptBtn.Hide()
'            EmailConfirmationPicBox.Image = Image.FromFile("C:\computingg1 (3)1\computingg1\computing coursework\ProjectCode\ProjectCode\Resources\emailsentorder.png")
'        Else
'            ReceiptBtn.Show()
'            EmailConfirmationPicBox.Image = Image.FromFile("C:\computingg1 (3)1\computingg1\computing coursework\ProjectCode\ProjectCode\Resources\emailhasnot.png")
'        End If
'    End Sub

'    Private Sub customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ReceiptBtn.Hide()
'        AddBtn.Hide()
'        DeleteBtn.Hide()
'        UpdateBtn.Hide()
'        ClearBtn.Hide()
'        Try
'            conn.Open()

'            sql = "SELECT * FROM Orders"

'            da = New OleDbDataAdapter(sql, conn)

'            da.Fill(ds, "Orders")

'            conn.Close()

'            maxrows = ds.Tables("Orders").Rows.Count
'            curRow = 0

'            MsgBox("The number of rows is " & maxrows)

'            MaxColumns = ds.Tables("Orders").Columns.Count
'            MsgBox("The number of fields is " & MaxColumns)

'            navigaterecords()
'        Catch ex As Exception
'            If conn.State = ConnectionState.Open Then
'                conn.Dispose()
'            End If
'            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'        If employeeAccessLevel_ = True Then
'            AddBtn.Show()
'            DeleteBtn.Show()
'            UpdateBtn.Show()
'            ClearBtn.Show()
'        End If
'    End Sub

'    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
'        Try
'            'navigates the table and cycles between the rows within the database
'            If curRow > 0 Then
'                curRow = curRow - 1 'minuses from current row therefore displaying the previous row
'                navigaterecords()
'            ElseIf curRow = -1 Then
'                MsgBox("No records yet")
'            ElseIf curRow = 0 Then
'                MsgBox("first record")
'            End If
'        Catch ex As Exception
'            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
'        ' navigates the table and cycles between the rows within the database
'        Try
'            If curRow <> maxrows - 1 Then
'                curRow = curRow + 1 'counts current row, going forward in rows and then displaying it
'                navigaterecords()
'            Else
'                MsgBox("no more rows") ' if the max number of rows is reached, then no more rows is displayed
'            End If
'        Catch ex As Exception
'            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
'        Dim SaleID As String = SalesIDTxtBx.Text
'        Dim CustomerID As String = CustomerIDTxtBx.Text
'        Dim EmployeeID As String = EmployeeIDTxtBx.Text
'        Dim PostalID As String = PostalIDtxtBx.Text
'        Dim DateOfSale As String = DateTxtBx.Text
'        Dim total As String = TotalTxtBx.Text

'        Dim cb As New OleDbCommandBuilder(da)

'        If SalesIDTxtBx.Text = "" Then
'            MsgBox("Please enter the id of the sale")
'            SalesIDTxtBx.Focus()
'        ElseIf SaleIDCheck(SaleID) = False Then
'            MsgBox("Please enter the ID in the correct format, S followed by 4 digits")
'            SalesIDTxtBx.Clear()
'            SalesIDTxtBx.Focus()

'        ElseIf CustomerIDTxtBx.Text = "" Then
'            MsgBox("Please enter the id of the customer")
'            CustomerIDTxtBx.Focus()
'        ElseIf CustomerIDCheck(CustomerID) = False Then
'            MsgBox("Please enter the ID in the correct format, N followed by 4 digits")
'            CustomerIDTxtBx.Clear()
'            CustomerIDTxtBx.Focus()

'        ElseIf DateTxtBx.Text = "" Then
'            MsgBox("Please enter the date of the sale")
'            DateTxtBx.Focus()
'        ElseIf DateCheck(DateOfSale) = False Then
'            MsgBox("Please enter the date in the correct format, dd/mm/yyyy")
'            DateTxtBx.Clear()
'            DateTxtBx.Focus()

'        ElseIf QuantityTxtBx.Text = "" Then
'            MsgBox("Please enter the quantity of items sold")
'            QuantityTxtBx.Focus()
'        ElseIf IsNumeric(QuantityTxtBx.Text) = False Then
'            MsgBox("Please enter a number only.")
'            QuantityTxtBx.Clear()
'            QuantityTxtBx.Focus()
'        ElseIf LengthCheck(QuantityTxtBx.Text, 4, 1) = False Then
'            MsgBox("Please enter a valid quantity, between 1 and 9999")
'            QuantityTxtBx.Clear()
'            QuantityTxtBx.Focus()

'        ElseIf TotalTxtBx.Text = "" Then
'            MsgBox("Please enter a total value of the order")
'            TotalTxtBx.Focus()
'        ElseIf CurrencyCheck(total) = False Then
'            MsgBox("Please enter the total in the correct format, £ followed by 2 digits. Ensure commas and decimal points where appropriate.")
'            TotalTxtBx.Clear()
'            TotalTxtBx.Focus()

'        ElseIf EmployeeIDTxtBx.Text = "" Then
'            MsgBox("Please enter the id of the employee")
'            EmployeeIDTxtBx.Focus()
'        ElseIf EmployeeIDCheck(employeeid) = False Then
'            MsgBox("Please enter the ID in the correct format, E followed by 4 digits")
'            EmployeeIDTxtBx.Clear()
'            EmployeeIDTxtBx.Focus()

'        ElseIf PostalIDtxtBx.Text = "" Then
'            MsgBox("Please enter the id of the postage service used")
'            PostalIDtxtBx.Focus()
'        ElseIf PostalIDcheck(PostalID) = False Then
'            MsgBox("Please enter the ID in the correct format, R followed by 4 digits")
'            PostalIDtxtBx.Clear()
'            PostalIDtxtBx.Focus()
'        Else
'            Try
'                dim totalSubStr as string = total.substring(1, total.length - 1)

'                ds.Tables("Orders").Rows(curRow).Item(0) = SalesIDTxtBx.Text
'                ds.Tables("Orders").Rows(curRow).Item(1) = CustomerIDTxtBx.Text
'                ds.Tables("Orders").Rows(curRow).Item(2) = DateTxtBx.Text
'                ds.Tables("Orders").Rows(curRow).Item(3) = QuantityTxtBx.Text
'                ds.Tables("Orders").Rows(curRow).Item(4) = totalSubStr
'                ds.Tables("Orders").Rows(curRow).Item(5) = EmployeeIDTxtBx.Text
'                ds.Tables("Orders").Rows(curRow).Item(6) = PostalIDtxtBx.Text
'                ds.Tables("Orders").Rows(curRow).Item(7) = ProductIDTxtBx.Text

'                cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
'                cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access

'                da.Update(ds, "Orders")
'                MsgBox("record updated")
'            Catch ex As Exception
'                If da isNot nothing Then
'                   da.dispose()
'                End If
'                MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End If
'    End Sub

'    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
'        If curRow <> -1 Then

'            Dim SaleID As String = SalesIDTxtBx.Text
'            Dim CustomerID As String = CustomerIDTxtBx.Text
'            Dim EmployeeID As String = EmployeeIDTxtBx.Text
'            Dim PostalID As String = PostalIDtxtBx.Text
'            Dim DateOfSale As String = DateTxtBx.Text
'            Dim total As String = TotalTxtBx.Text

'            Dim cb As New OleDbCommandBuilder(da)
'            Dim dsnewrow As DataRow

'            If SalesIDTxtBx.Text = "" Then
'                MsgBox("Please enter the id of the sale")
'                SalesIDTxtBx.Focus()
'            ElseIf SaleIDCheck(SaleID) = False Then
'                MsgBox("Please enter the ID in the correct format, S followed by 4 digits")
'                SalesIDTxtBx.Clear()
'                SalesIDTxtBx.Focus()

'            ElseIf CustomerIDTxtBx.Text = "" Then
'                MsgBox("Please enter the id of the customer")
'                CustomerIDTxtBx.Focus()
'            ElseIf CustomerIDCheck(CustomerID) = False Then
'                MsgBox("Please enter the ID in the correct format, N followed by 4 digits")
'                CustomerIDTxtBx.Clear()
'                CustomerIDTxtBx.Focus()

'            ElseIf DateTxtBx.Text = "" Then
'                MsgBox("Please enter the date of the sale")
'                DateTxtBx.Focus()
'            ElseIf DateCheck(DateOfSale) = False Then
'                MsgBox("Please enter the date in the correct format, dd/mm/yyyy")
'                DateTxtBx.Clear()
'                DateTxtBx.Focus()

'            ElseIf QuantityTxtBx.Text = "" Then
'                MsgBox("Please enter the quantity of items sold")
'                QuantityTxtBx.Focus()
'            ElseIf IsNumeric(QuantityTxtBx.Text) = False Then
'                MsgBox("Please enter a number only.")
'                QuantityTxtBx.Clear()
'                QuantityTxtBx.Focus()
'            ElseIf LengthCheck(QuantityTxtBx.Text, 4, 1) = False Then
'                MsgBox("Please enter a valid quantity, between 1 and 9999")
'                QuantityTxtBx.Clear()
'                QuantityTxtBx.Focus()

'            ElseIf TotalTxtBx.Text = "" Then
'                MsgBox("Please enter a total value of the order")
'                TotalTxtBx.Focus()
'            ElseIf CurrencyCheck(total) = False Then
'                MsgBox("Please enter the total in the correct format. Ensure commas and decimal points where appropriate, and a pound sign at the beginning.")
'                TotalTxtBx.Clear()
'                TotalTxtBx.Focus()

'            ElseIf EmployeeIDTxtBx.Text = "" Then
'                MsgBox("Please enter the id of the employee")
'                EmployeeIDTxtBx.Focus()
'            ElseIf EmployeeIDCheck(employeeid) = False Then
'                MsgBox("Please enter the ID in the correct format, E followed by 4 digits")
'                EmployeeIDTxtBx.Clear()
'                EmployeeIDTxtBx.Focus()

'            ElseIf PostalIDtxtBx.Text = "" Then
'                MsgBox("Please enter the id of the postage service used")
'                PostalIDtxtBx.Focus()
'            ElseIf PostalIDcheck(PostalID) = False Then
'                MsgBox("Please enter the ID in the correct format, R followed by 4 digits")
'                PostalIDtxtBx.Clear()
'                PostalIDtxtBx.Focus()

'            Else

'                    dim totalSubStr as string = total.substring(1, total.length - 1)
'                    dsnewrow = ds.Tables("Orders").NewRow()

'                    dsnewrow.Item("SalesID") = SalesIDTxtBx.Text
'                    dsnewrow.Item("CustomerID") = CustomerIDTxtBx.Text
'                    dsnewrow.Item("Date") = DateTxtBx.Text
'                    dsnewrow.Item("Quantity") = QuantityTxtBx.Text
'                    dsnewrow.Item("Total") = totalSubStr
'                    dsnewrow.Item("EmployeeID") = EmployeeIDTxtBx.Text
'                    dsnewrow.Item("PostalID") = PostalIDtxtBx.Text
'                    dsnewrow.Item("ProductID") = ProductIDTxtBx.Text

'                    ds.Tables("Orders").Rows.Add(dsnewrow)

'                    cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
'                    cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
'                try
'                    da.Update(ds, "Orders")
'                    MsgBox("New Orders record added to the database")
'                Catch ex As Exception
'                    If da isNot nothing Then
'                        da.dispose()
'                    End If
'                    MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                End Try

'                    Dim cmd As New OleDbCommand("UPDATE Products SET Quantity = Quantity - @decrement WHERE ProductID = @id", conn)
'                    cmd.Parameters.AddWithValue("@decrement", QuantityTxtBx.text)
'                    cmd.Parameters.AddWithValue("@id", productIDtxtbx.text)
'                Try
'                    conn.Open()
'                    cmd.ExecuteNonQuery()
'                    conn.Close()
'                Catch ex As Exception
'                    MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                End Try
'            End If
'        End If
'    End Sub

'    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click

'        Dim cb As New OleDbCommandBuilder(da)

'        If MessageBox.Show("Do you really want to delete this record",
'                           "delete", MessageBoxButtons.YesNo,
'                           MessageBoxIcon.Warning) = DialogResult.No Then ' displays a message box with a prompt to delete the records using yes or no buttons, if no is pressed the subroutine is exited, if yes then the row is deleted from the dataset

'            MsgBox("operation cancelled")
'            Exit Sub

'        ElseIf DialogResult.Yes Then

'            ds.Tables("Orders").Rows(curRow).Delete() ' connects customers and looks at the current row being viewed via currentrow and deletes it
'            maxrows = maxrows - 1 ' needs to be done so that next and previous will work

'            curRow = 0
'            navigaterecords()

'            cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
'            cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
'            Try
'                da.Update(ds, "Orders") ' updates the dataset named customers
'            Catch ex As Exception
'                If da isNot nothing Then
'                    da.dispose()
'                End If
'                MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End If
'    End Sub

'    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
'        cleartextboxes(me)
'        'sets a row to be empty
'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
'        Me.Hide()
'        MenuMain.Show()
'    End Sub

'    Private Sub receiptBtn_Click(sender As Object, e As EventArgs) Handles ReceiptBtn.Click
'        Dim cmd As OleDbCommand
'        Dim dr As OleDbDataReader
'        Dim checker As Integer

'        Dim customerEmail As String
'        Dim customerName As String
'        Dim customerAddress As String
'        Dim customerPostcode As String
'        Dim saleId As String
'        Dim saleDate As String
'        Dim saleQuantity As String
'        Dim saleTotal As String
'        Dim productNames As String

'        Try
'            conn.Open() 'opens connection to database
'            cmd = conn.CreateCommand() 'creates the command
'            cmd.CommandType = CommandType.Text 'command string is converted to .text
''           ' cmd.CommandText = "SELECT Products.ProductName, Customers.FirstName, Customers.Address, Customers.EmailAddress, Customers.Postcode, Orders.SalesID, Orders.Date, Orders.Quantity, Orders.Total
''FROM Products INNER JOIN ((Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) INNER JOIN OrdersLine ON Orders.SalesID = OrdersLine.SalesID) ON Products.ProductID = OrdersLine.ProductID WHERE Orders.SalesID = '" & SaleIdTxtBx.Text & "'" 'defines the query to be used in order to retrieve necessary data from tables in access
''            cmd.commandtext = "SELECT Products.ProductName, Customers.FirstName, Customers.Address, Customers.EmailAddress, Customers.Postcode, Orders.SalesID, Orders.Date, Orders.Quantity, Orders.Total
''FROM Products INNER JOIN (Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) ON Products.ProductID = Orders.ProductID WHERE Orders.SalesID = '" & SaleIdTxtBx.Text & "'"
'cmd.commandtext = "SELECT Customers.FirstName, Customers.Address, Customers.EmailAddress, Customers.Postcode, Orders.SalesID, Orders.Date, Orders.Quantity, Orders.Total, Products.ProductName
'FROM Products INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Products.ProductID = Orders.ProductID WHERE Orders.SalesID = '" & SalesIDTxtBx.Text & "'"
'            dr = cmd.ExecuteReader()
'            checker = 0

'            Do While (dr.Read)
'                checker = checker + 1
'                customerEmail = dr("EmailAddress")
'                customerName = dr("FirstName")
'                customerAddress = dr("Address")
'                customerPostcode = dr("Postcode")
'                saleId = dr("SalesID")
'                saleDate = dr("Date")
'                saleQuantity = dr("Quantity")
'                saleTotal = dr("Total")
'                productNames = dr("ProductName")
'            Loop
'            conn.close()
'        Catch ex As Exception
'            If conn.State = ConnectionState.Open Then
'                conn.Close()
'            End If
'            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End try

'        Dim smtpClient As New SmtpClient
'        Dim eMail As New MailMessage()
'        Dim companyEmail As New MailAddress("enfeysmarket@outlook.com")

'        smtpClient.UseDefaultCredentials = False
'        smtpClient.Credentials = New Net.NetworkCredential("enfeysmarket@outlook.com", "Ycc87$Nucy4nai4")
'        smtpClient.Port = 587
'        smtpClient.EnableSsl = True
'        smtpClient.Host = "smtp-mail.outlook.com"

'        eMail.From = companyEmail
'        eMail.To.Add(customeremail)
'        eMail.Subject = "Receipt for order number " & saleID & " on the " & saleDate & ""
'        eMail.IsBodyHtml = True
'        eMail.Body = "<html> <body> <p> Dear " & customername & ", <br> <br> Thank you for your order. <br> <br> Your order number is " & saleID & " and was placed on the " & saleDate & ". <br> <br> The total cost of your order is £" & saleTotal & ". <br> <br> Your order will be delivered to " & customeraddress & " <br> <br> If you have any questions or concerns, please contact us at enfeysmarket@outlook.com
'  <body>
'    <h1>Thank you for your purchase!</h1>
'    <p>Dear " & customername & " </p>
'    <p>Thank you for your recent purchase from Enfey's Market. Your order details are listed below:</p>
'    <table>
'      <tr>
'        <th>Item</th>
'        <th>Quantity</th>
'        <th>Total</th>
'      </tr>
'      <tr>
'        <td> " & productNames & " </td>
'        <td> " & saleQuantity & " </td>
'      </tr>
'      <tr>
'        <td colspan= 2 >Total</td>
'        <td>" & saleTotal & "</td>
'      </tr>
'    </table>
'    <p>Your order will be shipped to the following address:</p>
'    <p> " & customeraddress & " At the following postcode " & customerPostcode & " </p>
'    <p>Thank you for your business. If you have any questions or concerns, please don't hesitate to contact us.</p>
'    <p>Sincerely,</p>
'    <p>Enfey's Market</p>
'  </body>
'</html>"

'        Try
'            smtpClient.Send(eMail)
'            MsgBox("Mail Sent")
'        Catch ex As Exception
'            smtpClient.Dispose()
'            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End try

'        try
'            'conn.open()
'            'Dim cb As New OleDbCommandBuilder(da)

'            'cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
'            'cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
'            'ds.Tables("Orders").Rows(curRow).Item(7) = True
'            'da.Update(ds, "Orders")
'            'conn.Close()
'            'conn.open()
'            'dim upSQL as string = "UPDATE ORDERS SET ReceiptSent = True"
'            'dim cmd2 as new oledbcommand(upSQL, conn)
'            'cmd.executenonquery()
'            'conn.close()
'        Catch ex As Exception
'            If conn.State = ConnectionState.Open Then
'                conn.Close()
'            End If
'            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        end try
'    End Sub

'    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SearchOrdersBtn.Click
'        Me.Hide()
'        OrderSearch.Show()
'    End Sub
'End Class