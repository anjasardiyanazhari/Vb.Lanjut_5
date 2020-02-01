Public Class FormStrukSewa

    Private Sub FormStrukSewa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim NT As New NotaSewa
        Call LP.CetakLaporan(CrystalReportViewer1, NT, "tbl_penyewaan1", "", "ID_Penyewaan", "", FormInputPenyewaan.tId_Penyewaan, FormInputPenyewaan.tId_Penyewaan, True)
    End Sub
End Class