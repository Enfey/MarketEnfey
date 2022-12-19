Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class SimpleCustomerSearch
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\freelancedatabase.accdb")
    Private Sub SimpleCustomerSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim dbadapter As New OleDbDataAdapter("SELECT * FROM Customers", conn)
            dbadapter.Fill(dt)

            CustomerResult.DataSource = dt.DefaultView

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub WeightSearchBtn_Click(sender As Object, e As EventArgs) Handles CustomerSearchBtn.Click
        Dim customerid As String = CustomerIDTxtBx.Text
        Dim idpattern As String = "^[N]{1}[0-9]{4}$"
        Dim idRegEx As New Regex(idpattern)
        If idRegEx.IsMatch(customerid) = False Then
            MessageBox.Show("Please enter a valid customer ID")
        Else
            Try
                Dim temp As Integer
                temp = 0

                For i As Integer = 0 To CustomerResult.Rows.Count - 1
                    For j As Integer = 0 To CustomerResult.Columns.Count - 1
                        If CustomerResult.Rows(i).Cells(j).Value = CustomerIDTxtBx.Text Then
                            CustomerResult.Rows(i).Selected = True
                            CustomerResult.CurrentCell = CustomerResult.Rows(i).Cells(j)
                            temp = 1
                            MsgBox("Customer found")
                            Exit For
                        End If
                    Next
                Next

                If temp = 0 Then
                    MsgBox("customer not found")
                Else
                    GC.Collect()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class