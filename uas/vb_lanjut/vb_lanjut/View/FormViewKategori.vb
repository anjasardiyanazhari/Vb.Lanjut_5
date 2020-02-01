Public Class FormViewKategori

    Private Sub FormViewKategori_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        DB.tampilTabel1(DataGridViewKategori, "SELECT ID_Kategori, Kategori FROM TBL_KATEGORI")
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewKategori_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridViewKategori.DoubleClick
        With DataGridViewKategori
            FormInputJasa.txtKode_Kategori.Text = .Item(0, .CurrentRow.Index).Value
            FormInputJasa.txtKategori.Text = .Item(1, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub
End Class