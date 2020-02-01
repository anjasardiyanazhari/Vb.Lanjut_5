Public Class FormViewMerek

    Private Sub FormViewMerek_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DB.tampilTabel1(GridViewMerek, "SELECT ID_Merek, Merek FROM TBL_Merek")
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub GridViewMerek_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewMerek.DoubleClick
        With GridViewMerek
            FormInputBarang.txtIDMerek.Text = .Item(0, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub
End Class