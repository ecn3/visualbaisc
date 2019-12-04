Public Class Form2

    Dim chosenDuck = My.Resources.plainYellowDuck

    Private Sub spaceBtn_Click(sender As Object, e As EventArgs) Handles spaceBtn.Click
        themeDuck.Image = My.Resources.spaceDuck
        chosenDuck = My.Resources.spaceDuck
    End Sub

    Private Sub CowBoyBtn_Click(sender As Object, e As EventArgs) Handles CowBoyBtn.Click
        themeDuck.Image = My.Resources.cowboyDuck
        chosenDuck = My.Resources.cowboyDuck
    End Sub

    Private Sub turleBtn_Click(sender As Object, e As EventArgs) Handles turleBtn.Click
        themeDuck.Image = My.Resources.turtleDuck
        chosenDuck = My.Resources.turtleDuck
    End Sub

    Private Sub sportBtn_Click(sender As Object, e As EventArgs) Handles sportBtn.Click
        themeDuck.Image = My.Resources.sportsDuck
        chosenDuck = My.Resources.sportsDuck
    End Sub

    Private Sub politicianDuck_Click(sender As Object, e As EventArgs) Handles politicianDuck.Click
        themeDuck.Image = My.Resources.presidentDuck
        chosenDuck = My.Resources.presidentDuck
    End Sub

    Private Sub heroBtn_Click(sender As Object, e As EventArgs) Handles heroBtn.Click
        themeDuck.Image = My.Resources.heroDuck
        chosenDuck = My.Resources.heroDuck
    End Sub

    Private Sub artBtn_Click(sender As Object, e As EventArgs) Handles artBtn.Click
        themeDuck.Image = My.Resources.artisitDuck
        chosenDuck = My.Resources.artisitDuck
    End Sub

    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        Form1.pic.Image = chosenDuck
        Me.Close()
    End Sub
End Class