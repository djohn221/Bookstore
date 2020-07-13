Public Class frmSummaryScreen
    Private storeName, orderNumber As String
    Private subtotal, tax, grandTotal As Double

    Private Sub frmSummaryScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.BookStoreDataSet.sales)

        lstCartItems.Items.Add(frmOrderScreen.lstCart.Items)
        storeName = frmOrderScreen.cmbStore.SelectedItem
        subtotal = frmOrderScreen.SubTotal

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

    End Sub

    Private Sub SalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub


End Class
