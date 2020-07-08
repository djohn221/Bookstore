<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookStore
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublishersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OrderToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitlesToolStripMenuItem, Me.AuthorsToolStripMenuItem, Me.PublishersToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'TitlesToolStripMenuItem
        '
        Me.TitlesToolStripMenuItem.Name = "TitlesToolStripMenuItem"
        Me.TitlesToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.TitlesToolStripMenuItem.Text = "Titles"
        '
        'AuthorsToolStripMenuItem
        '
        Me.AuthorsToolStripMenuItem.Name = "AuthorsToolStripMenuItem"
        Me.AuthorsToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AuthorsToolStripMenuItem.Text = "Authors"
        '
        'PublishersToolStripMenuItem
        '
        Me.PublishersToolStripMenuItem.Name = "PublishersToolStripMenuItem"
        Me.PublishersToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.PublishersToolStripMenuItem.Text = "Publishers"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'lstShoppingCart
        '
        Me.lstShoppingCart.FormattingEnabled = True
        Me.lstShoppingCart.ItemHeight = 16
        Me.lstShoppingCart.Location = New System.Drawing.Point(403, 50)
        Me.lstShoppingCart.Name = "lstShoppingCart"
        Me.lstShoppingCart.Size = New System.Drawing.Size(370, 276)
        Me.lstShoppingCart.TabIndex = 1
        '
        'frmBookStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstShoppingCart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBookStore"
        Me.Text = "Book Store"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TitlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuthorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PublishersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstShoppingCart As ListBox
End Class
