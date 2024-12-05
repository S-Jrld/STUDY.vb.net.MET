Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Module GlobalVariables

    Public connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=met_moneyexpensetracker")

    'colums from tblusers
    Public Property userid As String
    Public Property usernamekey As String
    Public Property guserpass As String
    Public Property gfname As String
    Public Property glname As String
    Public Property gaddress As String
    Public Property guserbirthdate As Date
    Public Property gstatus As String
    Public Property gfundsource As String
    Public Property gmincome As String

    'columns from tblbalance
    Public Property setbudgetname As Boolean = False
    Public Property gbudgetname As String
    Public Property gbudget As Decimal
    Public Property gavailbal As Decimal
    Public Property gtotalexp As Decimal
    Public Property gstartdate As Date

    'columms from tbltransaction
    Public Property editrecords As Boolean = False
    Public Property gtransid As Integer
    Public Property gtransstatus As String
    Public Property gcategory As String
    Public Property gtransname As String
    Public Property gprice As Decimal
    Public Property gquantity As Integer
    Public Property gtotal As Decimal
    Public Property gtransdate As Date

    'columns from tblgoal
    Public Class Note
        Public Property noteid As Integer
        Public Property notetitle As String
        Public Property notecontext As String
        Public Property goalmoney As Decimal
        Public Property savedmoney As Decimal
    End Class

    Public Property gexpperiod As String = "Monthly"

    'list of top achievements
    Public Property gtopspent As String

End Module
