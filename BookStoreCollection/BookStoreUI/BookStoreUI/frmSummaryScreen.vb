'Affirmation of Authorship:

'Name: Darwin Chavez, David Johnson

'Date: 7/13/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by an yon and anyone else.
Public Class frmSummaryScreen
    Private storeName, orderNumber As String
    Private subtotal, tax, grandTotal As Double
    Private tiemStamp As Date

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs)
        MessageBox.Show(OrderFunctions.getStoreID("Barnum's"))
    End Sub

    Private Sub frmSummaryScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.BookStoreDataSet.sales)

        lstCartItems.Items.Clear()
        lstCartItems.Items.Add(frmOrderScreen.lstCart.Items)
        storeName = frmOrderScreen.cboStoreName.SelectedItem
        subtotal = frmOrderScreen.SubTotal
        orderNumber = OrderFunctions.genOrderNumber()
        tax = OrderFunctions.getTax()
        grandTotal = frmOrderScreen.grandTotal

        lblStoreName.Text = storeName
        lblSubTotal.Text = subtotal
        lblOrderNumber.Text = orderNumber
        lblGrandTotal.Text = grandTotal

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Select Case MsgBox("Are you sure you're complete with this order?", MsgBoxStyle.YesNo, "Complete order")
            Case MsgBoxResult.Yes
                MessageBox.Show("Thank you for your purchase from " + storeName + vbCrLf + vbCrLf + "Total: " + grandTotal + vbCrLf + "Order Number: " + orderNumber)
                frmOrderScreen.Close()
                Me.Close()
            Case MsgBoxResult.No
                Me.Close()
                Exit Sub
        End Select


        'Will send Information to database in phase 3
        'More specifically to the sales data base


    End Sub

    Private Sub SalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub


End Class
