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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbTipe = New System.Windows.Forms.ComboBox()
        Me.tPass = New System.Windows.Forms.TextBox()
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckPengguna = New System.Windows.Forms.CheckBox()
        Me.ckJenis = New System.Windows.Forms.CheckBox()
        Me.ckSatuan = New System.Windows.Forms.CheckBox()
        Me.ckMerek = New System.Windows.Forms.CheckBox()
        Me.ckBarang = New System.Windows.Forms.CheckBox()
        Me.ckSuplier = New System.Windows.Forms.CheckBox()
        Me.ckPembelian = New System.Windows.Forms.CheckBox()
        Me.ckPenjualan = New System.Windows.Forms.CheckBox()
        Me.ckOpname = New System.Windows.Forms.CheckBox()
        Me.ckBatalPenjualan = New System.Windows.Forms.CheckBox()
        Me.ckReturn = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bSimpan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bBatal = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GridPengguna = New System.Windows.Forms.DataGridView()
        Me.ckShow = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 155)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'cbTipe
        '
        Me.cbTipe.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipe.FormattingEnabled = True
        Me.cbTipe.Items.AddRange(New Object() {"Administrator", "Pengguna Biasa"})
        Me.cbTipe.Location = New System.Drawing.Point(119, 114)
        Me.cbTipe.Name = "cbTipe"
        Me.cbTipe.Size = New System.Drawing.Size(248, 29)
        Me.cbTipe.TabIndex = 7
        '
        'tPass
        '
        Me.tPass.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPass.Location = New System.Drawing.Point(119, 81)
        Me.tPass.Name = "tPass"
        Me.tPass.Size = New System.Drawing.Size(174, 29)
        Me.tPass.TabIndex = 6
        Me.tPass.UseSystemPasswordChar = True
        '
        'tUsername
        '
        Me.tUsername.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsername.Location = New System.Drawing.Point(119, 48)
        Me.tUsername.Name = "tUsername"
        Me.tUsername.Size = New System.Drawing.Size(248, 29)
        Me.tUsername.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipe Pengguna"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username "
        '
        'tID
        '
        Me.tID.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tID.Location = New System.Drawing.Point(119, 14)
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(248, 29)
        Me.tID.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID.Pengguna"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckReturn)
        Me.GroupBox2.Controls.Add(Me.ckBatalPenjualan)
        Me.GroupBox2.Controls.Add(Me.ckOpname)
        Me.GroupBox2.Controls.Add(Me.ckPenjualan)
        Me.GroupBox2.Controls.Add(Me.ckPembelian)
        Me.GroupBox2.Controls.Add(Me.ckSuplier)
        Me.GroupBox2.Controls.Add(Me.ckBarang)
        Me.GroupBox2.Controls.Add(Me.ckMerek)
        Me.GroupBox2.Controls.Add(Me.ckSatuan)
        Me.GroupBox2.Controls.Add(Me.ckJenis)
        Me.GroupBox2.Controls.Add(Me.ckPengguna)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 464)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'ckPengguna
        '
        Me.ckPengguna.AutoSize = True
        Me.ckPengguna.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPengguna.Location = New System.Drawing.Point(19, 19)
        Me.ckPengguna.Name = "ckPengguna"
        Me.ckPengguna.Size = New System.Drawing.Size(85, 22)
        Me.ckPengguna.TabIndex = 0
        Me.ckPengguna.Text = "Pengguna"
        Me.ckPengguna.UseVisualStyleBackColor = True
        '
        'ckJenis
        '
        Me.ckJenis.AutoSize = True
        Me.ckJenis.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckJenis.Location = New System.Drawing.Point(19, 47)
        Me.ckJenis.Name = "ckJenis"
        Me.ckJenis.Size = New System.Drawing.Size(58, 22)
        Me.ckJenis.TabIndex = 1
        Me.ckJenis.Text = "Jenis"
        Me.ckJenis.UseVisualStyleBackColor = True
        '
        'ckSatuan
        '
        Me.ckSatuan.AutoSize = True
        Me.ckSatuan.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckSatuan.Location = New System.Drawing.Point(19, 75)
        Me.ckSatuan.Name = "ckSatuan"
        Me.ckSatuan.Size = New System.Drawing.Size(68, 22)
        Me.ckSatuan.TabIndex = 2
        Me.ckSatuan.Text = "Satuan"
        Me.ckSatuan.UseVisualStyleBackColor = True
        '
        'ckMerek
        '
        Me.ckMerek.AutoSize = True
        Me.ckMerek.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckMerek.Location = New System.Drawing.Point(19, 103)
        Me.ckMerek.Name = "ckMerek"
        Me.ckMerek.Size = New System.Drawing.Size(63, 22)
        Me.ckMerek.TabIndex = 3
        Me.ckMerek.Text = "Merek"
        Me.ckMerek.UseVisualStyleBackColor = True
        '
        'ckBarang
        '
        Me.ckBarang.AutoSize = True
        Me.ckBarang.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckBarang.Location = New System.Drawing.Point(119, 19)
        Me.ckBarang.Name = "ckBarang"
        Me.ckBarang.Size = New System.Drawing.Size(68, 22)
        Me.ckBarang.TabIndex = 4
        Me.ckBarang.Text = "Barang"
        Me.ckBarang.UseVisualStyleBackColor = True
        '
        'ckSuplier
        '
        Me.ckSuplier.AutoSize = True
        Me.ckSuplier.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckSuplier.Location = New System.Drawing.Point(119, 47)
        Me.ckSuplier.Name = "ckSuplier"
        Me.ckSuplier.Size = New System.Drawing.Size(67, 22)
        Me.ckSuplier.TabIndex = 5
        Me.ckSuplier.Text = "Suplier"
        Me.ckSuplier.UseVisualStyleBackColor = True
        '
        'ckPembelian
        '
        Me.ckPembelian.AutoSize = True
        Me.ckPembelian.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPembelian.Location = New System.Drawing.Point(119, 75)
        Me.ckPembelian.Name = "ckPembelian"
        Me.ckPembelian.Size = New System.Drawing.Size(88, 22)
        Me.ckPembelian.TabIndex = 6
        Me.ckPembelian.Text = "Pembelian"
        Me.ckPembelian.UseVisualStyleBackColor = True
        '
        'ckPenjualan
        '
        Me.ckPenjualan.AutoSize = True
        Me.ckPenjualan.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPenjualan.Location = New System.Drawing.Point(119, 103)
        Me.ckPenjualan.Name = "ckPenjualan"
        Me.ckPenjualan.Size = New System.Drawing.Size(84, 22)
        Me.ckPenjualan.TabIndex = 7
        Me.ckPenjualan.Text = "Penjualan"
        Me.ckPenjualan.UseVisualStyleBackColor = True
        '
        'ckOpname
        '
        Me.ckOpname.AutoSize = True
        Me.ckOpname.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckOpname.Location = New System.Drawing.Point(217, 75)
        Me.ckOpname.Name = "ckOpname"
        Me.ckOpname.Size = New System.Drawing.Size(107, 22)
        Me.ckOpname.TabIndex = 8
        Me.ckOpname.Text = "Opname Stok"
        Me.ckOpname.UseVisualStyleBackColor = True
        '
        'ckBatalPenjualan
        '
        Me.ckBatalPenjualan.AutoSize = True
        Me.ckBatalPenjualan.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckBatalPenjualan.Location = New System.Drawing.Point(217, 19)
        Me.ckBatalPenjualan.Name = "ckBatalPenjualan"
        Me.ckBatalPenjualan.Size = New System.Drawing.Size(118, 22)
        Me.ckBatalPenjualan.TabIndex = 9
        Me.ckBatalPenjualan.Text = "Batal Penjualan"
        Me.ckBatalPenjualan.UseVisualStyleBackColor = True
        '
        'ckReturn
        '
        Me.ckReturn.AutoSize = True
        Me.ckReturn.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckReturn.Location = New System.Drawing.Point(217, 47)
        Me.ckReturn.Name = "ckReturn"
        Me.ckReturn.Size = New System.Drawing.Size(110, 22)
        Me.ckReturn.TabIndex = 10
        Me.ckReturn.Text = "Barang Return"
        Me.ckReturn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ToolStrip1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 622)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(374, 67)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bSimpan.Size = New System.Drawing.Size(106, 36)
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
        Me.GroupBox4.Location = New System.Drawing.Point(389, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(963, 687)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'GridPengguna
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPengguna.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridPengguna.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridPengguna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPengguna.Location = New System.Drawing.Point(3, 16)
        Me.GridPengguna.Name = "GridPengguna"
        Me.GridPengguna.Size = New System.Drawing.Size(957, 668)
        Me.GridPengguna.TabIndex = 0
        '
        'ckShow
        '
        Me.ckShow.AutoSize = True
        Me.ckShow.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckShow.Location = New System.Drawing.Point(299, 83)
        Me.ckShow.Name = "ckShow"
        Me.ckShow.Size = New System.Drawing.Size(70, 25)
        Me.ckShow.TabIndex = 10
        Me.ckShow.Text = "Show"
        Me.ckShow.UseVisualStyleBackColor = True
        '
        'FormInputPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 746)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormInputPengguna"
        Me.Text = "|Input Data Pengguna|"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipe As System.Windows.Forms.ComboBox
    Friend WithEvents tPass As System.Windows.Forms.TextBox
    Friend WithEvents tUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ckReturn As System.Windows.Forms.CheckBox
    Friend WithEvents ckBatalPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents ckOpname As System.Windows.Forms.CheckBox
    Friend WithEvents ckPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents ckPembelian As System.Windows.Forms.CheckBox
    Friend WithEvents ckSuplier As System.Windows.Forms.CheckBox
    Friend WithEvents ckBarang As System.Windows.Forms.CheckBox
    Friend WithEvents ckMerek As System.Windows.Forms.CheckBox
    Friend WithEvents ckSatuan As System.Windows.Forms.CheckBox
    Friend WithEvents ckJenis As System.Windows.Forms.CheckBox
    Friend WithEvents ckPengguna As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bBatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPengguna As System.Windows.Forms.DataGridView
    Friend WithEvents ckShow As System.Windows.Forms.CheckBox
End Class
