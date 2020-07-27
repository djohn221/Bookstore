Imports BookDO
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummaryScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSubTotalText = New System.Windows.Forms.Label()
        Me.lblOrderNumberText = New System.Windows.Forms.Label()
        Me.lblTaxText = New System.Windows.Forms.Label()
        Me.lstCartItems = New System.Windows.Forms.ListBox()
        Me.grpOrderDetails = New System.Windows.Forms.GroupBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblStoreName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPayTerms = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.BookStoreDataSet = New BookDO.BookStoreDataSet()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New BookDO.BookStoreDataSetTableAdapters.salesTableAdapter()
        Me.TableAdapterManager = New BookDO.BookStoreDataSetTableAdapters.TableAdapterManager()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.grpOrderDetails.SuspendLayout()
        CType(Me.BookStoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSubTotalText
        '
        Me.lblSubTotalText.AutoSize = True
        Me.lblSubTotalText.Location = New System.Drawing.Point(57, 77)
        Me.lblSubTotalText.Name = "lblSubTotalText"
        Me.lblSubTotalText.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTotalText.TabIndex = 0
        Me.lblSubTotalText.Text = "SubTotal:"
        '
        'lblOrderNumberText
        '
        Me.lblOrderNumberText.AutoSize = True
        Me.lblOrderNumberText.Location = New System.Drawing.Point(34, 51)
        Me.lblOrderNumberText.Name = "lblOrderNumberText"
        Me.lblOrderNumberText.Size = New System.Drawing.Size(76, 13)
        Me.lblOrderNumberText.TabIndex = 1
        Me.lblOrderNumberText.Text = "Order Number:"
        '
        'lblTaxText
        '
        Me.lblTaxText.AutoSize = True
        Me.lblTaxText.Location = New System.Drawing.Point(82, 103)
        Me.lblTaxText.Name = "lblTaxText"
        Me.lblTaxText.Size = New System.Drawing.Size(28, 13)
        Me.lblTaxText.TabIndex = 2
        Me.lblTaxText.Text = "Tax:"
        '
        'lstCartItems
        '
        Me.lstCartItems.FormattingEnabled = True
        Me.lstCartItems.Location = New System.Drawing.Point(89, 75)
        Me.lstCartItems.Name = "lstCartItems"
        Me.lstCartItems.Size = New System.Drawing.Size(248, 173)
        Me.lstCartItems.TabIndex = 3
        '
        'grpOrderDetails
        '
        Me.grpOrderDetails.Controls.Add(Me.lblTax)
        Me.grpOrderDetails.Controls.Add(Me.lblSubTotal)
        Me.grpOrderDetails.Controls.Add(Me.lblGrandTotal)
        Me.grpOrderDetails.Controls.Add(Me.lblOrderNumber)
        Me.grpOrderDetails.Controls.Add(Me.lblStoreName)
        Me.grpOrderDetails.Controls.Add(Me.Label1)
        Me.grpOrderDetails.Controls.Add(Me.Label4)
        Me.grpOrderDetails.Controls.Add(Me.lblTaxText)
        Me.grpOrderDetails.Controls.Add(Me.lblSubTotalText)
        Me.grpOrderDetails.Controls.Add(Me.lblOrderNumberText)
        Me.grpOrderDetails.Location = New System.Drawing.Point(89, 254)
        Me.grpOrderDetails.Name = "grpOrderDetails"
        Me.grpOrderDetails.Size = New System.Drawing.Size(248, 158)
        Me.grpOrderDetails.TabIndex = 4
        Me.grpOrderDetails.TabStop = False
        Me.grpOrderDetails.Text = "Order Details"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(116, 102)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(119, 19)
        Me.lblTax.TabIndex = 9
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(116, 76)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(119, 19)
        Me.lblSubTotal.TabIndex = 8
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrandTotal.Location = New System.Drawing.Point(116, 128)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(119, 19)
        Me.lblGrandTotal.TabIndex = 7
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderNumber.Location = New System.Drawing.Point(116, 50)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(119, 19)
        Me.lblOrderNumber.TabIndex = 6
        '
        'lblStoreName
        '
        Me.lblStoreName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStoreName.Location = New System.Drawing.Point(117, 24)
        Me.lblStoreName.Name = "lblStoreName"
        Me.lblStoreName.Size = New System.Drawing.Size(119, 19)
        Me.lblStoreName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Store Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Grand Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Order Summary"
        '
        'cboPayTerms
        '
        Me.cboPayTerms.AutoCompleteCustomSource.AddRange(New String() {"Pay In advance", "NET 10", "NET 30", "NET 60", "NET 90"})
        Me.cboPayTerms.FormattingEnabled = True
        Me.cboPayTerms.Items.AddRange(New Object() {"Pay In Advance", "Payment seven days after invoice date", "Payment ten days after invoice date", "Payment 30 days after invoice date", "Payment 60 days after invoice date", "Payment 90 days after invoice date"})
        Me.cboPayTerms.Location = New System.Drawing.Point(152, 432)
        Me.cboPayTerms.Name = "cboPayTerms"
        Me.cboPayTerms.Size = New System.Drawing.Size(185, 21)
        Me.cboPayTerms.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pay Terms:"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(237, 500)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 35)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'BookStoreDataSet
        '
        Me.BookStoreDataSet.DataSetName = "BookStoreDataSet"
        Me.BookStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "sales"
        Me.SalesBindingSource.DataSource = Me.BookStoreDataSet
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.discountsTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.jobsTableAdapter = Nothing
        Me.TableAdapterManager.pub_infoTableAdapter = Nothing
        Me.TableAdapterManager.publishersTableAdapter = Nothing
        Me.TableAdapterManager.royschedTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.storesTableAdapter = Nothing
        Me.TableAdapterManager.titleauthorTableAdapter = Nothing
        Me.TableAdapterManager.titlesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookDO.BookStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(89, 500)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(90, 35)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "Return to Order Screen"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmSummaryScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 567)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboPayTerms)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grpOrderDetails)
        Me.Controls.Add(Me.lstCartItems)
        Me.Name = "frmSummaryScreen"
        Me.Text = "Summary"
        Me.grpOrderDetails.ResumeLayout(False)
        Me.grpOrderDetails.PerformLayout()
        CType(Me.BookStoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubTotalText As Label
    Friend WithEvents lblOrderNumberText As Label
    Friend WithEvents lblTaxText As Label
    Friend WithEvents lstCartItems As ListBox
    Friend WithEvents grpOrderDetails As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BookStoreDataSet As BookStoreDataSet
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As BookStoreDataSetTableAdapters.salesTableAdapter
    Friend WithEvents TableAdapterManager As BookStoreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPayTerms As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents lblOrderNumber As Label
    Friend WithEvents lblStoreName As Label
    Friend WithEvents btnReturn As Button
End Class
