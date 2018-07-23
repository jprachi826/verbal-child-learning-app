Imports System.Speech
Imports System.Speech.Synthesis
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Form8
    Dim speaker As New SpeechSynthesizer()
    Dim strSay As String

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gb1.Visible = True
        TextBox1.Visible = True
        PictureBox1.Visible = False
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_listen.Click
        strSay = TextBox1.Text
        speaker.SpeakAsync(strSay)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        gb1.Visible = True
        TextBox1.Visible = False
        PictureBox1.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        gb1.Visible = False
        TextBox1.Visible = True
        PictureBox1.Visible = True
        TextBox1.Text = "Humpty dumpty sat on a wall
Humpty dumpty had a great fall;
All the king’s horses and all the king’s men
Couldn’t put humpty together again."
        PictureBox1.Image = ImageList1.Images(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gb1.Visible = False
        TextBox1.Visible = True
        TextBox1.Text = " Ring-a-ring o’ roses
A pocket full of posies
A-tishoo! a-tishoo!
We all fall down."
        PictureBox1.Image = ImageList1.Images(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gb1.Visible = False
        TextBox1.Visible = True
        TextBox1.Text = " Rain-rain go away,
Come again another day;
Little Johnny wants to play.
Rain, rain, go to Spain,
Do not show your face again."
        PictureBox1.Image = ImageList1.Images(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        gb1.Visible = False
        TextBox1.Visible = True
        TextBox1.Text = "A Rose Is Pink.
A Poppy Is Red.
The sky Is Blue.
A Swan Is White.
Pears are Yellow.
The Grass Is Green.
Clouds are Violet.
Why, an Orange!
Just an Orange?! "
        PictureBox1.Image = ImageList1.Images(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        gb1.Visible = False
        TextBox1.Visible = True
        TextBox1.Text = "Baa, Baa, Black Sheep…
Have you any wool?
Yes Sir, Yes Sir,
Three bags full.
One for my master,
One for my dame,
And one for the little boy
Who lives down the lane. "
        PictureBox1.Image = ImageList1.Images(4)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        gb1.Visible = False
        TextBox1.Visible = True
        TextBox1.Text = "BABY and I were baked in a pie, 
The gravy was wonderful hot! 
We had nothing to pay
To the baker that day, 
And so we crept out of the pot.  "
        PictureBox1.Image = ImageList1.Images(5)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        gb1.Visible = False
        TextBox1.Visible = True
        TextBox1.Text = "Clap your hands. 
Clap your hands. 
Listen to the music. 
And clap your hands. 
Stamp your feet. 
Stamp your feet. 
Listen to the music. 
And stamp your feet "
        PictureBox1.Image = ImageList1.Images(6)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        gb1.Visible = False
        TextBox1.Visible = True
        TextBox1.Text = "Come, let's to bed, 
Says Sleepy head : 
Tarry a while, says Slow. 
Put on the pot, 
Says Greedy-gut, 
We'll sup before we go. "
        PictureBox1.Image = ImageList1.Images(7)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        gb1.Visible = False
        TextBox1.Visible = True
        TextBox1.Text = "Chubby Cheeks, dimpled chin, 
Rosy lips, teeths within, 
Curly hair, very fair, 
Eyes so blue, lovely too, 
Teacher's pet, Is that you? 
Yes, Yes, Yes."
        PictureBox1.Image = ImageList1.Images(8)
    End Sub
End Class