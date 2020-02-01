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