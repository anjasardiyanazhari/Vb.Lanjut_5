Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub bMasuk_Click(sender As System.Object, e As System.EventArgs) Handles bMasuk.Click
        If tUser.Text = "" Or tPass.Text = "" Or cbTipe.Text = "" Then
            INF.Pesan("Masukan Username Dan Password Anda", "Peringatan", "Peringatan")
        Else
            With DB
                .Con.Close() : .Con.Open()
                .Cmd = New MySqlCommand("SELECT * FROM TBL_PENGGUNA WHERE USERNAME ='" & tUser.Text &
                                        "' AND PASSWORD ='" & tPass.Text & "' AND TIPE ='" & cbTipe.Text & "'", .Con)
                .Rdr = .Cmd.ExecuteReader
                .Rdr.Read()
                If .Rdr.HasRows = True Then 'JIKA USERNAME DAN PASSWORD DI TEMUKAN
                    If .Rdr.GetString(3) = "Administrator" Then 'jika admin

                        If .Rdr.GetValue(4) = 1 Then
                            FormUtama.mmDataPengguna.Enabled = True
                        Else
                            FormUtama.mmDataPengguna.Enabled = False
                        End If

                        If .Rdr.GetValue(5) = 1 Then
                            FormUtama.mmDataKategori.Enabled = True
                        Else
                            FormUtama.mmDataKategori.Enabled = False
                        End If

                        If .Rdr.GetValue(6) = 1 Then
                            FormUtama.mmDataFasilitas.Enabled = True
                        Else
                            FormUtama.mmDataFasilitas.Enabled = False
                        End If

                        If .Rdr.GetValue(7) = 1 Then
                            FormUtama.mmDataJasa.Enabled = True
                        Else
                            FormUtama.mmDataJasa.Enabled = False
                        End If

                        If .Rdr.GetValue(8) = 1 Then
                            FormUtama.mmDataPenyewaan.Enabled = True
                        Else
                            FormUtama.mmDataPenyewaan.Enabled = False
                        End If

                    Else 'jika pengguna biasa


                    End If
                    Me.Close()
                Else 'JIKA USERNAME DAN PASSWORD DI TIDAK TEMUKAN
                    INF.Pesan("Username Dan Password Anda Tidak Ditemukan", "Error", "Gagal Login")
                End If
            End With
        End If
    End Sub
End Class