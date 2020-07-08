Public Class frmAuthors
    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AuthorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmAuthors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.BookStoreDataSet.authors)

    End Sub
End Class