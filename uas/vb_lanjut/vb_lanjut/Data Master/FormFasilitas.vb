Public Class FormFasilitas

    Private Sub FormFasilitas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataFasilitas()
    End Sub

    Sub RefreshDataFasilitas()
        DB.tampilTabel(GridDataFasilitas, "tbl_fasilitas", "ID_Fasilitas")
        RapiGrid(GridDataFasilitas, "tbl_fasilitas")
    End Sub

    Private Sub tPencarian_TextChanged(sender As Object, e As System.EventArgs) Handles tPencarian.TextChanged
        DB.cariData(GridDataFasilitas, "tbl_fasilitas", "fasilitas", "ID_Fasilitas", tPencarian)
        RapiGrid(GridDataFasilitas, "tbl_fasilitas")
    End Sub

    Private Sub tTambah_Click(sender As System.Object, e As System.EventArgs) Handles tTambah.Click
        kondisi = True
        FS.FormShow(False, FormInputFasilitas, Me)
    End Sub

    Private Sub ckPilih_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckPilih.CheckedChanged
        FS.CentangItemHapus(GridDataFasilitas, ckPilih, True)
    End Sub

    Private Sub bHapus_Click(sender As System.Object, e As System.EventArgs) Handles bHapus.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Anda yakin ingin menghapus data ini..?", vbQuestion + vbYesNo, "Peringatan") = vbYes = True
        If Tanya = True Then
            DB.hapusRecord(GridDataFasilitas, "tbl_fasilitas", "ID_Fasilitas", "", "ID_Fasilitas", "", True)
        End If
        Call RefreshDataFasilitas()
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        kondisi = False
        With GridDataFasilitas
            FormInputFasilitas.txtIDFasilitas.Text = .Item(1, .CurrentRow.Index).Value
            FormInputFasilitas.txtFasilitas.Text = .Item(2, .CurrentRow.Index).Value
            FormInputFasilitas.txtket.Text = .Item(3, .CurrentRow.Index).Value
            kondisi = False
            FS.FormShow(False, FormInputFasilitas, Me)
        End With
    End Sub

    Private Sub tPencarian_Click(sender As System.Object, e As System.EventArgs) Handles tPencarian.Click

    End Sub


End Class