Imports MySql.Data.MySqlClient

Public Class FormInputJasa
    Dim HargaAwal1, HargaAwal2 As Double
    Dim HargaSewa1, HargaSewa2 As Double
    Dim Selisih, Sub_Selisih As Double

    Private Sub FormInputJasa_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            With DB
                .Con.Close() : .Con.Open()
                .Cmd = New MySqlCommand("SELECT ID_JASA FROM TBL_JASA WHERE ID_JASA='" & txtIDJasa.Text & "'", .Con)
                .Rdr = .Cmd.ExecuteReader
                .Rdr.Read()
                If .Rdr.HasRows = True Then
                    INF.Pesan("Ada Data", "Informasi", "Informasi")
                Else
                    INF.Pesan("Tidak Ada Data", "Informasi", "Informasi")
                End If
                .Rdr.Close()
            End With
        End If
    End Sub

    Private Sub ckKapital_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckKapital.CheckedChanged
        If ckKapital.Checked = True Then
            txtNama_Jasa.CharacterCasing = CharacterCasing.Upper
        Else
            txtNama_Jasa.CharacterCasing = CharacterCasing.Normal
        End If
    End Sub

    Private Sub txtHarga_Awal_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga_Awal.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = ",") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtHarga_Awal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHarga_Awal.TextChanged
        Try
            HargaAwal1 = CDbl(txtHarga_Awal.Text)
            HargaAwal2 = CDbl(txtHarga_Awal.Text)

            txtHarga_Awal.Text = Format(Val(HargaAwal1), "#,###")
            txtHarga_Awal.SelectionStart = Len(txtHarga_Awal.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtHarga_Sewa_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga_Sewa.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = ",") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtHarga_Sewa_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHarga_Sewa.TextChanged
        Try
            HargaSewa1 = CDbl(txtHarga_Sewa.Text)
            HargaSewa2 = CDbl(txtHarga_Sewa.Text)

            txtHarga_Sewa.Text = Format(Val(HargaSewa1), "#,###")
            txtHarga_Sewa.SelectionStart = Len(txtHarga_Sewa.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bPilihKodeKategori_Click(sender As System.Object, e As System.EventArgs) Handles bPilihKodeKategori.Click
        FS.FormShow(False, FormViewKategori, Me)
    End Sub

    Private Sub bPilihKodeFasilitas_Click(sender As System.Object, e As System.EventArgs) Handles bPilihKodeFasilitas.Click
        FS.FormShow(False, FormViewFasilitas, Me)
    End Sub

    Private Sub bSimpan_Click(sender As System.Object, e As System.EventArgs) Handles bSimpan.Click
        If txtIDJasa.Text = "" Or txtNama_Jasa.Text = "" Or txtHarga_Awal.Text = "" Or txtHarga_Sewa.Text = "" Then
            INF.Pesan("Data Belum Lengkap", "Peringatan", "Peringatan")
        Else
            If kondisi = True Then 'simpan
                If Val(HargaSewa2) <= Val(HargaAwal2) Then
                    INF.Pesan("Penentuan harga jual masih salah", "Error", "Gagal")
                Else
                    Selisih = Val(HargaSewa2) - Val(HargaAwal2)
                    Sub_Selisih = Val(txtStok.Text) * Val(Selisih)
                    '================================================='
                    DB.manipulasi("INSERT IGNORE INTO TBL_JASA VALUES ('" & txtIDJasa.Text & "', '" & txtNama_Jasa.Text &
                                  "', '" & HargaAwal2 & "', '" & HargaSewa2 & "', '" & Selisih &
                                  "', '" & txtStok.Text & "','" & txtKode_Kategori.Text & "', '" & txtKode_Fasilitas.Text &
                                  "',  '" & txtKategori.Text & "','0', '" & txtKet.Text & "','" & txtJml_Return.Text & "', '" & Sub_Selisih & "')", "Simpan")
                End If
            Else 'ubah
                If Val(HargaSewa2) <= Val(HargaAwal2) Then
                    INF.Pesan("Penentuan harga jual masih salah", "Error", "Gagal")
                Else
                    Selisih = Val(HargaSewa2) - Val(HargaAwal2)
                    Sub_Selisih = Val(txtStok.Text) * Val(Selisih)

                    '================================================='
                    DB.manipulasi("UPDATE TBL_JASA SET NAMA_JASA='" & txtNama_Jasa.Text & "', HARGA_AWAL='" & HargaAwal2 &
                                        "', HARGA_SEWA='" & HargaSewa2 & "', LABA='" & Selisih & "', STOK='" & txtStok.Text &
                                        "', ID_KATEGORI='" & txtKode_Kategori.Text & "', ID_FASILITAS='" & txtKode_Fasilitas.Text &
                                        "', KETERANGAN='" & txtKet.Text &
                                        "', JUMLAH_RETURN='" & txtJml_Return.Text & "', SUB_TOTAL_LABA='" & Sub_Selisih &
                                        "' WHERE ID_JASA='" & txtIDJasa.Text & "'", "Ubah")


                End If
            End If
            Call FormJasa.RefreshDataJasa()
            Call Bersih()
            kondisi = True
        End If
    End Sub

    Private Sub Bersih()
        txtIDJasa.Clear()
        txtNama_Jasa.Clear()
        txtHarga_Awal.Clear()
        txtHarga_Sewa.Clear()
        txtStok.Clear()
        txtStok.Clear()
        txtKode_Kategori.Clear()
        txtKode_Fasilitas.Clear()
        txtKategori.Clear()
        txtKet.Clear()
        txtJml_Return.Text = "0"
        txtIDJasa.Focus()
    End Sub

    Private Sub FormInputJasa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class