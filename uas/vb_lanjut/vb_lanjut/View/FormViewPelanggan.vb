Public Class FormViewPelanggan

    Private Sub FormViewPelanggan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        DB.tampilTabel1(DataGridViewPelanggan, "SELECT ID_Pelanggan, NAMA_PELANGGAN FROM TBL_PELANGGAN")
        With DataGridViewPelanggan
            .Columns(0).HeaderText = "ID Pelanggan"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "Nama Pelanggan"
            .Columns(1).Width = 150
        End With
    End Sub

    Private Sub DataGridViewPelanggan_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridViewPelanggan.DoubleClick
        With DataGridViewPelanggan
            FormInputPenyewaan.tId_Pelanggan.Text = .Item(0, .CurrentRow.Index).Value
            FormInputPenyewaan.tNama_Pelanggan.Text = .Item(1, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub

    Private Sub tPencarian_TextChanged(sender As Object, e As System.EventArgs) Handles tPencarian.TextChanged
        Call DB.cariData1(DataGridViewPelanggan, "SELECT ID_PELANGGAN, NAMA_PELANGGAN FROM TBL_PELANGGAN WHERE ID_PELANGGAN LIKE '%" & tPencarian.Text &
                  "%' OR NAMA_PELANGGAN LIKE '%" & tPencarian.Text & "%'")
    End Sub
End Class