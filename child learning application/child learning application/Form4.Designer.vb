<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbAlphabet = New System.Windows.Forms.GroupBox()
        Me.btnSay = New System.Windows.Forms.Button()
        Me.btnClearSay = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.txtSay = New System.Windows.Forms.TextBox()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.pbAnimal = New System.Windows.Forms.PictureBox()
        Me.lblIsFor = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pbLetter = New System.Windows.Forms.PictureBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbAlphabet.SuspendLayout()
        CType(Me.pbAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Learning Alphabets"
        '
        'gbAlphabet
        '
        Me.gbAlphabet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAlphabet.BackColor = System.Drawing.Color.LightCyan
        Me.gbAlphabet.Controls.Add(Me.btnSay)
        Me.gbAlphabet.Controls.Add(Me.btnClearSay)
        Me.gbAlphabet.Controls.Add(Me.btnZ)
        Me.gbAlphabet.Controls.Add(Me.btnY)
        Me.gbAlphabet.Controls.Add(Me.btnX)
        Me.gbAlphabet.Controls.Add(Me.btnW)
        Me.gbAlphabet.Controls.Add(Me.txtSay)
        Me.gbAlphabet.Controls.Add(Me.btnV)
        Me.gbAlphabet.Controls.Add(Me.btnU)
        Me.gbAlphabet.Controls.Add(Me.btnT)
        Me.gbAlphabet.Controls.Add(Me.btnS)
        Me.gbAlphabet.Controls.Add(Me.btnR)
        Me.gbAlphabet.Controls.Add(Me.btnQ)
        Me.gbAlphabet.Controls.Add(Me.btnP)
        Me.gbAlphabet.Controls.Add(Me.btnO)
        Me.gbAlphabet.Controls.Add(Me.btnN)
        Me.gbAlphabet.Controls.Add(Me.btnM)
        Me.gbAlphabet.Controls.Add(Me.btnL)
        Me.gbAlphabet.Controls.Add(Me.btnK)
        Me.gbAlphabet.Controls.Add(Me.btnJ)
        Me.gbAlphabet.Controls.Add(Me.btnI)
        Me.gbAlphabet.Controls.Add(Me.btnH)
        Me.gbAlphabet.Controls.Add(Me.btnG)
        Me.gbAlphabet.Controls.Add(Me.btnF)
        Me.gbAlphabet.Controls.Add(Me.btnE)
        Me.gbAlphabet.Controls.Add(Me.btnD)
        Me.gbAlphabet.Controls.Add(Me.btnC)
        Me.gbAlphabet.Controls.Add(Me.btnB)
        Me.gbAlphabet.Controls.Add(Me.btnA)
        Me.gbAlphabet.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbAlphabet.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAlphabet.ForeColor = System.Drawing.Color.Red
        Me.gbAlphabet.Location = New System.Drawing.Point(140, 119)
        Me.gbAlphabet.Name = "gbAlphabet"
        Me.gbAlphabet.Size = New System.Drawing.Size(609, 221)
        Me.gbAlphabet.TabIndex = 4
        Me.gbAlphabet.TabStop = False
        '
        'btnSay
        '
        Me.btnSay.BackColor = System.Drawing.Color.White
        Me.btnSay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSay.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSay.ForeColor = System.Drawing.Color.Blue
        Me.btnSay.Location = New System.Drawing.Point(385, 161)
        Me.btnSay.Name = "btnSay"
        Me.btnSay.Size = New System.Drawing.Size(95, 45)
        Me.btnSay.TabIndex = 27
        Me.btnSay.Text = "Say"
        Me.btnSay.UseVisualStyleBackColor = False
        '
        'btnClearSay
        '
        Me.btnClearSay.BackColor = System.Drawing.Color.White
        Me.btnClearSay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearSay.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSay.ForeColor = System.Drawing.Color.Blue
        Me.btnClearSay.Location = New System.Drawing.Point(497, 161)
        Me.btnClearSay.Name = "btnClearSay"
        Me.btnClearSay.Size = New System.Drawing.Size(95, 45)
        Me.btnClearSay.TabIndex = 26
        Me.btnClearSay.Text = "Clear"
        Me.btnClearSay.UseVisualStyleBackColor = False
        '
        'btnZ
        '
        Me.btnZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZ.ForeColor = System.Drawing.Color.LightGreen
        Me.btnZ.Location = New System.Drawing.Point(554, 96)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(38, 50)
        Me.btnZ.TabIndex = 25
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = False
        '
        'btnY
        '
        Me.btnY.BackColor = System.Drawing.Color.SteelBlue
        Me.btnY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnY.Location = New System.Drawing.Point(510, 96)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(38, 50)
        Me.btnY.TabIndex = 24
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = False
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.LightGreen
        Me.btnX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnX.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnX.Location = New System.Drawing.Point(466, 96)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(38, 50)
        Me.btnX.TabIndex = 23
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'btnW
        '
        Me.btnW.BackColor = System.Drawing.Color.Fuchsia
        Me.btnW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnW.Location = New System.Drawing.Point(422, 96)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(38, 50)
        Me.btnW.TabIndex = 22
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = False
        '
        'txtSay
        '
        Me.txtSay.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSay.ForeColor = System.Drawing.Color.Blue
        Me.txtSay.Location = New System.Drawing.Point(26, 161)
        Me.txtSay.Name = "txtSay"
        Me.txtSay.Size = New System.Drawing.Size(353, 45)
        Me.txtSay.TabIndex = 7
        '
        'btnV
        '
        Me.btnV.BackColor = System.Drawing.Color.LightCyan
        Me.btnV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnV.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnV.Location = New System.Drawing.Point(378, 96)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(38, 50)
        Me.btnV.TabIndex = 21
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = False
        '
        'btnU
        '
        Me.btnU.BackColor = System.Drawing.Color.Yellow
        Me.btnU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnU.ForeColor = System.Drawing.Color.Gold
        Me.btnU.Location = New System.Drawing.Point(334, 96)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(38, 50)
        Me.btnU.TabIndex = 20
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = False
        '
        'btnT
        '
        Me.btnT.BackColor = System.Drawing.Color.MediumBlue
        Me.btnT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnT.Location = New System.Drawing.Point(290, 96)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(38, 50)
        Me.btnT.TabIndex = 19
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = False
        '
        'btnS
        '
        Me.btnS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnS.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btnS.Location = New System.Drawing.Point(246, 96)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(38, 50)
        Me.btnS.TabIndex = 18
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = False
        '
        'btnR
        '
        Me.btnR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnR.ForeColor = System.Drawing.Color.DarkViolet
        Me.btnR.Location = New System.Drawing.Point(202, 96)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(38, 50)
        Me.btnR.TabIndex = 17
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = False
        '
        'btnQ
        '
        Me.btnQ.BackColor = System.Drawing.Color.Fuchsia
        Me.btnQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQ.ForeColor = System.Drawing.Color.Gold
        Me.btnQ.Location = New System.Drawing.Point(158, 96)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(38, 50)
        Me.btnQ.TabIndex = 16
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = False
        '
        'btnP
        '
        Me.btnP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnP.Location = New System.Drawing.Point(114, 96)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(38, 50)
        Me.btnP.TabIndex = 15
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = False
        '
        'btnO
        '
        Me.btnO.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnO.ForeColor = System.Drawing.Color.Red
        Me.btnO.Location = New System.Drawing.Point(70, 96)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(38, 50)
        Me.btnO.TabIndex = 14
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = False
        '
        'btnN
        '
        Me.btnN.BackColor = System.Drawing.Color.Yellow
        Me.btnN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnN.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnN.Location = New System.Drawing.Point(26, 96)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(38, 50)
        Me.btnN.TabIndex = 13
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = False
        '
        'btnM
        '
        Me.btnM.BackColor = System.Drawing.Color.MediumPurple
        Me.btnM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnM.ForeColor = System.Drawing.Color.DarkRed
        Me.btnM.Location = New System.Drawing.Point(554, 40)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(38, 50)
        Me.btnM.TabIndex = 12
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = False
        '
        'btnL
        '
        Me.btnL.BackColor = System.Drawing.Color.LightCyan
        Me.btnL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnL.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnL.Location = New System.Drawing.Point(510, 40)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(38, 50)
        Me.btnL.TabIndex = 11
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = False
        '
        'btnK
        '
        Me.btnK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnK.ForeColor = System.Drawing.Color.Gold
        Me.btnK.Location = New System.Drawing.Point(466, 40)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(38, 50)
        Me.btnK.TabIndex = 10
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = False
        '
        'btnJ
        '
        Me.btnJ.BackColor = System.Drawing.Color.MediumPurple
        Me.btnJ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnJ.Location = New System.Drawing.Point(422, 40)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(38, 50)
        Me.btnJ.TabIndex = 9
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = False
        '
        'btnI
        '
        Me.btnI.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnI.ForeColor = System.Drawing.Color.Cyan
        Me.btnI.Location = New System.Drawing.Point(378, 40)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(38, 50)
        Me.btnI.TabIndex = 8
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = False
        '
        'btnH
        '
        Me.btnH.BackColor = System.Drawing.Color.PowderBlue
        Me.btnH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnH.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnH.Location = New System.Drawing.Point(334, 40)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(38, 50)
        Me.btnH.TabIndex = 7
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = False
        '
        'btnG
        '
        Me.btnG.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnG.ForeColor = System.Drawing.Color.Yellow
        Me.btnG.Location = New System.Drawing.Point(290, 40)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(38, 50)
        Me.btnG.TabIndex = 6
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = False
        '
        'btnF
        '
        Me.btnF.BackColor = System.Drawing.Color.LightGreen
        Me.btnF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF.ForeColor = System.Drawing.Color.Yellow
        Me.btnF.Location = New System.Drawing.Point(246, 40)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(38, 50)
        Me.btnF.TabIndex = 5
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = False
        '
        'btnE
        '
        Me.btnE.BackColor = System.Drawing.Color.MediumPurple
        Me.btnE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnE.Location = New System.Drawing.Point(202, 40)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(38, 50)
        Me.btnE.TabIndex = 4
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.Color.Fuchsia
        Me.btnD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnD.ForeColor = System.Drawing.Color.Blue
        Me.btnD.Location = New System.Drawing.Point(158, 40)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(38, 50)
        Me.btnD.TabIndex = 3
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Yellow
        Me.btnC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC.ForeColor = System.Drawing.Color.Red
        Me.btnC.Location = New System.Drawing.Point(114, 40)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(38, 50)
        Me.btnC.TabIndex = 2
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnB.Location = New System.Drawing.Point(70, 40)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(38, 50)
        Me.btnB.TabIndex = 1
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnA.Location = New System.Drawing.Point(26, 40)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(38, 50)
        Me.btnA.TabIndex = 0
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'pbAnimal
        '
        Me.pbAnimal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAnimal.BackColor = System.Drawing.Color.DimGray
        Me.pbAnimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbAnimal.Location = New System.Drawing.Point(650, 469)
        Me.pbAnimal.Name = "pbAnimal"
        Me.pbAnimal.Size = New System.Drawing.Size(222, 217)
        Me.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAnimal.TabIndex = 6
        Me.pbAnimal.TabStop = False
        '
        'lblIsFor
        '
        Me.lblIsFor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIsFor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblIsFor.Font = New System.Drawing.Font("Comic Sans MS", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsFor.Location = New System.Drawing.Point(257, 515)
        Me.lblIsFor.Name = "lblIsFor"
        Me.lblIsFor.Size = New System.Drawing.Size(374, 134)
        Me.lblIsFor.TabIndex = 7
        Me.lblIsFor.Text = "Is For"
        Me.lblIsFor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Aa.jpg")
        Me.ImageList1.Images.SetKeyName(1, "Bb.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Cc.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Dd.jpg")
        Me.ImageList1.Images.SetKeyName(4, "Ee.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Ff.jpg")
        Me.ImageList1.Images.SetKeyName(6, "Gg.jpg")
        Me.ImageList1.Images.SetKeyName(7, "Hh.jpg")
        Me.ImageList1.Images.SetKeyName(8, "Ii.jpg")
        Me.ImageList1.Images.SetKeyName(9, "Jj.jpg")
        Me.ImageList1.Images.SetKeyName(10, "Kk.jpg")
        Me.ImageList1.Images.SetKeyName(11, "Ll.jpg")
        Me.ImageList1.Images.SetKeyName(12, "Mm.jpg")
        Me.ImageList1.Images.SetKeyName(13, "Nn.jpg")
        Me.ImageList1.Images.SetKeyName(14, "Oo.jpg")
        Me.ImageList1.Images.SetKeyName(15, "Pp.jpg")
        Me.ImageList1.Images.SetKeyName(16, "Qq.jpg")
        Me.ImageList1.Images.SetKeyName(17, "Rr.jpg")
        Me.ImageList1.Images.SetKeyName(18, "Ss.jpg")
        Me.ImageList1.Images.SetKeyName(19, "Tt.jpg")
        Me.ImageList1.Images.SetKeyName(20, "Uu.jpg")
        Me.ImageList1.Images.SetKeyName(21, "Vv.jpg")
        Me.ImageList1.Images.SetKeyName(22, "Ww.jpg")
        Me.ImageList1.Images.SetKeyName(23, "Xx.jpg")
        Me.ImageList1.Images.SetKeyName(24, "Yy.jpg")
        Me.ImageList1.Images.SetKeyName(25, "Zz.jpg")
        '
        'pbLetter
        '
        Me.pbLetter.BackColor = System.Drawing.Color.DimGray
        Me.pbLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLetter.Location = New System.Drawing.Point(2, 469)
        Me.pbLetter.Name = "pbLetter"
        Me.pbLetter.Size = New System.Drawing.Size(222, 217)
        Me.pbLetter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLetter.TabIndex = 8
        Me.pbLetter.TabStop = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "ants.gif")
        Me.ImageList2.Images.SetKeyName(1, "Bat.png")
        Me.ImageList2.Images.SetKeyName(2, "cat3.jpg")
        Me.ImageList2.Images.SetKeyName(3, "dog-book-lg.gif")
        Me.ImageList2.Images.SetKeyName(4, "elephant1.jpg")
        Me.ImageList2.Images.SetKeyName(5, "fish_.jpg")
        Me.ImageList2.Images.SetKeyName(6, "giraffe.jpg")
        Me.ImageList2.Images.SetKeyName(7, "hippo.jpg")
        Me.ImageList2.Images.SetKeyName(8, "iguana.jpg")
        Me.ImageList2.Images.SetKeyName(9, "jaguar.jpg")
        Me.ImageList2.Images.SetKeyName(10, "kangaroo.jpg")
        Me.ImageList2.Images.SetKeyName(11, "lion.jpg")
        Me.ImageList2.Images.SetKeyName(12, "monkey.gif")
        Me.ImageList2.Images.SetKeyName(13, "nurseshark.jpg")
        Me.ImageList2.Images.SetKeyName(14, "owl.jpg")
        Me.ImageList2.Images.SetKeyName(15, "panda.jpg")
        Me.ImageList2.Images.SetKeyName(16, "quail.jpg")
        Me.ImageList2.Images.SetKeyName(17, "rabbit.gif")
        Me.ImageList2.Images.SetKeyName(18, "snake.gif")
        Me.ImageList2.Images.SetKeyName(19, "tiger.gif")
        Me.ImageList2.Images.SetKeyName(20, "unicorn.jpg")
        Me.ImageList2.Images.SetKeyName(21, "vulture.gif")
        Me.ImageList2.Images.SetKeyName(22, "walrus.jpg")
        Me.ImageList2.Images.SetKeyName(23, "xray_fish.jpg")
        Me.ImageList2.Images.SetKeyName(24, "yak.jpg")
        Me.ImageList2.Images.SetKeyName(25, "zebra.jpg")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Jokerman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(741, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 57)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Main Menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.child_leaning_application.My.Resources.Resources.images__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(867, 685)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbLetter)
        Me.Controls.Add(Me.lblIsFor)
        Me.Controls.Add(Me.pbAnimal)
        Me.Controls.Add(Me.gbAlphabet)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form4"
        Me.Text = "Learning Alphabets"
        Me.gbAlphabet.ResumeLayout(False)
        Me.gbAlphabet.PerformLayout()
        CType(Me.pbAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLetter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbAlphabet As GroupBox
    Friend WithEvents btnSay As Button
    Friend WithEvents btnClearSay As Button
    Friend WithEvents btnZ As Button
    Friend WithEvents btnY As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnW As Button
    Friend WithEvents txtSay As TextBox
    Friend WithEvents btnV As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnA As Button
    Friend WithEvents pbAnimal As PictureBox
    Friend WithEvents lblIsFor As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents pbLetter As PictureBox
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Button1 As Button
End Class
