﻿Public Class FormSetting

    Private Sub bKoneksi_Click_1(sender As System.Object, e As System.EventArgs) Handles bKoneksi.Click
        If tIP.Text = "" Or tUser.Text = "" Or tDB.Text = "" Or cPort.Text = "" Then
            INF.Pesan("Lengkapi settingan anda", "Peringatan", "Peringatan")
        Else
            Call BukaKoneksi()
            If FormUtama.stsDB.Text = "Connected" Then
                FormUtama.stsDB.ForeColor = Color.Blue
                Me.Close()
            Else
                FormUtama.stsDB.ForeColor = Color.Maroon
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If CheckBox1.Checked = True Then
            tPass.UseSystemPasswordChar = False
        Else
            tPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class