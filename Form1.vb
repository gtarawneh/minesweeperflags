Public Class Form1

    Dim B(255) As Button 'Button array
    Dim M(255) As Int32 'Mines array
    Dim I(255) As Int32 'Iteration array

    Dim MinesCleared As Int32 'Number of mines cleared
    Dim Sweeps As Int32 'Number of sweeps
    Dim TargetMines 'Number of mines to win game

    Dim Audio As New Microsoft.VisualBasic.Devices.Audio

    Private Sub ClearI()
        Dim T As Int32
        For T = 0 To 255
            I(T) = 0
        Next
    End Sub

    Public Function Surround(ByVal N As Int32) As Int32

        Dim Up As Boolean = False
        Dim Down As Boolean = False
        Dim Left As Boolean = False
        Dim Right As Boolean = False

        Dim Count As Int32 = 0

        If N > 15 Then Up = True
        If N < 240 Then Down = True
        If (N Mod 16) Then Left = True
        If N Mod 16 <> 15 Then Right = True

        If Up Then Count += M(N - 16)
        If Up And Right Then Count += M(N - 15)
        If Right Then Count += M(N + 1)
        If Right And Down Then Count += M(N + 17)
        If Down Then Count += M(N + 16)
        If Down And Left Then Count += M(N + 15)
        If Left Then Count += M(N - 1)
        If Left And Up Then Count += M(N - 17)

        Return Count

    End Function
    Private Sub MineClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim H As String = sender.GetHashCode
        Dim N As Int32

        For N = 0 To 255

            If B(N).GetHashCode = H Then

                If M(N) Then

                    If My.Settings.Sounds Then Audio.Play(My.Resources.MineDing, AudioPlayMode.Background)

                    B(N).BackColor = Nothing
                    B(N).BackgroundImage = My.Resources.Minesweeper
                    B(N).Enabled = False
                    MinesCleared += 1
                    Me.RemainingMinesLbl.Text = Format(TargetMines - MinesCleared, "Remaining Mines : 0")
                    If MinesCleared = TargetMines Then Win()
                    Exit Sub
                End If

                ClearI()
                Iterative(N)
                Sweeps += 1
                Me.SweepsLbl.Text = Format(Sweeps, "Sweeps : 0")

                B(N).Enabled = False

                Exit Sub

            End If


        Next

    End Sub

    Private Sub Win()

        Me.ToolStripButton1.Image = My.Resources.cool
        Me.NewGameToolStripMenuItem.Image = My.Resources.cool

        Dim T As Int32

        For T = 0 To 255
            B(T).Enabled = False
        Next

        If TargetMines = 25 Then T = My.Settings.BeginnerSweeps3
        If TargetMines = 30 Then T = My.Settings.IntermediateSweeps3
        If TargetMines = 35 Then T = My.Settings.ExpertSweeps3

        If Sweeps < T Then

            'New High Score

            'Prompting for Player Nam

            Dim HS As New HighScoreEnter

            Dim Nam As String

            HS.ShowDialog()

            Nam = HS.TextBox1.Text

            HS.Close()

            HS = Nothing

            'Adding score, and re-arranging

            Select Case TargetMines

                Case 25

                    If Sweeps < My.Settings.BeginnerSweeps1 Then

                        My.Settings.BeginnerSweeps3 = My.Settings.BeginnerSweeps2
                        My.Settings.BeginnerNam3 = My.Settings.BeginnerNam2

                        My.Settings.BeginnerSweeps2 = My.Settings.BeginnerSweeps1
                        My.Settings.BeginnerNam2 = My.Settings.BeginnerNam1

                        My.Settings.BeginnerSweeps1 = Sweeps
                        My.Settings.BeginnerNam1 = Nam

                    ElseIf Sweeps < My.Settings.BeginnerSweeps2 Then

                        My.Settings.BeginnerSweeps3 = My.Settings.BeginnerSweeps2
                        My.Settings.BeginnerNam3 = My.Settings.BeginnerNam2

                        My.Settings.BeginnerSweeps2 = Sweeps
                        My.Settings.BeginnerNam2 = Nam

                    Else

                        My.Settings.BeginnerSweeps3 = Sweeps
                        My.Settings.BeginnerNam3 = Nam

                    End If

                Case 30

                    If Sweeps < My.Settings.IntermediateSweeps1 Then

                        My.Settings.IntermediateSweeps3 = My.Settings.IntermediateSweeps2
                        My.Settings.IntermediateNam3 = My.Settings.IntermediateNam2

                        My.Settings.IntermediateSweeps2 = My.Settings.IntermediateSweeps1
                        My.Settings.IntermediateNam2 = My.Settings.IntermediateNam1

                        My.Settings.IntermediateSweeps1 = Sweeps
                        My.Settings.IntermediateNam1 = Nam

                    ElseIf Sweeps < My.Settings.IntermediateSweeps2 Then

                        My.Settings.IntermediateSweeps3 = My.Settings.IntermediateSweeps2
                        My.Settings.IntermediateNam3 = My.Settings.IntermediateNam2

                        My.Settings.IntermediateSweeps2 = Sweeps
                        My.Settings.IntermediateNam2 = Nam

                    Else

                        My.Settings.IntermediateSweeps3 = Sweeps
                        My.Settings.IntermediateNam3 = Nam

                    End If

                Case 35

                    If Sweeps < My.Settings.ExpertSweeps1 Then

                        My.Settings.ExpertSweeps3 = My.Settings.ExpertSweeps2
                        My.Settings.ExpertNam3 = My.Settings.ExpertNam2

                        My.Settings.ExpertSweeps2 = My.Settings.ExpertSweeps1
                        My.Settings.ExpertNam2 = My.Settings.ExpertNam1

                        My.Settings.ExpertSweeps1 = Sweeps
                        My.Settings.ExpertNam1 = Nam

                    ElseIf Sweeps < My.Settings.ExpertSweeps2 Then

                        My.Settings.ExpertSweeps3 = My.Settings.ExpertSweeps2
                        My.Settings.ExpertNam3 = My.Settings.ExpertNam2

                        My.Settings.ExpertSweeps2 = Sweeps
                        My.Settings.ExpertNam2 = Nam

                    Else

                        My.Settings.ExpertSweeps3 = Sweeps
                        My.Settings.ExpertNam3 = Nam

                    End If

            End Select

            My.Settings.Save()

            HighScores(Nothing, Nothing)

        End If

    End Sub

    Private Sub Iterative(ByVal N As Int32)

        ShowMine(N)

        If Surround(N) Or I(N) Then Exit Sub

        I(N) = 1

        Dim Up As Boolean = False
        Dim Down As Boolean = False
        Dim Left As Boolean = False
        Dim Right As Boolean = False

        Dim Count As Int32 = 0

        If N > 15 Then Up = True
        If N < 240 Then Down = True
        If (N Mod 16) Then Left = True
        If N Mod 16 <> 15 Then Right = True

        If Up Then Iterative(N - 16)
        If Up And Right Then Iterative(N - 15)
        If Right Then Iterative(N + 1)
        If Right And Down Then Iterative(N + 17)
        If Down Then Iterative(N + 16)
        If Down And Left Then Iterative(N + 15)
        If Left Then Iterative(N - 1)
        If Left And Up Then Iterative(N - 17)


    End Sub
    Private Sub ShowMine(ByVal N As Int32)

        B(N).Enabled = False

        Dim S As Int32 = Surround(N)

        If S Then B(N).Text = S

        Select Case Surround(N)
            Case 0
                B(N).BackColor = Color.AliceBlue
            Case 1
                B(N).BackColor = Color.SkyBlue
            Case 2
                B(N).BackColor = Color.LightGreen
            Case 3
                B(N).BackColor = Color.PeachPuff
            Case 4
                B(N).BackColor = Color.Plum
            Case 5
                B(N).BackColor = Color.SlateBlue
            Case 6
                B(N).BackColor = Color.Crimson
            Case 7
                B(N).BackColor = Color.SlateBlue
            Case 8
                B(N).BackColor = Color.Crimson
        End Select

    End Sub
    Private Sub InitiateGrid()
        Dim T As Int32

        For T = 0 To 255
            B(T) = New Button
            B(T).FlatStyle = FlatStyle.Popup

            B(T).Size = New Point(25, 25)
            B(T).Location = New Point(Border.Left + 10 + 28 * (T Mod 16), Border.Top + 15 + (T \ 16) * 28)
            B(T).Tag = T
            B(T).BackgroundImageLayout = ImageLayout.Center
            Controls.Add(B(T))
            B(T).BringToFront()

            AddHandler B(T).Click, New EventHandler(AddressOf MineClick)

        Next T
    End Sub

    Public Function f(ByVal x As Double) As Double
        Return Math.Sqrt(x) + Math.Cos(x)
    End Function
    Private Sub NewGame(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click, NewGameToolStripMenuItem.Click

        'New Game

        ToolStripButton1.Image = My.Resources.happy
        NewGameToolStripMenuItem.Image = My.Resources.happy
        Me.Refresh()

        Dim T As Int32
        Dim N As Int32

        For T = 0 To 255
            M(T) = 0
        Next

        Randomize()

        For T = 1 To 40

            N = Rnd() * 255

            Do While (M(N) = 1)
                N = Rnd() * 255
            Loop

            M(N) = 1

        Next

        For T = 0 To 255

            B(T).BackColor = Nothing
            B(T).BackgroundImage = Nothing
            B(T).Image = Nothing
            B(T).Text = ""
            B(T).Enabled = True

        Next

        MinesCleared = 0

        If GameMode1.Checked Then TargetMines = 25
        If GameMode2.Checked Then TargetMines = 30
        If GameMode3.Checked Then TargetMines = 35


        Me.RemainingMinesLbl.Text = Format(TargetMines - MinesCleared, "Remaining Mines : 0")

        Sweeps = 0

        Me.SweepsLbl.Text = Format(Sweeps, "Sweeps : 0")


    End Sub

    Private Sub Resign(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click, ShowMinesToolStripMenuItem.Click

        If MinesCleared = TargetMines Then Exit Sub

        If Not IsNothing(sender) Then

            'This will display the confirmation dialog if this function was invoked by clicking the resign button

            Dim A As MsgBoxResult

            A = MsgBox("Are you sure you want to resign?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Resign")

            If A = MsgBoxResult.No Then Exit Sub

        End If

        ToolStripButton1.Image = My.Resources.oops
        NewGameToolStripMenuItem.Image = My.Resources.oops


        Me.Refresh()


        Dim t As Int32
        For t = 0 To 255
            If M(t) Then

                B(t).BackgroundImage = My.Resources.Minesweeper
                B(t).ImageAlign = ContentAlignment.MiddleCenter

            Else

                'Detecting false mine flags

                If Not IsNothing(B(t).BackgroundImage) Then

                End If

            End If
            B(t).Enabled = False
        Next
        '        GameOverLabel.Visible = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InitiateGrid()

        My.Settings.Reload()

        Select Case My.Settings.DefaultMode

            Case 1
                GameMode1.Checked = True
                TargetMines = 25
            Case 2
                GameMode2.Checked = True
                TargetMines = 30
            Case 3
                GameMode3.Checked = True
                TargetMines = 35

        End Select

        If My.Settings.Sounds Then EnabledToolStripMenuItem.Checked = True Else DisabledToolStripMenuItem.Checked = True

        NewGame(Nothing, Nothing) 'NewGame

    End Sub

    Private Sub About(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ExitGame(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BeginnerMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameMode1.Click

        If GameMode1.Checked Then Exit Sub

        GameMode1.Checked = True
        GameMode2.Checked = False
        GameMode3.Checked = False

        If MinesCleared Then
            Dim A As MsgBoxResult
            A = MsgBox("This change will take effect the next time you start a game, do you wish to restart the current game?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Game Mode Change")
            If A = MsgBoxResult.Yes Then NewGame(Nothing, Nothing)
        Else
            NewGame(Nothing, Nothing)
        End If

        My.Settings.DefaultMode = 1
        My.Settings.Save()

    End Sub

    Private Sub IntermediateMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameMode2.Click

        If GameMode2.Checked Then Exit Sub

        GameMode1.Checked = False
        GameMode2.Checked = True
        GameMode3.Checked = False

        If MinesCleared Then
            Dim A As MsgBoxResult
            A = MsgBox("This change will take effect the next time you start a game, do you wish to restart the current game?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Game Mode Change")
            If A = MsgBoxResult.Yes Then NewGame(Nothing, Nothing)
        Else
            NewGame(Nothing, Nothing)
        End If

        My.Settings.DefaultMode = 2
        My.Settings.Save()

    End Sub

    Private Sub ExperMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameMode3.Click

        If GameMode3.Checked Then Exit Sub

        GameMode1.Checked = False
        GameMode2.Checked = False
        GameMode3.Checked = True

        If MinesCleared Then
            Dim A As MsgBoxResult
            A = MsgBox("This change will take effect the next time you start a game, do you wish to restart the current game?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Game Mode Change")
            If A = MsgBoxResult.Yes Then NewGame(Nothing, Nothing)
        Else
            NewGame(Nothing, Nothing)
        End If

        My.Settings.DefaultMode = 3
        My.Settings.Save()

    End Sub

    Private Sub HighScores(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighScoresToolStripMenuItem.Click

        Dim ScoreWindow As New Form2

        ScoreWindow.ShowDialog()

        ScoreWindow = Nothing

    End Sub

    Private Sub HowToPlay(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToPlayToolStripMenuItem.Click, ToolStripButton3.Click
        Form3.ShowDialog()
    End Sub

    Private Sub EnabledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnabledToolStripMenuItem.Click
        My.Settings.Sounds = True
        EnabledToolStripMenuItem.Checked = True
        DisabledToolStripMenuItem.Checked = False
    End Sub

    Private Sub DisabledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisabledToolStripMenuItem.Click
        My.Settings.Sounds = False
        EnabledToolStripMenuItem.Checked = False
        DisabledToolStripMenuItem.Checked = True
    End Sub


End Class