<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SDBackup
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SDBackup))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PreviewMP4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DestinationPath = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PreviewJPG = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CreateGameFolder = New System.Windows.Forms.CheckBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.AlbumFolder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PreviewMP4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviewJPG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.PreviewMP4)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DestinationPath)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.PreviewJPG)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CreateGameFolder)
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.AlbumFolder)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 108)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(734, 466)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Making SD Backup"
        '
        'PreviewMP4
        '
        Me.PreviewMP4.Enabled = True
        Me.PreviewMP4.Location = New System.Drawing.Point(551, 258)
        Me.PreviewMP4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PreviewMP4.Name = "PreviewMP4"
        Me.PreviewMP4.OcxState = CType(resources.GetObject("PreviewMP4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PreviewMP4.Size = New System.Drawing.Size(175, 134)
        Me.PreviewMP4.TabIndex = 36
        Me.PreviewMP4.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(575, 242)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Windows Media Required"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(487, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 25)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 45)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Where to Copy your Files ?"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(598, 77)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Click on to Open"
        '
        'DestinationPath
        '
        Me.DestinationPath.Location = New System.Drawing.Point(147, 45)
        Me.DestinationPath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DestinationPath.Name = "DestinationPath"
        Me.DestinationPath.Size = New System.Drawing.Size(401, 20)
        Me.DestinationPath.TabIndex = 29
        Me.DestinationPath.Text = "D:\Nintendo Switch Album Backup"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 439)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Backup will ignore files with the same name"
        Me.Label6.Visible = False
        '
        'PreviewJPG
        '
        Me.PreviewJPG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreviewJPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PreviewJPG.Location = New System.Drawing.Point(551, 93)
        Me.PreviewJPG.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PreviewJPG.Name = "PreviewJPG"
        Me.PreviewJPG.Size = New System.Drawing.Size(175, 112)
        Me.PreviewJPG.TabIndex = 25
        Me.PreviewJPG.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 401)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Backup Options :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(238, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "ScreenShots"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 242)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Videos"
        '
        'CreateGameFolder
        '
        Me.CreateGameFolder.AutoSize = True
        Me.CreateGameFolder.Checked = True
        Me.CreateGameFolder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CreateGameFolder.Location = New System.Drawing.Point(10, 419)
        Me.CreateGameFolder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CreateGameFolder.Name = "CreateGameFolder"
        Me.CreateGameFolder.Size = New System.Drawing.Size(128, 17)
        Me.CreateGameFolder.TabIndex = 14
        Me.CreateGameFolder.Text = "Separate by Game ID"
        Me.CreateGameFolder.UseVisualStyleBackColor = True
        Me.CreateGameFolder.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(10, 258)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(537, 134)
        Me.ListBox2.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(10, 93)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(537, 134)
        Me.ListBox1.TabIndex = 12
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(435, 427)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 35)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Launch Backup"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'AlbumFolder
        '
        Me.AlbumFolder.Location = New System.Drawing.Point(147, 18)
        Me.AlbumFolder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AlbumFolder.Name = "AlbumFolder"
        Me.AlbumFolder.Size = New System.Drawing.Size(336, 20)
        Me.AlbumFolder.TabIndex = 7
        Me.AlbumFolder.Text = "F:\Nintendo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Input Your Nintendo Folder:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(578, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Original Idea by Bakatrouble"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(663, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "GUI by Soaresden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(462, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 36)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "SysScreenUploader"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'SDBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 587)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SDBackup"
        Me.Text = "SDBackup"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PreviewMP4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviewJPG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CreateGameFolder As CheckBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents AlbumFolder As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DestinationPath As TextBox
    Friend WithEvents PreviewJPG As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PreviewMP4 As AxWMPLib.AxWindowsMediaPlayer
End Class
