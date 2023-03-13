Imports System.Data.OleDb
Public Class Products
    Dim MaxColumns As Integer '
    Dim maxrows As Integer ' defines the maximum amount of rows,
    Dim curRow As Integer 'defines the current rows, used within most of the code
    Dim ds As New DataSet ' same as a table and is just defined as a set of data
    Dim da As OleDb.OleDbDataAdapter ' used to send data between access and visual studio
    Dim sql As String
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb") 'defines the connection to the database
    Private totalval As Decimal = PriceTxtBx.Text

    Private Sub navigaterecords()
        'shows fields of the current row that is selected
        ProductIdTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(0)
        ProductNameTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(1)
        GenreTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(2)
        PriceTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(3)
        QuantityTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(4)
        PriceTxtBx.Text = FormatCurrency(totalval)
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddBtn.Hide()
        DeleteBtn.Hide()
        UpdateBtn.Hide()
        ClearBtn.Hide()
        Try
            conn.Open()

            sql = "SELECT * FROM Products"
            da = New OleDbDataAdapter(sql, conn)
            da.Fill(ds, "Products")

            conn.Close()

            navigaterecords()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        maxrows = ds.Tables("Products").Rows.Count
        curRow = 0

        MessageBox.Show("The number of rows is " & maxrows, "Rows", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MaxColumns = ds.Tables("Products").Columns.Count
        MessageBox.Show("The number of fields is " & MaxColumns, "Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If employeeAccessLevel_ = True Then
            AddBtn.Show()
            DeleteBtn.Show()
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
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim productId As String = ProductIdTxtBx.Text
        Dim productName As String = ProductNameTxtBx.Text
        Dim productGenre As String = GenreTxtBx.Text
        Dim productPrice As String = PriceTxtBx.Text
        Dim productQuantity As String = QuantityTxtBx.Text

        Dim cb As New OleDbCommandBuilder(da)

        If ProductIdTxtBx.Text = "" Then
            MsgBox("Please enter the id of the product")
            ProductIdTxtBx.Focus()
        ElseIf ProductIDCheck(productId) = False Then
            MsgBox("Please enter a valid product id, following the proper format")
            ProductIdTxtBx.Clear()
            ProductIdTxtBx.Focus()

        ElseIf ProductNameTxtBx.Text = "" Then
            MsgBox("Please enter the product name")
            ProductNameTxtBx.Focus()
        ElseIf LengthCheck(productName, 40, 4) = False Then
            MsgBox("Please enter a valid product name, between 4 and 40 characters")
            ProductNameTxtBx.Clear()
            ProductNameTxtBx.Focus()
        ElseIf characterCheck(productName) = False Then
            MsgBox("Please enter a valid product name, only alphabetical characters and whitespaces are permitted")
            ProductNameTxtBx.Clear()
            ProductNameTxtBx.Focus()

        ElseIf GenreTxtBx.Text = "" Then
            MsgBox("Please enter the product genre")
            GenreTxtBx.Focus()
        ElseIf LengthCheck(productGenre, 40, 2) = False Then
            MsgBox("Please enter a valid product genre, between 2 and 30 characters")
            GenreTxtBx.Clear()
            GenreTxtBx.Focus()
        ElseIf characterCheck(productGenre) = False Then
            MsgBox("Please enter a valid product genre, only alphabetical characters and whitespaces are permitted")
            GenreTxtBx.Clear()
            GenreTxtBx.Focus()

        ElseIf PriceTxtBx.Text = "" Then
            MsgBox("Please enter a total value of the product")
            PriceTxtBx.Focus()
        ElseIf currencyCheck(productPrice) = False Then
            MsgBox("Please enter the total in the correct format, £ followed by 2 digits. Ensure commas and decimal points where appropriate")
            PriceTxtBx.Clear()
            PriceTxtBx.Focus()

        ElseIf QuantityTxtBx.Text = "" Then
            MsgBox("please enter the quantity of the product currently in inventory")
            QuantityTxtBx.Focus()
        ElseIf IsNumeric(productQuantity) = False Then
            MsgBox("Please enter a valid quantity, only numbers are permitted")
            QuantityTxtBx.Clear()
            QuantityTxtBx.Focus()
        ElseIf LengthCheck(productQuantity, 5, 0) = False Then
            MsgBox("Please enter a valid quantity, between 0 and 5 digits")
            QuantityTxtBx.Clear()
            QuantityTxtBx.Focus()
        Else
            Dim priceSubStr As String = productPrice.Substring(1, productPrice.Length - 1)
            ds.Tables("Products").Rows(curRow).Item(0) = ProductIdTxtBx.Text
            ds.Tables("Products").Rows(curRow).Item(1) = ProductNameTxtBx.Text
            ds.Tables("Products").Rows(curRow).Item(2) = GenreTxtBx.Text
            ds.Tables("Products").Rows(curRow).Item(3) = priceSubStr
            ds.Tables("Products").Rows(curRow).Item(4) = QuantityTxtBx.Text

            cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
            cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
            Try
                da.Update(ds, "Products")
                MsgBox("record updated")
            Catch ex As Exception
                da.Dispose()
                MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    '    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
    '        If curRow <> -1 Then

    '            Dim productId As String = ProductIdTxtBx.Text
    '            Dim productName As String = ProductNameTxtBx.Text
    '            Dim productGenre As String = GenreTxtBx.Text
    '            Dim productPrice As String = PriceTxtBx.Text
    '            Dim productQuantity As String = QuantityTxtBx.Text

    '            Dim cb As New OleDbCommandBuilder(da)
    '            Dim dsnewrow As DataRow

    '            If ProductIdTxtBx.Text = "" Then
    '                MsgBox("Please enter the id of the product")
    '            ElseIf ProductIDCheck(productId) = False Then
    '                MsgBox("Please enter a valid product id, following the proper format")

    '            ElseIf ProductNameTxtBx.Text = "" Then
    '                MsgBox("Please enter the product name")
    '            ElseIf LengthCheck(productName, 40, 4) = False Then
    '                MsgBox("Please enter a valid product name, between 4 and 40 characters")
    '            ElseIf characterCheck(productName) = False Then
    '                MsgBox("Please enter a valid product name, only alphabetical characters and whitespaces are permitted")

    '            ElseIf GenreTxtBx.Text = "" Then
    '                MsgBox("Please enter the product genre")
    '            ElseIf LengthCheck(productGenre, 40, 2) = false Then
    '                MsgBox("Please enter a valid product genre, between 2 and 30 characters")
    '            ElseIf characterCheck(productGenre) = False Then
    '                MsgBox("Please enter a valid product genre, only alphabetical characters and whitespaces are permitted")

    '            ElseIf PriceTxtBx.Text = "" Then
    '                MsgBox("Please enter a total value of the product")
    '            ElseIf currencyCheck(productPrice) = False Then
    '                MsgBox("Please enter the total in the correct format, £ followed by 2 digits. Ensure commas and decimal points where appropriate")

    '            ElseIf QuantityTxtBx.Text = "" Then
    '                MsgBox("please enter the quantity of the product currently in inventory")
    '            ElseIf IsNumeric(productQuantity) = False Then
    '                MsgBox("Please enter a valid quantity, only numbers are permitted")
    '            ElseIf LengthCheck(productQuantity, 5, 0) = false Then
    '                MsgBox("Please enter a valid quantity, between 0 and 5 digits")
    '            Else
    '                dsnewrow = ds.Tables("Products").NewRow()

    '                dsnewrow.Item("ProductID") = ProductIdTxtBx.Text
    '                dsnewrow.Item("ProductName") = ProductNameTxtBx.Text
    '                dsnewrow.Item("Genre") = GenreTxtBx.Text
    '                dsnewrow.Item("Price") = PriceTxtBx.Text
    '                dsnewrow.Item("Quantity") = QuantityTxtBx.Text

    '                ds.Tables("Products").Rows.Add(dsnewrow)

    '                cb.QuotePrefix = "["
    '                cb.QuoteSuffix = "]"
    '                try
    '                da.Update(ds, "Products")
    '                    MsgBox("record added")
    '                Catch ex As Exception
    '                    da.Dispose()
    '                    MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                end try
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

    '            ds.Tables("Products").Rows(curRow).Delete() ' connects customers and looks at the current row being viewed via currentrow and deletes it
    '            maxrows = maxrows - 1 ' needs to be done so that next and previous will work

    '            curRow = 0
    '            navigaterecords()

    '            cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
    '            cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
    '           try 
    '               da.Update(ds, "Products") ' updates the dataset named customers
    '           catch ex as exception 
    '               da.dispose()
    '               MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '           end try
    '        End If
    '    End Sub

    '    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
    '       cleartextboxes(me)
    '    End Sub

    '    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
    '        Me.Hide()
    '        MenuMain.Show()
    '    End Sub

    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ShowGraphBtn.Click
    '        productgraph.Show()
    '        Me.Hide()
    '    End Sub
End Class