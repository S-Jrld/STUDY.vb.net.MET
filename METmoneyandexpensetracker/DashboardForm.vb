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
        lbltitle.Text = "Dashboard"
        lblusername.Text = usernamekey
        gstateperiod = "DashboardContentsForm"
        'by using the method will display the form into the panel
        SwitchPanel(New DashboardContentsForm)

    End Sub

    Private Sub gbtnhistory_Click(sender As Object, e As EventArgs) Handles gbtnhistory.Click
        lbltitle.Text = "History"
        lblusername.Text = usernamekey
        gstateperiod = "HistoryForm"
        'by using the method will display the history into the panel
        SwitchPanel(New HistoryForm)

    End Sub

    Private Sub gbtngoal_Click(sender As Object, e As EventArgs) Handles gbtngoal.Click
        lbltitle.Text = "Goal"
        lblusername.Text = usernamekey
        gstateperiod = "GoalsForm"
        'by using the method will display the form into the panel
        SwitchPanel(New GoalsForm)

    End Sub

    Private Sub gbtnprofile_Click(sender As Object, e As EventArgs) Handles gbtnprofile.Click
        lbltitle.Text = "Profile"
        lblusername.Text = usernamekey
        gstateperiod = "ProfileForm"
        'by using the method will display the form into the panel
        SwitchPanel(New ProfileForm)

    End Sub

    Private Sub gbtnaboutus_Click(sender As Object, e As EventArgs) Handles gbtnaboutus.Click
        lbltitle.Text = "Know more about us"
        lblusername.Text = usernamekey

        gstateperiod = "AboutUs"
        SwitchPanel(New AboutUs)

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
        lbltitle.Text = "Dashboard"
        lblusername.Text = usernamekey
        gcmbperiod.Text = "Monthly"
        'by using the method will display the form into the panel
        SwitchPanel(New DashboardContentsForm)
    End Sub

    Private Sub gbtnhelp_Click(sender As Object, e As EventArgs) Handles gbtnhelp.Click
        lbltitle.Text = "Help Center"
        lblusername.Text = usernamekey
        gstateperiod = "HelpForm"
        'by using the method will display the form into the panel
        SwitchPanel(New HelpForm)
    End Sub

    Private Sub gcmbperiod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcmbperiod.SelectedIndexChanged
        If gcmbperiod.Text = "Monthly" Then
            If gexpperiod = "Yearly" Then
                gexpperiod = "Monthly"
            End If
            Select Case gstateperiod
                Case "DashboardContentsForm"
                    SwitchPanel(New DashboardContentsForm)
                Case "GoalsForm"
                    SwitchPanel(New GoalsForm)
                Case "HistoryForm"
                    SwitchPanel(New HistoryForm)
                Case "ProfileForm"
                    SwitchPanel(New ProfileForm)
            End Select
            'change the period to month to display info for the month
        ElseIf gcmbperiod.Text = "Yearly" Then
            If gexpperiod = "Monthly" Then
                gexpperiod = "Yearly"
            End If
            Select Case gstateperiod
                Case "DashboardContentsForm"
                    SwitchPanel(New DashboardContentsForm)
                Case "GoalsForm"
                    SwitchPanel(New GoalsForm)
                Case "HistoryForm"
                    SwitchPanel(New HistoryForm)
                Case "ProfileForm"
                    SwitchPanel(New ProfileForm)
            End Select
            'change the period to month to display info for the month
        End If
    End Sub
End Class