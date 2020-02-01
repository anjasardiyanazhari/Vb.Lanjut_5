<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoginPengguna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginPengguna))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.tId_pengguna = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbLevel = New System.Windows.Forms.ComboBox()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckBatalPenjualan = New System.Windows.Forms.CheckBox()
        Me.ckOpnameStok = New System.Windows.Forms.CheckBox()
        Me.ckReturnBarang = New System.Windows.Forms.CheckBox()
        Me.ckPenjualan = New System.Windows.Forms.CheckBox()
        Me.ckPembelian = New System.Windows.Forms.CheckBox()
        Me.ckSuplier = New System.Windows.Forms.CheckBox()
        Me.ckBarang = New System.Windows.Forms.CheckBox()
        Me.ckMerek = New System.Windows.Forms.CheckBox()
        Me.ckSatuan = New System.Windows.Forms.CheckBox()
        Me.ckJenis = New System.Windows.Forms.CheckBox()
        Me.ckPengguna = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bLogin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bBatal = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GridPengguna = New System.Windows.Forms.DataGridView()
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
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.tId_pengguna)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbLevel)
        Me.GroupBox1.Controls.Add(Me.tPassword)
        Me.GroupBox1.Controls.Add(Me.tUsername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 166)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(299, 92)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Show"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'tId_pengguna
        '
        Me.tId_pengguna.Location = New System.Drawing.Point(102, 23)
        Me.tId_pengguna.Name = "tId_pengguna"
        Me.tId_pengguna.Size = New System.Drawing.Size(242, 20)
        Me.tId_pengguna.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ID Pengguna"
        '
        'cbLevel
        '
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Items.AddRange(New Object() {"Administrator", "User"})
        Me.cbLevel.Location = New System.Drawing.Point(101, 122)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.Size = New System.Drawing.Size(242, 21)
        Me.cbLevel.TabIndex = 7
        Me.cbLevel.Text = "User"
        '
        'tPassword
        '
        Me.tPassword.Location = New System.Drawing.Point(101, 90)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.Size = New System.Drawing.Size(192, 20)
        Me.tPassword.TabIndex = 6
        '
        'tUsername
        '
        Me.tUsername.Location = New System.Drawing.Point(101, 57)
        Me.tUsername.Name = "tUsername"
        Me.tUsername.Size = New System.Drawing.Size(242, 20)
        Me.tUsername.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Level Akses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckBatalPenjualan)
        Me.GroupBox2.Controls.Add(Me.ckOpnameStok)
        Me.GroupBox2.Controls.Add(Me.ckReturnBarang)
        Me.GroupBox2.Controls.Add(Me.ckPenjualan)
        Me.GroupBox2.Controls.Add(Me.ckPembelian)
        Me.GroupBox2.Controls.Add(Me.ckSuplier)
        Me.GroupBox2.Controls.Add(Me.ckBarang)
        Me.GroupBox2.Controls.Add(Me.ckMerek)
        Me.GroupBox2.Controls.Add(Me.ckSatuan)
        Me.GroupBox2.Controls.Add(Me.ckJenis)
        Me.GroupBox2.Controls.Add(Me.ckPengguna)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 230)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'ckBatalPenjualan
        '
        Me.ckBatalPenjualan.AutoSize = True
        Me.ckBatalPenjualan.Location = New System.Drawing.Point(125, 109)
        Me.ckBatalPenjualan.Name = "ckBatalPenjualan"
        Me.ckBatalPenjualan.Size = New System.Drawing.Size(100, 17)
        Me.ckBatalPenjualan.TabIndex = 10
        Me.ckBatalPenjualan.Text = "Batal Penjualan"
        Me.ckBatalPenjualan.UseVisualStyleBackColor = True
        '
        'ckOpnameStok
        '
        Me.ckOpnameStok.AutoSize = True
        Me.ckOpnameStok.Location = New System.Drawing.Point(252, 21)
        Me.ckOpnameStok.Name = "ckOpnameStok"
        Me.ckOpnameStok.Size = New System.Drawing.Size(91, 17)
        Me.ckOpnameStok.TabIndex = 9
        Me.ckOpnameStok.Text = "Opname Stok"
        Me.ckOpnameStok.UseVisualStyleBackColor = True
        '
        'ckReturnBarang
        '
        Me.ckReturnBarang.AutoSize = True
        Me.ckReturnBarang.Location = New System.Drawing.Point(125, 135)
        Me.ckReturnBarang.Name = "ckReturnBarang"
        Me.ckReturnBarang.Size = New System.Drawing.Size(95, 17)
        Me.ckReturnBarang.TabIndex = 8
        Me.ckReturnBarang.Text = "Return Barang"
        Me.ckReturnBarang.UseVisualStyleBackColor = True
        '
        'ckPenjualan
        '
        Me.ckPenjualan.AutoSize = True
        Me.ckPenjualan.Location = New System.Drawing.Point(125, 79)
        Me.ckPenjualan.Name = "ckPenjualan"
        Me.ckPenjualan.Size = New System.Drawing.Size(73, 17)
        Me.ckPenjualan.TabIndex = 7
        Me.ckPenjualan.Text = "Penjualan"
        Me.ckPenjualan.UseVisualStyleBackColor = True
        '
        'ckPembelian
        '
        Me.ckPembelian.AutoSize = True
        Me.ckPembelian.Location = New System.Drawing.Point(125, 52)
        Me.ckPembelian.Name = "ckPembelian"
        Me.ckPembelian.Size = New System.Drawing.Size(75, 17)
        Me.ckPembelian.TabIndex = 6
        Me.ckPembelian.Text = "Pembelian"
        Me.ckPembelian.UseVisualStyleBackColor = True
        '
        'ckSuplier
        '
        Me.ckSuplier.AutoSize = True
        Me.ckSuplier.Location = New System.Drawing.Point(125, 23)
        Me.ckSuplier.Name = "ckSuplier"
        Me.ckSuplier.Size = New System.Drawing.Size(58, 17)
        Me.ckSuplier.TabIndex = 5
        Me.ckSuplier.Text = "Suplier"
        Me.ckSuplier.UseVisualStyleBackColor = True
        '
        'ckBarang
        '
        Me.ckBarang.AutoSize = True
        Me.ckBarang.Location = New System.Drawing.Point(22, 134)
        Me.ckBarang.Name = "ckBarang"
        Me.ckBarang.Size = New System.Drawing.Size(60, 17)
        Me.ckBarang.TabIndex = 4
        Me.ckBarang.Text = "Barang"
        Me.ckBarang.UseVisualStyleBackColor = True
        '
        'ckMerek
        '
        Me.ckMerek.AutoSize = True
        Me.ckMerek.Location = New System.Drawing.Point(22, 106)
        Me.ckMerek.Name = "ckMerek"
        Me.ckMerek.Size = New System.Drawing.Size(56, 17)
        Me.ckMerek.TabIndex = 3
        Me.ckMerek.Text = "Merek"
        Me.ckMerek.UseVisualStyleBackColor = True
        '
        'ckSatuan
        '
        Me.ckSatuan.AutoSize = True
        Me.ckSatuan.Location = New System.Drawing.Point(22, 79)
        Me.ckSatuan.Name = "ckSatuan"
        Me.ckSatuan.Size = New System.Drawing.Size(60, 17)
        Me.ckSatuan.TabIndex = 2
        Me.ckSatuan.Text = "Satuan"
        Me.ckSatuan.UseVisualStyleBackColor = True
        '
        'ckJenis
        '
        Me.ckJenis.AutoSize = True
        Me.ckJenis.Location = New System.Drawing.Point(22, 52)
        Me.ckJenis.Name = "ckJenis"
        Me.ckJenis.Size = New System.Drawing.Size(50, 17)
        Me.ckJenis.TabIndex = 1
        Me.ckJenis.Text = "Jenis"
        Me.ckJenis.UseVisualStyleBackColor = True
        '
        'ckPengguna
        '
        Me.ckPengguna.AutoSize = True
        Me.ckPengguna.Location = New System.Drawing.Point(22, 23)
        Me.ckPengguna.Name = "ckPengguna"
        Me.ckPengguna.Size = New System.Drawing.Size(75, 17)
        Me.ckPengguna.TabIndex = 0
        Me.ckPengguna.Text = "Pengguna"
        Me.ckPengguna.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ToolStrip1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 579)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(362, 52)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bLogin, Me.ToolStripSeparator1, Me.bBatal})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(356, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bLogin
        '
        Me.bLogin.Image = CType(resources.GetObject("bLogin.Image"), System.Drawing.Image)
        Me.bLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(57, 22)
        Me.bLogin.Text = "Login"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bBatal
        '
        Me.bBatal.Image = CType(resources.GetObject("bBatal.Image"), System.Drawing.Image)
        Me.bBatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bBatal.Name = "bBatal"
        Me.bBatal.Size = New System.Drawing.Size(53, 22)
        Me.bBatal.Text = "Batal"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridPengguna)
        Me.GroupBox4.Location = New System.Drawing.Point(382, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(968, 724)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'GridPengguna
        '
        Me.GridPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPengguna.Location = New System.Drawing.Point(6, 15)
        Me.GridPengguna.Name = "GridPengguna"
        Me.GridPengguna.Size = New System.Drawing.Size(956, 703)
        Me.GridPengguna.TabIndex = 0
        '
        'FormLoginPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 749)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormLoginPengguna"
        Me.Text = "FormLoginPengguna"
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
    Friend WithEvents cbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents tPassword As System.Windows.Forms.TextBox
    Friend WithEvents tUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tId_pengguna As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ckPengguna As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bLogin As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bBatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents ckMerek As System.Windows.Forms.CheckBox
    Friend WithEvents ckSatuan As System.Windows.Forms.CheckBox
    Friend WithEvents ckJenis As System.Windows.Forms.CheckBox
    Friend WithEvents ckOpnameStok As System.Windows.Forms.CheckBox
    Friend WithEvents ckReturnBarang As System.Windows.Forms.CheckBox
    Friend WithEvents ckPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents ckPembelian As System.Windows.Forms.CheckBox
    Friend WithEvents ckSuplier As System.Windows.Forms.CheckBox
    Friend WithEvents ckBarang As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPengguna As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ckBatalPenjualan As System.Windows.Forms.CheckBox
End Class
