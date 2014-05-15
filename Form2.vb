Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BeginnerLbl1.Text = My.Settings.BeginnerNam1
        Me.BeginnerLbl2.Text = My.Settings.BeginnerNam2
        Me.BeginnerLbl3.Text = My.Settings.BeginnerNam3

        Me.BeginnerLbl4.Text = Format(My.Settings.BeginnerSweeps1, "0 sweeps")
        Me.BeginnerLbl5.Text = Format(My.Settings.BeginnerSweeps2, "0 sweeps")
        Me.BeginnerLbl6.Text = Format(My.Settings.BeginnerSweeps3, "0 sweeps")

        Me.IntermediateLbl1.Text = My.Settings.IntermediateNam1
        Me.IntermediateLbl2.Text = My.Settings.IntermediateNam2
        Me.IntermediateLbl3.Text = My.Settings.IntermediateNam3

        Me.IntermediateLbl4.Text = Format(My.Settings.IntermediateSweeps1, "0 sweeps")
        Me.IntermediateLbl5.Text = Format(My.Settings.IntermediateSweeps2, "0 sweeps")
        Me.IntermediateLbl6.Text = Format(My.Settings.IntermediateSweeps3, "0 sweeps")

        Me.ExpertLbl1.Text = My.Settings.ExpertNam1
        Me.ExpertLbl2.Text = My.Settings.ExpertNam2
        Me.ExpertLbl3.Text = My.Settings.ExpertNam3

        Me.ExpertLbl4.Text = Format(My.Settings.ExpertSweeps1, "0 sweeps")
        Me.ExpertLbl5.Text = Format(My.Settings.ExpertSweeps2, "0 sweeps")
        Me.ExpertLbl6.Text = Format(My.Settings.ExpertSweeps3, "0 sweeps")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim A As MsgBoxResult
        A = MsgBox("Are you sure you want to clear your high scores records?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Confirm")
        If A = MsgBoxResult.Yes Then
            My.Settings.Reset()
            Form2_Load(Nothing, Nothing)
        End If
    End Sub
End Class