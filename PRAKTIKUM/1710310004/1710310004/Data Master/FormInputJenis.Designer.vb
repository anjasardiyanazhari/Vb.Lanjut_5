<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputJenis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputJenis))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtket = New System.Windows.Forms.TextBox()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.txtIDJenis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tSimpan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbatal = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtket)
        Me.GroupBox1.Controls.Add(Me.txtJenis)
        Me.GroupBox1.Controls.Add(Me.txtIDJenis)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 258)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtket
        '
        Me.txtket.Location = New System.Drawing.Point(92, 117)
        Me.txtket.Multiline = True
        Me.txtket.Name = "txtket"
        Me.txtket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtket.Size = New System.Drawing.Size(249, 114)
        Me.txtket.TabIndex = 5
        '
        'txtJenis
        '
        Me.txtJenis.Location = New System.Drawing.Point(92, 80)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.Size = New System.Drawing.Size(249, 22)
        Me.txtJenis.TabIndex = 4
        '
        'txtIDJenis
        '
        Me.txtIDJenis.Location = New System.Drawing.Point(92, 41)
        Me.txtIDJenis.Name = "txtIDJenis"
        Me.txtIDJenis.Size = New System.Drawing.Size(249, 22)
        Me.txtIDJenis.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ket              :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(73, 16)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Jenis          :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 41)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(75, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "ID_Jenis    :"
        '
        'tSimpan
        '
        Me.tSimpan.Image = CType(resources.GetObject("tSimpan.Image"), System.Drawing.Image)
        Me.tSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSimpan.Name = "tSimpan"
        Me.tSimpan.Size = New System.Drawing.Size(67, 22)
        Me.tSimpan.Text = "Simpan"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tSimpan, Me.ToolStripSeparator1, Me.tbatal})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(356, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbatal
        '
        Me.tbatal.Image = CType(resources.GetObject("tbatal.Image"), System.Drawing.Image)
        Me.tbatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbatal.Name = "tbatal"
        Me.tbatal.Size = New System.Drawing.Size(53, 22)
        Me.tbatal.Text = "Batal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 52)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'FormInputJenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 345)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInputJenis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInputJenis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtket As System.Windows.Forms.TextBox
    Friend WithEvents txtJenis As System.Windows.Forms.TextBox
    Friend WithEvents txtIDJenis As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents tSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
