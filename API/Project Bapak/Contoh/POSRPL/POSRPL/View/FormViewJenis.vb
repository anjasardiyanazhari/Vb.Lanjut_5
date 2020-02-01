Public Class FormViewJenis

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub FormViewJenis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        DB.tampilTabel1(GridViewJenis, "SELECT ID_JENIS, JENIS FROM TBL_JENIS")
    End Sub

    Private Sub GridViewJenis_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewJenis.DoubleClick
        With GridViewJenis
            FormInputBarang.txtIDJenis.Text = .Item(0, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub
End Class