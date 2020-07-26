'Affirmation of Authorship:

'Name: Darwin Chavez, David Johnson

'Date: 7/13/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by an yon and anyone else.
Imports BookBO
Imports OrderFunctions

Public Class frmOrderScreen
    Public Property dblSubtotal As Double
    Public Property dblTax As Double
    Public Property dblFinalTotal As Double

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
        If cboStoreName.SelectedIndex = -1 Then
            MessageBox.Show("There is no store selected.")
            Exit Sub
        ElseIf lstCart.Items.Count = 0 Then
            MessageBox.Show("Please add something to the cart.")
            Exit Sub
        End If
        frmSummaryScreen.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Removes item from selected list cart'
        If lstCart.Items.Count > 0 Then
            'Check if user selected an item from lstCart ListBox.'
            If lstCart.SelectedIndex = -1 Then
                MessageBox.Show("Please Select and Item.")
                Exit Sub
            Else
                'Add Logic Here That will update the cart subtotal, tax, finalTotal'
                'Get the Price and Quantity of item being removed.'
                'Dim dblPriceRemove As Double = lstCart.SelectedItem.dblPrice
                'Dim dblQuantityRemove As Double = CType(lstCart.SelectedItem.intQuantity, Double)

                ''Update Subtotal
                'Dim updatedSubtotal = subtractSubTotal(dblPriceRemove, dblQuantityRemove)
                'txtCartSubtotal.Text = updatedSubtotal

                ''Update Tax By Grabbing Tax of the item being removed(dblPriceRemv*dblQuantityRemv)
                'Dim dblTaxOfItem As Double = (getTax() * (dblPriceRemove * dblQuantityRemove))
                'Dim dblCurrTaxAmt As Double = CType(txtTax.Text.ToString(), Double)
                'txtTax.Text = dblCurrTaxAmt - dblTaxOfItem

                ''Update grandTotal
                'Dim updatedGrandTotal = ((dblTaxOfItem) + (dblPriceRemove * dblQuantityRemove))
                'txtTotal.Text = grandTotal - updatedGrandTotal

                'Removing Item is last step.'
                lstCart.Items.RemoveAt(lstCart.SelectedIndex)

            End If
        Else
            'Else Cart is empty
            'lstCart.Items.Count <0 Then'
            MessageBox.Show("Cart is empty")
        End If
    End Sub

    Private Sub lstCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCart.SelectedIndexChanged
        btnRemove.Enabled = True
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click

        If String.IsNullOrWhiteSpace(mtbQuantity.Text) Then
            MessageBox.Show("Please Enter a Quantity Value.")
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtPrice.Text) Then
            txtPrice.Text = "0.00"
        End If

        Dim dblQ As Double = CType(mtbQuantity.Text, Double)
        Dim dblPrice As Double = CType(txtPrice.Text, Double)
        Dim aTransaction As New BookBO.BookBO(txtTitleID.Text, txtTitleName.Text, dblPrice, dblQ)

        'Add item into Cart using reference variable aTransaction from class BookBO'
        lstCart.Items.Add(aTransaction)

        'dblSubtotal
        'dblTax
        'dblFinalTotal

        'Create a variable to get the subtotal
        dblSubtotal = getSubTotal(aTransaction.dblPrice, aTransaction.intQuantity)
        'Update Subtotal TextBox'
        txtCartSubtotal.Text = dblSubtotal

        'Tax is product of SubTotal and Tax
        dblTax = (getTax() * dblSubtotal)
        txtTax.Text = (dblTax)

        'GrandTotal = Subtotal + tax
        dblFinalTotal = (dblSubtotal + dblTax)
        txtTotal.Text = dblFinalTotal

    End Sub

End Class