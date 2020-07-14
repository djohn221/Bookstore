<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPublisher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPublisher))
        Me.PublishersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PublishersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnPublisherName = New System.Windows.Forms.Button()
        Me.PublishersDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtPublisherName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublishersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookStoreDataSet = New BookStoreUI.BookStoreDataSet()
        Me.PublishersTableAdapter = New BookStoreUI.BookStoreDataSetTableAdapters.publishersTableAdapter()
        Me.TableAdapterManager = New BookStoreUI.BookStoreDataSetTableAdapters.TableAdapterManager()
        CType(Me.PublishersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PublishersBindingNavigator.SuspendLayout()
        CType(Me.PublishersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookStoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PublishersBindingNavigator
        '
        Me.PublishersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PublishersBindingNavigator.BindingSource = Me.PublishersBindingSource
        Me.PublishersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PublishersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PublishersBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PublishersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PublishersBindingNavigatorSaveItem})
        Me.PublishersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PublishersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PublishersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PublishersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PublishersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PublishersBindingNavigator.Name = "PublishersBindingNavigator"
        Me.PublishersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PublishersBindingNavigator.Size = New System.Drawing.Size(683, 27)
        Me.PublishersBindingNavigator.TabIndex = 0
        Me.PublishersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'PublishersBindingNavigatorSaveItem
        '
        Me.PublishersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PublishersBindingNavigatorSaveItem.Image = CType(resources.GetObject("PublishersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PublishersBindingNavigatorSaveItem.Name = "PublishersBindingNavigatorSaveItem"
        Me.PublishersBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.PublishersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnPublisherName
        '
        Me.btnPublisherName.Location = New System.Drawing.Point(330, 340)
        Me.btnPublisherName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPublisherName.Name = "btnPublisherName"
        Me.btnPublisherName.Size = New System.Drawing.Size(172, 39)
        Me.btnPublisherName.TabIndex = 5
        Me.btnPublisherName.Text = "Search Publisher Name"
        Me.btnPublisherName.UseVisualStyleBackColor = True
        '
        'PublishersDataGridView
        '
        Me.PublishersDataGridView.AutoGenerateColumns = False
        Me.PublishersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PublishersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PublishersDataGridView.DataSource = Me.PublishersBindingSource
        Me.PublishersDataGridView.Location = New System.Drawing.Point(11, 44)
        Me.PublishersDataGridView.Name = "PublishersDataGridView"
        Me.PublishersDataGridView.RowTemplate.Height = 24
        Me.PublishersDataGridView.Size = New System.Drawing.Size(550, 220)
        Me.PublishersDataGridView.TabIndex = 7
        '
        'txtPublisherName
        '
        Me.txtPublisherName.Location = New System.Drawing.Point(126, 348)
        Me.txtPublisherName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPublisherName.MaxLength = 40
        Me.txtPublisherName.Name = "txtPublisherName"
        Me.txtPublisherName.Size = New System.Drawing.Size(185, 22)
        Me.txtPublisherName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Publisher Name:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "pub_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "pub_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "pub_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "pub_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "city"
        Me.DataGridViewTextBoxColumn3.HeaderText = "city"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "state"
        Me.DataGridViewTextBoxColumn4.HeaderText = "state"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "country"
        Me.DataGridViewTextBoxColumn5.HeaderText = "country"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'PublishersBindingSource
        '
        Me.PublishersBindingSource.DataMember = "publishers"
        Me.PublishersBindingSource.DataSource = Me.BookStoreDataSet
        '
        'BookStoreDataSet
        '
        Me.BookStoreDataSet.DataSetName = "BookStoreDataSet"
        Me.BookStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PublishersTableAdapter
        '
        Me.PublishersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.discountsTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.jobsTableAdapter = Nothing
        Me.TableAdapterManager.pub_infoTableAdapter = Nothing
        Me.TableAdapterManager.publishersTableAdapter = Me.PublishersTableAdapter
        Me.TableAdapterManager.royschedTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.storesTableAdapter = Nothing
        Me.TableAdapterManager.titleauthorTableAdapter = Nothing
        Me.TableAdapterManager.titlesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookStoreUI.BookStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmPublisher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 402)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPublisherName)
        Me.Controls.Add(Me.PublishersDataGridView)
        Me.Controls.Add(Me.btnPublisherName)
        Me.Controls.Add(Me.PublishersBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPublisher"
        Me.Text = "Publishers"
        CType(Me.PublishersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PublishersBindingNavigator.ResumeLayout(False)
        Me.PublishersBindingNavigator.PerformLayout()
        CType(Me.PublishersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookStoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookStoreDataSet As BookStoreDataSet
    Friend WithEvents PublishersBindingSource As BindingSource
    Friend WithEvents PublishersTableAdapter As BookStoreDataSetTableAdapters.publishersTableAdapter
    Friend WithEvents TableAdapterManager As BookStoreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PublishersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PublishersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnPublisherName As Button
    Friend WithEvents PublishersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents txtPublisherName As TextBox
    Friend WithEvents Label2 As Label
End Class
