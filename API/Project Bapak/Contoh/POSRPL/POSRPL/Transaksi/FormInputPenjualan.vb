Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Public Class FormInputPenjualan
    '==============================
    Dim Penjualan(9) As String
    Dim ada As Boolean
    Dim RowCount As Integer
    Dim StokAkhir As Integer
    Dim JmlQty As Integer = 1
    Dim TTL, SBTL, BAYAR, KEMBALIAN, TTLD As Double

    Sub DataTemp()
        Dim m As Integer
        With Me
            Penjualan(0) = .tIDPenjualan.Text
            Penjualan(1) = .tIDPelanggan.Text
            Penjualan(2) = .tNamaPelanggan.Text
            Penjualan(3) = .tIDBarang.Text
            Penjualan(4) = .tNamaBarang.Text
            Penjualan(5) = CInt(.tHargaJual.Text) + CInt(0)
            Penjualan(6) = CDbl(0)
            Penjualan(7) = CInt(JmlQty) * CDbl(tHargaJual.Text)
            Penjualan(8) = CDbl(JmlQty) + CInt(0)
            .GridDataInputPenjualan.RowCount = .GridDataInputPenjualan.RowCount + 1
            '========================================================================================='
            .GridDataInputPenjualan.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .GridDataInputPenjualan.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
            '========================================================================================='
            For m = 0 To 8
                .GridDataInputPenjualan(m, .GridDataInputPenjualan.RowCount - 2).Value = Penjualan(m)
            Next
        End With
    End Sub

    Sub CariIsiGrid()
        Dim Xloop1 As Integer
        Dim XPola As String
        Dim XBuka As String
        Dim XBetul As Boolean
        XPola = tIDBarang.Text + "*"
        XBetul = False
        With Me
            For Xloop1 = 1 To .GridDataInputPenjualan.RowCount - 1
                XBuka = .GridDataInputPenjualan.Rows(Xloop1 - 1).Cells(3).Value
                XBetul = UCase(XBuka) Like UCase(XPola)
                If XBetul = True Then
                    .GridDataInputPenjualan.CurrentCell = .GridDataInputPenjualan.Item(3, Xloop1 - 1)
                    If XBuka = .tIDBarang.Text Then
                        ada = True
                        .GridDataInputPenjualan.Item(8, .GridDataInputPenjualan.CurrentRow.Index).Value += 1
                        .GridDataInputPenjualan.Item(5, .GridDataInputPenjualan.CurrentRow.Index).Value += 0
                        .GridDataInputPenjualan.Item(7, .GridDataInputPenjualan.CurrentRow.Index).Value =
                        CDbl(.GridDataInputPenjualan.Item(8, .GridDataInputPenjualan.CurrentRow.Index).Value) *
                        CInt(.GridDataInputPenjualan.Item(5, .GridDataInputPenjualan.CurrentRow.Index).Value)
                    End If
                    Exit Sub
                Else
                    .GridDataInputPenjualan.CurrentCell = .GridDataInputPenjualan.Item(3, Xloop1 - 1)
                    ada = False
                End If
            Next
        End With
    End Sub

    Private Sub IDPenjualan()
        Dim ID, Thn, Bln As String
        Thn = Format(Now, "yyMMdd")
        Bln = Format(Now, "mmhhss")
        ID = Thn & Bln
        tIDPenjualan.Text = "PJ-" & ID
    End Sub

    Private Sub BacaPrinter()
        cbPrinter.Items.Clear()
        For Each print As String In PrinterSettings.InstalledPrinters
            cbPrinter.Items.Add(print)
        Next
    End Sub

    Sub TambahKolomDiGrid()
        Dim c As New AlFathUpDownColumn
        c.HeaderText = "Qty"
        c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        c.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        c.DataPropertyName = "DataTable Column Name"
        c.Width = 60
        Me.GridDataInputPenjualan.Columns.RemoveAt(8)
        Me.GridDataInputPenjualan.Columns.Add(c)
    End Sub

    Private Sub FormInputPenjualan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then 'jika saya tekan F1
            FS.FormShow(False, FormViewPelanggan, Me)
        End If
        If e.KeyCode = Keys.F2 Then 'jika saya tekan F2
            FS.FormShow(False, FormViewBarang, Me)
        End If
    End Sub

    Private Sub FormInputPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call IDPenjualan()
        Call BacaPrinter()
        Call TambahKolomDiGrid()
        StokAkhir = 2
        Me.KeyPreview = True
        Kondisi = True
    End Sub

    Private Sub tIDBarang_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tIDBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not ckBarcode.Checked = True Then
                FS.FormShow(False, FormViewBarang, Me)
            Else

                If tIDPenjualan.Text = "" Or tIDPelanggan.Text = "" Or tNamaPelanggan.Text = "" Or tIDBarang.Text = "" Then
                    MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    With DB
                        .Con.Close() : .Con.Open()
                        .Cmd = New MySqlCommand("SELECT * FROM TBL_BARANG WHERE ID_BARANG='" & tIDBarang.Text & "'", .Con)
                        .Rdr = .Cmd.ExecuteReader
                        .Rdr.Read()
                        If .Rdr.HasRows = True Then
                            tIDBarang.Text = .Rdr.GetString(0)
                            tNamaBarang.Text = .Rdr.GetString(1)
                            tHargaJual.Text = .Rdr.GetValue(3)
                            tStokAwal.Text = .Rdr.GetValue(5)
                            tStokAkhir.Text = StokAkhir
                            '==============================================================='
                            If Not CInt(StokAkhir) <= 1 Then
                                If tIDPenjualan.Text = "" Or tIDPelanggan.Text = "" Or tNamaPelanggan.Text = "" Or tIDBarang.Text = "" Or tNamaBarang.Text = "" Or tHargaJual.Text = "" Or tStokAwal.Text = "" Then
                                    INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
                                Else
                                    Call CariIsiGrid()
                                    If ada = True Then
                                    Else
                                        Call DataTemp()
                                    End If
                                End If
                                '================================================================='
                                tIDBarang.Focus()
                                tStokAkhir.Text = Val(tStokAwal.Text) - CInt(GridDataInputPenjualan.Item(8, GridDataInputPenjualan.CurrentRow.Index).Value)
                                tSubTotalItem.Text = CDbl(GridDataInputPenjualan.Item(8, GridDataInputPenjualan.CurrentRow.Index).Value) * CDbl(GridDataInputPenjualan.Item(5, GridDataInputPenjualan.CurrentRow.Index).Value)
                                Call FS.totalBiayaRecord(GridDataInputPenjualan, tTotalBayar, 7) 'diskon
                                Call FS.totalBiayaRecord(GridDataInputPenjualan, tTotalItem, 8) 'Total qty
                                Call FS.jumlahRecord(GridDataInputPenjualan, tItem, 0) 'qty
                                '================================================================='
                                StokAkhir = CInt(tStokAkhir.Text)
                                '================================================================='
                            Else
                                StokAkhir = 2
                            End If
                            '==============================================================='
                        Else
                            INF.Pesan("Barang dengan kode [ " & tIDBarang.Text & " ] tidak ditemukan, silahkan input ke master barang", "Peringatan", "Informasi")
                            tIDBarang.Focus()
                        End If
                        .Rdr.Close()
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub bOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOk.Click

        If tIDPenjualan.Text = "" Or tIDPelanggan.Text = "" Or tNamaPelanggan.Text = "" Or tIDBarang.Text = "" Or tNamaBarang.Text = "" Or tHargaJual.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            With DB
                .Con.Close() : .Con.Open()
                .Cmd = New MySqlCommand("SELECT * FROM TBL_BARANG WHERE ID_BARANG='" & tIDBarang.Text & "'", .Con)
                .Rdr = .Cmd.ExecuteReader
                .Rdr.Read()
                If .Rdr.HasRows = True Then
                    tIDBarang.Text = .Rdr.GetString(0)
                    tNamaBarang.Text = .Rdr.GetString(1)
                    tHargaJual.Text = .Rdr.GetValue(3)
                    tStokAwal.Text = .Rdr.GetValue(5)
                    tStokAkhir.Text = StokAkhir
                    '==============================================================='
                    If Not CInt(StokAkhir) <= 1 Then
                        If tIDPenjualan.Text = "" Or tIDPelanggan.Text = "" Or tNamaPelanggan.Text = "" Or tIDBarang.Text = "" Or tNamaBarang.Text = "" Or tHargaJual.Text = "" Or tStokAwal.Text = "" Then
                            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
                        Else
                            Call CariIsiGrid()
                            If ada = True Then
                            Else
                                Call DataTemp()
                            End If
                        End If
                        '================================================================='
                        tIDBarang.Focus()
                        tStokAkhir.Text = Val(tStokAwal.Text) - CInt(GridDataInputPenjualan.Item(8, GridDataInputPenjualan.CurrentRow.Index).Value)
                        tSubTotalItem.Text = CDbl(GridDataInputPenjualan.Item(8, GridDataInputPenjualan.CurrentRow.Index).Value) * CDbl(GridDataInputPenjualan.Item(5, GridDataInputPenjualan.CurrentRow.Index).Value)
                        Call FS.totalBiayaRecord(GridDataInputPenjualan, tTotalBayar, 7) 'diskon
                        Call FS.totalBiayaRecord(GridDataInputPenjualan, tTotalItem, 8) 'Total qty
                        Call FS.jumlahRecord(GridDataInputPenjualan, tItem, 0) 'qty
                        '================================================================='
                        StokAkhir = CInt(tStokAkhir.Text)
                        '================================================================='
                    Else
                        StokAkhir = 2
                    End If
                    '==============================================================='
                Else
                    INF.Pesan("Barang dengan kode [ " & tIDBarang.Text & " ] tidak ditemukan, silahkan input ke master barang", "Peringatan", "Informasi")
                    tIDBarang.Focus()
                End If
                .Rdr.Close()
            End With
        End If

    End Sub

    Private Sub tTotalBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTotalBayar.TextChanged
        Try
            TTL = CDbl(tTotalBayar.Text)
            tTotalBayar.Text = Format(Val(TTL), "#,###")
            tTotalBayar.SelectionStart = Len(tTotalBayar.Text)
            '================================================='
            tTerbilang.Text = Uang.BILANG(Val(TTL))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tSubTotalItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSubTotalItem.TextChanged
        Try
            SBTL = CDbl(tSubTotalItem.Text)
            tSubTotalItem.Text = Format(Val(SBTL), "#,###")
            tSubTotalItem.SelectionStart = Len(tSubTotalItem.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tPembayaran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPembayaran.TextChanged
        Try
            If tPembayaran.Text = "" Or tKembalian.Text = "" Or Not IsNumeric(tPembayaran.Text) Then
                tKembalian.Text = "0"
                Exit Sub
            End If

            BAYAR = tPembayaran.Text
            KEMBALIAN = tKembalian.Text
            KEMBALIAN = Val(BAYAR) - Val(TTL)
            '================================================================='
            tPembayaran.Text = Format(Val(BAYAR), "#,###")
            tPembayaran.SelectionStart = Len(tPembayaran.Text)
            '================================================================='
            tKembalian.Text = Format(KEMBALIAN, "#,###")
            tKembalian.SelectionStart = Len(tKembalian.Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tPembayaran_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tPembayaran.KeyPress
        If e.KeyChar = Chr(13) Then
            If tIDPelanggan.Text = "" Or tNamaPelanggan.Text = "" Or tPembayaran.Text = "" Then
                INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
            Else
                Select Case cbStatusPiutang.SelectedIndex
                    Case 0 'tunai
                        If Not CDbl(tKembalian.Text) < 0 Then
                            Call SimpanPenjualan()
                            Call SimpanPenjualanDetail()
                            Call FormTransaksiPenjualan.RefreshDataPenjualan()
                            '=================================='
                            If ckBesarFaktur.Checked = True Then
                                FS.FormShow(False, StrukJual, Me)
                            End If
                            '=============================='
                            Call IDPenjualan()
                            Call Bersih()
                            '==============================='
                            GridDataInputPenjualan.Rows.Clear()
                            GridDataInputPenjualan.Rows.Add()
                        Else
                            INF.Pesan("Nominal Uang Tidak Mencukupi", "Peringatan", "Peringatan")
                        End If
                    Case 1 'hutang
                        'belum di pakai
                End Select
            End If
        End If
    End Sub

    Private Sub Bersih()
        tIDPelanggan.Clear()
        tNamaPelanggan.Clear()
        tIDBarang.Clear()
        tNamaBarang.Clear()
        tStokAwal.Clear()
        tStokAkhir.Clear()
        tSubTotalItem.Text = "0"
        tTotalBayar.Text = "0"
        tPembayaran.Text = "0"
        GridDataInputPenjualan.Rows.Clear()
    End Sub
    Private Sub SimpanPenjualan() 'UNTUK TUNAI
        Dim TglTransaksi As String = Format(Now, "yyyy-MM-dd")
        Dim Total As Integer = CInt(tTotalItem.Text)
        DB.manipulasi("INSERT IGNORE INTO TBL_PENJUALAN VALUES ('" & tIDPenjualan.Text & "','" & tNamaPelanggan.Text &
                      "','" & tIDPelanggan.Text & "','" & TglTransaksi & "','-','" & Total & "')", "Simpan")
    End Sub
    Private Sub SimpanPenjualanDetail()
        Try
            With DB
                Dim Status As String = "Tunai"
                Dim IDPelanggan As String = CStr(tIDPelanggan.Text)
                For i As Integer = 0 To GridDataInputPenjualan.Rows.Count - 2
                    Dim IDPenjualan As String = GridDataInputPenjualan.Item(0, i).Value ' Kode Transaksi
                    Dim IDBarang As String = GridDataInputPenjualan.Item(3, i).Value 'KodeBarang
                    Dim NamaBarang As String = GridDataInputPenjualan.Item(4, i).Value 'Nama Barang
                    Dim HargaJual As Double = GridDataInputPenjualan.Item(5, i).Value 'Harga Jual
                    Dim JmlJual As Integer = GridDataInputPenjualan.Item(8, i).Value 'Jumlah Jual
                    Dim Diskon As Double = GridDataInputPenjualan.Item(6, i).Value 'Diskon
                    Dim SubTotal As Double = GridDataInputPenjualan.Item(7, i).Value ' Sub total
                    '============================================================================================================='
                    DB.manipulasi("Insert Into tbl_penjualan_dtl Values ('" & IDPenjualan & "','" & IDBarang &
                                  "','" & NamaBarang & "','" & HargaJual & "','" & JmlJual &
                                  "','" & Diskon & "','" & SubTotal & "','" & IDPelanggan & "','" & Status & "')", "Simpan")
                Next i
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tKembalian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tKembalian.TextChanged
        If tKembalian.Text = "" Then
            tKembalian.Text = "0"
        Else
            Dim KembalianUang As Double = CDbl(tKembalian.Text)
            tTerbilangKembalian.Text = Uang.BILANG(Val(KembalianUang))
        End If
    End Sub
End Class