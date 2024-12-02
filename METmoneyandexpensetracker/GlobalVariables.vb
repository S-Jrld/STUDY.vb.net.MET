Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module GlobalVariables

    Public connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=MoneyExpenseTracker")

    'colums from tblusers
    Public Property userid As String
    Public Property uname As String

    'columns from tblbalance
    Public Property startdate As Date
    Public Property balance As Decimal



    Public Property expperiod As String = "Monthly"

End Module
