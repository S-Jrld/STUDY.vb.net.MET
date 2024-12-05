Imports MySql.Data.MySqlClient

Public Class SurveyForm

    Public Sub UpdateUserInfo()
        ' Create a method to insert or update user info

        ' Create a query to update values in tblusers
        Dim query As String = "UPDATE tbluser SET fname = @fname, lname = @lname, address = @address, birthdate = @birthdate, status = @status, fundsource = @fundsource, mincome = @mincome WHERE uname = @username"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@username", usernamekey)
                cmd.Parameters.AddWithValue("@fname", gtbxfname.Text)
                cmd.Parameters.AddWithValue("@lname", gtbxlname.Text)
                cmd.Parameters.AddWithValue("@address", gtbxaddress.Text)
                cmd.Parameters.AddWithValue("@birthdate", CDate(gbirthdate.Value))
                cmd.Parameters.AddWithValue("@status", gcmbstatus.Text)
                cmd.Parameters.AddWithValue("@fundsource", gcmbfundsource.Text)
                cmd.Parameters.AddWithValue("@mincome", gtbxmincome.Text)

                ' Execute the query and return the integer value of rows affected after update
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Saved Successfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' If true, then proceed to the dashboard
                    Dim dash As New DashboardForm()
                    dash.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Save Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in UpdateUserInfo: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in UpdateUserInfo: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Function AreAllFieldsFilled() As Boolean
        ' Check each control for emptiness and return False immediately if any are empty
        If String.IsNullOrWhiteSpace(gtbxfname.Text) Then Return False
        If String.IsNullOrWhiteSpace(gtbxlname.Text) Then Return False
        If String.IsNullOrWhiteSpace(gtbxaddress.Text) Then Return False
        If gbirthdate.Value = DateTime.MinValue Then Return False
        If String.IsNullOrWhiteSpace(gcmbstatus.Text) Then Return False
        If String.IsNullOrWhiteSpace(gcmbfundsource.Text) Then Return False
        If String.IsNullOrWhiteSpace(gtbxmincome.Text) Then Return False

        ' If all checks pass, return True
        Return True
    End Function

    Private Sub gbtncontinue_Click(sender As Object, e As EventArgs) Handles gbtncontinue.Click
        'check field if filled
        If AreAllFieldsFilled() Then
            UpdateUserInfo()
        Else
            MessageBox.Show("Please fill out all required fields.")
        End If
    End Sub

    Private Sub SurveyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set datetimepicker date to now to keep being updated
        gbirthdate.Value = Now
    End Sub

    Private Sub gctrlclose_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim survey As New SurveyForm
            survey.Show()
            Me.Close()
        End If
    End Sub
End Class