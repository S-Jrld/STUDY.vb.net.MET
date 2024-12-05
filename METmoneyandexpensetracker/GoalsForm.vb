Imports System.Management
Imports MySql.Data.MySqlClient
Imports Mysqlx.Datatypes
Imports ZstdSharp.Unsafe

Public Class GoalsForm
    ' Define a FlowLayoutPanel and AddNote button in the designer
    Private notes As New List(Of GlobalVariables.Note)

    Private Sub GoalsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblname.Text = usernamekey
        forecastbudget()
        LoadNotes()
    End Sub

    'method to forecast the budget next month
    Private Sub forecastbudget()
        Dim query As String = "SELECT tblbalance.budget, tbluser.mincome FROM tblbalance LEFT JOIN tbluser ON tblbalance.uname = tbluser.uname WHERE tblbalance.budgetname = 'Monthly' AND (YEAR(tblbalance.startdate) = YEAR(CURDATE()) AND MONTH(tblbalance.startdate) = MONTH(CURDATE())) AND tblbalance.uname = @username ORDER BY ABS(DATEDIFF(NOW(), tblbalance.startdate)) LIMIT 1"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", usernamekey)
                ' Execute query into the database and return the data retrieved
                Using dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read() Then
                        Dim forecastbudget As Decimal = (Convert.ToDecimal(dr("mincome")) + Convert.ToDecimal(dr("budget"))) / 2
                        lblincome.Text = forecastbudget
                        lblnecessities.Text = forecastbudget * 0.5
                        lblwants.Text = forecastbudget * 0.3
                        lblsavings.Text = forecastbudget * 0.2
                    End If
                    dr.Close()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in forecastbudget: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in forecastbudget: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Event handler for AddNote button click
    Private Sub gbtnaddnote_Click(sender As Object, e As EventArgs) Handles gbtnaddnote.Click
        Using noteForm As New NoteInfoForm(Me)
            noteForm.Owner = Me
            noteForm.ShowDialog()
        End Using
    End Sub

    ' Method to add a note panel to the FlowLayoutPanel
    Public Sub AddNotePanel(note As GlobalVariables.Note)
        Dim panel As New Panel() With {
            .Tag = note.noteid,
            .BorderStyle = BorderStyle.FixedSingle,
            .Width = 170,
            .Height = 180 ' Adjust as needed
        }

        ' Create labels and buttons for the panel
        Dim lblTitle As New Label() With {.Text = "Title: " & note.notetitle, .AutoSize = True, .Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), .Location = New Point(5, 10)}
        Dim lblGoalMoney As New Label() With {.Text = "Goal Money: " & note.goalmoney.ToString("C2"), .AutoSize = True, .Location = New Point(10, 50)}
        Dim lblSavedMoney As New Label() With {.Text = "Saved Money: " & note.savedmoney.ToString("C2"), .AutoSize = True, .Location = New Point(10, 70)}
        Dim progress As Decimal = If(note.goalmoney > 0, (note.savedmoney / note.goalmoney) * 100, 0)
        Dim lblProgress As New Label() With {.Text = "Progress: " & progress.ToString("F2") & "%", .AutoSize = True, .Location = New Point(10, 90)}

        Dim btnEdit As New Button() With {.Text = "Edit Note", .Location = New Point(9, 140)}
        AddHandler btnEdit.Click, Sub() EditNotePanel(note, panel)

        Dim btnDelete As New Button() With {.Text = "Delete Note", .Location = New Point(83, 140)}
        AddHandler btnDelete.Click, Sub() DeleteNotePanel(note, panel)

        ' Add controls to the panel
        panel.Controls.Add(lblTitle)
        panel.Controls.Add(lblGoalMoney)
        panel.Controls.Add(lblSavedMoney)
        panel.Controls.Add(lblProgress)
        panel.Controls.Add(btnEdit)
        panel.Controls.Add(btnDelete)

        ' Add the panel to the FlowLayoutPanel
        mainflowpanel.Controls.Add(panel)
    End Sub

    ' Load notes from database
    Private Sub LoadNotes()
        Dim query As String = "SELECT noteid, notetitle, notecontext, goalmoney, savedmoney FROM tblgoal WHERE uname = @username"
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", usernamekey)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                mainflowpanel.Controls.Clear()
                While reader.Read()
                    Dim note As New GlobalVariables.Note With {
                        .noteid = reader("noteid"),
                        .notetitle = reader("notetitle").ToString(),
                        .notecontext = reader("notecontext").ToString(),
                        .goalmoney = Convert.ToDecimal(reader("goalmoney")),
                        .savedmoney = Convert.ToDecimal(reader("savedmoney"))
                    }
                    AddNotePanel(note)
                End While
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in LoadNotes: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in LoadNotes: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Method to edit a note panel
    Public Sub EditNotePanel(note As GlobalVariables.Note, panel As Panel)
        Using noteForm As New NoteInfoForm(Me, note)
            noteForm.Owner = Me
            noteForm.ShowDialog()
            ' Update the panel after editing
            UpdateNotePanel(note, panel)
        End Using
    End Sub

    ' Method to update the panel with new note data
    Public Sub UpdateNotePanel(note As GlobalVariables.Note, panel As Panel)
        For Each control As Control In panel.Controls
            If TypeOf control Is Label Then
                Dim lbl As Label = CType(control, Label)
                If lbl.Text.StartsWith("Title:") Then
                    lbl.Text = "Title: " & note.notetitle
                ElseIf lbl.Text.StartsWith("Goal Money:") Then
                    lbl.Text = "Goal Money: " & note.goalmoney.ToString("C2")
                ElseIf lbl.Text.StartsWith("Saved Money:") Then
                    lbl.Text = "Saved Money: " & note.savedmoney.ToString("C2")
                ElseIf lbl.Text.StartsWith("Progress:") Then
                    Dim progress As Decimal = If(note.goalmoney > 0, (note.savedmoney / note.goalmoney) * 100, 0)
                    lbl.Text = "Progress: " & progress.ToString("F2") & "%"
                End If
            End If
        Next
    End Sub

    ' Method to delete a note panel
    Public Sub DeleteNotePanel(note As GlobalVariables.Note, panel As Panel)
        Dim query As String = "DELETE FROM tblgoal WHERE uname = @username AND noteid = @noteId"
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", usernamekey)
                cmd.Parameters.AddWithValue("@noteId", note.noteid)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in DeleteNotePanel: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in DeleteNotePanel: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        mainflowpanel.Controls.Remove(panel)
    End Sub

End Class
