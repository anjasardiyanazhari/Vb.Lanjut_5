Public Class FormInputMerek

    Public QueryID As String = " select * from tbl_merek where ID_Merek in(select max(ID_Merek) from tbl_merek)"
    Public ID As String = "MRK"
    Public NO As String = "0001"
    Public IDPe As String = "ID_Merek"
    Public NOID As String = "MRK-0001"
    Public NOID1 As String = "MRK-0000"
    Public NOID2 As String = "MRK-000"
    Public NOID3 As String = "MRK-00"

    Private Sub FormInputMerek_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If kondisi = True Then
            DB.idOtomatis(txtIDMerek, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
        End If
    End Sub

    Private Sub tSimpan_Click(sender As System.Object, e As System.EventArgs) Handles tSimpan.Click
        If txtIDMerek.Text = "" Or txtMerek.Text = "" Or txtket.Text = "" Then
            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            If kondisi = True Then
                DB.manipulasi("INSERT IGNORE INTO TBL_MEREK VALUES ('" & txtIDMerek.Text & "','" & txtMerek.Text & "','" & txtket.Text & "')", "Simpan")
                DB.idOtomatis(txtIDMerek, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
            Else
                DB.manipulasi("UPDATE TBL_MEREK SET MEREK='" & txtMerek.Text & "', KETERANGAN='" & txtket.Text &
                              "' WHERE ID_MEREK='" & txtIDMerek.Text & "'", "Ubah")
            End If
            Call FormMerek.RefreshDataMerek()
        End If
    End Sub

    Private Sub tbatal_Click(sender As System.Object, e As System.EventArgs) Handles tbatal.Click
        Me.Close()
    End Sub
End Class