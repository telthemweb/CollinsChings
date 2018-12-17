<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoorrowedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvailableBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersT = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicalSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblAvtar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BooksToolStripMenuItem, Me.UsersT, Me.MembersToolStripMenuItem, Me.LoansToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1352, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBookToolStripMenuItem, Me.ViewsToolStripMenuItem, Me.IssueBookToolStripMenuItem, Me.BoorrowedBooksToolStripMenuItem, Me.AvailableBooksToolStripMenuItem})
        Me.BooksToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources.back
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'AddBookToolStripMenuItem
        '
        Me.AddBookToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources._1452835590_Newspaper
        Me.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        Me.AddBookToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.AddBookToolStripMenuItem.Text = "Add Book"
        '
        'ViewsToolStripMenuItem
        '
        Me.ViewsToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources.Actions_address_book_new_icon
        Me.ViewsToolStripMenuItem.Name = "ViewsToolStripMenuItem"
        Me.ViewsToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.ViewsToolStripMenuItem.Text = "Views Books"
        '
        'IssueBookToolStripMenuItem
        '
        Me.IssueBookToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources.Actions_contact_new_icon
        Me.IssueBookToolStripMenuItem.Name = "IssueBookToolStripMenuItem"
        Me.IssueBookToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.IssueBookToolStripMenuItem.Text = "Issue Book"
        '
        'BoorrowedBooksToolStripMenuItem
        '
        Me.BoorrowedBooksToolStripMenuItem.Name = "BoorrowedBooksToolStripMenuItem"
        Me.BoorrowedBooksToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.BoorrowedBooksToolStripMenuItem.Text = "Boorrowed Books"
        '
        'AvailableBooksToolStripMenuItem
        '
        Me.AvailableBooksToolStripMenuItem.Name = "AvailableBooksToolStripMenuItem"
        Me.AvailableBooksToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.AvailableBooksToolStripMenuItem.Text = "Available Books"
        '
        'UsersT
        '
        Me.UsersT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ViewUsersToolStripMenuItem})
        Me.UsersT.Image = Global.LIBS.My.Resources.Resources.girl_1
        Me.UsersT.Name = "UsersT"
        Me.UsersT.Size = New System.Drawing.Size(79, 25)
        Me.UsersT.Text = "Users"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources.Customer_32x32
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'ViewUsersToolStripMenuItem
        '
        Me.ViewUsersToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources.customers
        Me.ViewUsersToolStripMenuItem.Name = "ViewUsersToolStripMenuItem"
        Me.ViewUsersToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.ViewUsersToolStripMenuItem.Text = "View Users"
        '
        'MembersToolStripMenuItem
        '
        Me.MembersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolStripMenuItem, Me.ViewStudentsToolStripMenuItem})
        Me.MembersToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources._585e4bc4cb11b227491c3395
        Me.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        Me.MembersToolStripMenuItem.Size = New System.Drawing.Size(109, 25)
        Me.MembersToolStripMenuItem.Text = "Members"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources.Add_User_50
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'ViewStudentsToolStripMenuItem
        '
        Me.ViewStudentsToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources.customers
        Me.ViewStudentsToolStripMenuItem.Name = "ViewStudentsToolStripMenuItem"
        Me.ViewStudentsToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.ViewStudentsToolStripMenuItem.Text = "View Students"
        '
        'LoansToolStripMenuItem
        '
        Me.LoansToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnBooksToolStripMenuItem})
        Me.LoansToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources._1__10_
        Me.LoansToolStripMenuItem.Name = "LoansToolStripMenuItem"
        Me.LoansToolStripMenuItem.Size = New System.Drawing.Size(149, 25)
        Me.LoansToolStripMenuItem.Text = "Fine Payments"
        '
        'ReturnBooksToolStripMenuItem
        '
        Me.ReturnBooksToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources._1__10_
        Me.ReturnBooksToolStripMenuItem.Name = "ReturnBooksToolStripMenuItem"
        Me.ReturnBooksToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.ReturnBooksToolStripMenuItem.Text = "Fine Paid"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechnicalSupportToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources._1374
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(96, 25)
        Me.HelpToolStripMenuItem.Text = "Reports"
        '
        'TechnicalSupportToolStripMenuItem
        '
        Me.TechnicalSupportToolStripMenuItem.Image = Global.LIBS.My.Resources.Resources._1__16_
        Me.TechnicalSupportToolStripMenuItem.Name = "TechnicalSupportToolStripMenuItem"
        Me.TechnicalSupportToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.TechnicalSupportToolStripMenuItem.Text = "View Reports"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1131, 3)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(172, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "User"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblAvtar
        '
        Me.lblAvtar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAvtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAvtar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvtar.ForeColor = System.Drawing.Color.White
        Me.lblAvtar.Location = New System.Drawing.Point(1132, 32)
        Me.lblAvtar.Name = "lblAvtar"
        Me.lblAvtar.Size = New System.Drawing.Size(194, 27)
        Me.lblAvtar.TabIndex = 2
        Me.lblAvtar.Text = "User"
        Me.lblAvtar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.LIBS.My.Resources.Resources.copy1600
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(498, 255)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 183)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(498, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 62)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(751, 438)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(222, 62)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox2.BackgroundImage = Global.LIBS.My.Resources.Resources.open_folder16001
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(751, 255)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 183)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1008, 438)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(222, 62)
        Me.Button4.TabIndex = 8
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox4.BackgroundImage = Global.LIBS.My.Resources.Resources.imagesf
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(1008, 255)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(222, 183)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(249, 438)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(222, 62)
        Me.Button5.TabIndex = 12
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox5.BackgroundImage = Global.LIBS.My.Resources.Resources.customers1
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(249, 255)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(222, 183)
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(278, 441)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "View Members"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(518, 438)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Available Books"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(767, 441)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 27)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Borrowed Books"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1074, 441)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 27)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Reports "
        '
        'lblTl
        '
        Me.lblTl.AutoSize = True
        Me.lblTl.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTl.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTl.ForeColor = System.Drawing.Color.Cyan
        Me.lblTl.Location = New System.Drawing.Point(542, 465)
        Me.lblTl.Name = "lblTl"
        Me.lblTl.Size = New System.Drawing.Size(121, 27)
        Me.lblTl.TabIndex = 18
        Me.lblTl.Text = "Click Here"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Cyan
        Me.Label8.Location = New System.Drawing.Point(800, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 27)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Click Here"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(1065, 468)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 27)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Click Here"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cyan
        Me.Label6.Location = New System.Drawing.Point(306, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 27)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Click Here"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(909, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(231, 27)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "You are Logged in as"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.LIBS.My.Resources.Resources.clay_banks_258326_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 741)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAvtar)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersT As ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TechnicalSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblAvtar As Button
    Friend WithEvents IssueBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoorrowedBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvailableBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
