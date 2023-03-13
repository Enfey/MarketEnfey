Imports System.Data.OleDb

Public Class postal
    Private Sub Postal_Load(sender As Object, e As EventArgs) Handles Me.shown
        dataGridFill("SELECT * FROM Postal", new datatable, PostalDgv)
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        If Me IsNot Nothing Then
            clearAllControls(Me)
            Me.close()
            'dataGridFill("SELECT * FROM Postal", new datatable, postalresult) 'needed otherwise the datagrid is empty when the user returns due to clearallcontrols
            MenuMain.Show()
        Else
            MsgBox("An error has occurred, please try exiting and restarting the program.")
        End If
    End Sub
    Private Sub DeliverySearchBtn_Click(sender As Object, e As EventArgs) Handles DeliverySearchBtn.Click
        Dim isvaliddelivery As Boolean = deliverycheck(deliverytxtbx.text)
        Dim isvalidweight As Boolean = weightCheck(WeightTxtBx.Text)
        Dim isvaliddimensions As Boolean = postallength(dimensionstxtbx.text)

        If (isvaliddelivery Or isvalidweight Or isvaliddimensions) Then
            Dim sql = "SELECT * FROM Postal WHERE 1 = 1 "
            Dim parameters As New List(Of OleDbParameter)

            If isvaliddelivery = True Then
                sql += "AND DeliveryTime = @deliverytime "
                parameters.Add(New OleDbParameter("@deliverytime", DeliveryTxtBx.Text))
            End If

            If isvalidweight = True Then
                sql += "AND Weight = @weight "
                parameters.Add(New OleDbParameter("@weight", WeightTxtBx.Text))
            End If

            If isvaliddimensions = True Then
                sql += "AND Centimetres = @centimetres "
                parameters.Add(New OleDbParameter("@centimetres", DimensionsTxtBx.Text))
            End If

            dataGridFill(sql, New DataTable(), PostalDgv, parameters.ToArray())
            Else 
                MsgBox("Please enter a search term, ensure your parameters for searching are valid such as ""Next Day, 3 days etc"" for delivery time, ""20kg, 750g etc"" for weight and""20cm etc"" for dimensions")
        End If
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        dataGridFill("SELECT * FROM Postal", New datatable(), PostalDgv)
    End Sub
End Class
