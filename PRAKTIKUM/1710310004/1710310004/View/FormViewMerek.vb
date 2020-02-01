Public Class FormViewMerek

    Private Sub FormViewMerek_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DB.tampilTabel1(DataGridViewMerek, "SELECT ID_Merek, MEREK FROM TBL_MEREK")
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewMerek_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DataGridViewMerek.DoubleClick
        With DataGridViewMerek
            FormInputBarang.tKODE_MEREK.Text = .Item(0, .CurrentRow.Index).Value
            Me.Close()
        End With
    End Sub
End Class