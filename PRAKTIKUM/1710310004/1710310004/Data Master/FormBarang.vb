Public Class FormBarang

    Private Sub FormBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataBarang()
    End Sub

    Sub RefreshDataBarang()
        DB.tampilTabel(GridDataBarang, "tbl_barang", "ID_Barang")
        RapiGrid(GridDataBarang, "tbl_barang")
    End Sub

    Private Sub tTambah_Click(sender As System.Object, e As System.EventArgs) Handles tTambah.Click
        kondisi = True
        FS.FormShow(False, FormInputBarang, Me)
    End Sub

    Private Sub tPencarian_TextChanged(sender As Object, e As System.EventArgs) Handles tPencarian.TextChanged
        Try
            DB.cariData1(GridDataBarang, "SELECT * FROM TBL_BARANG WHERE NAMA_BARANG LIKE '%" & tPencarian.Text & "%'")
            RapiGrid(GridDataBarang, "tbl_barang")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        With GridDataBarang
            FormInputBarang.tID_BARANG.Text = .Item(1, .CurrentRow.Index).Value 'ID
            FormInputBarang.tNAMA_BARANG.Text = .Item(2, .CurrentRow.Index).Value 'ID
            FormInputBarang.tHARGA_BELI.Text = .Item(3, .CurrentRow.Index).Value 'ID
            FormInputBarang.tHARGA_JUAL.Text = .Item(4, .CurrentRow.Index).Value 'ID

            'FormInputBarang.txt.Text = .Item(5, .CurrentRow.Index).Value '

            FormInputBarang.tSTOK_BARANG.Text = .Item(6, .CurrentRow.Index).Value 'ID
            FormInputBarang.tKODE_JENIS.Text = .Item(7, .CurrentRow.Index).Value 'ID
            FormInputBarang.tKODE_MEREK.Text = .Item(8, .CurrentRow.Index).Value 'ID
            FormInputBarang.tKODE_SATUAN.Text = .Item(9, .CurrentRow.Index).Value 'ID
            FormInputBarang.tSATUAN.Text = .Item(10, .CurrentRow.Index).Value 'ID
            FormInputBarang.tUKURAN.Text = .Item(11, .CurrentRow.Index).Value 'ID

            'FormInputBarang.txt.Text = .Item(5, .CurrentRow.Index).Value '

            FormInputBarang.tKETERANGAN.Text = .Item(13, .CurrentRow.Index).Value 'ID
            FormInputBarang.tJML_RETURN.Text = .Item(14, .CurrentRow.Index).Value 'ID

            kondisi = False
            FS.FormShow(False, FormInputBarang, Me)
        End With
    End Sub

    Private Sub bHapus_Click(sender As System.Object, e As System.EventArgs) Handles bHapus.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Anda yakin ingin menghapus data ini..?", vbQuestion + vbYesNo, "Peringatan") = vbYes = True
        If Tanya = True Then
            DB.hapusRecord(GridDataBarang, "tbl_barang", "ID_Barang", "", "ID_Barang", "", True)
        End If
        Call RefreshDataBarang()
    End Sub

    Private Sub ckPilih_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckPilih.CheckedChanged
        FS.CentangItemHapus(GridDataBarang, ckPilih, True)
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub GridDataBarang_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridDataBarang.CellContentClick

    End Sub
End Class