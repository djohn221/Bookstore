<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.TitlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookStoreDataSet = New BookStoreUI.BookStoreDataSet()
        Me.lblCatalog = New System.Windows.Forms.Label()
        Me.lblTitleName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.txtTitleName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtCartSubtotal = New System.Windows.Forms.TextBox()
        Me.TitlesTableAdapter = New BookStoreUI.BookStoreDataSetTableAdapters.titlesTableAdapter()
        Me.TableAdapterManager = New BookStoreUI.BookStoreDataSetTableAdapters.TableAdapterManager()
        Me.cboStoreName = New System.Windows.Forms.ComboBox()
        Me.FKsalestitleid24927208BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SalesTableAdapter = New BookStoreUI.BookStoreDataSetTableAdapters.salesTableAdapter()
        Me.TitlesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtbQuantity = New System.Windows.Forms.MaskedTextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtTitleID = New System.Windows.Forms.TextBox()
        Me.lblTitleID = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookStoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKsalestitleid24927208BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 16
        Me.lstCart.Location = New System.Drawing.Point(503, 100)
        Me.lstCart.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(665, 276)
        Me.lstCart.TabIndex = 0
        '
        'TitlesBindingSource
        '
        Me.TitlesBindingSource.DataMember = "titles"
        Me.TitlesBindingSource.DataSource = Me.BookStoreDataSet
        '
        'BookStoreDataSet
        '
        Me.BookStoreDataSet.DataSetName = "BookStoreDataSet"
        Me.BookStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCatalog
        '
        Me.lblCatalog.AutoSize = True
        Me.lblCatalog.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatalog.Location = New System.Drawing.Point(16, 39)
        Me.lblCatalog.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCatalog.Name = "lblCatalog"
        Me.lblCatalog.Size = New System.Drawing.Size(415, 39)
        Me.lblCatalog.TabIndex = 3
        Me.lblCatalog.Text = "Choose From the Catalog:"
        '
        'lblTitleName
        '
        Me.lblTitleName.AutoSize = True
        Me.lblTitleName.Location = New System.Drawing.Point(63, 452)
        Me.lblTitleName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleName.Name = "lblTitleName"
        Me.lblTitleName.Size = New System.Drawing.Size(39, 17)
        Me.lblTitleName.TabIndex = 4
        Me.lblTitleName.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 542)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Quantity:"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(112, 601)
        Me.btnAddToCart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(171, 57)
        Me.btnAddToCart.TabIndex = 6
        Me.btnAddToCart.Text = "Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'txtTitleName
        '
        Me.txtTitleName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "title", True))
        Me.txtTitleName.Enabled = False
        Me.txtTitleName.Location = New System.Drawing.Point(112, 452)
        Me.txtTitleName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitleName.MaxLength = 80
        Me.txtTitleName.Name = "txtTitleName"
        Me.txtTitleName.Size = New System.Drawing.Size(185, 22)
        Me.txtTitleName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(835, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 39)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Current Cart:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(749, 490)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Cart Subtotal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(807, 527)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tax:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(799, 564)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(496, 601)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(157, 57)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel Order"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(843, 601)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(181, 57)
        Me.btnCheckout.TabIndex = 15
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(851, 561)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(169, 22)
        Me.txtTotal.TabIndex = 17
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Location = New System.Drawing.Point(851, 523)
        Me.txtTax.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(169, 22)
        Me.txtTax.TabIndex = 18
        '
        'txtCartSubtotal
        '
        Me.txtCartSubtotal.Enabled = False
        Me.txtCartSubtotal.Location = New System.Drawing.Point(851, 487)
        Me.txtCartSubtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCartSubtotal.Name = "txtCartSubtotal"
        Me.txtCartSubtotal.Size = New System.Drawing.Size(169, 22)
        Me.txtCartSubtotal.TabIndex = 19
        '
        'TitlesTableAdapter
        '
        Me.TitlesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.storesTableAdapter = Nothing
        Me.TableAdapterManager.titleauthorTableAdapter = Nothing
        Me.TableAdapterManager.titlesTableAdapter = Me.TitlesTableAdapter
        Me.TableAdapterManager.UpdateOrder = BookStoreUI.BookStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cboStoreName
        '
        Me.cboStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStoreName.FormattingEnabled = True
        Me.cboStoreName.Items.AddRange(New Object() {"Eric the Read Books", "Barnum's", "News & Brews", "Doc-U-Mat: Quality Laundry and Books ", "Fricative Bookshop ", "Bookbeat"})
        Me.cboStoreName.Location = New System.Drawing.Point(112, 420)
        Me.cboStoreName.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStoreName.Name = "cboStoreName"
        Me.cboStoreName.Size = New System.Drawing.Size(185, 24)
        Me.cboStoreName.TabIndex = 20
        '
        'FKsalestitleid24927208BindingSource
        '
        Me.FKsalestitleid24927208BindingSource.DataMember = "FK__sales__title_id__24927208"
        Me.FKsalestitleid24927208BindingSource.DataSource = Me.TitlesBindingSource
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 423)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Store Name:"
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TitlesDataGridView
        '
        Me.TitlesDataGridView.AutoGenerateColumns = False
        Me.TitlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TitlesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TitlesDataGridView.DataSource = Me.TitlesBindingSource
        Me.TitlesDataGridView.Location = New System.Drawing.Point(32, 100)
        Me.TitlesDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TitlesDataGridView.Name = "TitlesDataGridView"
        Me.TitlesDataGridView.RowTemplate.Height = 24
        Me.TitlesDataGridView.Size = New System.Drawing.Size(399, 290)
        Me.TitlesDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "title_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "title_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pub_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "pub_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "advance"
        Me.DataGridViewTextBoxColumn6.HeaderText = "advance"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "royalty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "royalty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ytd_sales"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ytd_sales"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "notes"
        Me.DataGridViewTextBoxColumn9.HeaderText = "notes"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "pubdate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "pubdate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'mtbQuantity
        '
        Me.mtbQuantity.Location = New System.Drawing.Point(112, 542)
        Me.mtbQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtbQuantity.Mask = "00"
        Me.mtbQuantity.Name = "mtbQuantity"
        Me.mtbQuantity.Size = New System.Drawing.Size(185, 22)
        Me.mtbQuantity.TabIndex = 22
        Me.mtbQuantity.ValidatingType = GetType(Integer)
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.Location = New System.Drawing.Point(1059, 383)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(111, 23)
        Me.btnRemove.TabIndex = 24
        Me.btnRemove.Text = "Remove Item"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtTitleID
        '
        Me.txtTitleID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "title_id", True))
        Me.txtTitleID.Enabled = False
        Me.txtTitleID.Location = New System.Drawing.Point(112, 482)
        Me.txtTitleID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitleID.MaxLength = 80
        Me.txtTitleID.Name = "txtTitleID"
        Me.txtTitleID.Size = New System.Drawing.Size(185, 22)
        Me.txtTitleID.TabIndex = 26
        '
        'lblTitleID
        '
        Me.lblTitleID.AutoSize = True
        Me.lblTitleID.Location = New System.Drawing.Point(45, 482)
        Me.lblTitleID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleID.Name = "lblTitleID"
        Me.lblTitleID.Size = New System.Drawing.Size(56, 17)
        Me.lblTitleID.TabIndex = 25
        Me.lblTitleID.Text = "Title ID:"
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "price", True))
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(112, 512)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.MaxLength = 80
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(185, 22)
        Me.txtPrice.TabIndex = 28
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(59, 512)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 17)
        Me.lblPrice.TabIndex = 27
        Me.lblPrice.Text = "Price:"
        '
        'frmOrderScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 678)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtTitleID)
        Me.Controls.Add(Me.lblTitleID)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.mtbQuantity)
        Me.Controls.Add(Me.TitlesDataGridView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboStoreName)
        Me.Controls.Add(Me.txtCartSubtotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTitleName)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitleName)
        Me.Controls.Add(Me.lblCatalog)
        Me.Controls.Add(Me.lstCart)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmOrderScreen"
        Me.Text = "Place Order"
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookStoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKsalestitleid24927208BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCart As ListBox
    Friend WithEvents BookStoreDataSet As BookStoreDataSet
    Friend WithEvents TitlesBindingSource As BindingSource
    Friend WithEvents TitlesTableAdapter As BookStoreDataSetTableAdapters.titlesTableAdapter
    Friend WithEvents TableAdapterManager As BookStoreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblCatalog As Label
    Friend WithEvents lblTitleName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents txtTitleName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtCartSubtotal As TextBox
    Friend WithEvents cboStoreName As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FKsalestitleid24927208BindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As BookStoreDataSetTableAdapters.salesTableAdapter
    Friend WithEvents TitlesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents mtbQuantity As MaskedTextBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtTitleID As TextBox
    Friend WithEvents lblTitleID As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
End Class
