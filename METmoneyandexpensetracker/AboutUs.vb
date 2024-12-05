Public Class AboutUs

    Private Sub gctrlclose_Click(sender As Object, e As EventArgs)
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim dashboard As New DashboardForm
            dashboard.Show()
            Me.Close()
        End If
    End Sub
End Class
