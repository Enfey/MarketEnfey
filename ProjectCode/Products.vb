Imports System.Text.RegularExpressions

Public Class Products
    Dim MaxColumns As Integer '
    Dim maxrows As Integer ' defines the maximum amount of rows,
    Dim curRow As Integer 'defines the current rows, used within most of the code
    Dim con As New OleDb.OleDbConnection ' connects the database
    Dim ds As New DataSet ' same as a table and is just defined as a set of data
    Dim da As OleDb.OleDbDataAdapter ' used to send data between access and visual studio
    Dim sql As String

    Private Sub navigaterecords()
        'shows fields of the current row that is selected
        ProductIdTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(0)
        ProdNameTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(1)
        ProdGenreTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(2)
        ProdPriceTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(3)
        ProdQuantityTxtBx.Text = ds.Tables("Products").Rows(curRow).Item(4)
        Dim totalval As Decimal = ProdPriceTxtBx.Text
        ProdPriceTxtBx.Text = FormatCurrency(totalval)
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=microsoft.ACE.OLEDB.12.0;Data Source=C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\freelancedatabase.accdb"
        con.Open()

        sql = "SELECT * FROM Products"

        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "Products")

        con.Close()

        maxrows = ds.Tables("Products").Rows.Count
        curRow = 0

        MsgBox("The number of rows is " & maxrows)

        MaxColumns = ds.Tables("Products").Columns.Count
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
        If curRow <> maxrows - 1 Then
            curRow = curRow + 1 'counts current row, going forward in rows and then displaying it
            navigaterecords()
        Else
            MsgBox("no more rows") ' if the max number of rows is reached, then no more rows is displayed
        End If
        UpdateBtn.Enabled = True
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim productid As String = ProductIdTxtBx.Text
        Dim prodidpattern As String = "^[P]{1}[0-9]{4}$"
        Dim idRegEx As New Regex(prodidpattern)

        Dim price As String = ProdPriceTxtBx.Text
        Dim pricepattern As String = "^\£?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$"
        Dim priceRegEx As New Regex(pricepattern)

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsnewrow As DataRow


        If ProductIdTxtBx.Text = "" Then
            MsgBox("Please enter the id of the product")
        ElseIf idRegEx.IsMatch(productid) = False Then
            MsgBox("Please enter a valid product id")

        ElseIf ProdNameTxtBx.Text = "" Then
            MsgBox("Please enter the product name")
        ElseIf Len(ProdNameTxtBx.Text) > 40 Then
            MsgBox("Please enter a shorter product name")

        ElseIf ProdGenreTxtBx.Text = "" Then
            MsgBox("Please enter the product genre")
        ElseIf Len(ProdGenreTxtBx.Text) > 30 Then
            MsgBox("Please enter a shorter product genre")

        ElseIf ProdPriceTxtBx.Text = "" Then
            MsgBox("Please enter a total value of the product")
        ElseIf priceRegEx.IsMatch(price) = False Then
            MsgBox("Please enter a valid price")

        ElseIf ProdQuantityTxtBx.Text = "" Then
            MsgBox("please enter the quantity of the product currently in inventory")
        ElseIf Len(ProdQuantityTxtBx.Text) > 50 Or IsNumeric(ProdQuantityTxtBx.Text) = False Then
            MsgBox("Please enter a valid quantity")
        Else
            ds.Tables("Products").Rows(curRow).Item(0) = ProductIdTxtBx.Text
            ds.Tables("Products").Rows(curRow).Item(1) = ProdNameTxtBx.Text
            ds.Tables("Products").Rows(curRow).Item(2) = ProdGenreTxtBx.Text
            ds.Tables("Products").Rows(curRow).Item(3) = ProdPriceTxtBx.Text
            ds.Tables("Products").Rows(curRow).Item(4) = ProdQuantityTxtBx.Text

            cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
            cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access

            da.Update(ds, "Products")
            MsgBox("record updated")
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If curRow <> -1 Then

            Dim productid As String = ProductIdTxtBx.Text
            Dim prodidpattern As String = "^[P]{1}[0-9]{4}$"
            Dim idRegEx As New Regex(prodidpattern)

            Dim price As String = ProdPriceTxtBx.Text
            Dim pricepattern As String = "^\£?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$"
            Dim priceRegEx As New Regex(pricepattern)

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsnewrow As DataRow

            If ProductIdTxtBx.Text = "" Then
                MsgBox("Please enter the id of the product")
            ElseIf idRegEx.IsMatch(productid) = False Then
                MsgBox("Please enter a valid product id")

            ElseIf ProdNameTxtBx.Text = "" Then
                MsgBox("Please enter the product name")
            ElseIf Len(ProdNameTxtBx.Text) > 40 Then
                MsgBox("Please enter a shorter product name")

            ElseIf ProdGenreTxtBx.Text = "" Then
                MsgBox("Please enter the product genre")
            ElseIf Len(ProdGenreTxtBx.Text) > 30 Then
                MsgBox("Please enter a shorter product genre")

            ElseIf ProdPriceTxtBx.Text = "" Then
                MsgBox("Please enter a total value of the product")
            ElseIf priceRegEx.IsMatch(price) = False Then
                MsgBox("Please enter a valid price")

            ElseIf ProdQuantityTxtBx.Text = "" Then
                MsgBox("please enter the quantity of the product currently in inventory")
            ElseIf Len(ProdQuantityTxtBx.Text) > 50 Or IsNumeric(ProdQuantityTxtBx.Text) = False Then
                MsgBox("Please enter a valid quantity")
            Else
                dsnewrow = ds.Tables("Products").NewRow()

                dsnewrow.Item("ProductID") = ProductIdTxtBx.Text
                dsnewrow.Item("ProductName") = ProdNameTxtBx.Text
                dsnewrow.Item("Genre") = ProdGenreTxtBx.Text
                dsnewrow.Item("Price") = ProdPriceTxtBx.Text
                dsnewrow.Item("Quantity") = ProdQuantityTxtBx.Text

                ds.Tables("Products").Rows.Add(dsnewrow)

                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"

                da.Update(ds, "Products")
                MsgBox("record added")
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        If MessageBox.Show("Do you really want to delete this record",
                           "delete", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.No Then ' displays a message box with a prompt to delete the records using yes or no buttons, if no is pressed the subroutine is exited, if yes then the row is deleted from the dataset

            MsgBox("operation cancelled")
            Exit Sub

        ElseIf DialogResult.Yes Then

            ds.Tables("Products").Rows(curRow).Delete() ' connects customers and looks at the current row being viewed via currentrow and deletes it
            maxrows = maxrows - 1 ' needs to be done so that next and previous will work

            curRow = 0
            navigaterecords()

            cb.QuotePrefix = "[" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
            cb.QuoteSuffix = "]" ' needed in order for the SQL statement to work (update) as it defines when the statement ends and begins to work in access
            da.Update(ds, "Products") ' updates the dataset named customers
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ProductIdTxtBx.Text = ""
        ProdNameTxtBx.Text = ""
        ProdGenreTxtBx.Text = ""
        ProdPriceTxtBx.Text = ""
        ProdQuantityTxtBx.Text = ""

        'sets a row to be empty
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MenuMain.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        productgraph.Show()
        Me.Hide()
    End Sub
End Class