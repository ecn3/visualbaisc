Public Class Form1
    Public Shared firstName As String = ""
    Public Shared todaysDate() As String
    Public Shared birthDate() As String
    Public Shared todaysDay As Integer = 0
    Public Shared todaysMonth As Integer = 0
    Public Shared todaysYear As Integer = 0
    Public Shared birthDay As Integer = 0
    Public Shared birthMonth As Integer = 0
    Public Shared birthYear As Integer = 0
    Public Shared totalDaysAlive As Integer = 0
    Public Shared daysAlive As Integer = 0
    Public Shared monthsAlive As Integer = 0
    Public Shared yearsAlive As Integer = 0
    Public Shared hoursExercised As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = "" '// hourse exercised
        TextBox1.Text = ""
        TextBox2.Text = "11/23/2019"
        TextBox3.Text = "11/23/2019"
        totalDaysAlive = 0
        hoursExercised = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalDaysAlive = 0
        hoursExercised = 0

        todaysDate = TextBox2.Text.Split("/") '//break up date
        birthDate = TextBox3.Text.Split("/")

        todaysDay = Integer.Parse(todaysDate(0))
        todaysMonth = Integer.Parse(todaysDate(1))
        todaysYear = Integer.Parse(todaysDate(2))

        birthDay = Integer.Parse(birthDate(0))
        birthMonth = Integer.Parse(birthDate(1))
        birthYear = Integer.Parse(birthDate(2))

        yearsAlive = todaysYear - birthYear
        totalDaysAlive += yearsAlive * 365

        daysAlive = todaysMonth - birthMonth
        totalDaysAlive += daysAlive

        monthsAlive = todaysDay - birthDay
        totalDaysAlive += monthsAlive * 30

        hoursExercised = totalDaysAlive * 2.5

        Label5.Text = hoursExercised

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
