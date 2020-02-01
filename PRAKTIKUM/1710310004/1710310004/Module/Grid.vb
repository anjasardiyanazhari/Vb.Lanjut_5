Module Grid

    Sub RapiGrid(ByVal Grid As DataGridView, ByVal Table As String)
        Select Case Table
            Case "tbl_jenis"
                With Grid
                    .Columns(0).HeaderText = "Pilih"
                    .Columns(0).Width = 40
                    .Columns(1).HeaderText = "ID Jenis"
                    .Columns(1).Width = 250
                    .Columns(2).HeaderText = "Jenis"
                    .Columns(2).Width = 400
                    .Columns(3).HeaderText = "Keterangan"
                    .Columns(3).Width = 600
                End With

            Case "tbl_merek"
                With Grid
                    .Columns(0).HeaderText = "Pilih"
                    .Columns(0).Width = 40
                    .Columns(1).HeaderText = "ID Merek"
                    .Columns(1).Width = 250
                    .Columns(2).HeaderText = "Merek"
                    .Columns(2).Width = 400
                    .Columns(3).HeaderText = "Keterangan"
                    .Columns(3).Width = 600
                End With

            Case "tbl_satuan"
                With Grid
                    .Columns(0).HeaderText = "Pilih"
                    .Columns(0).Width = 40
                    .Columns(1).HeaderText = "ID Satuan"
                    .Columns(1).Width = 250
                    .Columns(2).HeaderText = "Satuan"
                    .Columns(2).Width = 400
                    .Columns(3).HeaderText = "Keterangan"
                    .Columns(3).Width = 600
                End With

            Case "tbl_barang"
                With Grid
                    .Columns(0).Width = 50
                    .Columns(0).HeaderText = "PILIH"
                    .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(0).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(1).Width = 130
                    .Columns(1).HeaderText = "ID BARANG"
                    .Columns(2).Width = 300
                    .Columns(2).HeaderText = "NAMA BARANG"
                    .Columns(3).Width = 300
                    .Columns(3).HeaderText = "HARGA BELI"
                    .Columns(3).DefaultCellStyle.Format = "N0"
                    .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(3).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(4).Width = 120
                    .Columns(4).HeaderText = "HARGA JUAL"
                    .Columns(4).DefaultCellStyle.Format = "N0"
                    .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(4).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(5).Width = 120
                    .Columns(5).HeaderText = "LABA"
                    .Columns(5).DefaultCellStyle.Format = "N0"
                    .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(5).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(6).Width = 75
                    .Columns(6).HeaderText = "STOK"
                    .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(6).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(7).Width = 95
                    .Columns(7).HeaderText = "ID.JENIS"
                    .Columns(8).Width = 95
                    .Columns(8).HeaderText = "ID.MEREK"
                    .Columns(9).Width = 95
                    .Columns(9).HeaderText = "ID.SATUAN"
                    .Columns(10).Width = 110
                    .Columns(10).HeaderText = "SATUAN"
                    .Columns(11).Width = 110
                    .Columns(11).HeaderText = "UKURAN"
                    .Columns(12).Width = 120
                    .Columns(12).HeaderText = "DISKON"
                    .Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(12).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(13).Width = 120
                    .Columns(13).HeaderText = "KETERANGAN"
                    .Columns(14).Width = 75
                    .Columns(14).HeaderText = "JML.RETURN"
                    .Columns(14).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(14).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(15).Width = 150
                    .Columns(15).HeaderText = "SUB TOTAL"
                    .Columns(15).DefaultCellStyle.Format = "N0"
                    .Columns(15).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(15).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

            Case "view_jual"
                With Grid
                    .Columns(0).Width = 50
                    .Columns(0).HeaderText = "PILIH"
                    .Columns(1).Width = 120
                    .Columns(1).HeaderText = "ID Penjualan"
                    .Columns(2).Width = 120
                    .Columns(2).HeaderText = "ID Pelanggan"
                    .Columns(3).Width = 200
                    .Columns(3).HeaderText = "ID Pelanggan"
                    .Columns(4).Width = 100
                    .Columns(4).HeaderText = "Tgl.Transaksi"
                    .Columns(4).DefaultCellStyle.Format = "dd-MM-yyyy"
                    .Columns(5).Width = 100
                    .Columns(5).HeaderText = "ID Barang"
                    .Columns(6).Width = 200
                    .Columns(6).HeaderText = "Barang"
                    .Columns(7).Width = 100
                    .Columns(7).HeaderText = "Harga Barang"
                    .Columns(7).DefaultCellStyle.Format = "N0"
                    .Columns(8).Width = 50
                    .Columns(8).HeaderText = "Qyt"
                    .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(8).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(9).Width = 145
                    .Columns(9).HeaderText = "Sub Total"
                End With

        End Select

    End Sub
End Module
