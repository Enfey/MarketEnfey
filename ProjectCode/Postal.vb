Imports System.Data.OleDb
Imports System
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class postal
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\freelancedatabase.accdb")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DeliverySearchBtn.Click
        Try
            Dim delivery As String = DeliveryTxtBx.Text
            Dim deliverypattern As String = "^(Next Day|3 days|3 Days|next day|Next day|next Day)$"
            Dim deliveryRegEx As New Regex(deliverypattern)
            If deliveryRegEx.IsMatch(delivery) = False Then
                MsgBox("Please enter a valid delivery time, the options are Next Day and 3 days")
            ElseIf DeliveryTxtBx.Text = "" Then
                MsgBox("Please enter a delivery time")
            Else

                Dim sql1 As String = "SELECT * FROM Postal WHERE DeliveryTime = '" + DeliveryTxtBx.Text + "'"
                Dim DBAdapter As OleDbDataAdapter = New OleDbDataAdapter(sql1, conn)
                Dim results As New DataTable

                DBAdapter.Fill(results)
                PostalResult.DataSource = results
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Postal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim results As New DataTable
        DeliveryTxtBx.Enabled = False
        WeightTxtBx.Enabled = False
        DimensionsTxtBx.Enabled = False
        Try

            Dim sql As String = "SELECT * FROM Postal"
            Dim dbadapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)

            dbadapter.Fill(results)
            PostalResult.DataSource = results

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LengthSearchBtn.Click
        Try
            Dim length As String = DimensionsTxtBx.Text
            Dim lengthpattern As String = "^[0-9]{1,3}(cm)$"
            Dim lengthRegEx As New Regex(lengthpattern)

            If lengthRegEx.IsMatch(length) = False Then
                MsgBox("Please enter a valid length, the format is 1-3 digits followed by cm")
            ElseIf DimensionsTxtBx.Text = "" Then
                MsgBox("Please enter a length")
            Else
                Dim results As New DataTable
                Dim sql As String = "SELECT * FROM Postal WHERE Centimetres = '" + DimensionsTxtBx.Text + "'"
                Dim DBAdapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)
                DBAdapter.Fill(results)
                PostalResult.DataSource = results
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub WeightSearchBtn_Click(sender As Object, e As EventArgs) Handles WeightSearchBtn.Click
        Try
            Dim weight As String = WeightTxtBx.Text
            Dim weightpattern As String = "^[0-9]{1,3}(kg|g)$"
            Dim weightRegEx As New Regex(weightpattern)

            If weightRegEx.IsMatch(weight) = False Then
                MsgBox("Please enter a valid weight, the format is 1-3 digits followed by kg or g")
            ElseIf WeightTxtBx.Text = "" Then
                MsgBox("Please enter a weight")
            Else
                Dim results As New DataTable
                Dim sql As String = "SELECT * FROM Postal WHERE Weight = '" + WeightTxtBx.Text + "'"
                Dim DBAdapter As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)

                DBAdapter.Fill(results)
                PostalResult.DataSource = results
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MenuMain.Show()
    End Sub

    Private Sub DeliveryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DeliveryRadioButton.CheckedChanged
        DeliveryTxtBx.Enabled = True
        WeightTxtBx.Enabled = False
        DimensionsTxtBx.Enabled = False
        WeightTxtBx.Clear()
        DimensionsTxtBx.Clear()
    End Sub

    Private Sub CentimetresRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CentimetresRadioButton.CheckedChanged
        DeliveryTxtBx.Enabled = False
        WeightTxtBx.Enabled = False
        DimensionsTxtBx.Enabled = True
        DeliveryTxtBx.Clear()
        WeightTxtBx.Clear()
    End Sub

    Private Sub WeightRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles WeightRadioButton.CheckedChanged
        DeliveryTxtBx.Enabled = False
        WeightTxtBx.Enabled = True
        DimensionsTxtBx.Enabled = False
        DimensionsTxtBx.Clear()
        DeliveryTxtBx.Clear()
    End Sub
End Class
