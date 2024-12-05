Imports MySql.Data.MySqlClient

Public Class NoteInfoForm
    Private parentForm As GoalsForm
    Private currentNote As Note

    ' Constructor for adding a new note
    Public Sub New(parent As GoalsForm)
        InitializeComponent()
        parentForm = parent
        gbtneditnote.Enabled = False ' Disable edit button for new notes
    End Sub

    ' Constructor for editing an existing note
    Public Sub New(parent As GoalsForm, note As Note)
        InitializeComponent()
        parentForm = parent
        currentNote = note

        ' Populate fields with note data
        gtbxtitle.Text = note.notetitle
        gtbxcontext.Text = note.notecontext
        gtbxgoalmoney.Text = note.goalmoney.ToString()
        gtbxgoalmoney.Enabled = False ' Disable Goal Money
        gtbxsavedmoney.Text = note.savedmoney.ToString()
        gbtnaddnote.Enabled = False ' Disable Display button
        gbtneditnote.Enabled = True
    End Sub

    ' Event handler for DisplayInFlowLayoutPanel button click
    Private Sub btnDisplayInFlowLayoutPanel_Click(sender As Object, e As EventArgs) Handles gbtnaddnote.Click
        Dim note As New GlobalVariables.Note() With {
            .notetitle = gtbxtitle.Text,
            .notecontext = gtbxcontext.Text,
            .goalmoney = Decimal.Parse(gtbxgoalmoney.Text),
            .savedmoney = Decimal.Parse(gtbxsavedmoney.Text)
        }

        InsertNoteIntoDatabase(note)
        parentForm.AddNotePanel(note)
        Me.Close()
    End Sub

    ' Event handler for EditNote button click
    Private Sub btnEditNote_Click(sender As Object, e As EventArgs) Handles gbtneditnote.Click
        If currentNote IsNot Nothing Then
            currentNote.notetitle = gtbxtitle.Text
            currentNote.notecontext = gtbxcontext.Text
            currentNote.savedmoney = Decimal.Parse(gtbxsavedmoney.Text)
            UpdateNoteInDatabase(currentNote)
            ' Find the panel by Tag
            Dim panel = CType(parentForm.mainflowpanel.Controls.OfType(Of Panel).FirstOrDefault(Function(p) p.Tag IsNot Nothing AndAlso p.Tag.ToString() = currentNote.noteid.ToString()), Panel)
            If panel IsNot Nothing Then
                parentForm.UpdateNotePanel(currentNote, panel)
                Me.Close()
            Else MessageBox.Show("Panel not found")
            End If
        Else MessageBox.Show("No note to edit")
        End If


    End Sub

    ' Insert note into database
    Private Sub InsertNoteIntoDatabase(note As GlobalVariables.Note)
        Try
            Dim query As String = "INSERT INTO tblgoal (userid, uname, notetitle, notecontext, goalmoney, savedmoney) VALUES ((SELECT userid FROM tbluser WHERE uname = @username), @username, @title, @context, @goalMoney, @savedMoney)"
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", usernamekey)
                cmd.Parameters.AddWithValue("@title", note.notetitle)
                cmd.Parameters.AddWithValue("@context", note.notecontext)
                cmd.Parameters.AddWithValue("@goalMoney", note.goalmoney)
                cmd.Parameters.AddWithValue("@savedMoney", note.savedmoney)
                cmd.ExecuteNonQuery()
                note.noteid = CInt(cmd.LastInsertedId)
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in InsertNoteIntoDatabase: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error in InsertNoteIntoDatabase: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Update note in the database
    Private Sub UpdateNoteInDatabase(note As GlobalVariables.Note)
        Try
            Dim query As String = "UPDATE tblgoal SET notetitle = @title, notecontext = @context, savedmoney = @savedMoney WHERE uname = @username AND noteid = @id"
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", usernamekey)
                cmd.Parameters.AddWithValue("@id", note.noteid)
                cmd.Parameters.AddWithValue("@title", note.notetitle)
                cmd.Parameters.AddWithValue("@context", note.notecontext)
                cmd.Parameters.AddWithValue("@savedMoney", note.savedmoney)
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in UpdateNoteInDatabase: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error in UpdateNoteInDatabase: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub gbtnback_Click(sender As Object, e As EventArgs) Handles gbtnback.Click
        Me.Close()
    End Sub
End Class

