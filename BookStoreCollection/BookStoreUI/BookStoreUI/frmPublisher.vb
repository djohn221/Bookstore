Public Class frmPublisher
    Private Sub PublishersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PublishersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PublishersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmPublisher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.publishers' table. You can move, or remove it, as needed.
        'Me.PublishersTableAdapter.Fill(Me.BookStoreDataSet.publishers)

    End Sub

    Private Sub btnPublisherName_Click(sender As Object, e As EventArgs) Handles btnPublisherName.Click
        Try


            Me.PublishersTableAdapter.fillTablePubName(Me.BookStoreDataSet.publishers, txtPublisherName.Text)
            txtPublisherName.Text = String.Empty

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Input Error")
        End Try
    End Sub
End Class