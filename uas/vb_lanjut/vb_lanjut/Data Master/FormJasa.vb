Public Class FormJasa

    Private Sub FormJasa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataJasa()
    End Sub

    Sub RefreshDataJasa()
        DB.tampilTabel(GridDataJasa, "tbl_jasa", "ID_Jasa")
        RapiGrid(GridDataJasa, "tbl_jasa")
    End Sub

    Private Sub tTambah_Click(sender As System.Object, e As System.EventArgs) Handles tTambah.Click
        kondisi = True
        FS.FormShow(False, FormInputJasa, Me)
    End Sub

    Private Sub tPencarian_TextChanged(sender As Object, e As System.EventArgs) Handles tPencarian.TextChanged
        Try
            DB.cariData1(GridDataJasa, "SELECT * FROM TBL_JASA WHERE NAMA_JASA LIKE '%" & tPencarian.Text & "%'")
            RapiGrid(GridDataJasa, "tbl_jasa")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        With GridDataJasa
            FormInputJasa.txtIDJasa.Text = .Item(1, .CurrentRow.Index).Value 'ID
            FormInputJasa.txtNama_Jasa.Text = .Item(2, .CurrentRow.Index).Value 'ID
            FormInputJasa.txtHarga_Awal.Text = .Item(3, .CurrentRow.Index).Value 'ID
            FormInputJasa.txtHarga_Sewa.Text = .Item(4, .CurrentRow.Index).Value 'ID

            'FormInputBarang.txt.Text = .Item(5, .CurrentRow.Index).Value '

            FormInputJasa.txtStok.Text = .Item(6, .CurrentRow.Index).Value 'ID
            FormInputJasa.txtKode_Kategori.Text = .Item(7, .CurrentRow.Index).Value 'ID
            FormInputJasa.txtKode_Fasilitas.Text = .Item(8, .CurrentRow.Index).Value 'ID

            'FormInputBarang.txt.Text = .Item(5, .CurrentRow.Index).Value '

            FormInputJasa.txtKet.Text = .Item(10, .CurrentRow.Index).Value 'ID
            FormInputJasa.txtJml_Return.Text = .Item(11, .CurrentRow.Index).Value 'ID

            kondisi = False
            FS.FormShow(False, FormInputJasa, Me)
        End With
    End Sub

    Private Sub bHapus_Click(sender As System.Object, e As System.EventArgs) Handles bHapus.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Anda yakin ingin menghapus data ini..?", vbQuestion + vbYesNo, "Peringatan") = vbYes = True
        If Tanya = True Then
            DB.hapusRecord(GridDataJasa, "tbl_jasa", "ID_Jasa", "", "ID_Jasa", "", True)
        End If
        Call RefreshDataJasa()
    End Sub

    Private Sub ckPilih_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckPilih.CheckedChanged
        FS.CentangItemHapus(GridDataJasa, ckPilih, True)
    End Sub
End Class