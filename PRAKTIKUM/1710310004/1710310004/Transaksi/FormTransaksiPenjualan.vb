Public Class FormTransaksiPenjualan

    Private Sub GridDataBarang_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridDataPenjualan.CellContentClick
        Call RefreshDataPenjualan()
    End Sub

    Sub RefreshDataPenjualan()
        Call DB.tampilTabel(GridDataPenjualan, "view_jual", "ID_Penjualan")
        Call RapiGrid(GridDataPenjualan, "view_jual")
    End Sub

    Private Sub tTambah_Click(sender As System.Object, e As System.EventArgs) Handles tTambah.Click
        kondisi = True
        FS.FormShow(False, FormInputPenjualan, Me)
    End Sub

    Private Sub FormTransaksiPenjualan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class