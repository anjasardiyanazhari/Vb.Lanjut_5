Public Class FormSatuan

    Private Sub FormSatuan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataSatuan()
    End Sub

    Sub RefreshDataSatuan()
        DB.tampilTabel(GridDataSatuan, "tbl_satuan", "ID_Satuan")
        RapiGrid(GridDataSatuan, "tbl_satuan")
    End Sub

    Private Sub tPencarian_TextChanged(sender As Object, e As System.EventArgs) Handles tPencarian.TextChanged
        DB.cariData(GridDataSatuan, "tbl_satuan", "Satuan", "ID_Satuan", tPencarian)
        RapiGrid(GridDataSatuan, "tbl_Satuan")
    End Sub

    Private Sub tTambah_Click(sender As System.Object, e As System.EventArgs) Handles tTambah.Click
        kondisi = True
        FS.FormShow(False, FormInputSatuan, Me)
    End Sub

    Private Sub ckPilih_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckPilih.CheckedChanged
        FS.CentangItemHapus(GridDataSatuan, ckPilih, True)
    End Sub

    Private Sub bHapus_Click(sender As System.Object, e As System.EventArgs) Handles bHapus.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Anda yakin ingin menghapus data ini..?", vbQuestion + vbYesNo, "Peringatan") = vbYes = True
        If Tanya = True Then
            DB.hapusRecord(GridDataSatuan, "tbl_satuan", "ID_Satuan", "", "ID_Satuan", "", True)
        End If
        Call RefreshDataSatuan()
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        kondisi = False
        With GridDataSatuan
            FormInputSatuan.txtIDSatuan.Text = .Item(1, .CurrentRow.Index).Value
            FormInputSatuan.txtSatuan.Text = .Item(2, .CurrentRow.Index).Value
            FormInputSatuan.txtket.Text = .Item(3, .CurrentRow.Index).Value
            kondisi = False
            FS.FormShow(False, FormInputSatuan, Me)
        End With
    End Sub
End Class