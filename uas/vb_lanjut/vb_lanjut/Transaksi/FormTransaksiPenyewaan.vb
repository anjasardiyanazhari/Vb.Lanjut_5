Public Class FormTransaksiPenyewaan

    Private Sub GridDataTransaksi_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridDataTransaksi.CellContentClick
        Call RefreshDataPenjualan()
    End Sub

    Sub RefreshDataPenjualan()
        Call DB.tampilTabel(GridDataTransaksi, "VIEW_SEWA", "ID_Penyewaan")
        Call RapiGrid(GridDataTransaksi, "view_jual")
    End Sub

    Private Sub tTambah_Click(sender As System.Object, e As System.EventArgs) Handles tTambah.Click
        kondisi = True
        FS.FormShow(False, FormInputPenyewaan, Me)
    End Sub

    Private Sub ckPilih_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckPilih.CheckedChanged
        FS.CentangItemHapus(GridDataTransaksi, ckPilih, True)
    End Sub

    Private Sub bHapus_Click(sender As System.Object, e As System.EventArgs) Handles bHapus.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Anda yakin ingin menghapus data ini..?", vbQuestion + vbYesNo, "Peringatan") = vbYes = True
        If Tanya = True Then
            DB.hapusRecord(GridDataTransaksi, "tbl_penyewaan", "ID_Penyewaan", "", "ID_Penyewaan", "", True)
        End If
        Call RefreshDataPenjualan()
    End Sub
End Class