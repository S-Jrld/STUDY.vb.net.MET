Imports System.Reflection.Emit

Public Class DashboardForm
    Private Sub LoadFormIntoPanel(form As Form)
        'clear the panel
        gpnlmain.Controls.Clear()

        'set the panel perspective
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        'add the form into the panel
        gpnlmain.Controls.Add(form)
        form.Show()

    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DashboardForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'close the application when close btn is clicked
        Application.Exit()
    End Sub

    Private Sub gbtndashboard_Click(sender As Object, e As EventArgs) Handles gbtndashboard.Click
        'by using the method will display the form into the panel
        LoadFormIntoPanel(New DashboardContentsForm)

    End Sub

    Private Sub gbtnhistory_Click(sender As Object, e As EventArgs) Handles gbtnhistory.Click
        'by using the method will display the history into the panel
        LoadFormIntoPanel(New HistoryForm)

    End Sub

    Private Sub gbtngoal_Click(sender As Object, e As EventArgs) Handles gbtngoal.Click
        'by using the method will display the form into the panel
        LoadFormIntoPanel(New GoalsForm)

    End Sub

    Private Sub gbtnprofile_Click(sender As Object, e As EventArgs) Handles gbtnprofile.Click
        'by using the method will display the form into the panel
        LoadFormIntoPanel(New ProfileForm)

    End Sub

    Private Sub gbtnabout_Click(sender As Object, e As EventArgs) Handles gbtnabout.Click
        Dim about As New AboutUs
        about.Show()
        Me.Hide()

    End Sub

    Private Sub gdashbtnout_Click(sender As Object, e As EventArgs) Handles gdashbtnout.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            'change into login form by loggin out
            Dim login As New LoginForm
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class