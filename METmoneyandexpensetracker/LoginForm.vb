Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class LoginForm

    Public newuser As Boolean = False
    Public Sub checknewuser()
        Dim query As String = "SELECT COUNT(*) FROM tblusers WHERE Username = @Username AND (fname = '' OR fname IS NULL)"

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", glogtbxname.Text)

            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                newuser = True
            End If

        Catch ex As MySqlException
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Sub checkacc()
        'check the no. of rows to see if there is an account
        Dim query As String = "SELECT COUNT(*) FROM tblusers WHERE Username = @Username AND Password = @Password"

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", glogtbxname.Text)
            cmd.Parameters.AddWithValue("@Password", glogtbxpass.Text)

            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                MessageBox.Show("Login successful!")
                'Proceed to the next form or main application window
                username = glogtbxname.Text
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
            MsgBox("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'close the application
        Application.Exit()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles glogbtnreg.Click
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
        checknewuser()

        'use the method to check if there is an account in the database
        checkacc()
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

    Private Sub glogtbxname_TextChanged(sender As Object, e As EventArgs) Handles glogtbxname.TextChanged

    End Sub
End Class