Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Mail

Module GlobalLogic 'this contains general, reusable logic that is employed throughout the application
    Public Function ExecuteQueryAndReturnData(query As String, ParamArray parameters() As OleDbParameter) As (success As Boolean, data As List(Of Dictionary(Of String, Object)))
        Dim success = False 'default val
        Dim data As New List(Of Dictionary(Of String, Object))

        Try
            Using conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
                conn.Open()

                Using cmd = conn.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = query
                    cmd.Parameters.AddRange(parameters)

                    Using dr As OleDbDataReader = cmd.ExecuteReader()
                        If dr.HasRows Then
                            While dr.Read()
                                Dim row As New Dictionary(Of String, Object)
                                For i = 0 To dr.FieldCount - 1
                                    row.Add(dr.GetName(i), dr(i))
                                Next
                                data.Add(row)
                            End While
                        Else
                            MessageBox.Show("No rows found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            success = False
                            Exit Function
                        End If
                    End Using
                End Using
            End Using

            success = True
            Return (success, data)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Sub SendEmail(message As String, subject As String, credentials As Dictionary(Of String, String), sender As MailAddress, receipient As String, Optional mailAttachment As Attachment = Nothing, Optional attachmentName As String = Nothing)
        Dim smtpClient As New SmtpClient
        Dim eMail As New MailMessage()

        smtpClient.UseDefaultCredentials = False
        smtpClient.Credentials = New NetworkCredential(credentials("username"), credentials("password"))
        smtpClient.Port = 587
        smtpClient.EnableSsl = True
        smtpClient.Host = "smtp-mail.outlook.com"

        eMail.From = sender
        eMail.To.Add(receipient)
        eMail.Subject = subject
        eMail.IsBodyHtml = False
        eMail.Body = message

        If mailAttachment IsNot Nothing Then
            mailAttachment.Name = attachmentName
            eMail.Attachments.Add(mailAttachment)
        End If

        Try
            smtpClient.Send(eMail)
            MsgBox("Mail Sent")
        Catch ex As Exception
            smtpClient.Dispose()
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub dataGridFill(query As String, dataTable As DataTable, dataGrid As DataGridView, Optional parameters As OleDbParameter() = Nothing)
        Using conn = New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=.\freelancedatabase.accdb")
            conn.Open()
            Using command As New OleDbCommand(query, conn)
                If parameters IsNot Nothing Then
                    command.Parameters.AddRange(parameters)
                End If
                Using adapter As New OleDbDataAdapter(command)
                    adapter.Fill(dataTable)
                    dataGrid.DataSource = dataTable
                End Using
            End Using
        End Using
    End Sub

    Public Sub clearAllControls(ByVal form As Form)
        For Each control As Control In form.Controls
            Select Case control.GetType().Name
                Case "TextBox"
                    Dim textBox As TextBox = CType(control, TextBox)
                    textBox.Clear()
                Case "ComboBox"
                    Dim comboBox As ComboBox = CType(control, ComboBox)
                    comboBox.SelectedIndex = -1
                Case "CheckBox"
                    Dim checkBox As CheckBox = CType(control, CheckBox)
                    checkBox.Checked = False
                Case "RadioButton"
                    Dim radioButton As RadioButton = CType(control, RadioButton)
                    radioButton.Checked = False
                Case "DataGridView"
                    Dim dataGridView As DataGridView = CType(control, DataGridView)
                    If dataGridView.DataSource IsNot Nothing Then
                        dataGridView.DataSource = Nothing
                    End If
                    dataGridView.Rows.Clear()
            End Select
        Next
    End Sub
    Public Sub clearTextBoxes(ByVal form As Form)
        For Each control As Control In form.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Public Function RecursiveBinarySearch(ByVal dataGrid As DataGridView, ByVal searchValue As String, ByVal startIndex As Integer, ByVal endIndex As Integer) As Boolean
        Try
            If startIndex > endIndex Then 'if left greater than right, searchValue was not found
                Return False
            End If

            Dim midIndex As Integer = (startIndex + endIndex) \ 2 'sets mid point
            Dim cellValue As String = CStr(dataGrid.Rows(midIndex).Cells(0).Value) 'holds value of current cell being compared against search value

            If cellValue = searchValue Then ' base case
                dataGrid.Rows(midIndex).Selected = True
                dataGrid.CurrentCell = dataGrid.Rows(midIndex).Cells(0)
                Return True
            ElseIf cellValue.CompareTo(searchValue) < 0 Then
                Return RecursiveBinarySearch(dataGrid, searchValue, midIndex + 1, endIndex) ' dispose of left
            Else
                Return RecursiveBinarySearch(dataGrid, searchValue, startIndex, midIndex - 1) ' dispose of right
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
