Public Class FormViewBarang

    Private Sub FormViewBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Call DB.tampilTabel1(GridViewDataBarang, "SELECT ID_BARANG, NAMA_BARANG, HARGA_BELI, HARGA_JUAL, STOK, SATUAN FROM TBL_BARANG")
        Call RapiGrid(GridViewDataBarang, "view_barang")
    End Sub

    
    Private Sub GridViewDataBarang_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewDataBarang.DoubleClick
        With GridViewDataBarang
            FormInputPenjualan.tIDBarang.Text = .Item(0, .CurrentRow.Index).Value
            FormInputPenjualan.tNamaBarang.Text = .Item(1, .CurrentRow.Index).Value
            FormInputPenjualan.tHargaJual.Text = .Item(3, .CurrentRow.Index).Value
            FormInputPenjualan.tStokAwal.Text = .Item(4, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub
End Class