<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mstrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.startcmd = New System.Windows.Forms.Button()
        Me.verlbl = New System.Windows.Forms.Label()
        Me.homelbl = New System.Windows.Forms.Label()
        Me.CheckOutMyGitHubPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mstrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(56, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IconDbCleaner"
        '
        'mstrip
        '
        Me.mstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mstrip.Location = New System.Drawing.Point(0, 0)
        Me.mstrip.Name = "mstrip"
        Me.mstrip.Size = New System.Drawing.Size(276, 24)
        Me.mstrip.TabIndex = 2
        Me.mstrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckOutMyGitHubPageToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'startcmd
        '
        Me.startcmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.startcmd.Location = New System.Drawing.Point(95, 150)
        Me.startcmd.Name = "startcmd"
        Me.startcmd.Size = New System.Drawing.Size(99, 23)
        Me.startcmd.TabIndex = 3
        Me.startcmd.Text = "Start"
        Me.startcmd.UseVisualStyleBackColor = True
        '
        'verlbl
        '
        Me.verlbl.AutoSize = True
        Me.verlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.verlbl.Location = New System.Drawing.Point(62, 73)
        Me.verlbl.Name = "verlbl"
        Me.verlbl.Size = New System.Drawing.Size(59, 15)
        Me.verlbl.TabIndex = 4
        Me.verlbl.Text = "Version "
        '
        'homelbl
        '
        Me.homelbl.AutoSize = True
        Me.homelbl.Location = New System.Drawing.Point(44, 121)
        Me.homelbl.Name = "homelbl"
        Me.homelbl.Size = New System.Drawing.Size(199, 13)
        Me.homelbl.TabIndex = 5
        Me.homelbl.Text = "To begin cleaning, click the Start button."
        '
        'CheckOutMyGitHubPageToolStripMenuItem
        '
        Me.CheckOutMyGitHubPageToolStripMenuItem.Name = "CheckOutMyGitHubPageToolStripMenuItem"
        Me.CheckOutMyGitHubPageToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.CheckOutMyGitHubPageToolStripMenuItem.Text = "Check out my GitHub page!"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 193)
        Me.Controls.Add(Me.homelbl)
        Me.Controls.Add(Me.verlbl)
        Me.Controls.Add(Me.startcmd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mstrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "home"
        Me.Text = "IconDbCleaner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mstrip.ResumeLayout(False)
        Me.mstrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mstrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents startcmd As Button
    Friend WithEvents verlbl As Label
    Friend WithEvents homelbl As Label
    Friend WithEvents CheckOutMyGitHubPageToolStripMenuItem As ToolStripMenuItem
End Class
