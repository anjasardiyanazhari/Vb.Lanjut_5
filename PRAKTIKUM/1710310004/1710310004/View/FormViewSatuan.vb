Public Class FormViewSatuan

    Private Sub FormViewSatuan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DB.tampilTabel1(DataGridViewSatuan, "SELECT ID_Satuan, SATUAN FROM TBL_SATUAN")
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewSatuan_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DataGridViewSatuan.DoubleClick
        With DataGridViewSatuan
            FormInputBarang.tKODE_SATUAN.Text = .Item(0, .CurrentRow.Index).Value
            FormInputBarang.tSATUAN.Text = .Item(1, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub
End Class