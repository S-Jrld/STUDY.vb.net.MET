Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class LoginForm

    Private newuser As Boolean = False

    Private Sub CheckNewUser(username As String)
        ' Create query to be executed in the database
        Dim query As String = "SELECT COUNT(*) FROM tbluser WHERE uname = @username AND (fname = '' OR fname IS NULL)"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Save SQL query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)

            ' Execute query in the database and return the number of rows selected
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                newuser = True
            End If

        Catch ex As MySqlException
            MsgBox("MySQL Error in checknewuser: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error in checknewuser: " & ex.Message)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub CheckAccount(username As String, password As String)
        ' Create a query to select the number of rows to see if there is an account
        Dim query As String = "SELECT COUNT(*) FROM tbluser WHERE uname = @username AND pass = @password"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Save SQL query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            ' Execute query in the database and return the number of rows selected
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                MessageBox.Show("Login successful!")
                ' Save the value of username textbox to the global variable to be accessible across forms
                usernamekey = glogtbxname.Text

                ' Proceed to the dashboard or survey form based on user type
                If newuser Then
                    Dim survey As New SurveyForm()
                    survey.Show()
                    Me.Hide()
                Else
                    Dim dashboard As New DashboardForm()
                    dashboard.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Catch ex As MySqlException
            MsgBox("MySQL Error in checkacc: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error in checkacc: " & ex.Message)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub gbtnback_Click(sender As Object, e As EventArgs) Handles gbtnback.Click
        'change form into starting page
        Dim start As New Form1
        start.Show()
        Me.Hide()
    End Sub

    Private Sub gbtnforgot_Click(sender As Object, e As EventArgs) Handles gbtnforgot.Click
        'change form into forgotform
        Dim forgot As New ForgotForm
        forgot.Show()
        Hide()
    End Sub

    Private Sub gbtnlogin_Click(sender As Object, e As EventArgs) Handles gbtnlogin.Click

        'check the user if new account or not
        CheckNewUser(glogtbxname.Text)

        'check if there is an account in the database
        CheckAccount(glogtbxname.Text, glogtbxpass.Text)
    End Sub

    Private Sub gcheckshow_CheckedChanged(sender As Object, e As EventArgs) Handles gcheckshow.CheckedChanged
        'the condition to show password
        If gcheckshow.Checked Then
            ' Show the password
            glogtbxpass.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            glogtbxpass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub gctrlclose_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim login As New LoginForm
            login.Show()
            Me.Close()
        End If
    End Sub
End Class