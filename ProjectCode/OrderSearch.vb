'Imports System.Data.OleDb
'Public Class OrderSearch
'    Private Sub SearchCustomerIdBtn_CLick(sender As Object, e As EventArgs) Handles SearchCustomerIDBtn.Click

'        Dim CustomerID As String = CustomerIDTxtBx.Text

'        If CustomerIDTxtBx.Text = "" Then 'validation
'            MsgBox("please enter a customer ID")
'            CustomerIDTxtBx.Focus()
'        ElseIf customerIDCheck(CustomerID) = False Then
'            MsgBox("Please enter a valid customer ID, the format is 1 N followed 4 digits")
'            CustomerIDTxtBx.Clear()
'            CustomerIDTxtBx.Focus()
'        ElseIf customerIDCheck(CustomerID) = True Then
'            Dim sql As String = "SELECT * FROM ORDERS WHERE CustomerID = '" + CustomerIDTxtBx.Text + "'"
'            Dim results As New DataTable
'            Dim dbadapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)
'            dbadapter.Fill(results)

'            If results.Rows.Count = 0 Then
'                MsgBox("User not found")
'            Else
'                PostalResult.DataSource = results
'            End If

'        End If
'    End Sub
'    Private Sub DateSearchBtn_Click(sender As Object, e As EventArgs) Handles DateSearchBtn.Click

'        Dim dateid As String = DateSearchTxtBx.Text


'        If DateSearchTxtBx.Text = "" Then
'            MsgBox("please enter a date")
'        ElseIf DateCheck(dateid) = False Then
'            MsgBox("Please enter a valid date in the format dd/mm/yyyy")

'        ElseIf DateCheck(DateSearchTxtBx.Text) = True Then
'            Dim sql As String = "SELECT * FROM ORDERS WHERE Date = #" + DateSearchTxtBx.Text + "#"
'            Dim results As New DataTable
'            Dim dbadapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)
'            dbadapter.Fill(results)
'            If results.Rows.Count = 0 Then
'                MsgBox("Date not found")
'            Else
'                PostalResult.DataSource = results
'            End If

'        End If
'    End Sub
'    Private Sub SearchAndSortBtn_Click(sender As Object, e As EventArgs) Handles SearchAndSortBtn.Click
'        Dim sql As String

'        If CustomerIDTxtBx.Text = "" Then   'handles validation for input on triple parameter search
'            MsgBox("Please enter a customer ID")
'            CustomerIDTxtBx.Focus()
'        ElseIf DateSearchTxtBx.Text = "" Then
'            MsgBox("Please enter a date")
'            DateSearchTxtBx.Focus()
'        ElseIf customerIDCheck(CustomerIDTxtBx.Text) = False Then
'            MsgBox("Please enter a valid customer ID, the format is 1 N followed 4 digits")
'            CustomerIDTxtBx.Clear()
'            CustomerIDTxtBx.Focus()
'        ElseIf DateCheck(DateSearchTxtBx.Text) = False Then
'            MsgBox("Please enter a valid date in the format dd/mm/yyyy")
'            DateSearchTxtBx.Clear()
'            DateSearchTxtBx.Focus()
'        Else
'            'handles the triple parameter search
'            If OrderComboBox.Text = "Ascending Order" And DateCheck(DateSearchTxtBx.Text) = True And customerIDCheck(CustomerIDTxtBx.Text) = True Then
'                Dim results As New DataTable
'                sql = "SELECT * FROM Orders WHERE CustomerID = '" + CustomerIDTxtBx.Text + "' AND Date = #" + DateSearchTxtBx.Text + "#"

'                Try

'                    Dim DBAdapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)
'                    DBAdapter.Fill(results) 'fills datatable with results of sql query carried out by the dbadapter

'                Catch ex As Exception
'                    MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                End Try

'                Dim resultDataview As New DataView(results)

'                If resultDataview.Count = 0 Then 'if no results are found
'                    MsgBox("There is no result for the parameters you have entered, please try again")
'                Else
'                    resultDataview.Sort = "Date ASC" 'sorts the results by date in ascending order, one of two different sort methods i have chose to use
'                    PostalResult.DataSource = resultDataview
'                End If

'            ElseIf OrderComboBox.Text = "Descending Order" And DateCheck(DateSearchTxtBx.Text) = True And customerIDCheck(CustomerIDTxtBx.Text) = True Then
'                Dim results As New DataTable
'                sql = "SELECT * FROM Orders WHERE CustomerID = '" + CustomerIDTxtBx.Text + "' AND Date = #" + DateSearchTxtBx.Text + "# ORDER BY Date DESC"

'                Try

'                    Dim DBAdapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn) 'connects the dataset with the info from the sql query and uses the connection to the database
'                    DBAdapter.Fill(results) 'fills the datatable

'                Catch ex As Exception
'                    MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                End Try

'                If results.Rows.Count = 0 Then 'done on the datatable as dataview is not needed here, sort is done via the SQL instead
'                    MsgBox("There is no result for the parameters you have entered, please try again")
'                Else
'                    PostalResult.DataSource = results
'                End If
'            Else
'                MessageBox.Show("Error, Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End If
'        End If
'    End Sub

'    Private Sub DateOrderBtn_Click(sender As Object, e As EventArgs) Handles DateOrderBtn.Click
'        If OrderComboBox.Text = "Ascending Order" Then
'            PostalResult.Sort(PostalResult.Columns(2), ComponentModel.ListSortDirection.Ascending)
'        ElseIf OrderComboBox.Text = "Descending Order" Then
'            PostalResult.Sort(PostalResult.Columns(2), ComponentModel.ListSortDirection.Descending)
'        End If
'    End Sub

'    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BackBtn.Click
'        showall()
'        Me.Hide()
'        Orders.Show()
'    End Sub

'    Private Sub OrderSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        CustomerIDTxtBx.Enabled = False
'        DateSearchTxtBx.Enabled = False
'        OrderComboBox.Enabled = True
'        DisableComplexSearchBtn.Hide()
'        SearchAndSortBtn.Hide()
'        showall()
'    End Sub

'    Private Sub CustomerRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CustomerRadioButton.CheckedChanged
'        CustomerIDTxtBx.Enabled = True
'        DateSearchTxtBx.Enabled = False
'        DateSearchTxtBx.Clear()
'        DateSearchBtn.Hide()
'        SearchCustomerIDBtn.Enabled = True
'        SearchCustomerIDBtn.Show()
'    End Sub

'    Private Sub DateSearchRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DateSearchRadioButton.CheckedChanged
'        CustomerIDTxtBx.Enabled = False
'        DateSearchTxtBx.Enabled = True
'        CustomerIDTxtBx.Clear()
'        DateSearchBtn.Enabled = True
'        SearchCustomerIDBtn.Hide()
'        DateSearchBtn.Show()
'    End Sub
'    Private Sub showall()
'        Dim results As New DataTable
'        Dim sql As String = "SELECT * FROM Orders"
'        Dim dbadapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)

'        dbadapter.Fill(results)
'        PostalResult.DataSource = results
'    End Sub
'    Private Sub TripleSearchBtn_Click(sender As Object, e As EventArgs)
'        CustomerIDTxtBx.Enabled = True
'        DateSearchTxtBx.Enabled = True
'        OrderComboBox.Enabled = True
'        DateSearchTxtBx.Clear()
'        CustomerIDTxtBx.Clear()
'        DateSearchBtn.Hide()
'        SearchCustomerIDBtn.Hide()
'        DateOrderBtn.Hide()

'        SearchAndSortBtn.Show()
'    End Sub
'    Private Sub EnableComplexSearchBtn_Click(sender As Object, e As EventArgs) Handles enablecomplexsearchbtn.Click
'        CustomerIDTxtBx.Enabled = True
'        DateSearchTxtBx.Enabled = True
'        OrderComboBox.Enabled = True
'        DateSearchTxtBx.Clear()
'        CustomerIDTxtBx.Clear()
'        DateSearchBtn.Hide()
'        SearchCustomerIDBtn.Hide()
'        DateOrderBtn.Hide()
'        CustomerRadioButton.Hide()
'        DateSearchRadioButton.Hide()
'        SearchAndSortBtn.Show()
'        enablecomplexsearchbtn.Hide()
'        DisableComplexSearchBtn.Show()
'    End Sub

'    Private Sub DisableComplexSearchBtn_Click(sender As Object, e As EventArgs) Handles DisableComplexSearchBtn.Click
'        CustomerIDTxtBx.Enabled = False
'        DateSearchTxtBx.Enabled = False
'        DateSearchTxtBx.Clear()
'        CustomerIDTxtBx.Clear()
'        DateSearchBtn.Show()
'        SearchCustomerIDBtn.Show()
'        DateOrderBtn.Show()
'        SearchAndSortBtn.Hide()
'        CustomerRadioButton.Show()
'        DateSearchRadioButton.Show()
'        showall()
'        DisableComplexSearchBtn.Hide()
'        enablecomplexsearchbtn.Show()
'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SearchAndSortBtn.Click
'        showall()
'    End Sub
'End Class