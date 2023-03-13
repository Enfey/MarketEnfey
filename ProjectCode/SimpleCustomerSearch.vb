Public Class SimpleCustomerSearch
    Private Sub SimpleCustomerSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGridFill("SELECT * FROM Customers", New DataTable, CustomerDgv)

        For Each column As DataGridViewColumn In CustomerDgv.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        CustomerDgv.ReadOnly = True
    End Sub

    Private Sub WeightSearchBtn_Click(sender As Object, e As EventArgs) Handles SearchCustomerBtn.Click
        If customerIDCheck(CustomerIDTxtBx.Text) = False Then
            MsgBox($"" & CustomerIDTxtBx.Text & " is not a valid customer ID, please enter in the format N followed by 4 digits")
            CustomerIDTxtBx.Clear()
            CustomerIDTxtBx.Focus()
        Else
            Dim result = RecursiveBinarySearch(CustomerDgv, CustomerIDTxtBx.Text, 0, CustomerDgv.Rows.Count - 1)
            If result = True Then
                MsgBox("Customer found!")
            Else
                MsgBox("Customer not found, please try again.")
                CustomerIDTxtBx.Clear()
                CustomerIDTxtBx.Focus()
            End If
        End If
    End Sub

    Private Sub ExitBtn_click(sender As Object, e As EventArgs) Handles BackBtn.Click
        me.hide()
        clearAllControls(Me)
        dataGridFill("SELECT * FROM Customers", New DataTable, CustomerDgv)
        customers.show()
    End Sub
End Class