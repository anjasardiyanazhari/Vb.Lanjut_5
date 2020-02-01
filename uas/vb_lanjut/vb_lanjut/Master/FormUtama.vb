Public Class FormUtama
    Private Sub FormUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SettingDBToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingDBToolStripMenuItem.Click
        FS.FormShow(False, FormSetting, Me)
    End Sub

    Private Sub mmDataKategori_Click(sender As System.Object, e As System.EventArgs) Handles mmDataKategori.Click
        FS.FormShow(True, FormKategori, Me)
    End Sub

    Private Sub mmDataFasilitas_Click(sender As System.Object, e As System.EventArgs) Handles mmDataFasilitas.Click
        FS.FormShow(True, FormFasilitas, Me)
    End Sub

    Private Sub mmDataJasa_Click(sender As System.Object, e As System.EventArgs) Handles mmDataJasa.Click
        FS.FormShow(True, FormJasa, Me)
    End Sub

    Private Sub mmDataPenyewaan_Click(sender As System.Object, e As System.EventArgs) Handles mmDataPenyewaan.Click
        FS.formChildClose(Me, "[FormUtama]")
        FS.FormShow(True, FormTransaksiPenyewaan, Me)
    End Sub

    Private Sub mmDataPengguna_Click(sender As System.Object, e As System.EventArgs) Handles mmDataPengguna.Click
        FS.formChildClose(Me, "[FormUtama]")
        FS.FormShow(True, FormInputPengguna, Me)
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FS.formChildClose(Me, "[FormUtama]")
        FS.FormShow(True, FormLogin, Me)
    End Sub
End Class