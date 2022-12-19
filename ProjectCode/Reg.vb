Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Module Reg
    Public conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\freelancedatabase.accdb")
    Public Function LengthCheck(ByVal text As String, upper As Integer, lower As Integer) As Boolean
        If text.Length() > upper Or text.Length() < lower Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function CustomerIDCheck(ByVal text As String) As Boolean
        Dim CustomerIDregex As New Regex("^[N]{1}[0-9]{4}$")
        If CustomerIDregex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public function emailCheck (ByVal text As String) As Boolean
        Dim EmailRegex As New Regex("(([^<>()\[\]\\.,;:\s@""]+(\.[^<>()\[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))")
        If EmailRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function postcodeCheck(ByVal text As String) As Boolean
        Dim PostcodeRegex As New Regex("^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([AZa-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2})$")
        If PostcodeRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
     
    Public function phoneCheck (ByVal text As String) As Boolean
        Dim phoneRegex As New Regex("^\+[1-9]\d{1,14}$")
        If phoneRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EmployeeIDCheck(ByVal text As String) As Boolean
        Dim EmployeeIDRegex As New Regex("^[E]{1}[0-9]{4}$")
        If EmployeeIDRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function PasswordCheck(ByVal text As String) As Boolean
        Dim PasswordRegex As New Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,30}$")
        If PasswordRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function admincheck(ByVal text As String) As Boolean
        Dim AdminRegex As New Regex("^[0-1]{1}$")
        If AdminRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CharacterCheck(ByVal text As String) 'USED FOR SECRET QUESTION AND ANSWER WITH A PRESENCE CHECK + LENGTH CHECK
        For i = 0 To text.Length - 1
            If Not Char.IsLetter(text.Chars(i)) Then
                If Not Char.IsWhiteSpace(text.Chars(i)) Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function
    Public Function SaleIDCheck(ByVal text As String) As Boolean
        Dim SaleIDRegex As New Regex("^[S]{1}[0-9]{4}$")
        If SaleIDRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function PostalIDCheck(ByVal text As String) As Boolean
        Dim PostalIDRegex As New Regex("^[R]{1}[0-9]{4}$")
        If PostalIDRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CurrencyCheck(ByVal text As String) As Boolean
        Dim CurrencyRegex As New Regex("^\£([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$")
        If CurrencyRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function DateCheck(ByVal text As String) As Boolean
        Dim DateRegex As New Regex("^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/((19|20)\d\d)$")
        If DateRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ProductIDCheck(ByVal text As String) As Boolean
        Dim ProductIDRegex As New Regex("^[P]{1}[0-9]{4}$")
        If ProductIDRegex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
