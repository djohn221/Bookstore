'Affirmation of Authorship:

'Name: Darwin Chavez, David Johnson

'Date: 7/13/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by an yon and anyone else.
Public Class frmAuthors
    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AuthorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmAuthors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.authors' table. You can move, or remove it, as needed.
        'Me.AuthorsTableAdapter.Fill(Me.BookStoreDataSet.authors)

    End Sub

    Private Sub btnAuthorName_Click(sender As Object, e As EventArgs) Handles btnAuthorName.Click

        Try

            Me.AuthorsTableAdapter.FillAuLastOrFirst(Me.BookStoreDataSet.authors, txtAuthorLastName.Text, txtAuthorFirstName.Text)
            txtAuthorLastName.Text = String.Empty
            txtAuthorFirstName.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Input Error")
        End Try
    End Sub
End Class