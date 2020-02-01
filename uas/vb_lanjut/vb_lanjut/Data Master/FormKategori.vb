Public Class FormKategori

    Private Sub FormKategori_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataKategori()
    End Sub

    Sub RefreshDataKategori()
        DB.tampilTabel(GridDataKategori, "tbl_kategori", "ID_Kategori")
        RapiGrid(GridDataKategori, "tbl_kategori")
    End Sub

    Private Sub tPencarian_TextChanged(sender As Object, e As System.EventArgs) Handles tPencarian.TextChanged
        DB.cariData(GridDataKategori, "tbl_kategori", "Kategori", "ID_Kategori", tPencarian)
        RapiGrid(GridDataKategori, "tbl_kategori")
    End Sub

    Private Sub tTambah_Click(sender As System.Object, e As System.EventArgs) Handles tTambah.Click
        kondisi = True
        FS.FormShow(False, FormInputKategori, Me)
    End Sub

    Private Sub ckPilih_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckPilih.CheckedChanged
        FS.CentangItemHapus(GridDataKategori, ckPilih, True)
    End Sub

    Private Sub bHapus_Click(sender As System.Object, e As System.EventArgs) Handles bHapus.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Anda yakin ingin menghapus data ini..?", vbQuestion + vbYesNo, "Peringatan") = vbYes = True
        If Tanya = True Then
            DB.hapusRecord(GridDataKategori, "tbl_kategori", "ID_Kategori", "", "ID_Kategori", "", True)
        End If
        Call RefreshDataKategori()
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        kondisi = False
        With GridDataKategori
            FormInputKategori.txtIDKategori.Text = .Item(1, .CurrentRow.Index).Value
            FormInputKategori.txtKategori.Text = .Item(2, .CurrentRow.Index).Value
            FormInputKategori.txtKet.Text = .Item(3, .CurrentRow.Index).Value
            kondisi = False
            FS.FormShow(False, FormInputKategori, Me)
        End With
    End Sub

End Class