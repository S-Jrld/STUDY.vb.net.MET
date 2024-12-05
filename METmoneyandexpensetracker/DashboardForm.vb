Imports System.Reflection.Emit

Public Class DashboardForm

    ' Shared method to switch panels
    Public Sub SwitchPanel(ByVal panel As Form)
        gpanelmain.Controls.Clear()
        panel.TopLevel = False
        gpanelmain.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub gbtndashboard_Click(sender As Object, e As EventArgs) Handles gbtndashboard.Click
        'by using the method will display the form into the panel
        SwitchPanel(New DashboardContentsForm)

    End Sub

    Private Sub gbtnhistory_Click(sender As Object, e As EventArgs) Handles gbtnhistory.Click
        'by using the method will display the history into the panel
        SwitchPanel(New HistoryForm)

    End Sub

    Private Sub gbtngoal_Click(sender As Object, e As EventArgs) Handles gbtngoal.Click
        'by using the method will display the form into the panel
        SwitchPanel(New GoalsForm)

    End Sub

    Private Sub gbtnprofile_Click(sender As Object, e As EventArgs) Handles gbtnprofile.Click
        'by using the method will display the form into the panel
        SwitchPanel(New ProfileForm)

    End Sub

    Private Sub gbtnaboutus_Click(sender As Object, e As EventArgs) Handles gbtnaboutus.Click
        'proceed to about us form
        Dim about As New AboutUs
        about.Show()
        Me.Hide()

    End Sub

    Private Sub gbtnlogout_Click(sender As Object, e As EventArgs) Handles gbtnlogout.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            'change into login form by loggin out
            Dim login As New LoginForm
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub gctrlclose_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim dashboard As New DashboardForm
            dashboard.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'by using the method will display the form into the panel
        SwitchPanel(New DashboardContentsForm)
    End Sub

End Class