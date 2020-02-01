<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKategori))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridDataKategori = New System.Windows.Forms.DataGridView()
        Me.Hapus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BatalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tTambah = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tPencarian = New System.Windows.Forms.ToolStripTextBox()
        Me.PilihDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ckPilih = New System.Windows.Forms.CheckBox()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridDataKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridDataKategori)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1338, 525)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GridDataKategori
        '
        Me.GridDataKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDataKategori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Hapus})
        Me.GridDataKategori.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridDataKategori.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDataKategori.Location = New System.Drawing.Point(3, 16)
        Me.GridDataKategori.Name = "GridDataKategori"
        Me.GridDataKategori.Size = New System.Drawing.Size(1332, 506)
        Me.GridDataKategori.TabIndex = 0
        '
        'Hapus
        '
        Me.Hapus.HeaderText = "Pilih"
        Me.Hapus.Name = "Hapus"
        '
        'BatalToolStripMenuItem
        '
        Me.BatalToolStripMenuItem.Image = CType(resources.GetObject("BatalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BatalToolStripMenuItem.Name = "BatalToolStripMenuItem"
        Me.BatalToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BatalToolStripMenuItem.Text = "Batal"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(95, 34)
        Me.ToolStripLabel1.Text = "Pencarian :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tTambah, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.tPencarian})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1329, 37)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tTambah
        '
        Me.tTambah.Image = CType(resources.GetObject("tTambah.Image"), System.Drawing.Image)
        Me.tTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tTambah.Name = "tTambah"
        Me.tTambah.Size = New System.Drawing.Size(83, 34)
        Me.tTambah.Text = "&Tambah"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'tPencarian
        '
        Me.tPencarian.Name = "tPencarian"
        Me.tPencarian.Size = New System.Drawing.Size(600, 37)
        '
        'PilihDataToolStripMenuItem
        '
        Me.PilihDataToolStripMenuItem.Image = CType(resources.GetObject("PilihDataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PilihDataToolStripMenuItem.Name = "PilihDataToolStripMenuItem"
        Me.PilihDataToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PilihDataToolStripMenuItem.Text = "Pilih Data"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihDataToolStripMenuItem, Me.BatalToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 48)
        '
        'ckPilih
        '
        Me.ckPilih.AutoSize = True
        Me.ckPilih.Location = New System.Drawing.Point(1175, 27)
        Me.ckPilih.Name = "ckPilih"
        Me.ckPilih.Size = New System.Drawing.Size(79, 17)
        Me.ckPilih.TabIndex = 2
        Me.ckPilih.Text = "Pilih semua"
        Me.ckPilih.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(1094, 22)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(75, 23)
        Me.bHapus.TabIndex = 1
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckPilih)
        Me.GroupBox2.Controls.Add(Me.bHapus)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 542)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1335, 54)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'FormKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 611)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormKategori"
        Me.Text = "FormKategori"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridDataKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridDataKategori As System.Windows.Forms.DataGridView
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BatalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tPencarian As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PilihDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ckPilih As System.Windows.Forms.CheckBox
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tTambah As System.Windows.Forms.ToolStripButton
End Class
