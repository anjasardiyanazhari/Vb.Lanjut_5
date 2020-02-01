Public Class FormInputSatuan

    Public QueryID As String = " select * from tbl_satuan where ID_Satuan in(select max(ID_Satuan) from tbl_satuan)"
    Public ID As String = "STN"
    Public NO As String = "0001"
    Public IDPe As String = "ID_Satuan"
    Public NOID As String = "STN-0001"
    Public NOID1 As String = "STN-0000"
    Public NOID2 As String = "STN-000"
    Public NOID3 As String = "STN-00"

    Private Sub FormInputSatuan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If kondisi = True Then
            DB.idOtomatis(txtIDSatuan, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
        End If
    End Sub

    Private Sub tSimpan_Click(sender As System.Object, e As System.EventArgs) Handles tSimpan.Click
        If txtIDSatuan.Text = "" Or txtSatuan.Text = "" Or txtket.Text = "" Then
            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            If kondisi = True Then
                DB.manipulasi("INSERT IGNORE INTO TBL_SATUAN VALUES ('" & txtIDSatuan.Text & "','" & txtSatuan.Text & "','" & txtket.Text & "')", "Simpan")
                DB.idOtomatis(txtIDSatuan, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
            Else
                DB.manipulasi("UPDATE TBL_SATUAN SET SATUAN='" & txtSatuan.Text & "', KETERANGAN='" & txtket.Text &
                              "' WHERE ID_SATUAN='" & txtIDSatuan.Text & "'", "Ubah")
            End If
            Call FormSatuan.RefreshDataSatuan()
        End If
    End Sub

    Private Sub tbatal_Click(sender As System.Object, e As System.EventArgs) Handles tbatal.Click
        Me.Close()
    End Sub
End Class