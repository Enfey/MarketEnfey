Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class Orders
    Dim MaxColumns As Integer '
    Dim maxrows As Integer ' defines the maximum amount of rows,
    Dim curRow As Integer 'defines the current rows, used within most of the code
    Dim con As New OleDbConnection ' connects the database
    Dim ds As New DataSet ' same as a table and is just defined as a set of data
    Dim da As OleDbDataAdapter ' used to send data between access and visual studio
    Dim sql As String
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\freelancedatabase.accdb")

    Private Sub navigaterecords()
        'shows fields of the current row that is selected
        SaleIdTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(0)
        CustIdTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(1)
        DateTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(2)
        QuantityTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(3)
        TotalTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(4)
        EmployeeIDTxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(5)
        PostalIDtxtBx.Text = ds.Tables("Orders").Rows(curRow).Item(6)
        Dim totalval As Decimal = TotalTxtBx.Text
        TotalTxtBx.Text = FormatCurrency(totalval)
        If ds.Tables("Orders").Rows(curRow).Item(7) = True Then
            ReceiptBtn.Hide()
            EmailConfirmationPicBox.Image = Image.FromFile("C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\ProjectCode\Resources\emailsentorder.png")
        Else
            ReceiptBtn.Show()
            EmailConfirmationPicBox.Image = Image.FromFile("C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\ProjectCode\Resources\emailhasnot.png")
        End If
    End Sub

    Private Sub customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReceiptBtn.Hide()
        con.ConnectionString = "Provider=microsoft.ACE.OLEDB.12.0;Data Source=C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\freelancedatabase.accdb"
        con.Open()

        sql = "SELECT * FROM Orders"

        da = New OleDbDataAdapter(sql, con)

        da.Fill(ds, "Orders")

        con.Close()

        maxrows = ds.Tables("Orders").Rows.Count
        curRow = 0

        MsgBox("The number of rows is " & maxrows)

        MaxColumns = ds.Tables("Orders").Columns.Count
        MsgBox("The number of fields is " & MaxColumns)

        navigaterecords()

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

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        'navigates the table and cycles between the rows within the database
        If curRow > 0 Then
            curRow = curRow - 1 'minuses from current row therefore displaying the previous row
            navigaterecords()
        ElseIf curRow = -1 Then
            MsgBox("No records yet")
        ElseIf curRow = 0 Then
            MsgBox("first record")
        End If
        UpdateBtn.Enabled = True
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        ' navigates the table and cycles between the rows within the database
        If curRow <> maxrows - 1 Then
            curRow = curRow + 1 'counts current row, going forward in rows and then displaying it
            navigaterecords()
        Else
            MsgBox("no more rows") ' if the max number of rows is reached, then no more rows is displayed
        End If
        UpdateBtn.Enabled = True
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        
        Dim SaleID As String = SaleIdTxtBx.Text
        Dim CustomerID As String = CustIdTxtBx.Text
        Dim EmployeeID As String = EmployeeIDTxtBx.Text
        Dim PostalID As String = EmployeeIDTxtBx.Text
        Dim DateOfSale As String = DateTxtBx.Text
        Dim total As String = TotalTxtBx.Text
        

        Dim cb As New OleDbCommandBuilder(da)

        If SaleIdTxtBx.Text = "" Then
            MsgBox("Please enter the id of the sale")
            SaleIdTxtBx.Focus()
        ElseIf SaleIDCheck(SaleID) = False Then
            MsgBox("Please enter the ID in the correct format, S followed by 4 digits")
            SaleIdTxtBx.Clear()
            SaleIdTxtBx.Focus()

        ElseIf CustIdTxtBx.Text = "" Then
            MsgBox("Please enter the id of the customer")
            CustIdTxtBx.Focus()
        ElseIf CustomerIDCheck(CustomerID) = False Then
            MsgBox("Please enter the ID in the correct format, N followed by 4 digits")
            CustIdTxtBx.Clear()
            CustIdTxtBx.Focus()

        ElseIf DateTxtBx.Text = "" Then
            MsgBox("Please enter the date of the sale")
            DateTxtBx.Focus()
        ElseIf DateCheck(DateOfSale) = False Then
            MsgBox("Please enter the date in the correct format, dd/mm/yyyy")
            DateTxtBx.Clear()
            DateTxtBx.Focus()

        ElseIf QuantityTxtBx.Text = "" Then
            MsgBox("Please enter the quantity of items sold")
            QuantityTxtBx.Focus()
        ElseIf IsNumeric(QuantityTxtBx.Text) = False Then
            MsgBox("Please enter a number only.")
            QuantityTxtBx.Clear()
            QuantityTxtBx.Focus()
        ElseIf LengthCheck(QuantityTxtBx.Text, 4, 1) = False Then
            MsgBox("Please enter a valid quantity, between 1 and 9999")
            QuantityTxtBx.Clear()
            QuantityTxtBx.Focus()

        ElseIf TotalTxtBx.Text = "" Then
            MsgBox("Please enter a total value of the order")
            TotalTxtBx.Focus()
        ElseIf CurrencyCheck(total) = False Then
            MsgBox("Please enter the total in the correct format, £ followed by 2 digits. Ensure commas and decimal points where appropriate.")
            TotalTxtBx.Clear()
            TotalTxtBx.Focus()

        ElseIf EmployeeIDTxtBx.Text = "" Then
            MsgBox("Please enter the id of the employee")
            EmployeeIDTxtBx.Focus()
        ElseIf EmployeeIDCheck(employeeid) = False Then
            MsgBox("Please enter the ID in the correct format, E followed by 4 digits")
            EmployeeIDTxtBx.Clear()
            EmployeeIDTxtBx.Focus()

        ElseIf PostalIDtxtBx.Text = "" Then
            MsgBox("Please enter the id of the postage service used")
            PostalIDtxtBx.Focus()
        ElseIf PostalIDcheck(PostalID) = False Then
            MsgBox("Please enter the ID in the correct format, R followed by 4 digits")
            PostalIDtxtBx.Clear()
            PostalIDtxtBx.Focus()
        Else
            Try
                conn.Open()
                ds.Tables("Orders").Rows(curRow).Item(0) = SaleIdTxtBx.Text
                ds.Tables("Orders").Rows(curRow).Item(1) = CustIdTxtBx.Text
                ds.Tables("Orders").Rows(curRow).Item(2) = DateTxtBx.Text
                ds.Tables("Orders").Rows(curRow).Item(3) = QuantityTxtBx.Text
                ds.Tables("Orders").Rows(curRow).Item(4) = TotalTxtBx.Text
                ds.Tables("Orders").Rows(curRow).Item(5) = EmployeeIDTxtBx.Text
                ds.Tables("Orders").Rows(curRow).Item(6) = PostalIDtxtBx.Text

                cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access

                da.Update(ds, "Orders")
                MsgBox("record updated")
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If curRow <> -1 Then

            Dim SaleID As String = SaleIdTxtBx.Text
            Dim CustomerID As String = CustIdTxtBx.Text
            Dim EmployeeID As String = EmployeeIDTxtBx.Text
            Dim PostalID As String = EmployeeIDTxtBx.Text
            Dim DateOfSale As String = DateTxtBx.Text
            Dim total As String = TotalTxtBx.Text

            Dim cb As New OleDbCommandBuilder(da)
            Dim dsnewrow As DataRow

            If SaleIdTxtBx.Text = "" Then
            MsgBox("Please enter the id of the sale")
            SaleIdTxtBx.Focus()
        ElseIf SaleIDCheck(SaleID) = False Then
            MsgBox("Please enter the ID in the correct format, S followed by 4 digits")
            SaleIdTxtBx.Clear()
            SaleIdTxtBx.Focus()

        ElseIf CustIdTxtBx.Text = "" Then
            MsgBox("Please enter the id of the customer")
            CustIdTxtBx.Focus()
        ElseIf CustomerIDCheck(CustomerID) = False Then
            MsgBox("Please enter the ID in the correct format, N followed by 4 digits")
            CustIdTxtBx.Clear()
            CustIdTxtBx.Focus()

        ElseIf DateTxtBx.Text = "" Then
            MsgBox("Please enter the date of the sale")
            DateTxtBx.Focus()
        ElseIf DateCheck(DateOfSale) = False Then
            MsgBox("Please enter the date in the correct format, dd/mm/yyyy")
            DateTxtBx.Clear()
            DateTxtBx.Focus()

        ElseIf QuantityTxtBx.Text = "" Then
            MsgBox("Please enter the quantity of items sold")
            QuantityTxtBx.Focus()
        ElseIf IsNumeric(QuantityTxtBx.Text) = False Then
            MsgBox("Please enter a number only.")
            QuantityTxtBx.Clear()
            QuantityTxtBx.Focus()
        ElseIf LengthCheck(QuantityTxtBx.Text, 4, 1) = False Then
            MsgBox("Please enter a valid quantity, between 1 and 9999")
            QuantityTxtBx.Clear()
            QuantityTxtBx.Focus()

        ElseIf TotalTxtBx.Text = "" Then
            MsgBox("Please enter a total value of the order")
            TotalTxtBx.Focus()
        ElseIf CurrencyCheck(total) = False Then
            MsgBox("Please enter the total in the correct format, £ followed by 2 digits. Ensure commas and decimal points where appropriate.")
            TotalTxtBx.Clear()
            TotalTxtBx.Focus()

        ElseIf EmployeeIDTxtBx.Text = "" Then
            MsgBox("Please enter the id of the employee")
            EmployeeIDTxtBx.Focus()
        ElseIf EmployeeIDCheck(employeeid) = False Then
            MsgBox("Please enter the ID in the correct format, E followed by 4 digits")
            EmployeeIDTxtBx.Clear()
            EmployeeIDTxtBx.Focus()

        ElseIf PostalIDtxtBx.Text = "" Then
            MsgBox("Please enter the id of the postage service used")
            PostalIDtxtBx.Focus()
        ElseIf PostalIDcheck(PostalID) = False Then
            MsgBox("Please enter the ID in the correct format, R followed by 4 digits")
            PostalIDtxtBx.Clear()
            PostalIDtxtBx.Focus()

            Else
                Try
                    conn.Open()

                    dsnewrow = ds.Tables("Orders").NewRow()

                    dsnewrow.Item("SalesID") = SaleIdTxtBx.Text
                    dsnewrow.Item("CustomerID") = CustIdTxtBx.Text
                    dsnewrow.Item("Date") = DateTxtBx.Text
                    dsnewrow.Item("Quantity") = QuantityTxtBx.Text
                    dsnewrow.Item("Total") = TotalTxtBx.Text
                    dsnewrow.Item("EmployeeID") = EmployeeIDTxtBx.Text
                    dsnewrow.Item("PostalID") = PostalIDtxtBx.Text

                    ds.Tables("Orders").Rows.Add(dsnewrow)

                    cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
                    cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access

                    da.Update(ds, "Orders")
                    MsgBox("New Orders record added to the database")
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Dim cb As New OleDbCommandBuilder(da)

        If MessageBox.Show("Do you really want to delete this record",
                           "delete", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.No Then ' displays a message box with a prompt to delete the records using yes or no buttons, if no is pressed the subroutine is exited, if yes then the row is deleted from the dataset

            MsgBox("operation cancelled")
            Exit Sub

        ElseIf DialogResult.Yes Then

            ds.Tables("Orders").Rows(curRow).Delete() ' connects customers and looks at the current row being viewed via currentrow and deletes it
            maxrows = maxrows - 1 ' needs to be done so that next and previous will work

            curRow = 0
            navigaterecords()

            cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
            cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
            da.Update(ds, "Orders") ' updates the dataset named customers
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        SaleIdTxtBx.Text = ""
        CustIdTxtBx.Text = ""
        DateTxtBx.Text = ""
        QuantityTxtBx.Text = ""
        TotalTxtBx.Text = ""
        EmployeeIDTxtBx.Text = ""
        PostalIDtxtBx.Text = ""
        'sets a row to be empty
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MenuMain.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ReceiptBtn.Click
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim checker As Integer
        Dim customeremail As String
        Dim customername As String

        conn.Open() 'opens connection to database
        cmd = conn.CreateCommand() 'creates the command
        cmd.CommandType = CommandType.Text 'command string is converted to .text
        cmd.CommandText = "SELECT * FROM Customers WHERE CustomerID = '" + CustIdTxtBx.Text + "'" 'defines the query to be used in order to retrieve necessary data from tables in access
        dr = cmd.ExecuteReader()
        checker = 0

        Do While (dr.Read)
            checker = checker + 1
            customeremail = dr("EmailAddress")
            customername = dr("FirstName")
        Loop
        Dim sql As String
        Dim da As OleDbDataAdapter

        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Dim companyemail As New MailAddress("enfeysmarket@outlook.com")

        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("enfeysmarket@outlook.com", "Ycc87$Nucy4nai4")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp-mail.outlook.com"

        e_mail.From = companyemail
        e_mail.To.Add(customeremail)
        e_mail.Subject = "Receipt for order number " & SaleIdTxtBx.Text & " on the " & DateTxtBx.Text & ""
        e_mail.IsBodyHtml = True
        e_mail.Body = "<html> <body> <p> Dear " & customername & ", <br> <br> Thank you for your order. <br> <br> Your order number is " & SaleIdTxtBx.Text & " and was placed on the " & DateTxtBx.Text & ". <br> <br> The total cost of your order is £" & TotalTxtBx.Text & ". <br> <br> Your order will be delivered by " & PostalIDtxtBx.Text & " and will be delivered to the address you provided when you placed your order. <br> <br> If you have any questions or concerns, please contact us at
  <body>
    <h1>Thank you for your purchase!</h1>
    <p>Dear " & customername & " </p>
    <p>Thank you for your recent purchase from Enfey's Market. Your order details are listed below:</p>
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
        MsgBox("Mail Sent")

        Dim cb As New OleDbCommandBuilder(da)
        cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
        cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
        ds.Tables("Orders").Rows(curRow).Item(7) = True
        da.Update(ds, "Orders")

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        OrderSearch.Show()
    End Sub
End Class