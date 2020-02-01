Public Class FormMerek

    Private Sub FormMerek_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataMerek()
    End Sub

    Sub RefreshDataMerek()
        DB.tampilTabel(GridDataMerek, "tbl_merek", "ID_Merek")
        RapiGrid(GridDataMerek, "tbl_merek")
    End Sub

    Private Sub tPencarian_TextChanged(sender As Object, e As System.EventArgs) Handles tPencarian.TextChanged
        DB.cariData(GridDataMerek, "tbl_merek", "Merek", "ID_Merek", tPencarian)
        RapiGrid(GridDataMerek, "tbl_merek")
    End Sub

    Private Sub tTambah_Click(sender As System.Object, e As System.EventArgs) Handles tTambah.Click
        kondisi = True
        FS.FormShow(False, FormInputMerek, Me)
    End Sub

    Private Sub ckPilih_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckPilih.CheckedChanged
        FS.CentangItemHapus(GridDataMerek, ckPilih, True)
    End Sub

    Private Sub bHapus_Click(sender As System.Object, e As System.EventArgs) Handles bHapus.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Anda yakin ingin menghapus data ini..?", vbQuestion + vbYesNo, "Peringatan") = vbYes = True
        If Tanya = True Then
            DB.hapusRecord(GridDataMerek, "tbl_merek", "ID_Merek", "", "ID_Merek", "", True)
        End If
        Call RefreshDataMerek()
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        kondisi = False
        With GridDataMerek
            FormInputMerek.txtIDMerek.Text = .Item(1, .CurrentRow.Index).Value
            FormInputMerek.txtMerek.Text = .Item(2, .CurrentRow.Index).Value
            FormInputMerek.txtket.Text = .Item(3, .CurrentRow.Index).Value
            kondisi = False
            FS.FormShow(False, FormInputMerek, Me)
        End With
    End Sub
End Class