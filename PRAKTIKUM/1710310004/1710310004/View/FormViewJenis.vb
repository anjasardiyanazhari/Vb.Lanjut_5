Public Class FormViewJenis

    Private Sub FormViewJenis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        DB.tampilTabel1(DataGridViewJenis, "SELECT ID_Jenis, JENIS FROM TBL_JENIS")
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewJenis_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DataGridViewJenis.DoubleClick
        With DataGridViewJenis
            FormInputBarang.tKODE_JENIS.Text = .Item(0, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub

    Private Sub DataGridViewJenis_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewJenis.CellContentClick

    End Sub
End Class