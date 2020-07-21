
Public Class frmLoginScreen
    Private Sub frmLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmBookStore.ShowDialog()
    End Sub
End Class