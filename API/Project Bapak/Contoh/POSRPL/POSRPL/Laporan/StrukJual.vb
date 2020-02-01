Public Class StrukJual

    Private Sub StrukJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim NT As New Nota1
        Call LP.CetakLaporan(CRV, NT, "tbl_penjualan1", "", "ID_Penjualan", "", FormInputPenjualan.tIDPenjualan, FormInputPenjualan.tIDPenjualan, True)
    End Sub
End Class