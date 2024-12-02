Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module GlobalVariables

    Public connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=MoneyExpenseTracker")

    Public Property username As String
    Public Property id As String
    Public Property startdate As Date
    Public Property balance As Decimal
    Public Property expperiod As String = "Monthly"

End Module
