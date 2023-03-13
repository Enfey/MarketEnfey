Imports System.Data.OleDb

Public Class WelcomeScreen
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
    Dim da As OleDbDataAdapter
    Private Sub WelcomeLoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Me.Hide() 'hides the welcome screen
        login.Show() 'displays the login
    End Sub

    Private Sub WelcomeExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim ProgExit As DialogResult 'defines the variable to be able to indicate the return value of a dialog box
        ProgExit = MessageBox.Show("Are you sure you want to exit?", "",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (ProgExit = DialogResult.Yes) Then
            Application.Exit() ' fully exits program
        End If
    End Sub

    Private Sub WelcomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim valuesToUpdate As New List(Of String)({"John", "Doe"})
        'Dim columnNames As New List(Of String)({"FirstName", "Surname"})
        'Dim primaryKeyColumnName As String = "CustomerID"
        'Dim primaryKeyValue As String = "N8320"
        'Dim tableName As String = "Customers"
        'Dim dSet As New DataSet
        'Dim sql As String = "SELECT * FROM Customers"
        'conn.Open()


        'da = New OleDbDataAdapter(Sql, conn)
        'da.Fill(dSet, "Customers")

        'conn.Close()

        '' Fill the DataSet using an OleDbDataAdapter

        'Dim success As Boolean = AccessLogic.ExecuteUpdateQuery1(valuesToUpdate, columnNames, primaryKeyColumnName, primaryKeyValue, tableName, dSet)

        'If success Then
        '    MessageBox.Show("Update successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    MessageBox.Show(dSet.ToString)
        'Else
        '    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If



        Dim ds As New DataSet
        Dim da = New OleDbDataAdapter("SELECT * FROM Customers", conn)
        da.Fill(ds, "Customers")
        Dim tablename As String = "Customers"
        Dim primarykeycolumnname = "CustomerID"
        Dim primarykeyvalue = "N8321"
        Dim updateValues As New Dictionary(Of String, String) From {
            {"FirstName", "Jonny"},
            {"Surname", "Banks"}
        }

        'Dim success As DataSet = AccessLogic.Exec(ds, tablename, updateValues, primarykeycolumnname, primarykeyvalue)


















        Dim parameters As OleDbParameter() = {
                                                 New OleDbParameter("@FirstName", "John"),
                                                 New OleDbParameter("@surname", "Doe"),
                                                 New OleDbParameter("@CustomerID", "N8320")
                                             }


        'dynamic sql query (kind of)
        Dim sql As String = "UPDATE Customers SET "
        sql += "FirstName = @FirstName, "
        sql += "Surname = @Surname "
        sql += "WHERE CustomerID = @CustomerID"



        'dataset initialisation
        Dim dSet As New DataSet
        Dim adapter As New OleDbDataAdapter("SELECT * FROM Customers", conn)
        adapter.Fill(dSet, "Customers")




        'adding param vals + executing
        Dim cmd As New OleDbCommand(sql, conn)
        cmd.Parameters.AddRange(parameters)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()


        Dim builder As New OleDbCommandBuilder(adapter)
        builder.QuotePrefix = "["
        builder.QuoteSuffix = "]"
        adapter.Update(dSet.Tables("Customers"))



















        'Dim valuesToUpdate As New List(Of String)
        'valuesToUpdate.Add("New Value 1")
        'valuesToUpdate.Add("New Value 2")

        'Dim columnNames As New List(Of String)()
        'columnNames.Add("FirstName")
        'columnNames.Add("LastName")

        'Dim primaryKeyColumnName As String = "CustomerID"
        'Dim primaryKeyValue As String = "N8320"

        'Dim tableName As String = "Customers"
        'Dim dataSet As New DataSet()

        'AccessLogic.UpdateData(valuesToUpdate, columnNames, primaryKeyColumnName, primaryKeyValue, tableName, dataSet)
    End Sub
End Class