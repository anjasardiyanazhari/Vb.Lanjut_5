<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.InformasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDataPengguna = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnDataJenis = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDataSatuan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDataMerek = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnDataBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDataSuplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BatalPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReturnBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpnameStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.VisualStyler1 = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengaturanToolStripMenuItem, Me.DataMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1356, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.ToolStripSeparator3, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripSeparator1, Me.InformasiToolStripMenuItem, Me.KeluarAplikasiToolStripMenuItem, Me.ToolStripSeparator2})
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(86, 22)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Image = CType(resources.GetObject("DatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(160, 6)
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'InformasiToolStripMenuItem
        '
        Me.InformasiToolStripMenuItem.Image = CType(resources.GetObject("InformasiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InformasiToolStripMenuItem.Name = "InformasiToolStripMenuItem"
        Me.InformasiToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.InformasiToolStripMenuItem.Text = "Informasi"
        '
        'KeluarAplikasiToolStripMenuItem
        '
        Me.KeluarAplikasiToolStripMenuItem.Image = CType(resources.GetObject("KeluarAplikasiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarAplikasiToolStripMenuItem.Name = "KeluarAplikasiToolStripMenuItem"
        Me.KeluarAplikasiToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.KeluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(160, 6)
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnDataPengguna, Me.ToolStripSeparator4, Me.mnDataJenis, Me.mnDataSatuan, Me.mnDataMerek, Me.ToolStripSeparator5, Me.mnDataBarang, Me.mnDataSuplier, Me.ToolStripSeparator6})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'mnDataPengguna
        '
        Me.mnDataPengguna.Image = CType(resources.GetObject("mnDataPengguna.Image"), System.Drawing.Image)
        Me.mnDataPengguna.Name = "mnDataPengguna"
        Me.mnDataPengguna.Size = New System.Drawing.Size(165, 22)
        Me.mnDataPengguna.Text = "Data Pengguna"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(162, 6)
        '
        'mnDataJenis
        '
        Me.mnDataJenis.Image = CType(resources.GetObject("mnDataJenis.Image"), System.Drawing.Image)
        Me.mnDataJenis.Name = "mnDataJenis"
        Me.mnDataJenis.Size = New System.Drawing.Size(165, 22)
        Me.mnDataJenis.Text = "Data Jenis"
        '
        'mnDataSatuan
        '
        Me.mnDataSatuan.Image = CType(resources.GetObject("mnDataSatuan.Image"), System.Drawing.Image)
        Me.mnDataSatuan.Name = "mnDataSatuan"
        Me.mnDataSatuan.Size = New System.Drawing.Size(165, 22)
        Me.mnDataSatuan.Text = "Data Satuan"
        '
        'mnDataMerek
        '
        Me.mnDataMerek.Image = CType(resources.GetObject("mnDataMerek.Image"), System.Drawing.Image)
        Me.mnDataMerek.Name = "mnDataMerek"
        Me.mnDataMerek.Size = New System.Drawing.Size(165, 22)
        Me.mnDataMerek.Text = "Data Merek"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(162, 6)
        '
        'mnDataBarang
        '
        Me.mnDataBarang.Image = CType(resources.GetObject("mnDataBarang.Image"), System.Drawing.Image)
        Me.mnDataBarang.Name = "mnDataBarang"
        Me.mnDataBarang.Size = New System.Drawing.Size(165, 22)
        Me.mnDataBarang.Text = "Data Barang"
        '
        'mnDataSuplier
        '
        Me.mnDataSuplier.Image = CType(resources.GetObject("mnDataSuplier.Image"), System.Drawing.Image)
        Me.mnDataSuplier.Name = "mnDataSuplier"
        Me.mnDataSuplier.Size = New System.Drawing.Size(165, 22)
        Me.mnDataSuplier.Text = "Data Suplier"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(162, 6)
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem, Me.ToolStripSeparator7, Me.BatalPenjualanToolStripMenuItem, Me.ToolStripSeparator8, Me.ReturnBarangToolStripMenuItem, Me.OpnameStokToolStripMenuItem, Me.ToolStripSeparator9})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Image = CType(resources.GetObject("PembelianToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Image = CType(resources.GetObject("PenjualanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(164, 6)
        '
        'BatalPenjualanToolStripMenuItem
        '
        Me.BatalPenjualanToolStripMenuItem.Image = CType(resources.GetObject("BatalPenjualanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BatalPenjualanToolStripMenuItem.Name = "BatalPenjualanToolStripMenuItem"
        Me.BatalPenjualanToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.BatalPenjualanToolStripMenuItem.Text = "Batal Penjualan"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(164, 6)
        '
        'ReturnBarangToolStripMenuItem
        '
        Me.ReturnBarangToolStripMenuItem.Image = CType(resources.GetObject("ReturnBarangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReturnBarangToolStripMenuItem.Name = "ReturnBarangToolStripMenuItem"
        Me.ReturnBarangToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ReturnBarangToolStripMenuItem.Text = "Return Barang"
        '
        'OpnameStokToolStripMenuItem
        '
        Me.OpnameStokToolStripMenuItem.Image = CType(resources.GetObject("OpnameStokToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpnameStokToolStripMenuItem.Name = "OpnameStokToolStripMenuItem"
        Me.OpnameStokToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.OpnameStokToolStripMenuItem.Text = "Opname Stok"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(164, 6)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.stsDB, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel9})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 718)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1356, 23)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 18)
        Me.ToolStripStatusLabel1.Text = "Database :"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(12, 18)
        Me.ToolStripStatusLabel2.Text = "["
        '
        'stsDB
        '
        Me.stsDB.Name = "stsDB"
        Me.stsDB.Size = New System.Drawing.Size(20, 18)
        Me.stsDB.Text = "..."
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(12, 18)
        Me.ToolStripStatusLabel4.Text = "]"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(1106, 18)
        Me.ToolStripStatusLabel5.Spring = True
        Me.ToolStripStatusLabel5.Text = "Point Of Sale V1.0.1"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Image = CType(resources.GetObject("ToolStripStatusLabel6.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(69, 18)
        Me.ToolStripStatusLabel6.Text = "Waktu :"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(20, 18)
        Me.ToolStripStatusLabel7.Text = "..."
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(11, 18)
        Me.ToolStripStatusLabel8.Text = "|"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(20, 18)
        Me.ToolStripStatusLabel9.Text = "..."
        '
        'VisualStyler1
        '
        Me.VisualStyler1.HostForm = Me
        Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"), SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.VisualStyler1.LoadVisualStyle(Nothing, "Office2007 (Blue).vssf")
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 741)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "[Form Utama]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PengaturanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InformasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDataPengguna As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnDataJenis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDataSatuan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDataMerek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnDataBarang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDataSuplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BatalPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReturnBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpnameStokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsDB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler

End Class
