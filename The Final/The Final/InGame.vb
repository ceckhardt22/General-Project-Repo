Public Class frmInGame

    'Integers
    Private lives As Integer = 5                 ' Lives per game .. 
    Private level As Integer = 1                 ' Starting level/current level the player is on ..
    Private score As Integer                     ' Player score ..
    Private highScore As Integer                 ' High score default ..
    Private invaderEntryPath As Integer          ' Denotes which path the invaders will travel along ..
    Private playerPivotPos As Integer = 61       ' Player piviot starting pos. ..

    'Booleans
    Private moveKeyPress(2) As Boolean           ' Flags set true when player input requests to move the ship left / right
    Private shootKeyPress As Boolean             ' Flag set when player shoots
    Private shootKeyUP As Boolean                ' Flag set when player input key / button is released
    Private levelCompleted As Boolean            ' Set when level has just been completed
    Private AppRunning As Boolean = True         ' Set while app is running 
    Private gameOver As Boolean = True           ' Set when game over ...
    Private doingSOLevel As Boolean              ' Start of a new level then set
    Private doingEOLevel As Boolean              ' End of a level then set ... 
    Private doingSOGame As Boolean               ' Flasg set when doing the start of a new game 
    Private playerExplosion As Boolean           ' Set when the player's ship is exploding

    Private Sub InGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class