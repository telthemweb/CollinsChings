<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.transpicker = New System.Windows.Forms.DateTimePicker()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GridTrans = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbBookcode = New System.Windows.Forms.ComboBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.GridTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 75)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reports For All Transactions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Search Report by Date"
        '
        'transpicker
        '
        Me.transpicker.Checked = False
        Me.transpicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transpicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.transpicker.Location = New System.Drawing.Point(216, 93)
        Me.transpicker.Name = "transpicker"
        Me.transpicker.Size = New System.Drawing.Size(161, 35)
        Me.transpicker.TabIndex = 10
        Me.transpicker.Value = New Date(2018, 12, 17, 0, 0, 0, 0)
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Olive
        Me.Button4.Location = New System.Drawing.Point(370, 534)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 34)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Print"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GridTrans
        '
        Me.GridTrans.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridTrans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTrans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.GridTrans.Location = New System.Drawing.Point(25, 253)
        Me.GridTrans.Name = "GridTrans"
        Me.GridTrans.Size = New System.Drawing.Size(921, 253)
        Me.GridTrans.TabIndex = 41
        '
        'Column1
        '
        Me.Column1.HeaderText = "SrNo"
        Me.Column1.Name = "Column1"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Book Code"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 134
        '
        'Column2
        '
        Me.Column2.HeaderText = "Book ISBN"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 156
        '
        'Column3
        '
        Me.Column3.HeaderText = "Student ID"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 167
        '
        'Column4
        '
        Me.Column4.HeaderText = "Borrow Date"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 160
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date Returned"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 160
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(539, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Search by Book Code"
        '
        'cmbBookcode
        '
        Me.cmbBookcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBookcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBookcode.FormattingEnabled = True
        Me.cmbBookcode.Location = New System.Drawing.Point(736, 98)
        Me.cmbBookcode.Name = "cmbBookcode"
        Me.cmbBookcode.Size = New System.Drawing.Size(138, 28)
        Me.cmbBookcode.TabIndex = 43
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Green
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(661, 170)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(235, 58)
        Me.Button9.TabIndex = 44
        Me.Button9.Text = "Load Reports"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'TransactionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 580)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbBookcode)
        Me.Controls.Add(Me.GridTrans)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.transpicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransactionList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents transpicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents GridTrans As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbBookcode As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button9 As Button
End Class
