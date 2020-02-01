Public Class FormUtama

    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        FS.formShow(False, FormSetting, Me)
    End Sub

    Private Sub DataJenisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDataJenis.Click
        FS.formChildClose(Me, "[Form Utama]")
        FS.FormShow(True, FormJenis, Me)
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDataBarang.Click
        FS.formChildClose(Me, "[Form Utama]")
        FS.FormShow(True, FormBarang, Me)
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FS.formChildClose(Me, "[Form Utama]")
        FS.FormShow(True, FormTransaksiPenjualan, Me)
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FS.formChildClose(Me, "[Form Utama]")
        FS.FormShow(False, FormLogin, Me)
    End Sub

    Private Sub DataPenggunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDataPengguna.Click
        FS.formChildClose(Me, "[Form Utama]")
        FS.FormShow(True, FormInputPengguna, Me)
    End Sub

    Sub NonAktif()
        With Me
            .mnDataPengguna.Enabled = False
            .mnDataJenis.Enabled = False
            .mnDataMerek.Enabled = False
            .mnDataSatuan.Enabled = False
            .mnDataBarang.Enabled = False
            .mnDataSuplier.Enabled = False
        End With
    End Sub

    Private Sub FormUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call NonAktif()
    End Sub
End Class
