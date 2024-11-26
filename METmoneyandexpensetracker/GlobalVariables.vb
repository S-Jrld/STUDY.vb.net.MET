Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module GlobalVariables

    Public connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=MoneyExpenseTracker")

    Public username As String
    Public id As String

End Module
