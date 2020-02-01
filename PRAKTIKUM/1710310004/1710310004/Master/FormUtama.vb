Public Class FormUtama
    Private Sub SettingDBToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingDBToolStripMenuItem.Click
        FS.FormShow(False, FormSetting, Me)
    End Sub

    Private Sub DataJenisToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mmDataJenis.Click
        FS.FormShow(True, FormJenis, Me)
    End Sub

    Private Sub DataMerekToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mmDataMerek.Click
        FS.FormShow(True, FormMerek, Me)
    End Sub

    Private Sub DataSatuanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mmDataSatuan.Click
        FS.formChildClose(Me, "[FormUtama]")
        FS.FormShow(True, FormSatuan, Me)
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mmDataBarang.Click
        FS.formChildClose(Me, "[FormUtama]")
        FS.FormShow(True, FormBarang, Me)
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FS.formChildClose(Me, "[FormUtama]")
        FS.FormShow(True, FormTransaksiPenjualan, Me)
    End Sub

    Private Sub FormUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FS.formChildClose(Me, "[FormUtama]")
        FS.FormShow(True, FormLogin, Me)
    End Sub

    Private Sub DataPenggunaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mmDataPengguna.Click
        FS.formChildClose(Me, "[FormUtama]")
        FS.FormShow(True, FormLoginPengguna, Me)
    End Sub

    Sub NonAktif()
        With Me
            .mmDataPengguna.Enabled = False
            .mmDataJenis.Enabled = False
            .mmDataSatuan.Enabled = False
            .mmDataMerek.Enabled = False
            .mmDataBarang.Enabled = False
            .mmDataSuplier.Enabled = False
        End With
    End Sub


End Class