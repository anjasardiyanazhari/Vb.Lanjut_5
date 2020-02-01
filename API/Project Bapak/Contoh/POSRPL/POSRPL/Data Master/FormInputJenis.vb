Imports MySql.Data.MySqlClient
Public Class FormInputJenis
    Public QueryID As String = "Select * From tbl_jenis Where ID_Jenis in(select max(ID_Jenis) from tbl_jenis)"
    Public ID As String = "JNS-"
    Public NO As String = "00001"
    Public IDPe As String = "ID_Jenis"
    Public NOID As String = "JNS-00001"
    Public NOID1 As String = "JNS-0000"
    Public NOID2 As String = "JNS-000"
    Public NOID3 As String = "JNS-00"

    Private Sub FormInputJenis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Kondisi = True Then
            DB.idOtomatis(txtIDJenis, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtIDJenis.Text = "" Or txtJenis.Text = "" Or txtKet.Text = "" Then
            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            If Kondisi = True Then 'SIMPAN DATA
                DB.manipulasi("INSERT IGNORE INTO TBL_JENIS VALUES ('" & txtIDJenis.Text & "','" & txtJenis.Text &
              "','" & txtKet.Text & "')", "Simpan")
            Else 'UBAH DATA
                DB.manipulasi("UPDATE TBL_JENIS SET JENIS ='" & txtJenis.Text & "', KETERANGAN='" & txtKet.Text &
                "' WHERE ID_JENIS='" & txtIDJenis.Text & "'", "Ubah")
            End If
            Call FormJenis.RefreshDataJenis()
            DB.idOtomatis(txtIDJenis, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
            txtJenis.Clear() : txtKet.Clear()
        End If
    End Sub
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class