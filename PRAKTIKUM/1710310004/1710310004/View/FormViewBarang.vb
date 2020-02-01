Public Class FormViewBarang

    Private Sub FormViewBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Call DB.tampilTabel1(DataGridViewBarang, "SELECT ID_Barang, NAMA_BARANG, HARGA_BELI, HARGA_JUAL, STOK, SATUAN FROM TBL_BARANG")
        Call RapiGrid(DataGridViewBarang, "view_barang")
    End Sub

    Private Sub DataGridViewBarang_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridViewBarang.DoubleClick
        With DataGridViewBarang
            FormInputPenjualan.tKode_Barang.Text = .Item(0, .CurrentRow.Index).Value
            FormInputPenjualan.tNama_Barang.Text = .Item(1, .CurrentRow.Index).Value
            FormInputPenjualan.tHarga_Jual.Text = .Item(2, .CurrentRow.Index).Value
            FormInputPenjualan.tStok_Awal.Text = .Item(3, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class