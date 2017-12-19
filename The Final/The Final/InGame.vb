Public Class frmInGame

    ' Player movement/direction declaration ...
    Dim xdir As Integer
    Dim ydir As Integer

    Private Sub InGame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.W : ydir = -1
            Case Keys.A : xdir = -1
            Case Keys.S : ydir = 1
            Case Keys.D : xdir = 1
        End Select
    End Sub

    Private Sub InGame_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.W : ydir = -1 Then ydir = 0
            Case Keys.A : xdir = -1 Then xdir = 0
            Case Keys.S : ydir = 1 Then ydir = 0
            Case Keys.D : xdir = 1 Then xdir = 0
        End Select
    End Sub

    Private Sub picPlayer_Click(sender As Object, e As EventArgs) Handles picPlayer.Click
        Dim bmp As New Bitmap(picPlayer)
        bmp.MakeTransparent(Color.White)
        Me.picPlayer.BackColor = Color.Transparent

    End Sub
End Class