'Affirmation of Authorship:

'Name: Darwin Chavez, David Johnson

'Date: 7/13/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by an yon and anyone else.
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
        MessageBox.Show("Applications Name: Online Book Store" & vbNewLine & "Version: .5 Beta")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
