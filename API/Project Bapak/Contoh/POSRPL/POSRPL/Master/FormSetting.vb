Public Class FormSetting

    Private Sub bKoneki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKoneki.Click
        If txtIP.Text = "" Or txtUser.Text = "" Or txtDB.Text = "" Or cbPort.Text = "" Then
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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class