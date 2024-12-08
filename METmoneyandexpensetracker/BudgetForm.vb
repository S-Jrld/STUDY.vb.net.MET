Imports MySql.Data.MySqlClient

Public Class BudgetForm
    'Dim budget As Decimal = budget + Val(gtbxbudget.Text)
    Public Sub AddBothBudget()
        Dim queryMonthly As String = "INSERT INTO tblbalance(userid, uname, budgetname, budget, startdate) VALUES((SELECT userid FROM tbluser WHERE uname = @username), @username, 'Monthly', @budget, @startdate)"
        Dim queryYearly As String = "INSERT INTO tblbalance(userid, uname, budgetname, budget, startdate) VALUES((SELECT userid FROM tbluser WHERE uname = @username), @username, 'Yearly', @budget, @startdate)"

        If MsgBox("Do you want to set a new budget?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                ' Check connection state; if closed, then open
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                ' Begin a database transaction
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    ' Initialize commands for each query
                    Using cmdMonthly As New MySqlCommand(queryMonthly, connection, transaction),
                      cmdYearly As New MySqlCommand(queryYearly, connection, transaction)

                        ' Clear and add parameters for the Monthly budget
                        cmdMonthly.Parameters.Clear()
                        cmdMonthly.Parameters.AddWithValue("@username", usernamekey)
                        cmdMonthly.Parameters.AddWithValue("@budget", gtbxmonthlybudget.Text)
                        cmdMonthly.Parameters.AddWithValue("@startdate", Now())

                        ' Clear and add parameters for the Yearly budget
                        cmdYearly.Parameters.Clear()
                        cmdYearly.Parameters.AddWithValue("@username", usernamekey)
                        cmdYearly.Parameters.AddWithValue("@budget", gtbxyearlybudget.Text)
                        cmdYearly.Parameters.AddWithValue("@startdate", Now())

                        ' Execute both queries within the transaction
                        Dim rowsMonthly As Integer = cmdMonthly.ExecuteNonQuery()
                        Dim rowsYearly As Integer = cmdYearly.ExecuteNonQuery()

                        If rowsMonthly > 0 AndAlso rowsYearly > 0 Then
                            ' Commit the transaction if both inserts are successful
                            transaction.Commit()
                            MessageBox.Show("Set New Budget Successfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'close the form and return to dashboard
                            Me.Close()
                        Else
                            ' Rollback the transaction if any insert fails
                            transaction.Rollback()
                            MessageBox.Show("Set New Budget Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("MySQL Error in AddBudget: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error in AddBudget: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Check connection state; if open, then close
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Public Sub AddMonthBudget()
        Dim getUserIdQuery As String = "SELECT userid FROM tbluser WHERE uname = @username"
        Dim insertBalanceQuery As String = "INSERT INTO tblbalance(userid, uname, budgetname, budget, startdate) VALUES (@userid, @username, 'Monthly', @budget, @startdate)"
        Dim budgetAmount As Decimal

        ' Validate and convert the budget input
        If Not Decimal.TryParse(gtbxmonthlybudget.Text, budgetAmount) Then
            MessageBox.Show("Invalid budget amount. Please enter a valid number.", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Check connection state; if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Retrieve the user ID based on the username
            Using cmdGetUserId As New MySqlCommand(getUserIdQuery, connection)
                cmdGetUserId.Parameters.AddWithValue("@username", usernamekey)
                Dim userIdResult As Object = cmdGetUserId.ExecuteScalar()

                ' Ensure userIdResult is not null
                If userIdResult Is Nothing Then
                    MessageBox.Show("User not found. Please check the username.", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                userid = userIdResult.ToString() ' Store the user ID as a string
            End Using

            ' Insert the new budget record
            Using cmdInsertBalance As New MySqlCommand(insertBalanceQuery, connection)
                cmdInsertBalance.Parameters.AddWithValue("@userid", userid) ' Use the string user ID
                cmdInsertBalance.Parameters.AddWithValue("@username", usernamekey)
                cmdInsertBalance.Parameters.AddWithValue("@budget", budgetAmount)
                cmdInsertBalance.Parameters.AddWithValue("@startdate", Now())

                Dim i As Integer = cmdInsertBalance.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Set New Budget Successfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Close the form and return to the dashboard
                    Me.Close()
                Else
                    MessageBox.Show("Set New Budget Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in ExecuteBudgetQuery: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in ExecuteBudgetQuery: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub gbtnback_Click(sender As Object, e As EventArgs) Handles gbtnback.Click
        'close the form and return to dashboard
        Me.Close()

    End Sub

    Private Sub gbtnsetnew_Click(sender As Object, e As EventArgs) Handles gbtnsetnew.Click
        If setbudgetname Then
            'this set the budget only on this month
            AddMonthBudget()
        Else
            AddBothBudget()
        End If

    End Sub

    Private Sub gcmbbudgetname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcmbbudgetname.SelectedIndexChanged
        If gcmbbudgetname.Text = "Monthly" Then
            gtbxyearlybudget.Enabled = False
            setbudgetname = True
        Else
            gtbxyearlybudget.Enabled = True
            setbudgetname = False
        End If
    End Sub

    Private Sub BudgetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcmbbudgetname.Text = "Monthly"
    End Sub
End Class