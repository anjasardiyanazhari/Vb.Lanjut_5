Public Class FormBarang

    Sub RefreshDataBarang()
        DB.tampilTabel(GridDataBarang, "tbl_barang", "ID_Barang")
        RapiGrid(GridDataBarang, "tbl_barang")
    End Sub

    Private Sub FormBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call RefreshDataBarang()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Kondisi = True
        FS.FormShow(False, FormInputBarang, Me)
    End Sub

    Private Sub txtPencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPencarian.TextChanged
        Try
            DB.cariData1(GridDataBarang, "SELECT * FROM TBL_BARANG WHERE NAMA_BARANG LIKE '%" & txtPencarian.Text & "%' OR ID_BARANG LIKE '%" & txtPencarian.Text & "%'")
            RapiGrid(GridDataBarang, "tbl_barang")
        Catch ex As Exception
        End Try
    End Sub


    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        With GridDataBarang
            FormInputBarang.txtIDBarang.Text = .Item(1, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtNamaBarang.Text = .Item(2, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtHargaBeli.Text = .Item(3, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtHargaJual.Text = .Item(4, .CurrentRow.Index).Value 'ID
            'FormInputBarang.txt.Text = .Item(5, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtStok.Text = .Item(6, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtIDJenis.Text = .Item(7, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtIDMerek.Text = .Item(8, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtIDSatuan.Text = .Item(9, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtSatuan.Text = .Item(10, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtUkuran.Text = .Item(11, .CurrentRow.Index).Value 'ID
            'FormInputBarang.txtIDBarang.Text = .Item(12, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtKet.Text = .Item(13, .CurrentRow.Index).Value 'ID
            FormInputBarang.txtJmlReturn.Text = .Item(14, .CurrentRow.Index).Value 'ID
            'FormInputBarang.txtIDBarang.Text = .Item(15, .CurrentRow.Index).Value 'ID
            Kondisi = False
            FS.FormShow(False, FormInputBarang, Me)
        End With
    End Sub
End Class