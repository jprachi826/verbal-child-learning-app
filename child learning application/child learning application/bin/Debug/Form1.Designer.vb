<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.strtbtn = New System.Windows.Forms.Button()
        Me.extbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 70)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tap and Learn"
        '
        'strtbtn
        '
        Me.strtbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.strtbtn.AutoSize = True
        Me.strtbtn.Font = New System.Drawing.Font("Goudy Stout", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strtbtn.Location = New System.Drawing.Point(12, 382)
        Me.strtbtn.Name = "strtbtn"
        Me.strtbtn.Size = New System.Drawing.Size(131, 41)
        Me.strtbtn.TabIndex = 2
        Me.strtbtn.Text = "START"
        Me.strtbtn.UseVisualStyleBackColor = True
        '
        'extbtn
        '
        Me.extbtn.AutoSize = True
        Me.extbtn.Font = New System.Drawing.Font("Goudy Stout", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extbtn.Location = New System.Drawing.Point(654, 382)
        Me.extbtn.Name = "extbtn"
        Me.extbtn.Size = New System.Drawing.Size(113, 41)
        Me.extbtn.TabIndex = 3
        Me.extbtn.Text = "EXIT"
        Me.extbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.child_leaning_application.My.Resources.Resources.jyj
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(779, 459)
        Me.Controls.Add(Me.extbtn)
        Me.Controls.Add(Me.strtbtn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents strtbtn As Button
    Friend WithEvents extbtn As Button
End Class
