Imports MySql.Data.MySqlClient

Public Class ForgotForm
    Public Property UsernameExists As Boolean = False

    Private Sub CheckUsername()
        ' Check the username if the same as input by user in the textbox
        Dim query As String = "SELECT COUNT(*) FROM tbluser WHERE uname = @username"

        Try
            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            'save sql query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", gtbxuname.Text)
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If result > 0 Then
                    UsernameExists = True
                Else
                    MessageBox.Show("Invalid username", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    UsernameExists = False
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in CheckUsername: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in CheckUsername: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub ChangePass()
        ' Using the query will update the password into the current password
        Dim query As String = "UPDATE tbluser SET pass = @password WHERE uname = @username"

        Try
            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            'save sql query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@password", gtbxconfirmpass.Text)
                cmd.Parameters.AddWithValue("@username", gtbxuname.Text)

                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Save Successfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Save Unsuccessfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in ChangePass: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in ChangePass: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub gcheckshow2_CheckedChanged(sender As Object, e As EventArgs) Handles gcheckshow2.CheckedChanged
        'the condition to show password
        If gcheckshow2.Checked Then
            ' Show the password
            gtbxconfirmpass.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gtbxconfirmpass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub gcheckshow1_CheckedChanged(sender As Object, e As EventArgs) Handles gcheckshow1.CheckedChanged
        'the condition to show password
        If gcheckshow1.Checked Then
            ' Show the password
            gtbxnewpass.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gtbxnewpass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub gbtnchangepass_Click(sender As Object, e As EventArgs) Handles gbtnchangepass.Click
        ' Check if the username exists
        CheckUsername()

        ' If the username exists, change the password and redirect to the login form
        If UsernameExists Then
            ChangePass()
            Dim login As New LoginForm()
            login.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid User Account", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub gbtnback_Click(sender As Object, e As EventArgs) Handles gbtnback.Click
        'will cancel the forgot form and go back to login
        Dim log As New LoginForm
        log.Show()
        Hide()
    End Sub

    Private Sub gctrlclose_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim forgot As New ForgotForm()
            forgot.Show()
            Me.Close()
        End If
    End Sub
End Class