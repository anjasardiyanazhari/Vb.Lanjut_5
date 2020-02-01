Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub FormLoginvb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub bLogin_Click(sender As System.Object, e As System.EventArgs) Handles bLogin.Click
        If tUsername.Text = "" Or tPassword.Text = "" Then
            INF.Pesan("Data Belum Lengkap", "Peringatan", "peringata")
        Else
            With DB
                .Con.Close() : .Con.Open()
                .Cmd = New MySqlCommand("SELECT * FROM TBL_PENGGUNA WHERE USERNAME='" & tUsername.Text & "' AND PASSWORD='" & tPassword.Text & "' AND TIPE='" & cbLevel.Text & "'", .Con)
                .Rdr = .Cmd.ExecuteReader
                .Rdr.Read()
                If .Rdr.HasRows = True Then
                    If .Rdr.GetString(3) = "Administrator" Then 'jika admin
                        If .Rdr.GetValue(4) = 1 Then
                            FormUtama.mmDataPengguna.Enabled = True
                        Else
                            FormUtama.mmDataPengguna.Enabled = False
                        End If
                    Else 'jika user

                    End If
                Else
                    INF.Pesan("Username dan Password Anda Tidak Ditemukan", "Error", "Gagal Login")
                End If
            End With
        End If

    End Sub
End Class