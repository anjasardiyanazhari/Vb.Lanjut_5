Public Class StrukJual

    Private Sub StrukJual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim NT As New Nota
        Call LP.CetakLaporan(CRV, NT, "tbl_penjualan1", "", "ID_Penjualan", "", FormInputPenjualan.tId_Penjualan, FormInputPenjualan.tId_Penjualan, True)
    End Sub
End Class