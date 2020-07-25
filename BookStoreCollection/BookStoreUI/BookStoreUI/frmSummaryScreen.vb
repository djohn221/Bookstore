'Affirmation of Authorship:

'Name: Darwin Chavez, David Johnson

'Date: 7/13/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by an yon and anyone else.
Imports BookBO
Imports BookDO

Public Class frmSummaryScreen
    Private storeName, orderNumber, stor_id As String
    Private subtotal, tax, grandTotal As Double
    Private timeStamp As Date

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub frmSummaryScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.BookStoreDataSet.sales)

        lstCartItems.Items.Clear()
        lstCartItems.Items.AddRange(frmOrderScreen.lstCart.Items)
        storeName = frmOrderScreen.cboStoreName.SelectedItem
        'subtotal = frmOrderScreen.SubTotal
        orderNumber = OrderFunctions.genOrderNumber()
        tax = (OrderFunctions.getTax() * subtotal)
        'grandTotal = frmOrderScreen.grandTotal


        lblStoreName.Text = storeName
        lblSubTotal.Text = frmOrderScreen.txtCartSubtotal.Text
        lblTax.Text = frmOrderScreen.txtTax.Text
        lblOrderNumber.Text = orderNumber
        lblGrandTotal.Text = frmOrderScreen.txtTotal.Text
        stor_id = OrderFunctions.getStoreID(storeName)
        timeStamp = Date.Today

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If cboPayTerms.SelectedIndex <> -1 Then
            Select Case MsgBox("Are you sure you're complete with this order?", MsgBoxStyle.YesNo, "Complete order")
                Case MsgBoxResult.Yes
                    MessageBox.Show("Thank you for your purchase from " + storeName + vbCrLf + vbCrLf + "Total: " + grandTotal.ToString() + vbCrLf + "Order Number: " + orderNumber)
                    frmOrderScreen.Close()
                    Me.Close()
                Case MsgBoxResult.No
                    Me.Close()
                    Exit Sub
            End Select
        Else
            MessageBox.Show("Please choose a payterm.")
            Exit Sub
        End If

        'Will send Information to database in phase 3
        'More specifically to the sales data base

        Dim finishedOrder As New OrderDO()

        For Each order As BookBO.BookBO In frmOrderScreen.lstCart.Items
            MessageBox.Show(stor_id + " " + orderNumber + " " + timeStamp + " " + order.intQuantity.ToString() + " " + cboPayTerms.Text + " " + order.strTitleID)
            finishedOrder.NewInsert(stor_id, orderNumber, timeStamp, order.intQuantity, cboPayTerms.Text, order.strTitleID)
        Next


    End Sub

    Private Sub SalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub


End Class
