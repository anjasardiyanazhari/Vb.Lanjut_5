Imports MySql.Data.MySqlClient
Public Class FormLogin

    Private Sub bMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMasuk.Click
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
                            FormUtama.mnDataPengguna.Enabled = True
                        Else
                            FormUtama.mnDataPengguna.Enabled = False
                        End If

                        If .Rdr.GetValue(5) = 1 Then
                            FormUtama.mnDataJenis.Enabled = True
                        Else
                            FormUtama.mnDataJenis.Enabled = False
                        End If

                        If .Rdr.GetValue(6) = 1 Then
                            FormUtama.mnDataSatuan.Enabled = True
                        Else
                            FormUtama.mnDataSatuan.Enabled = False
                        End If

                        If .Rdr.GetValue(7) = 1 Then
                            FormUtama.mnDataMerek.Enabled = True
                        Else
                            FormUtama.mnDataMerek.Enabled = False
                        End If

                        If .Rdr.GetValue(8) = 1 Then
                            FormUtama.mnDataBarang.Enabled = True
                        Else
                            FormUtama.mnDataBarang.Enabled = False
                        End If

                        If .Rdr.GetValue(9) = 1 Then
                            FormUtama.mnDataSuplier.Enabled = True
                        Else
                            FormUtama.mnDataSuplier.Enabled = False
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