Public Class FormInputKategori

    Public QueryID As String = " select * from tbl_kategori where ID_Kategori in(select max(ID_Kategori) from tbl_kategori)"
    Public ID As String = "KTG-"
    Public NO As String = "00001"
    Public IDPe As String = "ID_Kategori"
    Public NOID As String = "KTG-0001"
    Public NOID1 As String = "KTG-0000"
    Public NOID2 As String = "KTG-000"
    Public NOID3 As String = "KTG-00"

    Private Sub label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub FormInputKategori_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If kondisi = True Then
            DB.idOtomatis(txtIDKategori, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If txtIDKategori.Text = "" Or txtKategori.Text = "" Or txtKet.Text = "" Then
            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            If kondisi = True Then
                DB.manipulasi("INSERT IGNORE INTO TBL_KATEGORI VALUES ('" & txtIDKategori.Text & "','" & txtKategori.Text & "','" & txtKet.Text & "')", "Simpan")
                DB.idOtomatis(txtIDKategori, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
            Else
                DB.manipulasi("UPDATE TBL_KATEGORI SET KATEGORI='" & txtKategori.Text & "', KETERANGAN='" & txtKet.Text &
                              "' WHERE ID_KATEGORI='" & txtIDKategori.Text & "'", "Ubah")
            End If
            Call FormKategori.RefreshDataKategori()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class