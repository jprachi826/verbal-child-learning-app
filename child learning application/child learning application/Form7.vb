Imports System.Speech
Imports System.Speech.Synthesis
Public Class Form7
    Dim speaker As New SpeechSynthesizer()
    Dim strSay As String
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        pbLetter.Image = ImageList1.Images(0)
        pbAnimal.Image = ImageList2.Images(0)
        txtSay.Text = "A is for apple"
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        pbLetter.Image = ImageList1.Images(1)
        pbAnimal.Image = ImageList2.Images(1)
        txtSay.Text = "B is for Banana"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        pbLetter.Image = ImageList1.Images(2)
        pbAnimal.Image = ImageList2.Images(2)
        txtSay.Text = "C is for coconut"
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        pbLetter.Image = ImageList1.Images(3)
        pbAnimal.Image = ImageList2.Images(3)
        txtSay.Text = "D is for durian"
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        pbLetter.Image = ImageList1.Images(4)
        pbAnimal.Image = ImageList2.Images(4)
        txtSay.Text = "E is for elderberry"
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        pbLetter.Image = ImageList1.Images(5)
        pbAnimal.Image = ImageList2.Images(5)
        txtSay.Text = "F is for fig"
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        pbLetter.Image = ImageList1.Images(6)
        pbAnimal.Image = ImageList2.Images(6)
        txtSay.Text = "G is for grapes"
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        pbLetter.Image = ImageList1.Images(7)
        pbAnimal.Image = ImageList2.Images(7)
        txtSay.Text = "H is for honeydew"
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        pbLetter.Image = ImageList1.Images(8)
        pbAnimal.Image = ImageList2.Images(8)
        txtSay.Text = "I is for iyokan"
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        pbLetter.Image = ImageList1.Images(9)
        pbAnimal.Image = ImageList2.Images(9)
        txtSay.Text = "J is for jujube"
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        pbLetter.Image = ImageList1.Images(10)
        pbAnimal.Image = ImageList2.Images(10)
        txtSay.Text = "K is for kiwi"
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        pbLetter.Image = ImageList1.Images(11)
        pbAnimal.Image = ImageList2.Images(11)
        txtSay.Text = "L is for lemon"
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        pbLetter.Image = ImageList1.Images(12)
        pbAnimal.Image = ImageList2.Images(12)
        txtSay.Text = "M is for mango"
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        pbLetter.Image = ImageList1.Images(13)
        pbAnimal.Image = ImageList2.Images(13)
        txtSay.Text = "N is for nectarine"
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        pbLetter.Image = ImageList1.Images(14)
        pbAnimal.Image = ImageList2.Images(14)
        txtSay.Text = "O is for orange"
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        pbLetter.Image = ImageList1.Images(15)
        pbAnimal.Image = ImageList2.Images(15)
        txtSay.Text = "P is for papaya"
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        pbLetter.Image = ImageList1.Images(16)
        pbAnimal.Image = ImageList2.Images(16)
        txtSay.Text = "Q is for quince"
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        pbLetter.Image = ImageList1.Images(17)
        pbAnimal.Image = ImageList2.Images(17)
        txtSay.Text = "R is for rambutan"
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        pbLetter.Image = ImageList1.Images(18)
        pbAnimal.Image = ImageList2.Images(18)
        txtSay.Text = "S is for soursop"
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        pbLetter.Image = ImageList1.Images(19)
        pbAnimal.Image = ImageList2.Images(19)
        txtSay.Text = "T is for tomato"
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        pbLetter.Image = ImageList1.Images(20)
        pbAnimal.Image = ImageList2.Images(20)
        txtSay.Text = "U is for ugli"
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        pbLetter.Image = ImageList1.Images(21)
        pbAnimal.Image = ImageList2.Images(21)
        txtSay.Text = "V is for velvet tarmarind"
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        pbLetter.Image = ImageList1.Images(22)
        pbAnimal.Image = ImageList2.Images(22)
        txtSay.Text = "W is for Wax jambu"
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        pbLetter.Image = ImageList1.Images(23)
        pbAnimal.Image = ImageList2.Images(23)
        txtSay.Text = "X is for ximenia"
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        pbLetter.Image = ImageList1.Images(24)
        pbAnimal.Image = ImageList2.Images(24)
        txtSay.Text = "Y is for Yumberry"
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        pbAnimal.Image = ImageList2.Images(25)
        pbAnimal.Image = ImageList2.Images(25)
        txtSay.Text = "Z is for zucchini"
    End Sub

    Private Sub btnClearSay_Click(sender As Object, e As EventArgs) Handles btnClearSay.Click
        txtSay.Text = "  "
        pbAnimal.Image = Nothing
        pbLetter.Image = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnSay_Click(sender As Object, e As EventArgs) Handles btnSay.Click
        strSay = txtSay.Text
        speaker.SpeakAsync(strSay)
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class