Imports MySql.Data.MySqlClient
Imports alfathNET
Public Class Formulir
    Dim DB As New Database
    Dim Inf As New Informasi

    Private Sub SimpanData()
        DB.Con.Close() : DB.Con.Open()
        Dim SqlTrans As MySqlTransaction = DB.Con.BeginTransaction
        Dim Cmd As MySqlCommand = DB.Con.CreateCommand
        '======================================================='
        Try
            Dim FileSize As UInt32
            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()
            '====================================a==================='
            With Cmd
                .CommandText = "Simpan"
                .CommandType = CommandType.StoredProcedure
                .Connection = DB.Con
                .Transaction = SqlTrans
                '============================================================'
                Dim JurJen As String = cbJur.Text & " | " & cbJen.Text
                Dim JK As String
                If rbLaki.Checked = True Then
                    JK = "L"
                Else
                    JK = "P"
                End If
                .Parameters.Add("pNPM", MySqlDbType.VarChar, 10).Value = tNPM.Text
                .Parameters.Add("pNama", MySqlDbType.VarChar, 75).Value = tNama.Text
                .Parameters.Add("pTempat", MySqlDbType.VarChar, 50).Value = tTempat.Text
                .Parameters.Add("pTanggal", MySqlDbType.Date, 20).Value = Format(dtLahir.Value, "yyyy-MM-dd")
                .Parameters.Add("pJurJenjang", MySqlDbType.VarChar, 20).Value = JurJen
                .Parameters.Add("pKelamin", MySqlDbType.VarChar, 2).Value = JK
                .Parameters.Add("pFoto", arrImage)
                .ExecuteNonQuery()
                SqlTrans.Commit()
            End With
        Catch ex As Exception
            SqlTrans.Rollback()
            MsgBox(ex.Message)
        Finally
            SqlTrans.Dispose()
            Cmd.Dispose()
        End Try
    End Sub
    Private Sub AturGrid()
        With DataGridView1
            .Columns(0).HeaderText = "Npm"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "Nama Mahasiswa"
            .Columns(1).Width = 155
            .Columns(2).HeaderText = "Foto Mahasiswa"
            .Columns(2).Width = 150
            Dim imgc As New DataGridViewImageColumn()
            imgc = .Columns(2)
            imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
            .RowTemplate.Height = 125
            .Columns(3).HeaderText = "Jurusan | Jenjang"
            .Columns(3).Width = 150
        End With
    End Sub
    Private Sub bSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSimpan.Click
        If tNPM.Text = "" Or tNama.Text = "" Or tTempat.Text = "" Or cbJen.Text = "" Or cbJur.Text = "" Then
            Inf.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            Call SimpanData()
            DB.tampilTabel1(DataGridView1, "SELECT NPM, NAMA, FOTO, Jur_Jenjang FROM TBL_FORMULIR")
            Call AturGrid()
        End If
    End Sub

    Private Sub Formulir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DB.Koneksi("127.0.0.1", "root", "alfath", "db_formulir", "3306", Me)
        DB.tampilTabel1(DataGridView1, "SELECT NPM, NAMA, FOTO, JUR_JENJANG FROM TBL_FORMULIR")
        Call AturGrid()
    End Sub

    Private Sub bFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFoto.Click
        Try
            Dim CDFO As OpenFileDialog
            CDFO = New OpenFileDialog
            CDFO.ShowDialog()
            If CDFO.FileName = "" Then
                MessageBox.Show(Me, "Pilih gambar terlebih dahulu.", "Gambar kosong!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                PictureBox1.Image = Image.FromFile(CDFO.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        With DataGridView1
            DB.Con.Close() : DB.Con.Open()
            DB.Cmd = New MySqlCommand("SELECT * FROM TBL_FORMULIR WHERE NPM = '" & .Item(0, .CurrentRow.Index).Value & "'", DB.Con)
            DB.Rdr = DB.Cmd.ExecuteReader
            DB.Rdr.Read()
            If DB.Rdr.HasRows Then
                FormView.LabelNpm.Text = "NPM : " & DB.Rdr.GetString(0)
                FormView.LabelNama.Text = "Nama : " & DB.Rdr.GetString(1)
                FormView.LabelTempat.Text = "Tempat Lahir " & DB.Rdr.GetString(2)
                FormView.LabelTanggal.Text = "Tanggal Lahir " & Format(DB.Rdr.GetValue(3), "dd-MM-yyyy")
                FormView.LabelJurusan_Jenjang.Text = "Jurusan Dan Jenjang " & DB.Rdr.GetValue(4)
                Dim Jk As String = DB.Rdr.GetString(5)
                If Jk = "L" Then
                    FormView.RbLaki.Checked = True
                Else
                    FormView.RbPere.Checked = True
                End If
                Dim ArrImg() As Byte = DB.Rdr(6)
                Dim mstream As New System.IO.MemoryStream(ArrImg)
                FormView.PictureBox1.Image = Image.FromStream(mstream)
                FormView.ShowDialog()
            End If
            DB.Rdr.Close()
        End With
    End Sub
End Class
