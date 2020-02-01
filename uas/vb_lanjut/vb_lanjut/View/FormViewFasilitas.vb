Public Class FormViewFasilitas

    Private Sub FormViewFasilitas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        DB.tampilTabel1(DataGridViewFasilitas, "SELECT ID_Fasilitas, Fasilitas FROM TBL_FASILITAS")
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewFasilitas_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridViewFasilitas.DoubleClick
        With DataGridViewFasilitas
            FormInputJasa.txtKode_Fasilitas.Text = .Item(0, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub
End Class