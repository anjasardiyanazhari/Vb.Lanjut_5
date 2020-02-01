Imports MySql.Data.MySqlClient
Public Class FormInputBarang
    Dim HargaBeli1, HargaBeli2 As Double
    Dim HargaJual1, HargaJual2 As Double
    Dim Selisih, Sub_Selisih As Double

    Private Sub FormInputBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tID_BARANG_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tID_BARANG.KeyPress
        If e.KeyChar = Chr(13) Then
            With DB
                .Con.Close() : .Con.Open()
                .Cmd = New MySqlCommand("SELECT ID_BARANG FROM TBL_BARANG WHERE ID_BARANG='" & tID_BARANG.Text & "'", .Con)
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

    Private Sub cbKAPITAL_NAMA_BARANG_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbKAPITAL_NAMA_BARANG.CheckedChanged
        If cbKAPITAL_NAMA_BARANG.Checked = True Then
            tNAMA_BARANG.CharacterCasing = CharacterCasing.Upper
        Else
            tNAMA_BARANG.CharacterCasing = CharacterCasing.Normal
        End If
    End Sub

    Private Sub tHARGA_BELI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tHARGA_BELI.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = ",") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tHARGA_BELI_TextChanged(sender As System.Object, e As System.EventArgs) Handles tHARGA_BELI.TextChanged
        Try
            HargaBeli1 = CDbl(tHARGA_BELI.Text)
            HargaBeli2 = CDbl(tHARGA_BELI.Text)

            tHARGA_BELI.Text = Format(Val(HargaBeli1), "#,###")
            tHARGA_BELI.SelectionStart = Len(tHARGA_BELI.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tHARGA_JUAL_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tHARGA_JUAL.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = ",") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tHARGA_JUAL_TextChanged(sender As System.Object, e As System.EventArgs) Handles tHARGA_JUAL.TextChanged
        Try
            HargaJual1 = CDbl(tHARGA_JUAL.Text)
            HargaJual2 = CDbl(tHARGA_JUAL.Text)

            tHARGA_JUAL.Text = Format(Val(HargaJual1), "#,###")
            tHARGA_JUAL.SelectionStart = Len(tHARGA_JUAL.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnKODE_JENIS_Click(sender As System.Object, e As System.EventArgs) Handles btnKODE_JENIS.Click
        FS.FormShow(False, FormViewJenis, Me)
    End Sub

    Private Sub btnSTOK_SATUAN_Click(sender As System.Object, e As System.EventArgs) Handles btnSTOK_SATUAN.Click
        FS.FormShow(False, FormViewSatuan, Me)
    End Sub

    Private Sub btnKODE_MEREK_Click(sender As System.Object, e As System.EventArgs) Handles btnKODE_MEREK.Click
        FS.FormShow(False, FormViewMerek, Me)
    End Sub

    Private Sub tSimpan_Click(sender As System.Object, e As System.EventArgs) Handles tSimpan.Click
        If tID_BARANG.Text = "" Or tNAMA_BARANG.Text = "" Or tHARGA_BELI.Text = "" Or tHARGA_JUAL.Text = ""  Then
            INF.Pesan("Data Belum Lengkap", "Peringatan", "Peringatan")
        Else
            If kondisi = True Then 'simpan
                If Val(HargaJual2) <= Val(HargaBeli2) Then
                    INF.Pesan("Penentuan harga jual masih salah", "Error", "Gagal")
                Else
                    Selisih = Val(HargaJual2) - Val(HargaBeli2)
                    Sub_Selisih = Val(tSTOK_BARANG.Text) * Val(Selisih)
                    '================================================='
                    DB.manipulasi("INSERT IGNORE INTO TBL_BARANG VALUES ('" & tID_BARANG.Text & "', '" & tNAMA_BARANG.Text &
                                  "', '" & HargaBeli2 & "', '" & HargaJual2 & "', '" & Selisih &
                                  "','" & tSTOK_BARANG.Text & "','" & tKODE_JENIS.Text & "', '" & tKODE_MEREK.Text & "', '" & tKODE_SATUAN.Text &
                                  "', '" & tSATUAN.Text & "', '" & tUKURAN.Text &
                                  "', '0', '" & tKETERANGAN.Text & "','" & tJML_RETURN.Text & "', '" & Sub_Selisih & "')", "Simpan")
                End If
            Else 'ubah
                If Val(HargaJual2) <= Val(HargaBeli2) Then
                    INF.Pesan("Penentuan harga jual masih salah", "Error", "Gagal")
                Else
                    Selisih = Val(HargaJual2) - Val(HargaBeli2)
                    Sub_Selisih = Val(tSTOK_BARANG.Text) * Val(Selisih)

                    '================================================='
                    DB.manipulasi("UPDATE TBL_BARANG SET NAMA_BARANG='" & tNAMA_BARANG.Text & "', HARGA_BELI='" & HargaBeli2 &
                                  "', HARGA_JUAL='" & HargaJual2 & "', LABA='" & Selisih & "', STOK='" & tSTOK_BARANG.Text &
                                  "', ID_JENIS='" & tKODE_JENIS.Text & "',ID_MEREK='" & tKODE_MEREK.Text &
                                  "', ID_SATUAN='" & tKODE_SATUAN.Text & "',SATUAN='" & tSATUAN.Text &
                                  "', UKURAN='" & tUKURAN.Text & "',KETERANGAN='" & tKETERANGAN.Text &
                                  "', JUMLAH_RETURN='" & tJML_RETURN.Text & "', SUB_TOTAL_LABA='" & Sub_Selisih &
                                  "' WHERE ID_BARANG='" & tID_BARANG.Text & "'", "Ubah")


                End If
            End If
            Call FormBarang.RefreshDataBarang()
            Call Bersih()
            kondisi = True
        End If
    End Sub

    Private Sub Bersih()
        tID_BARANG.Clear()
        tNAMA_BARANG.Clear()
        tHARGA_BELI.Clear()
        tHARGA_JUAL.Clear()
        tSTOK_BARANG.Clear()
        tKODE_JENIS.Clear()
        tKODE_MEREK.Clear()
        tKODE_SATUAN.Clear()
        tSATUAN.Clear()
        tUKURAN.Clear()
        tKETERANGAN.Clear()
        tJML_RETURN.Text = "0"
        tID_BARANG.Focus()
    End Sub

    Private Sub tSATUAN_TextChanged(sender As System.Object, e As System.EventArgs) Handles tSATUAN.TextChanged

    End Sub

    Private Sub tJML_RETURN_TextChanged(sender As System.Object, e As System.EventArgs) Handles tJML_RETURN.TextChanged

    End Sub
End Class
