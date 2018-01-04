Public Class frmInGame
    Dim picPlayer As New PictureBox
    Dim movement As New Point(0, 0)

    ' Player movement/direction declaration ...
    Dim xdir As Integer
    Dim ydir As Integer


    Private Sub picPlayer_Click(sender As Object, e As EventArgs)
        ' Dim bmp As New Bitmap(picPlayer)
        ' bmp.MakeTransparent(Color.White)
        Me.picPlayer.BackColor = Color.Transparent

    End Sub

    Private Sub InGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub playerModel_Click(sender As Object, e As EventArgs) Handles playerModel.Click
        Dim movement As New Point(0, 0)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                Me.playerModel.Left -= 5
            Case Keys.Right
                Me.playerModel.Left -= -5
        End Select
    End Sub
End Class