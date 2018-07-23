Imports System.Speech
Imports System.Speech.Synthesis
Public Class Form5
    Dim speaker As New SpeechSynthesizer()
    Dim strSay As String
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "1"
        Else
            txtNum1.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "2"
        Else
            txtNum1.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "3"
        Else
            txtNum1.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "4"
        Else
            txtNum1.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "5"
        Else
            txtNum1.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "6"
        Else
            txtNum1.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "7"
        Else
            txtNum1.Text = 7
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "8"
        Else
            txtNum1.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "9"
        Else
            txtNum1.Text = "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtNum1.Text.Length = 1 Then
            txtNum2.Text = "0"
        Else
            txtNum1.Text = "0"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum1.Text = ""
        txtNum2.Text = ""
        txtAnswer.Text = ""
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        lblSign.Text = "+"

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        lblSign.Text = "-"

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If lblSign.Text = "+" Then
            txtAnswer.Text = (CInt(txtNum1.Text) + CInt(txtNum2.Text))
            strSay = txtAnswer.Text
            speaker.SpeakAsync(strSay)
        Else
            If CInt(txtNum1.Text) >= CInt(txtNum2.Text) Then
                txtAnswer.Text = (CInt(txtNum1.Text) - CInt(txtNum2.Text))
                strSay = txtAnswer.Text
                speaker.SpeakAsync(strSay)
            Else
                MessageBox.Show("First number must be" & vbCrLf &
                                    "larger than the second number.")
                btnClear.PerformClick()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class