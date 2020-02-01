Public Class FormInputJenis

    Public QueryID As String = " select * from tbl_jenis where ID_Jenis in(select max(ID_Jenis) from tbl_jenis)"
    Public ID As String = "JNS"
    Public NO As String = "0001"
    Public IDPe As String = "ID_Jenis"
    Public NOID As String = "JNS-0001"
    Public NOID1 As String = "JNS-0000"
    Public NOID2 As String = "JNS-000"
    Public NOID3 As String = "JNS-00"

    Private Sub FormInputJenis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If kondisi = True Then
            DB.idOtomatis(txtIDJenis, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
        End If
    End Sub

    Private Sub tSimpan_Click(sender As System.Object, e As System.EventArgs) Handles tSimpan.Click
        If txtIDJenis.Text = "" Or txtJenis.Text = "" Or txtket.Text = "" Then
            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            If kondisi = True Then
                DB.manipulasi("INSERT IGNORE INTO TBL_JENIS VALUES ('" & txtIDJenis.Text & "','" & txtJenis.Text & "','" & txtket.Text & "')", "Simpan")
                DB.idOtomatis(txtIDJenis, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
            Else
                DB.manipulasi("UPDATE TBL_JENIS SET JENIS='" & txtJenis.Text & "', KETERANGAN='" & txtket.Text &
                              "' WHERE ID_JENIS='" & txtIDJenis.Text & "'", "Ubah")
            End If
            Call FormJenis.RefreshDataJenis()
        End If
    End Sub

    Private Sub tbatal_Click(sender As System.Object, e As System.EventArgs) Handles tbatal.Click
        Me.Close()
    End Sub
End Class