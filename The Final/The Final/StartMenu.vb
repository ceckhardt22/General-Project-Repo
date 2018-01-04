Public Class StartMenu

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim oForm As New frmInGame
        oForm.Show()
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim rQuit As DialogResult
        rQuit = MessageBox.Show("Are you sure you want to quit?", "Game Quit", MessageBoxButtons.YesNo)
        If rQuit = Windows.Forms.DialogResult.No Then
            MessageBox.Show("I knew you couldn't leave me yet. :3")
        ElseIf rQuit = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub StartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Will play game music ..
        My.Computer.Audio.Play(My.Resources.RealityDistortion, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
