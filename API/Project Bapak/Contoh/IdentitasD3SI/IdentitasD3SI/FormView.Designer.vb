<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormView
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelNpm = New System.Windows.Forms.Label()
        Me.LabelTempat = New System.Windows.Forms.Label()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.LabelJurusan_Jenjang = New System.Windows.Forms.Label()
        Me.RbLaki = New System.Windows.Forms.RadioButton()
        Me.RbPere = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 270)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(251, 18)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(46, 18)
        Me.LabelNama.TabIndex = 3
        Me.LabelNama.Text = "Label1"
        '
        'LabelNpm
        '
        Me.LabelNpm.AutoSize = True
        Me.LabelNpm.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNpm.Location = New System.Drawing.Point(251, 47)
        Me.LabelNpm.Name = "LabelNpm"
        Me.LabelNpm.Size = New System.Drawing.Size(46, 18)
        Me.LabelNpm.TabIndex = 4
        Me.LabelNpm.Text = "Label1"
        '
        'LabelTempat
        '
        Me.LabelTempat.AutoSize = True
        Me.LabelTempat.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTempat.Location = New System.Drawing.Point(251, 78)
        Me.LabelTempat.Name = "LabelTempat"
        Me.LabelTempat.Size = New System.Drawing.Size(46, 18)
        Me.LabelTempat.TabIndex = 5
        Me.LabelTempat.Text = "Label1"
        '
        'LabelTanggal
        '
        Me.LabelTanggal.AutoSize = True
        Me.LabelTanggal.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTanggal.Location = New System.Drawing.Point(251, 105)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(46, 18)
        Me.LabelTanggal.TabIndex = 6
        Me.LabelTanggal.Text = "Label1"
        '
        'LabelJurusan_Jenjang
        '
        Me.LabelJurusan_Jenjang.AutoSize = True
        Me.LabelJurusan_Jenjang.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJurusan_Jenjang.Location = New System.Drawing.Point(251, 137)
        Me.LabelJurusan_Jenjang.Name = "LabelJurusan_Jenjang"
        Me.LabelJurusan_Jenjang.Size = New System.Drawing.Size(46, 18)
        Me.LabelJurusan_Jenjang.TabIndex = 7
        Me.LabelJurusan_Jenjang.Text = "Label1"
        '
        'RbLaki
        '
        Me.RbLaki.AutoSize = True
        Me.RbLaki.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLaki.Location = New System.Drawing.Point(254, 165)
        Me.RbLaki.Name = "RbLaki"
        Me.RbLaki.Size = New System.Drawing.Size(78, 22)
        Me.RbLaki.TabIndex = 8
        Me.RbLaki.TabStop = True
        Me.RbLaki.Text = "Laki-Laki"
        Me.RbLaki.UseVisualStyleBackColor = True
        '
        'RbPere
        '
        Me.RbPere.AutoSize = True
        Me.RbPere.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPere.Location = New System.Drawing.Point(338, 165)
        Me.RbPere.Name = "RbPere"
        Me.RbPere.Size = New System.Drawing.Size(92, 22)
        Me.RbPere.TabIndex = 9
        Me.RbPere.TabStop = True
        Me.RbPere.Text = "Perempuan"
        Me.RbPere.UseVisualStyleBackColor = True
        '
        'FormView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 280)
        Me.Controls.Add(Me.RbPere)
        Me.Controls.Add(Me.RbLaki)
        Me.Controls.Add(Me.LabelJurusan_Jenjang)
        Me.Controls.Add(Me.LabelTanggal)
        Me.Controls.Add(Me.LabelTempat)
        Me.Controls.Add(Me.LabelNpm)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormView"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelNama As System.Windows.Forms.Label
    Friend WithEvents LabelNpm As System.Windows.Forms.Label
    Friend WithEvents LabelTempat As System.Windows.Forms.Label
    Friend WithEvents LabelTanggal As System.Windows.Forms.Label
    Friend WithEvents LabelJurusan_Jenjang As System.Windows.Forms.Label
    Friend WithEvents RbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents RbPere As System.Windows.Forms.RadioButton
End Class
