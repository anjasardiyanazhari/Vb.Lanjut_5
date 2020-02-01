Imports MySql.Data.MySqlClient
Public Class FormInputBarang
    Dim HargaBeli1, HargaBeli2 As Double
    Dim HargaJual1, HargaJual2 As Double
    Dim Selisih, Sub_Selisih As Double

    Private Sub txtIDBarang_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            With DB
                .Con.Close() : .Con.Open()
                .Cmd = New MySqlCommand("SELECT ID_BARANG FROM TBL_BARANG WHERE ID_BARANG='" & txtIDBarang.Text &
                                        "'", .Con)
                .Rdr = .Cmd.ExecuteReader
                .Rdr.Read()
                If .Rdr.HasRows = True Then
                    INF.Pesan("Ada data", "Informasi", "Informasi")
                End If
                .Rdr.Close()
            End With
        End If
    End Sub

    Private Sub ckKapital_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckKapital.CheckedChanged
        If ckKapital.Checked = True Then
            txtNamaBarang.CharacterCasing = CharacterCasing.Upper
        Else
            txtNamaBarang.CharacterCasing = CharacterCasing.Normal
        End If
    End Sub

    Private Sub txtHargaBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaBeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = ",") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtHargaBeli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHargaBeli.TextChanged
        Try
            HargaBeli1 = CDbl(txtHargaBeli.Text)
            HargaBeli2 = CDbl(txtHargaBeli.Text)

            txtHargaBeli.Text = Format(Val(HargaBeli1), "#,###")
            txtHargaBeli.SelectionStart = Len(txtHargaBeli.Text)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtHargaJual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaJual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = ",") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtHargaJual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHargaJual.TextChanged
        Try
            HargaJual1 = CDbl(txtHargaJual.Text)
            HargaJual2 = CDbl(txtHargaJual.Text)

            txtHargaJual.Text = Format(Val(HargaJual1), "#,###")
            txtHargaJual.SelectionStart = Len(txtHargaJual.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bPilihKodeJenis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPilihKodeJenis.Click
        FS.FormShow(False, FormViewJenis, Me)
    End Sub

    Private Sub bPilihKodeSatuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPilihKodeSatuan.Click
        FS.FormShow(False, FormViewSatuan, Me)
    End Sub

    Private Sub bPilihKodeMerek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPilihKodeMerek.Click
        FS.FormShow(False, FormViewMerek, Me)
    End Sub

    Private Sub bSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSimpan.Click
        If txtIDBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHargaBeli.Text = "" Or txtHargaJual.Text = "" Then
            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            If Kondisi = True Then 'simpan
                If Val(HargaJual2) <= Val(HargaBeli2) Then
                    INF.Pesan("Penentuan harga jual masih salah", "Error", "Gagal")
                Else
                    Selisih = Val(HargaJual2) - Val(HargaBeli2)
                    Sub_Selisih = Val(txtStok.Text) * Val(Selisih)
                    '============================================'
                    DB.manipulasi("INSERT IGNORE INTO TBL_BARANG VALUES ('" & txtIDBarang.Text & "','" & txtNamaBarang.Text &
                                  "','" & HargaBeli2 & "','" & HargaJual2 & "','" & Selisih &
                                  "','" & txtStok.Text & "','" & txtIDJenis.Text & "','" & txtIDMerek.Text &
                                  "','" & txtIDSatuan.Text & "','" & txtSatuan.Text & "','" & txtUkuran.Text &
                                  "','0','" & txtKet.Text & "','" & txtJmlReturn.Text & "','" & Sub_Selisih & "')", "Simpan")
                End If
            Else 'ubah
                If Val(HargaJual2) <= Val(HargaBeli2) Then
                    INF.Pesan("Penentuan harga jual masih salah", "Error", "Gagal")
                Else
                    Selisih = Val(HargaJual2) - Val(HargaBeli2)
                    Sub_Selisih = Val(txtStok.Text) * Val(Selisih)
                    '============================================'
                    DB.manipulasi("UPDATE TBL_BARANG SET NAMA_BARANG ='" & txtNamaBarang.Text &
                                  "', HARGA_BELI='" & HargaBeli2 & "', HARGA_JUAL='" & HargaJual2 &
                                  "', LABA ='" & Selisih & "', STOK='" & txtStok.Text & "', ID_JENIS='" & txtIDJenis.Text &
                                  "', ID_MEREK='" & txtIDMerek.Text & "', ID_SATUAN='" & txtIDSatuan.Text &
                                  "', SATUAN = '" & txtSatuan.Text & "', UKURAN ='" & txtUkuran.Text & "', KETERANGAN ='" & txtKet.Text &
                                  "', JUMLAH_RETURN='" & txtJmlReturn.Text & "', SUB_TOTAL_LABA='" & Sub_Selisih &
                                  "' WHERE ID_BARANG ='" & txtIDBarang.Text & "'", "Ubah")

                End If
            End If
            Call FormBarang.RefreshDataBarang()
            Call Bersih()
            Kondisi = True

        End If
    End Sub
    Private Sub Bersih()
        txtIDBarang.Clear()
        txtNamaBarang.Clear()
        txtHargaBeli.Clear()
        txtHargaJual.Clear()
        txtStok.Clear()
        txtIDJenis.Clear()
        txtIDMerek.Clear()
        txtIDSatuan.Clear()
        txtSatuan.Clear()
        txtKet.Text = "-"
        txtJmlReturn.Text = "0"
        txtIDBarang.Focus()
    End Sub

    Private Sub bBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBatal.Click
        Me.Close()
    End Sub
End Class