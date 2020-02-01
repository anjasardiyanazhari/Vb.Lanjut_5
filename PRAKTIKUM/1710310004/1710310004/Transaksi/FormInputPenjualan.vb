Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormInputPenjualan
    Dim Penjualan(9) As String
    Dim ada As Boolean
    Dim RowCount As Integer
    Dim StokAkhir As Integer
    Dim JmlQyt As Integer = 1
    Dim TTL, SBTL, BAYAR, KEMBALIAN, TTLD As Double

    Sub DataTemp()
        Dim m As Integer
        With Me
            Penjualan(0) = tId_Penjualan.Text
            Penjualan(1) = tId_Pelanggan.Text
            Penjualan(2) = tNama_Pelanggan.Text
            Penjualan(3) = tKode_Barang.Text
            Penjualan(4) = tNama_Barang.Text
            Penjualan(5) = CInt(.tHarga_Jual.Text)
            Penjualan(6) = CDbl(0)
            Penjualan(7) = CInt(JmlQyt) * CDbl(tHarga_Jual.Text)
            Penjualan(8) = CDbl(JmlQyt) + CInt(0)
            .DataGridInputPenjualan.RowCount = .DataGridInputPenjualan.RowCount + 1
            '=========================================='
            .DataGridInputPenjualan.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DataGridInputPenjualan.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
            '=========================================='
            For m = 0 To 8
                .DataGridInputPenjualan(m, DataGridInputPenjualan.RowCount - 2).Value = Penjualan(m)
            Next

        End With
    End Sub
    Sub CariIsiGrid()
        Dim Xloop1 As Integer
        Dim XPola As String
        Dim XBuka As String
        Dim XBetul As Boolean
        XPola = tKode_Barang.Text + "*"
        XBetul = False
        With Me
            For Xloop1 = 1 To .DataGridInputPenjualan.RowCount - 1
                XBuka = .DataGridInputPenjualan.Rows(Xloop1 - 1).Cells(3).Value
                XBetul = UCase(XBuka) Like UCase(XPola)
                If XBetul = True Then
                    .DataGridInputPenjualan.CurrentCell = .DataGridInputPenjualan(3, Xloop1 - 1)
                    If XBuka = .tKode_Barang.Text Then
                        ada = True
                        .DataGridInputPenjualan.Item(8, .DataGridInputPenjualan.CurrentRow.Index).Value += 1
                        .DataGridInputPenjualan.Item(5, .DataGridInputPenjualan.CurrentRow.Index).Value += 0
                        .DataGridInputPenjualan.Item(7, .DataGridInputPenjualan.CurrentRow.Index).Value =
                       CDbl(.DataGridInputPenjualan.Item(8, .DataGridInputPenjualan.CurrentRow.Index).Value) *
                       CInt(.DataGridInputPenjualan.Item(5, .DataGridInputPenjualan.CurrentRow.Index).Value)
                    End If
                    Exit Sub
                Else
                    .DataGridInputPenjualan.CurrentCell = .DataGridInputPenjualan.Item(3, Xloop1 - 1)
                    ada = False
                End If
            Next
        End With
    End Sub

    Private Sub IDPenjualan()
        Dim ID, Thn, Bln As String
        Thn = Format(Now, "yyMMdd")
        Bln = Format(Now, " mmhhss")
        ID = Thn & Bln
        tId_Penjualan.Text = "PJ-" & ID
    End Sub

    Private Sub BacaPrinter()
        cbPrinter.Items.Clear()
        For Each Print As String In PrinterSettings.InstalledPrinters
            cbPrinter.Items.Add(Print)
        Next
    End Sub

    Sub TambahKolomDiGrid()
        Dim c As New AlFathUpDownColumn
        c.HeaderText = "Qty"
        c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        c.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        c.DataPropertyName = "DataTable Column Name"
        c.Width = 65
        Me.DataGridInputPenjualan.Columns.RemoveAt(8)
        Me.DataGridInputPenjualan.Columns.Add(c)
    End Sub

    Private Sub FormInputPenjualan_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then 'Jika Saya Tekan F1 view jenis
            FS.FormShow(False, FormViewPelanggan, Me)
        End If

        If e.KeyCode = Keys.F2 Then 'Jika Saya Tekan F2 view barang
            FS.FormShow(False, FormViewBarang, Me)
        End If
    End Sub

    Private Sub Transaksi_Penjualan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call IDPenjualan()
        Call BacaPrinter()
        Call TambahKolomDiGrid()
        StokAkhir = 2
        Me.KeyPreview = True
        kondisi = True
    End Sub

    Private Sub tKode_Barang_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tKode_Barang.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not ckBarcode.Checked = True Then
                FS.FormShow(False, FormViewBarang, Me)
            Else
                '======
                If tId_Penjualan.Text = "" Or tId_Pelanggan.Text = "" Or tNama_Pelanggan.Text = "" Or tKode_Barang.Text = "" Then
                    MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    With DB
                        .Con.Close() : .Con.Open()
                        .Cmd = New MySqlCommand("SELECT * FROM TBL_BARANG WHERE ID_BARANG='" & tKode_Barang.Text & "'", .Con)
                        .Rdr = .Cmd.ExecuteReader
                        .Rdr.Read()
                        If .Rdr.HasRows = True Then
                            tKode_Barang.Text = .Rdr.GetString(0)
                            tNama_Barang.Text = .Rdr.GetString(1)
                            tHarga_Jual.Text = .Rdr.GetValue(3)
                            tStok_Awal.Text = .Rdr.GetValue(5)
                            tStok_Akhir.Text = StokAkhir
                            '==============================================================='
                            If Not CInt(StokAkhir) <= 1 Then
                                If tId_Penjualan.Text = "" Or tId_Pelanggan.Text = "" Or tNama_Pelanggan.Text = "" Or tKode_Barang.Text = "" Or tNama_Barang.Text = "" Or tHarga_Jual.Text = "" Or tStok_Awal.Text = "" Then
                                    INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
                                Else
                                    Call CariIsiGrid()
                                    If ada = True Then
                                    Else
                                        Call DataTemp()
                                    End If
                                End If
                                '================================================================='
                                tKode_Barang.Focus()
                                tStok_Akhir.Text = Val(tStok_Awal.Text) - CInt(DataGridInputPenjualan.Item(8, DataGridInputPenjualan.CurrentRow.Index).Value)
                                tSub_Total_Item.Text = CDbl(DataGridInputPenjualan.Item(8, DataGridInputPenjualan.CurrentRow.Index).Value) * CDbl(DataGridInputPenjualan.Item(5, DataGridInputPenjualan.CurrentRow.Index).Value)
                                Call FS.totalBiayaRecord(DataGridInputPenjualan, tTotal_Bayar, 7) 'diskon
                                Call FS.totalBiayaRecord(DataGridInputPenjualan, tItem_Qty, 8) 'Total qty
                                Call FS.jumlahRecord(DataGridInputPenjualan, tItem, 0) 'qty
                                '================================================================='
                                StokAkhir = CInt(tStok_Akhir.Text)
                                '================================================================='
                            Else
                                StokAkhir = 2
                            End If
                            '==============================================================='
                        Else
                            INF.Pesan("Barang dengan kode [ " & tKode_Barang.Text & " ] tidak ditemukan, silahkan input ke master barang", "Peringatan", "Informasi")
                            tKode_Barang.Focus()
                        End If
                        .Rdr.Close()
                    End With
                End If
                '========
            End If
        End If
    End Sub


    Private Sub btnOke_Click(sender As System.Object, e As System.EventArgs) Handles btnOke.Click
        If tId_Penjualan.Text = "" Or tId_Pelanggan.Text = "" Or tNama_Pelanggan.Text = "" Or tKode_Barang.Text = "" Or tNama_Barang.Text = "" Or tHarga_Jual.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            With DB
                .Con.Close() : .Con.Open()
                .Cmd = New MySqlCommand("SELECT * FROM TBL_BARANG WHERE ID_BARANG='" & tKode_Barang.Text & "'", .Con)
                .Rdr = .Cmd.ExecuteReader
                .Rdr.Read()
                If .Rdr.HasRows = True Then
                    tKode_Barang.Text = .Rdr.GetString(0)
                    tNama_Barang.Text = .Rdr.GetString(1)
                    tHarga_Jual.Text = .Rdr.GetValue(3)
                    tStok_Awal.Text = .Rdr.GetValue(5)
                    tStok_Akhir.Text = StokAkhir
                    '==============================================================='
                    If Not CInt(StokAkhir) <= 1 Then
                        If tId_Penjualan.Text = "" Or tId_Pelanggan.Text = "" Or tNama_Pelanggan.Text = "" Or tKode_Barang.Text = "" Or tNama_Barang.Text = "" Or tHarga_Jual.Text = "" Or tStok_Awal.Text = "" Then
                            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
                        Else
                            Call CariIsiGrid()
                            If ada = True Then
                            Else
                                Call DataTemp()
                            End If
                        End If
                        '================================================================='
                        tKode_Barang.Focus()
                        tStok_Akhir.Text = Val(tStok_Awal.Text) - CInt(DataGridInputPenjualan.Item(8, DataGridInputPenjualan.CurrentRow.Index).Value)
                        tSub_Total_Item.Text = CDbl(DataGridInputPenjualan.Item(8, DataGridInputPenjualan.CurrentRow.Index).Value) * CDbl(DataGridInputPenjualan.Item(5, DataGridInputPenjualan.CurrentRow.Index).Value)
                        Call FS.totalBiayaRecord(DataGridInputPenjualan, tTotal_Bayar, 7) 'diskon
                        Call FS.totalBiayaRecord(DataGridInputPenjualan, tItem_Qty, 8) 'Total qty
                        Call FS.jumlahRecord(DataGridInputPenjualan, tItem, 0) 'qty
                        '================================================================='
                        StokAkhir = CInt(tStok_Akhir.Text)
                        '================================================================='
                    Else
                        StokAkhir = 2
                    End If
                    '==============================================================='
                Else
                    INF.Pesan("Barang dengan kode [ " & tKode_Barang.Text & " ] tidak ditemukan, silahkan input ke master barang", "Peringatan", "Informasi")
                    tKode_Barang.Focus()
                End If
                .Rdr.Close()
            End With
        End If

    End Sub

    Private Sub tTotal_Bayar_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTotal_Bayar.TextChanged
        Try
            TTL = CDbl(tTotal_Bayar.Text)
            tTotal_Bayar.Text = Format(Val(TTL), "#,###")
            tTotal_Bayar.SelectionStart = Len(tTotal_Bayar.Text)
            '=======================
            tTerbilang_Total_Bayar.Text = Uang.BILANG(Val(TTL))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tSub_Total_Item_TextChanged(sender As System.Object, e As System.EventArgs) Handles tSub_Total_Item.TextChanged
        Try
            SBTL = CDbl(tSub_Total_Item.Text)
            tSub_Total_Item.Text = Format(Val(SBTL), "#,###")
            tSub_Total_Item.SelectionStart = Len(tSub_Total_Item.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tPembayaran_TextChanged(sender As System.Object, e As System.EventArgs) Handles tPembayaran.TextChanged
        Try
            If tPembayaran.Text = "" Or tKembalian.Text = "" Or Not IsNumeric(tPembayaran.Text) Then
                tKembalian.Text = "0"
                Exit Sub
            End If

            BAYAR = tPembayaran.Text
            KEMBALIAN = tKembalian.Text
            KEMBALIAN = Val(BAYAR) - Val(TTL)
            '==========================================
            tPembayaran.Text = Format(Val(BAYAR), "#,###")
            tPembayaran.SelectionStart = Len(tPembayaran.Text)
            '==========================================
            tKembalian.Text = Format(KEMBALIAN, "#,###")
            tKembalian.SelectionStart = Len(tKembalian.Text)
            '==========================================
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tKembalian_TextChanged(sender As System.Object, e As System.EventArgs) Handles tKembalian.TextChanged
        If tKembalian.Text = "" Then
            tKembalian.Text = "0"
        End If
        Dim KembalianUang As Double = CDbl(tKembalian.Text)
        tTerbilang_Kembalian.Text = Uang.BILANG(Val(KembalianUang))
    End Sub

    Private Sub SimpanPenjualan()
        Dim TglTransaksi As String = Format(Now, "yyyy-MM-dd")
        Dim Total As Integer = CInt(tItem_Qty.Text)
        DB.manipulasi("INSERT IGNORE INTO TBL_PENJUALAN VALUES('" & tId_Penjualan.Text & "', '" & tNama_Pelanggan.Text &
                      "', '" & tId_Pelanggan.Text & "', '" & TglTransaksi & "', '-', '" & Total & "')", "Simpan")
    End Sub

    Private Sub SimpanPenjualanDetail()
        Try
            With DB
                Dim Status As String = "Tunai"
                Dim IDPelanggan As String = CStr(tId_Pelanggan.Text)
                For i As Integer = 0 To DataGridInputPenjualan.Rows.Count - 2
                    Dim IDPenjualan As String = DataGridInputPenjualan.Item(0, i).Value 'Kode Transaksi
                    Dim IDBarang As String = DataGridInputPenjualan.Item(3, i).Value 'Kode Barang
                    Dim NamaBarang As String = DataGridInputPenjualan.Item(4, i).Value 'Nama Barang
                    Dim HargaJual As Double = DataGridInputPenjualan.Item(5, i).Value 'Harga Jual
                    Dim JmlJual As String = DataGridInputPenjualan.Item(8, i).Value 'Jumlah Jual
                    Dim Diskon As Double = DataGridInputPenjualan.Item(6, i).Value 'Diskon
                    Dim SubTotal As Double = DataGridInputPenjualan.Item(7, i).Value 'Sub Total
                    '===================================================================================
                    DB.manipulasi("Insert into tbl_penjualan_dtl values ('" & IDPenjualan & "', '" & IDBarang &
                                  "', '" & NamaBarang & "', '" & HargaJual & "', '" & JmlJual &
                                  "', '" & Diskon & "', '" & SubTotal & "', '" & IDPelanggan & "', '" & Status & "')", "Simpan")
                Next
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tPembayaran_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tPembayaran.KeyPress
        If e.KeyChar = Chr(13) Then
            If tId_Pelanggan.Text = "" Or tNama_Pelanggan.Text = "" Or tPembayaran.Text = "" Then
                INF.Pesan("Data Belum Lengkap", "Peringatan", "Peringatan")
            Else
                Select Case cbStatusPiutang.SelectedIndex
                    Case 0 'tunai'
                        If Not CDbl(tKembalian.Text) < 0 Then
                            Call SimpanPenjualan()
                            Call SimpanPenjualanDetail()
                            Call FormTransaksiPenjualan.RefreshDataPenjualan()
                            '===============================================
                            If ckBesarFaktur.Checked = True Then
                                FS.FormShow(False, StrukJual, Me)
                            End If
                            '===============================================
                            Call IDPenjualan()
                            Call bersih()
                            '===============================================
                            DataGridInputPenjualan.Rows.Clear()
                            DataGridInputPenjualan.Rows.Add()
                        Else
                            INF.Pesan("Nominal Uang Tidak Mencukupi", "Peringatan", "Pringatan")
                        End If
                    Case 1 'hutang
                        'Belum Dipakai
                End Select
            End If
        End If
    End Sub

    Private Sub bersih()
        tId_Pelanggan.Clear()
        tNama_Pelanggan.Clear()
        tId_Penjualan.Clear()
        tKode_Barang.Clear()
        tNama_Barang.Clear()
        tStok_Awal.Clear()
        tStok_Akhir.Clear()
        tSub_Total_Item.Text = "0"
        tTotal_Bayar.Text = "0"
        tPembayaran.Text = "0"
        DataGridInputPenjualan.Rows.Clear()
    End Sub

End Class