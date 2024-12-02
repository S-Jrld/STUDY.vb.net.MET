Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class LoginForm

    Public newuser As Boolean = False

    Public Sub checknewuser(username As String)
        'create query to be execute in database
        Dim query As String = "SELECT COUNT(*) FROM tblusers WHERE Username = @Username AND (fname = '' OR fname IS NULL)"

        Try
            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            'save sql query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", username)

            'execute query into database and return number of rows selected
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                newuser = True
            End If

        Catch ex As MySqlException
            MsgBox("MySQL Error in checknewuser: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error in checknewuser: " & ex.Message)
        Finally
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Sub checkacc(username As String, password As String)
        'create a query that will select the number of rows to see if there is an account
        Dim query As String = "SELECT COUNT(*) FROM tblusers WHERE Username = @Username AND Password = @Password"

        Try
            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            'save sql query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)

            'execute query into database and return number of rows selected
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                MessageBox.Show("Login successful!")
                'save the value of username textbox to the global variable to be accessible across forms
                uname = glogtbxname.Text

                'Proceed to the dashboardform if true else do the survey
                If newuser = True Then
                    Dim survey As New SurveyForm
                    survey.Show()
                    Me.Hide()
                Else
                    Dim dashboard As New DashboardForm
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
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles glogbtnback.Click
        'change form into starting page
        Dim start As New Form1
        start.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles glogbtnfor.Click
        'change form into forgotform
        Dim forgot As New ForgotForm
        forgot.Show()
        Hide()
    End Sub

    Private Sub gstartbtn_Click(sender As Object, e As EventArgs) Handles glogbtn.Click

        'check the user if new account or not
        checknewuser(glogtbxname.Text)

        'check if there is an account in the database
        checkacc(glogtbxname.Text, glogtbxpass.Text)
    End Sub

    Private Sub gckbxshow1_CheckedChanged(sender As Object, e As EventArgs) Handles gckbxshow1.CheckedChanged
        'the condition to show password
        If gckbxshow1.Checked Then
            ' Show the password
            glogtbxpass.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            glogtbxpass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim login As New LoginForm
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class