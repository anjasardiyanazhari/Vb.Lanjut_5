Public Class FormInputPengguna

    Sub DataPengguna()
        Call DB.tampilTabel1(GridPengguna, "SELECT ID_PENGGUNA, USERNAME, TIPE FROM TBL_PENGGUNA")
        With GridPengguna
            .Columns(0).Width = 160
            .Columns(0).HeaderText = "ID.Pengguna"
            .Columns(1).Width = 450
            .Columns(1).HeaderText = "Nama Pengguna"
            .Columns(2).Width = 300
            .Columns(2).HeaderText = "Tipe Pengguna"
        End With
    End Sub

    Private Sub FormInputPengguna_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call DataPengguna()
    End Sub

    Private Sub ckShow_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckShow.CheckedChanged
        If ckShow.Checked = True Then
            tPass.UseSystemPasswordChar = False
        Else
            tPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub bSimpan_Click(sender As System.Object, e As System.EventArgs) Handles bSimpan.Click
        If tID.Text = "" Or tUsername.Text = "" Or tPass.Text = "" Or cbTipe.Text = "" Then
            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            Dim Pengguna, Kategori, Fasilitas, Jasa, Penyewaan As Integer
            If ckPengguna.Checked = True Then
                Pengguna = 1
            Else
                Pengguna = 0
            End If

            If ckKategori.Checked = True Then
                Kategori = 1
            Else
                Kategori = 0
            End If

            If ckFasilitas.Checked = True Then
                Fasilitas = 1
            Else
                Fasilitas = 0
            End If

            If ckJasa.Checked = True Then
                Jasa = 1
            Else
                Jasa = 0
            End If

            If ckPenyewaan.Checked = True Then
                Penyewaan = 1
            Else
                Penyewaan = 0
            End If

            '==========='

            DB.manipulasi("INSERT IGNORE INTO TBL_PENGGUNA VALUES ('" & tID.Text & "','" & tUsername.Text & "','" & tPass.Text &
                          "','" & cbTipe.Text & "','" & Pengguna & "','" & Kategori & "','" & Fasilitas & "','" & Jasa & "','" & Penyewaan &
                          "')", "Simpan")

            Call DataPengguna()
        End If
    End Sub
End Class