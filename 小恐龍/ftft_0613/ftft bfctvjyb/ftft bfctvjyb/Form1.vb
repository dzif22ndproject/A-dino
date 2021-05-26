Public Class Form1
    Dim xiaolong As Integer = 0
    Dim gravity As Integer = 5
    Dim pipe(4) As PictureBox
    Dim pipe1(4) As PictureBox

    Dim bigtree As Integer
    Dim player1 As New WMPLib.WindowsMediaPlayer
    Dim replay As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        xiaolong += gravity

        PictureBox1.Top += xiaolong
        If PictureBox1.Top < 250 Then
            PictureBox1.Top += xiaolong
        Else
            PictureBox1.Top = 250

        End If
        For a = 0 To 3
            pipe(a).Left -= 10
            If pipe(a).Left < 0 Then
                pipe(a).Left += 400
                pipe(a).Height = 70 + 100 * Rnd()
                pipe(a).Top = 300 - pipe(a).Height
            End If


            If PictureBox1.Left + PictureBox1.Width / 2 > pipe(a).Left + 10 And
               PictureBox1.Left + PictureBox1.Width / 2 < pipe(a).Left + pipe(a).Width - 10 And
                PictureBox1.Top + PictureBox1.Height / 2 > pipe(a).Top And
                PictureBox1.Top + PictureBox1.Height / 2 < pipe(a).Top + pipe(3).Height Then

                PictureBox1.Image = PictureBox6.Image
                Timer3.Enabled = False
                Timer1.Enabled = False
                replay = MsgBox("你死了!重玩嗎?", 32 + 4, "game over")
                If replay = 6 Then
                    Form2.Show()
                    Me.Close()



                Else
                    Me.Close()
                    Form2.Close()

                End If
            End If
        Next


        For b = 0 To 3
            pipe1(b).Left -= 10
            If pipe1(b).Left < 0 Then
                pipe1(b).Left += 400
                pipe1(b).Height = 70 + 50 * Rnd()
                pipe1(b).Top = 100 - pipe1(b).Height
            End If

            If PictureBox1.Left + PictureBox1.Width / 2 > pipe1(b).Left + 10 And
               PictureBox1.Left + PictureBox1.Width / 2 < pipe1(b).Left + pipe1(b).Width - 10 And
                PictureBox1.Top + PictureBox1.Height / 2 > pipe1(b).Top And
                PictureBox1.Top + PictureBox1.Height / 2 < pipe1(b).Top + pipe1(3).Height Then

                PictureBox1.Image = PictureBox6.Image

                Timer1.Enabled = False
                Timer3.Enabled = False
                replay = MsgBox("你死了!重玩嗎?", 32 + 4, "game over")
                If replay = 6 Then
                    Form2.Show()
                    Me.Close()



                Else
                    Me.Close()
                    Form2.Close()

                End If
            End If
        Next

        If PictureBox1.Top > 0 Then
            PictureBox1.Top += xiaolong
        Else
            PictureBox1.Top = 0

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer1.Enabled = False
        'CreatetopPipes(1
        pipe = {PictureBox2, PictureBox3, PictureBox4, PictureBox5}
        pipe1 = {PictureBox7, PictureBox8, PictureBox9, PictureBox10}
        player1.URL = My.Application.Info.DirectoryPath & "\IZONE (아이즈원) - FIESTA CLEAN INSTRUMENTAL.mp3"
        player1.settings.setMode("loop", True)
        'Timer3.Enabled = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, Button1.KeyDown
        If e.KeyCode = Keys.Space Then
            xiaolong = -15
        End If

    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick


        If ProgressBar1.Value < ProgressBar1.Maximum - 1 Then

            ProgressBar1.Value += 1
        Else
            Timer3.Enabled = False
            ProgressBar1.Value = ProgressBar1.Maximum
            Form3.Show()
            Timer1.Enabled = False


        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Visible = False
        Button1.Enabled = False
        Timer1.Enabled = True
        ProgressBar1.Value = ProgressBar1.Minimum
        Timer3.Enabled = True

        'ProgressBar1.Value += 2



    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub
End Class
