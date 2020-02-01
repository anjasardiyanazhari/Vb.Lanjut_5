Public Class FormLoginPengguna
    Sub DataPengguna()
        Call DB.tampilTabel1(GridPengguna, "SELECT ID_PENGGUNA, USERNAME, TIPE FROM TBL_PENGGUNA")
        With GridPengguna
            .Columns(0).Width = 150
            .Columns(0).HeaderText = "ID.Pengguna"
            .Columns(1).Width = 450
            .Columns(1).HeaderText = "Nama Pengguna"
            .Columns(2).Width = 200
            .Columns(2).HeaderText = "Tipe Pengguna"
        End With
    End Sub

    Private Sub FormLoginPengguna_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call DataPengguna()
    End Sub

    Private Sub bLogin_Click(sender As System.Object, e As System.EventArgs) Handles bLogin.Click
        If tId_pengguna.Text = "" Or tUsername.Text = "" Or cbLevel.Text = "" Then
            INF.Pesan("Data Belum Lengkap", "Peringatan", "peringata")
        Else
            Dim Pengguna, Jenis, Satuan, Merek, Barang, Suplier, Pembelian, Penjualan, Batal_penjualan, Return_barang, Opname As Integer

            If ckPengguna.Checked = True Then
                Pengguna = 1
            Else
                Pengguna = 0
            End If

            If ckJenis.Checked = True Then
                jenis = 1
            Else
                jenis = 0
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
                Batal_penjualan = 1
            Else
                Batal_penjualan = 0
            End If

            If ckReturnBarang.Checked = True Then
                Return_barang = 1
            Else
                Return_barang = 0
            End If

            If ckOpnameStok.Checked = True Then
                Opname = 1
            Else
                Opname = 0
            End If

            DB.manipulasi("INSERT IGNORE INTO TBL_PENGGUNA VALUE('" & tId_pengguna.Text & "', '" & tUsername.Text & "', '" & tPassword.Text & "', '" & cbLevel.Text &
                    "', '" & Pengguna & "', '" & Jenis & "', '" & Satuan & "', '" & Merek & "', '" & Barang & "', '" & Suplier & "', '" & Pembelian & "', '" & Penjualan &
                    "', '" & Batal_penjualan & "','" & Return_barang & "', '" & Opname & "')", "Simpan")
            Call DataPengguna()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            tPassword.UseSystemPasswordChar = False
        Else
            tPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class