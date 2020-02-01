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
    Private Sub FormInputPengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call DataPengguna()
    End Sub

    Private Sub ckShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckShow.CheckedChanged
        If ckShow.Checked = True Then
            tPass.UseSystemPasswordChar = False
        Else
            tPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub bSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSimpan.Click
        If tID.Text = "" Or tUsername.Text = "" Or tPass.Text = "" Or cbTipe.Text = "" Then
            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            Dim Pengguna, Jenis, Satuan, Merek, Barang, Suplier, Pembelian, Penjualan, BatalPenjualan, ReturnBarang, Opname As Integer
            If ckPengguna.Checked = True Then
                Pengguna = 1
            Else
                Pengguna = 0
            End If

            If ckJenis.Checked = True Then
                Jenis = 1
            Else
                Jenis = 0
            End If

            If ckSatuan.Checked = True Then
                Satuan = 1
            Else
                Satuan = 0
            End If

            If ckMerek.Checked = True Then
                Merek = 1
            Else
                Merek = 0
            End If

            If ckBarang.Checked = True Then
                Barang = 1
            Else
                Barang = 0
            End If

            If ckSuplier.Checked = True Then
                Suplier = 1
            Else
                Suplier = 0
            End If

            If ckPembelian.Checked = True Then
                Pembelian = 1
            Else
                Pembelian = 0
            End If

            If ckPenjualan.Checked = True Then
                Penjualan = 1
            Else
                Penjualan = 0
            End If

            If ckBatalPenjualan.Checked = True Then
                BatalPenjualan = 1
            Else
                BatalPenjualan = 0
            End If

            If ckReturn.Checked = True Then
                ReturnBarang = 1
            Else
                ReturnBarang = 0
            End If

            If ckOpname.Checked = True Then
                Opname = 1
            Else
                Opname = 0
            End If
            '==========='
            
            DB.manipulasi("INSERT IGNORE INTO TBL_PENGGUNA VALUES ('" & tID.Text & "','" & tUsername.Text & "','" & tPass.Text &
                          "','" & cbTipe.Text & "','" & Pengguna & "','" & Jenis & "','" & Satuan & "','" & Merek & "','" & Barang &
                          "','" & Suplier & "','" & Pembelian & "','" & Penjualan & "','" & BatalPenjualan &
                          "','" & ReturnBarang & "','" & Opname & "')", "Simpan")

            Call DataPengguna()
        End If
    End Sub
End Class