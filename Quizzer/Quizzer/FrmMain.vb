Public Class FrmMain
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Me.Hide()
        FrmCreate.Show()
    End Sub

    Private Sub BtnTake_Click(sender As Object, e As EventArgs) Handles BtnTake.Click
        If OfdTake.ShowDialog() = DialogResult.OK Then
            Me.Hide()
            FrmTake.Show()
            FrmTake.InitializeQuiz(OfdTake.FileName)
        End If
    End Sub
End Class
