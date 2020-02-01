Public Class FormTransaksiPenjualan

    Private Sub FormTransaksiPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataPenjualan()
    End Sub

    Sub RefreshDataPenjualan()
        Call DB.tampilTabel(GridDataPenjualan, "view_jual", "ID_Penjualan")
        Call RapiGrid(GridDataPenjualan, "view_jual")
    End Sub



    Private Sub bTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTambah.Click
        Kondisi = True
        FS.FormShow(False, FormInputPenjualan, Me)
    End Sub
End Class