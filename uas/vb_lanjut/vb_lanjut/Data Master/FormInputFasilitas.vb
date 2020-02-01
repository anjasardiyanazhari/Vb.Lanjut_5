Public Class FormInputFasilitas

    Public QueryID As String = " select * from tbl_fasilitas where ID_Fasilitas in(select max(ID_Fasilitas) from tbl_fasilitas)"
    Public ID As String = "FLS-"
    Public NO As String = "00001"
    Public IDPe As String = "ID_Fasilitas"
    Public NOID As String = "FLS-0001"
    Public NOID1 As String = "FLS-0000"
    Public NOID2 As String = "FLS-000"
    Public NOID3 As String = "FLS-00"

    Private Sub FormInputFasilitas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If kondisi = True Then
            DB.idOtomatis(txtIDFasilitas, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If txtIDFasilitas.Text = "" Or txtFasilitas.Text = "" Or txtKet.Text = "" Then
            INF.Pesan("Data belum lengkap", "Peringatan", "Peringatan")
        Else
            If kondisi = True Then
                DB.manipulasi("INSERT IGNORE INTO TBL_FASILITAS VALUES ('" & txtIDFasilitas.Text & "','" & txtFasilitas.Text & "','" & txtKet.Text & "')", "Simpan")
                DB.idOtomatis(txtIDFasilitas, QueryID, NO, ID, NOID, IDPe, NOID1, NOID2, NOID3)
            Else
                DB.manipulasi("UPDATE TBL_FASILITAS SET FASILITAS='" & txtFasilitas.Text & "', KETERANGAN='" & txtKet.Text &
                              "' WHERE ID_FASILITAS='" & txtIDFasilitas.Text & "'", "Ubah")
            End If
            Call FormFasilitas.RefreshDataFasilitas()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class