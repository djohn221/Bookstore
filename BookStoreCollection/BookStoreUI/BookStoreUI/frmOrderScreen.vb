Public Class frmOrderScreen
    Public SubTotal As Double = 0.00
    Public storeName As String = ""


    Private Sub TitlesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TitlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmOrderScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.titles' table. You can move, or remove it, as needed.
        Me.TitlesTableAdapter.Fill(Me.BookStoreDataSet.titles)

    End Sub

    Private Sub cmbStore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStore.SelectedIndexChanged

    End Sub
End Class