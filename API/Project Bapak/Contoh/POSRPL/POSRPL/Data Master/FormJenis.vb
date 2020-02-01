Public Class FormJenis

    Private Sub FormJenis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataJenis()
    End Sub

    Sub RefreshDataJenis()
        DB.tampilTabel(GridDataJenis, "tbl_jenis", "ID_Jenis")
        RapiGrid(GridDataJenis, "tbl_jenis")
    End Sub

    Private Sub txtPencarian_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPencarian.Click

    End Sub

    Private Sub txtPencarian_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPencarian.TextChanged
        DB.cariData(GridDataJenis, "tbl_jenis", "Jenis", "ID_Jenis", txtPencarian)
        RapiGrid(GridDataJenis, "tbl_jenis")
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Kondisi = True
        FS.formShow(False, FormInputJenis, Me)
    End Sub

    Private Sub ckPilih_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckPilih.CheckedChanged
        FS.centangItemHapus(GridDataJenis, ckPilih, True)
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Yakin hapus data ..?", vbQuestion + vbYesNo, "Peringatan") = vbYes = True
        If Tanya = True Then
            DB.hapusRecord(GridDataJenis, "tbl_jenis", "ID_Jenis", "", "ID_Jenis", "", True)
        End If
        Call RefreshDataJenis()
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        With GridDataJenis
            FormInputJenis.txtIDJenis.Text = .Item(1, .CurrentRow.Index).Value
            FormInputJenis.txtJenis.Text = .Item(2, .CurrentRow.Index).Value
            FormInputJenis.txtKet.Text = .Item(3, .CurrentRow.Index).Value
            Kondisi = False
            FS.FormShow(False, FormInputJenis, Me)
        End With
    End Sub
End Class