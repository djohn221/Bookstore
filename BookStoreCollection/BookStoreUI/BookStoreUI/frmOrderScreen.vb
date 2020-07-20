'Affirmation of Authorship:

'Name: Darwin Chavez, David Johnson

'Date: 7/13/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by an yon and anyone else.
Imports BookBO
Public Class frmOrderScreen

    Public SubTotal As Double = 0.00
    Public storeName As String = ""
    Public grandTotal As Double = 0.00


    Private Sub TitlesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TitlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmOrderScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.titles' table. You can move, or remove it, as needed.
        Me.TitlesTableAdapter.Fill(Me.BookStoreDataSet.titles)
    End Sub


    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        frmSummaryScreen.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Removes item from selected list cart'
        Try
            If lstCart.Items.Count > 0 Then
                lstCart.Items.RemoveAt(lstCart.SelectedIndex)
            Else
                MessageBox.Show("Cart is empty")
            End If

            'Add Logic Here That will update the cart subtotal, tax, finalTotal'

        Catch ex As Exception
            MessageBox.Show(ex, "Please select an item.")
        End Try
    End Sub

    Private Sub lstCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCart.SelectedIndexChanged
        btnRemove.Enabled = True
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click

        'When addToCart button is selected, it will add titleID, titleName, Price and Quantity.'

        Do While mtbQuantity.Text = String.Empty
            MessageBox.Show("Please Enter a Quantity Value.")
        Loop

        Dim intQ As Integer = CType(mtbQuantity.Text, Integer)
        Dim dblPrice As Double = CType(txtPrice.Text, Double)
        Dim aTransaction As New BookBO.BookBO(txtTitleID.Text, txtTitleName.Text, dblPrice, intQ)

        'Add item into Cart using reference variable aTransaction from class BookBO'
        lstCart.Items.Add(aTransaction)
        'Update Subtotal'
        txtCartSubtotal.Text = dblPrice * intQ

    End Sub

End Class