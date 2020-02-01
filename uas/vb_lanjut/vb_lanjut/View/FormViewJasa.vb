Public Class FormViewJasa

    Private Sub FormViewJasa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Call DB.tampilTabel1(DataGridViewBarang, "SELECT ID_Jasa, NAMA_JASA, HARGA_AWAL, HARGA_SEWA, STOK, KATEGORI FROM TBL_JASA")
        Call RapiGrid(DataGridViewBarang, "view_jasa")
    End Sub

    Private Sub DataGridViewBarang_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridViewBarang.DoubleClick
        With DataGridViewBarang
            FormInputPenyewaan.tKode_Jasa.Text = .Item(0, .CurrentRow.Index).Value
            FormInputPenyewaan.tNama_Barang.Text = .Item(1, .CurrentRow.Index).Value
            FormInputPenyewaan.tHarga_Jual.Text = .Item(2, .CurrentRow.Index).Value
            FormInputPenyewaan.tStok_Awal.Text = .Item(3, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class