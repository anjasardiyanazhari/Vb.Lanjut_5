<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputJasa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputJasa))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ckAktif = New System.Windows.Forms.CheckBox()
        Me.txtJml_Return = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHarga_Awal = New System.Windows.Forms.TextBox()
        Me.ckDefault = New System.Windows.Forms.CheckBox()
        Me.ckKapital = New System.Windows.Forms.CheckBox()
        Me.bPilihKodeFasilitas = New System.Windows.Forms.Button()
        Me.bPilihKodeKategori = New System.Windows.Forms.Button()
        Me.txtKet = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtKode_Fasilitas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKode_Kategori = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHarga_Sewa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama_Jasa = New System.Windows.Forms.TextBox()
        Me.txtIDJasa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bSimpan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bBatal = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtKategori)
        Me.GroupBox1.Controls.Add(Me.txtStok)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ckAktif)
        Me.GroupBox1.Controls.Add(Me.txtJml_Return)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtHarga_Awal)
        Me.GroupBox1.Controls.Add(Me.ckDefault)
        Me.GroupBox1.Controls.Add(Me.ckKapital)
        Me.GroupBox1.Controls.Add(Me.bPilihKodeFasilitas)
        Me.GroupBox1.Controls.Add(Me.bPilihKodeKategori)
        Me.GroupBox1.Controls.Add(Me.txtKet)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtKode_Fasilitas)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtKode_Kategori)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtHarga_Sewa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNama_Jasa)
        Me.GroupBox1.Controls.Add(Me.txtIDJasa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 417)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Kategori"
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(107, 236)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(259, 20)
        Me.txtKategori.TabIndex = 45
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(107, 142)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(259, 22)
        Me.txtStok.TabIndex = 43
        Me.txtStok.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Stok Fasilitas"
        '
        'ckAktif
        '
        Me.ckAktif.AutoSize = True
        Me.ckAktif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAktif.Location = New System.Drawing.Point(309, 269)
        Me.ckAktif.Name = "ckAktif"
        Me.ckAktif.Size = New System.Drawing.Size(52, 20)
        Me.ckAktif.TabIndex = 41
        Me.ckAktif.Text = "Aktif"
        Me.ckAktif.UseVisualStyleBackColor = True
        '
        'txtJml_Return
        '
        Me.txtJml_Return.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJml_Return.Location = New System.Drawing.Point(108, 267)
        Me.txtJml_Return.Name = "txtJml_Return"
        Me.txtJml_Return.ReadOnly = True
        Me.txtJml_Return.Size = New System.Drawing.Size(191, 22)
        Me.txtJml_Return.TabIndex = 40
        Me.txtJml_Return.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 16)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Jml.Return"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Harga Awal"
        '
        'txtHarga_Awal
        '
        Me.txtHarga_Awal.Location = New System.Drawing.Point(107, 80)
        Me.txtHarga_Awal.Name = "txtHarga_Awal"
        Me.txtHarga_Awal.Size = New System.Drawing.Size(258, 20)
        Me.txtHarga_Awal.TabIndex = 37
        '
        'ckDefault
        '
        Me.ckDefault.AutoSize = True
        Me.ckDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckDefault.Location = New System.Drawing.Point(107, 389)
        Me.ckDefault.Name = "ckDefault"
        Me.ckDefault.Size = New System.Drawing.Size(94, 20)
        Me.ckDefault.TabIndex = 35
        Me.ckDefault.Text = "Default Ket."
        Me.ckDefault.UseVisualStyleBackColor = True
        '
        'ckKapital
        '
        Me.ckKapital.AutoSize = True
        Me.ckKapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckKapital.Location = New System.Drawing.Point(307, 48)
        Me.ckKapital.Name = "ckKapital"
        Me.ckKapital.Size = New System.Drawing.Size(68, 20)
        Me.ckKapital.TabIndex = 34
        Me.ckKapital.Text = "Kapital"
        Me.ckKapital.UseVisualStyleBackColor = True
        '
        'bPilihKodeFasilitas
        '
        Me.bPilihKodeFasilitas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPilihKodeFasilitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPilihKodeFasilitas.Location = New System.Drawing.Point(305, 205)
        Me.bPilihKodeFasilitas.Name = "bPilihKodeFasilitas"
        Me.bPilihKodeFasilitas.Size = New System.Drawing.Size(58, 23)
        Me.bPilihKodeFasilitas.TabIndex = 31
        Me.bPilihKodeFasilitas.Text = "....."
        Me.bPilihKodeFasilitas.UseVisualStyleBackColor = True
        '
        'bPilihKodeKategori
        '
        Me.bPilihKodeKategori.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPilihKodeKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPilihKodeKategori.Location = New System.Drawing.Point(305, 174)
        Me.bPilihKodeKategori.Name = "bPilihKodeKategori"
        Me.bPilihKodeKategori.Size = New System.Drawing.Size(58, 23)
        Me.bPilihKodeKategori.TabIndex = 30
        Me.bPilihKodeKategori.Text = "....."
        Me.bPilihKodeKategori.UseVisualStyleBackColor = True
        '
        'txtKet
        '
        Me.txtKet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKet.Location = New System.Drawing.Point(107, 301)
        Me.txtKet.Multiline = True
        Me.txtKet.Name = "txtKet"
        Me.txtKet.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtKet.Size = New System.Drawing.Size(259, 86)
        Me.txtKet.TabIndex = 29
        Me.txtKet.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 304)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Ket."
        '
        'txtKode_Fasilitas
        '
        Me.txtKode_Fasilitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode_Fasilitas.Location = New System.Drawing.Point(107, 204)
        Me.txtKode_Fasilitas.Name = "txtKode_Fasilitas"
        Me.txtKode_Fasilitas.ReadOnly = True
        Me.txtKode_Fasilitas.Size = New System.Drawing.Size(192, 22)
        Me.txtKode_Fasilitas.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Kode Fasilitas"
        '
        'txtKode_Kategori
        '
        Me.txtKode_Kategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode_Kategori.Location = New System.Drawing.Point(107, 173)
        Me.txtKode_Kategori.Name = "txtKode_Kategori"
        Me.txtKode_Kategori.ReadOnly = True
        Me.txtKode_Kategori.Size = New System.Drawing.Size(192, 22)
        Me.txtKode_Kategori.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kode Kategori"
        '
        'txtHarga_Sewa
        '
        Me.txtHarga_Sewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga_Sewa.Location = New System.Drawing.Point(107, 111)
        Me.txtHarga_Sewa.Name = "txtHarga_Sewa"
        Me.txtHarga_Sewa.Size = New System.Drawing.Size(259, 22)
        Me.txtHarga_Sewa.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Harga Sewa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Barcode"
        '
        'txtNama_Jasa
        '
        Me.txtNama_Jasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama_Jasa.Location = New System.Drawing.Point(107, 46)
        Me.txtNama_Jasa.Name = "txtNama_Jasa"
        Me.txtNama_Jasa.Size = New System.Drawing.Size(193, 22)
        Me.txtNama_Jasa.TabIndex = 6
        '
        'txtIDJasa
        '
        Me.txtIDJasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDJasa.Location = New System.Drawing.Point(107, 15)
        Me.txtIDJasa.Name = "txtIDJasa"
        Me.txtIDJasa.Size = New System.Drawing.Size(192, 22)
        Me.txtIDJasa.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Jasa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID.Jasa"
        '
        'bSimpan
        '
        Me.bSimpan.Image = CType(resources.GetObject("bSimpan.Image"), System.Drawing.Image)
        Me.bSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(94, 34)
        Me.bSimpan.Text = "&Simpan"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bSimpan, Me.ToolStripSeparator1, Me.bBatal})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(369, 37)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'bBatal
        '
        Me.bBatal.Image = CType(resources.GetObject("bBatal.Image"), System.Drawing.Image)
        Me.bBatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bBatal.Name = "bBatal"
        Me.bBatal.Size = New System.Drawing.Size(78, 34)
        Me.bBatal.Text = "&Batal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox2.Location = New System.Drawing.Point(9, 430)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 61)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'FormInputJasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormInputJasa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInputJasa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ckDefault As System.Windows.Forms.CheckBox
    Friend WithEvents ckKapital As System.Windows.Forms.CheckBox
    Friend WithEvents bPilihKodeFasilitas As System.Windows.Forms.Button
    Friend WithEvents bPilihKodeKategori As System.Windows.Forms.Button
    Friend WithEvents txtKet As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtKode_Fasilitas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKode_Kategori As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHarga_Sewa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNama_Jasa As System.Windows.Forms.TextBox
    Friend WithEvents txtIDJasa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bBatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHarga_Awal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ckAktif As System.Windows.Forms.CheckBox
    Friend WithEvents txtJml_Return As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
