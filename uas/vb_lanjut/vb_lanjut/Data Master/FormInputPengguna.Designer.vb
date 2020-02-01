<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputPengguna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputPengguna))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckShow = New System.Windows.Forms.CheckBox()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipe = New System.Windows.Forms.ComboBox()
        Me.tPass = New System.Windows.Forms.TextBox()
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bSimpan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bBatal = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GridPengguna = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckPenyewaan = New System.Windows.Forms.CheckBox()
        Me.ckJasa = New System.Windows.Forms.CheckBox()
        Me.ckFasilitas = New System.Windows.Forms.CheckBox()
        Me.ckKategori = New System.Windows.Forms.CheckBox()
        Me.ckPengguna = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckShow)
        Me.GroupBox1.Controls.Add(Me.tID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbTipe)
        Me.GroupBox1.Controls.Add(Me.tPass)
        Me.GroupBox1.Controls.Add(Me.tUsername)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 155)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'ckShow
        '
        Me.ckShow.AutoSize = True
        Me.ckShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckShow.Location = New System.Drawing.Point(299, 83)
        Me.ckShow.Name = "ckShow"
        Me.ckShow.Size = New System.Drawing.Size(68, 24)
        Me.ckShow.TabIndex = 10
        Me.ckShow.Text = "Show"
        Me.ckShow.UseVisualStyleBackColor = True
        '
        'tID
        '
        Me.tID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tID.Location = New System.Drawing.Point(119, 14)
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(248, 26)
        Me.tID.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID.Pengguna"
        '
        'cbTipe
        '
        Me.cbTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipe.FormattingEnabled = True
        Me.cbTipe.Items.AddRange(New Object() {"Administrator", "Pengguna Biasa"})
        Me.cbTipe.Location = New System.Drawing.Point(119, 114)
        Me.cbTipe.Name = "cbTipe"
        Me.cbTipe.Size = New System.Drawing.Size(248, 28)
        Me.cbTipe.TabIndex = 7
        '
        'tPass
        '
        Me.tPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPass.Location = New System.Drawing.Point(119, 81)
        Me.tPass.Name = "tPass"
        Me.tPass.Size = New System.Drawing.Size(174, 26)
        Me.tPass.TabIndex = 6
        Me.tPass.UseSystemPasswordChar = True
        '
        'tUsername
        '
        Me.tUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsername.Location = New System.Drawing.Point(119, 48)
        Me.tUsername.Name = "tUsername"
        Me.tUsername.Size = New System.Drawing.Size(248, 26)
        Me.tUsername.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipe Pengguna"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ToolStrip1)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 313)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(374, 67)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bSimpan, Me.ToolStripSeparator1, Me.bBatal})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(368, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bSimpan
        '
        Me.bSimpan.Image = CType(resources.GetObject("bSimpan.Image"), System.Drawing.Image)
        Me.bSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(105, 36)
        Me.bSimpan.Text = "Simpan"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'bBatal
        '
        Me.bBatal.Image = CType(resources.GetObject("bBatal.Image"), System.Drawing.Image)
        Me.bBatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bBatal.Name = "bBatal"
        Me.bBatal.Size = New System.Drawing.Size(87, 36)
        Me.bBatal.Text = "Batal"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridPengguna)
        Me.GroupBox4.Location = New System.Drawing.Point(391, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(959, 704)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'GridPengguna
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPengguna.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GridPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridPengguna.DefaultCellStyle = DataGridViewCellStyle8
        Me.GridPengguna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPengguna.Location = New System.Drawing.Point(3, 16)
        Me.GridPengguna.Name = "GridPengguna"
        Me.GridPengguna.Size = New System.Drawing.Size(953, 685)
        Me.GridPengguna.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckPenyewaan)
        Me.GroupBox2.Controls.Add(Me.ckJasa)
        Me.GroupBox2.Controls.Add(Me.ckFasilitas)
        Me.GroupBox2.Controls.Add(Me.ckKategori)
        Me.GroupBox2.Controls.Add(Me.ckPengguna)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 120)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'ckPenyewaan
        '
        Me.ckPenyewaan.AutoSize = True
        Me.ckPenyewaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPenyewaan.Location = New System.Drawing.Point(218, 19)
        Me.ckPenyewaan.Name = "ckPenyewaan"
        Me.ckPenyewaan.Size = New System.Drawing.Size(98, 20)
        Me.ckPenyewaan.TabIndex = 4
        Me.ckPenyewaan.Text = "Penyewaan"
        Me.ckPenyewaan.UseVisualStyleBackColor = True
        '
        'ckJasa
        '
        Me.ckJasa.AutoSize = True
        Me.ckJasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckJasa.Location = New System.Drawing.Point(119, 47)
        Me.ckJasa.Name = "ckJasa"
        Me.ckJasa.Size = New System.Drawing.Size(57, 20)
        Me.ckJasa.TabIndex = 3
        Me.ckJasa.Text = "Jasa"
        Me.ckJasa.UseVisualStyleBackColor = True
        '
        'ckFasilitas
        '
        Me.ckFasilitas.AutoSize = True
        Me.ckFasilitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFasilitas.Location = New System.Drawing.Point(119, 19)
        Me.ckFasilitas.Name = "ckFasilitas"
        Me.ckFasilitas.Size = New System.Drawing.Size(77, 20)
        Me.ckFasilitas.TabIndex = 2
        Me.ckFasilitas.Text = "Fasilitas"
        Me.ckFasilitas.UseVisualStyleBackColor = True
        '
        'ckKategori
        '
        Me.ckKategori.AutoSize = True
        Me.ckKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckKategori.Location = New System.Drawing.Point(19, 47)
        Me.ckKategori.Name = "ckKategori"
        Me.ckKategori.Size = New System.Drawing.Size(77, 20)
        Me.ckKategori.TabIndex = 1
        Me.ckKategori.Text = "Kategori"
        Me.ckKategori.UseVisualStyleBackColor = True
        '
        'ckPengguna
        '
        Me.ckPengguna.AutoSize = True
        Me.ckPengguna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPengguna.Location = New System.Drawing.Point(19, 19)
        Me.ckPengguna.Name = "ckPengguna"
        Me.ckPengguna.Size = New System.Drawing.Size(89, 20)
        Me.ckPengguna.TabIndex = 0
        Me.ckPengguna.Text = "Pengguna"
        Me.ckPengguna.UseVisualStyleBackColor = True
        '
        'FormInputPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 746)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormInputPengguna"
        Me.Text = "FormInputPengguna"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ckShow As System.Windows.Forms.CheckBox
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipe As System.Windows.Forms.ComboBox
    Friend WithEvents tPass As System.Windows.Forms.TextBox
    Friend WithEvents tUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bBatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPengguna As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ckPenyewaan As System.Windows.Forms.CheckBox
    Friend WithEvents ckJasa As System.Windows.Forms.CheckBox
    Friend WithEvents ckFasilitas As System.Windows.Forms.CheckBox
    Friend WithEvents ckKategori As System.Windows.Forms.CheckBox
    Friend WithEvents ckPengguna As System.Windows.Forms.CheckBox
End Class
