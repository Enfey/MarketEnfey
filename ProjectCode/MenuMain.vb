Public Class MenuMain 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Hide() 'hides main menu
        login.Show() 'shows form
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles CustomersBtn.Click
        customers.Show() 'hides main menu
        Me.Hide()
    End Sub

    Private Sub ProductsBtn_Click(sender As Object, e As EventArgs) Handles ProductsBtn.Click
        Products.Show() 'hides main menu
        Me.Hide() 'shows form
    End Sub

    Private Sub PostalBtn_Click(sender As Object, e As EventArgs) Handles PostalBtn.Click
        Me.Hide() 'hides main menu
        Postal.Show() 'shows form
    End Sub

    Private Sub OrdersBtn_Click(sender As Object, e As EventArgs) Handles OrdersBtn.Click
        Me.Hide() 'hides main menu
        Orders.Show() 'shows form
    End Sub

    Private Sub EmployeesBtn_Click(sender As Object, e As EventArgs) Handles EmployeesBtn.Click
        Me.Hide() 'hides main menu
        Employees.Show() 'shows form
    End Sub

    Private Sub MenuMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If employeeAccessLevel_ = false Then
            PictureBox3.Hide()
        End If
    End Sub
End Class