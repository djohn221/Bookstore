Public Class frmOrderScreen
    Private Sub TitlesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TitlesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TitlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmOrderScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.titles' table. You can move, or remove it, as needed.
        Me.TitlesTableAdapter.Fill(Me.BookStoreDataSet.titles)

    End Sub
End Class