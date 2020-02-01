Public Class FormJenis

    Private Sub FormJenis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataJenis()
    End Sub

    Sub RefreshDataJenis()
        DB.tampilTabel(GridDataJenis, "tbl_jenis", "ID_Jenis")
        RapiGrid(GridDataJenis, "tbl_jenis")
    End Sub

    Private Sub tPencarian_TextChanged(sender As Object, e As System.EventArgs) Handles tPencarian.TextChanged
        DB.cariData(GridDataJenis, "tbl_jenis", "Jenis", "ID_Jenis", tPencarian)
        RapiGrid(GridDataJenis, "tbl_jenis")
    End Sub

    Private Sub tTambah_Click(sender As System.Object, e As System.EventArgs) Handles tTambah.Click
        kondisi = True
        FS.FormShow(False, FormInputJenis, Me)
    End Sub

    Private Sub ckPilih_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckPilih.CheckedChanged
        FS.CentangItemHapus(GridDataJenis, ckPilih, True)
    End Sub

    Private Sub bHapus_Click(sender As System.Object, e As System.EventArgs) Handles bHapus.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Anda yakin ingin menghapus data ini..?", vbQuestion + vbYesNo, "Peringatan") = vbYes = True
        If Tanya = True Then
            DB.hapusRecord(GridDataJenis, "tbl_jenis", "ID_Jenis", "", "ID_Jenis", "", True)
        End If
        Call RefreshDataJenis()
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        kondisi = False
        With GridDataJenis
            FormInputJenis.txtIDJenis.Text = .Item(1, .CurrentRow.Index).Value
            FormInputJenis.txtJenis.Text = .Item(2, .CurrentRow.Index).Value
            FormInputJenis.txtket.Text = .Item(3, .CurrentRow.Index).Value
            kondisi = False
            FS.FormShow(False, FormInputJenis, Me)
        End With
    End Sub





End Class