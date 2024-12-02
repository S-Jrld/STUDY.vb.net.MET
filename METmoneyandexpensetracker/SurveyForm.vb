Imports MySql.Data.MySqlClient

Public Class SurveyForm
    'create a method to insert info into users
    Public Sub insertinfo()
        Dim query As String = "UPDATE `tblusers` SET `fname`=@fname,`lname`=@lname,`useraddress`=@useraddress,`birthdate`=@birthdate,`occupation`=@occupation,`fundsource`=@fundsource, incomemon =@incomemon WHERE Username = @Username"

        Try
            'check the connection to the database
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            'initialize the query
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@fname", gtbxfname.Text)
            cmd.Parameters.AddWithValue("@lname", gtbxlname.Text)
            cmd.Parameters.AddWithValue("@useraddress", gtbxaddress.Text)
            cmd.Parameters.AddWithValue("@birthdate", CDate(gbirthdate.Value))
            cmd.Parameters.AddWithValue("@occupation", gcbxoccupation.Text)
            cmd.Parameters.AddWithValue("@fundsource", gcbxsource.Text)
            cmd.Parameters.AddWithValue("@incomemon", gtbxincome.Text)
            'execute the query
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Save Succesfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim dash As New DashboardForm
                dash.Show()
                Me.Hide()
            Else
                MessageBox.Show("Save Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occured: ", ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub gbtncontinue_Click(sender As Object, e As EventArgs) Handles gbtncontinue.Click
        insertinfo()
    End Sub

    Private Sub SurveyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbirthdate.Value = Now
    End Sub
End Class