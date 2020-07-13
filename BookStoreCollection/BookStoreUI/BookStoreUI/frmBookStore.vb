Public Class frmBookStore

    Private Sub TitlesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitlesToolStripMenuItem.Click
        frmTitles.ShowDialog()
    End Sub

    Private Sub PublishersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublishersToolStripMenuItem.Click
        frmPublisher.ShowDialog()
    End Sub

    Private Sub AuthorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorsToolStripMenuItem.Click
        frmAuthors.ShowDialog()
    End Sub

    Private Sub OrderSummaryTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderSummaryTestToolStripMenuItem.Click
        frmOrderScreen.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Applications Name: Online Book Store" & vbNewLine & "Version: 1.0")
    End Sub
End Class
