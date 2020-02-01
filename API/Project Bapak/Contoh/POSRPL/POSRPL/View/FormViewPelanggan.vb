Public Class FormViewPelanggan

    Private Sub FormViewPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        DB.tampilTabel1(GridViewPelanggan, "SELECT ID_PELANGGAN, NAMA_PELANGGAN FROM TBL_PELANGGAN")
        With GridViewPelanggan
            .Columns(0).HeaderText = "ID.Pelanggan"
            .Columns(0).Width = 140
            .Columns(1).HeaderText = "Nama Pelanggan"
            .Columns(1).Width = 220
        End With
    End Sub

    Private Sub GridViewPelanggan_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewPelanggan.DoubleClick
        With GridViewPelanggan
            FormInputPenjualan.tIDPelanggan.Text = .Item(0, .CurrentRow.Index).Value
            FormInputPenjualan.tNamaPelanggan.Text = .Item(1, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub

    Private Sub txtPencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPencarian.TextChanged
        Call DB.cariData1(GridViewPelanggan, "SELECT ID_PELANGGAN, NAMA_PELANGGAN FROM TBL_PELANGGAN WHERE ID_PELANGGAN LIKE '%" & txtPencarian.Text &
                          "%' OR NAMA_PELANGGAN LIKE '%" & txtPencarian.Text & "%'")
    End Sub
End Class