Public Class frmOrderScreen
    Public SubTotal As Double = 0.00
    Public storeName As String = ""


    Private Sub TitlesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TitlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmOrderScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'BookStoreDataSet.sales' table. You can move, or remove it, as needed.
        'Me.SalesTableAdapter.Fill(Me.BookStoreDataSet.sales)
        ''TODO: This line of code loads data into the 'BookStoreDataSet.sales' table. You can move, or remove it, as needed.
        'Me.SalesTableAdapter.Fill(Me.BookStoreDataSet.sales)
        'TODO: This line of code loads data into the 'BookStoreDataSet.titles' table. You can move, or remove it, as needed.
        Me.TitlesTableAdapter.Fill(Me.BookStoreDataSet.titles)
        btnRemove.Enabled = False
        lstCart.Items.Add("Test")

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
        Catch ex As Exception
            MessageBox.Show(ex, "Please select an item.")
        End Try
    End Sub

    Private Sub lstCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCart.SelectedIndexChanged
        btnRemove.Enabled = True
    End Sub
End Class