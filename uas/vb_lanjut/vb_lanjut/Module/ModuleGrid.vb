Module ModuleGrid

    Sub RapiGrid(ByVal Grid As DataGridView, ByVal Table As String)
        Select Case Table
            Case "tbl_kategori"
                With Grid
                    .Columns(0).HeaderText = "Pilih"
                    .Columns(0).Width = 40
                    .Columns(1).HeaderText = "ID Kategori"
                    .Columns(1).Width = 250
                    .Columns(2).HeaderText = "Kategori"
                    .Columns(2).Width = 400
                    .Columns(3).HeaderText = "Keterangan"
                    .Columns(3).Width = 600
                End With

            Case "tbl_fasilitas"
                With Grid
                    .Columns(0).HeaderText = "Pilih"
                    .Columns(0).Width = 40
                    .Columns(1).HeaderText = "ID Fasilitas"
                    .Columns(1).Width = 250
                    .Columns(2).HeaderText = "Fasilitas"
                    .Columns(2).Width = 400
                    .Columns(3).HeaderText = "Keterangan"
                    .Columns(3).Width = 600
                End With

            Case "tbl_jasa"
                With Grid
                    .Columns(0).Width = 50
                    .Columns(0).HeaderText = "PILIH"
                    .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(0).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

            Case "view_jasa"
                With Grid
                    .Columns(0).Width = 50
                    .Columns(0).HeaderText = "PILIH"
                End With

        End Select

    End Sub
End Module
