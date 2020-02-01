Public Class FormViewSatuan

    Private Sub FormViewSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DB.tampilTabel1(GridViewSatuan, "SELECT ID_Satuan, Satuan FROM TBL_Satuan")
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub GridViewSatuan_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewSatuan.DoubleClick
        With GridViewSatuan
            FormInputBarang.txtIDSatuan.Text = .Item(0, .CurrentRow.Index).Value
            FormInputBarang.txtSatuan.Text = .Item(1, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub
End Class