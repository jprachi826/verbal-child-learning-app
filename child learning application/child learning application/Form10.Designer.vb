<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AppDataSet = New child_leaning_application.appDataSet()
        Me.ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfileTableAdapter = New child_leaning_application.appDataSetTableAdapters.profileTableAdapter()
        CType(Me.AppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(312, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hello,"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Font = New System.Drawing.Font("Goudy Stout", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(916, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tap to choose any of the button below"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe Script", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.Location = New System.Drawing.Point(225, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Learning Alphabets"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe Script", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Button2.Location = New System.Drawing.Point(591, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 57)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Play With Numbers"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Segoe Script", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Button3.Location = New System.Drawing.Point(225, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(247, 53)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Fun With Fruits"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Segoe Script", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Button4.Location = New System.Drawing.Point(591, 296)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(240, 53)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Real Animals"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Segoe Script", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Button5.Location = New System.Drawing.Point(225, 420)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(247, 52)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Listening Time"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Segoe Script", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Button6.Location = New System.Drawing.Point(591, 420)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(240, 52)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Quit"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label3.Font = New System.Drawing.Font("Goudy Stout", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 28)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "NAME"
        '
        'AppDataSet
        '
        Me.AppDataSet.DataSetName = "appDataSet"
        Me.AppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfileBindingSource
        '
        Me.ProfileBindingSource.DataMember = "profile"
        Me.ProfileBindingSource.DataSource = Me.AppDataSet
        '
        'ProfileTableAdapter
        '
        Me.ProfileTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.child_leaning_application.My.Resources.Resources.images__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 524)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.AppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents AppDataSet As appDataSet
    Friend WithEvents ProfileBindingSource As BindingSource
    Friend WithEvents ProfileTableAdapter As appDataSetTableAdapters.profileTableAdapter
End Class
