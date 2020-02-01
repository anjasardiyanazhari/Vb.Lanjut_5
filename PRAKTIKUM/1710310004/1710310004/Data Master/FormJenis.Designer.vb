<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJenis))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridDataJenis = New System.Windows.Forms.DataGridView()
        Me.Hapus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ckPilih = New System.Windows.Forms.CheckBox()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.tPencarian = New System.Windows.Forms.ToolStripTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PilihDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tTambah = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridDataJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridDataJenis)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1338, 525)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GridDataJenis
        '
        Me.GridDataJenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDataJenis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Hapus})
        Me.GridDataJenis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDataJenis.Location = New System.Drawing.Point(3, 16)
        Me.GridDataJenis.Name = "GridDataJenis"
        Me.GridDataJenis.Size = New System.Drawing.Size(1332, 506)
        Me.GridDataJenis.TabIndex = 0
        '
        'Hapus
        '
        Me.Hapus.HeaderText = "Pilih"
        Me.Hapus.Name = "Hapus"
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
        'tPencarian
        '
        Me.tPencarian.Name = "tPencarian"
        Me.tPencarian.Size = New System.Drawing.Size(600, 37)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihDataToolStripMenuItem, Me.BatalToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 48)
        '
        'PilihDataToolStripMenuItem
        '
        Me.PilihDataToolStripMenuItem.Image = CType(resources.GetObject("PilihDataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PilihDataToolStripMenuItem.Name = "PilihDataToolStripMenuItem"
        Me.PilihDataToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PilihDataToolStripMenuItem.Text = "Pilih Data"
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
        'tTambah
        '
        Me.tTambah.Image = CType(resources.GetObject("tTambah.Image"), System.Drawing.Image)
        Me.tTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tTambah.Name = "tTambah"
        Me.tTambah.Size = New System.Drawing.Size(83, 34)
        Me.tTambah.Text = "Tambah"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckPilih)
        Me.GroupBox2.Controls.Add(Me.bHapus)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 540)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1335, 54)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'FormJenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 611)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormJenis"
        Me.Text = "FormJenis"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridDataJenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridDataJenis As System.Windows.Forms.DataGridView
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ckPilih As System.Windows.Forms.CheckBox
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents tPencarian As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PilihDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BatalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tTambah As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
