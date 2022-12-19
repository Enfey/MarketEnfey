Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class OrderSearch
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\freelancedatabase.accdb") ' connects to database
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CustIDSearchBtn.Click

        Dim CustomerID As String = CustIDTxtBx.Text
        Dim CustomerPattern As String = "^[N]{1}[0-9]{4}$"
        Dim customeridRegEx As New Regex(CustomerPattern)

        If customeridRegEx.IsMatch(CustomerID) = False Then
            MsgBox("Please enter a valid customer ID")
        ElseIf CustIDTxtBx.Text = "" Then 'validation
            MsgBox("please enter a customer Id")
        Else
            Dim sql As String = "SELECT * FROM ORDERS WHERE CustomerID = '" + CustIDTxtBx.Text + "'"
            Dim results As New DataTable
            Dim dbadapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)

            dbadapter.Fill(results)
            PostalResult.DataSource = results
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DateSearchBtn.Click
        '''''''''''''''''''''''''''WOULD PARSE AS DATE FORMAT AND NOT USE REGEX BUT KEEPS GIVING ERRORS
        Dim dateid As String = DateSearchTxtBx.Text
        Dim datepattern As String = "^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$"
        Dim DateIDRegEx As New Regex(datepattern)

        If DateIDRegEx.IsMatch(dateid) = False Then
            MsgBox("Please enter a valid date in the format dd/mm/yyyy")
        ElseIf DateSearchTxtBx.Text = "" Then
            MsgBox("please enter a date")
        Else
            Dim sql As String = "SELECT * FROM ORDERS WHERE OrderDate = '" + DateSearchTxtBx.Text + "'"
            Dim results As New DataTable
            Dim dbadapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)

            dbadapter.Fill(results)
            PostalResult.DataSource = results
        End If
    End Sub

    Private Sub WeightSearchBtn_Click(sender As Object, e As EventArgs) Handles DateOrderBtn.Click
        Dim results As New DataTable
        Dim sql As String
        If OrderComboBox.Text = "Ascending Order" Then
            sql = "SELECT * FROM ORDERS ORDER BY Date ASC" 'sql query
            Dim DBAdapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn) 'connects the dataset with the info from the sql query and uses the connection to the database
            DBAdapter.Fill(results) 'fills the datatable
            PostalResult.DataSource = results
        ElseIf OrderComboBox.Text = "Descending Order" Then
            sql = "SELECT * FROM ORDERS ORDER BY Date DESC" 'sql query
            Dim DBAdapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn) 'connects the dataset with the info from the sql query and uses the connection to the database
            DBAdapter.Fill(results) 'fills the datatable
            PostalResult.DataSource = results
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Orders.Show()
    End Sub

    Private Sub OrderSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateOrderBtn.Hide()
        CustIDSearchBtn.Hide()
        DateSearchBtn.Hide()
        Dim results As New DataTable
        Dim sql As String = "SELECT * FROM Orders"
        Dim dbadapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)

        dbadapter.Fill(results)
        PostalResult.DataSource = results
    End Sub

    Private Sub CustomerRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CustomerRadioButton.CheckedChanged
        CustIDTxtBx.Enabled = True
        DateSearchTxtBx.Enabled = False
        OrderComboBox.Enabled = False
        OrderComboBox.Text = ""
        DateSearchTxtBx.Clear()
        DateSearchBtn.Hide()
        DateOrderBtn.Hide()
        CustIDSearchBtn.Enabled = True
        CustIDSearchBtn.Show()
    End Sub

    Private Sub DateSearchRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DateSearchRadioButton.CheckedChanged
        CustIDTxtBx.Enabled = False
        DateSearchTxtBx.Enabled = True
        OrderComboBox.Enabled = False
        OrderComboBox.Text = ""
        CustIDTxtBx.Clear()
        DateSearchBtn.Enabled = True
        DateOrderBtn.Hide()
        CustIDSearchBtn.Hide()
        DateSearchBtn.Show()
    End Sub

    Private Sub OrderByDateRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles OrderByDateRadioButton.CheckedChanged
        CustIDTxtBx.Enabled = False
        DateSearchTxtBx.Enabled = True
        OrderComboBox.Enabled = True
        DateSearchTxtBx.Clear()
        CustIDTxtBx.Clear()
        DateSearchBtn.Hide()
        DateOrderBtn.Enabled = True
        CustIDSearchBtn.Hide()
        DateOrderBtn.Show()
    End Sub
End Class