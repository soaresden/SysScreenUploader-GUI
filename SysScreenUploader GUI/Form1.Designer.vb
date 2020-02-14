<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ExecuteButton = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.outputfolder = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lineedited = New System.Windows.Forms.TextBox()
        Me.ConfigFilePath = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox1.Controls.Add(Me.ExecuteButton)
        Me.GroupBox1.Controls.Add(Me.ListBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.outputfolder)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 356)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Launching Server"
        '
        'ExecuteButton
        '
        Me.ExecuteButton.Location = New System.Drawing.Point(255, 283)
        Me.ExecuteButton.Name = "ExecuteButton"
        Me.ExecuteButton.Size = New System.Drawing.Size(111, 45)
        Me.ExecuteButton.TabIndex = 22
        Me.ExecuteButton.Text = "Launch Server"
        Me.ExecuteButton.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(9, 132)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(125, 196)
        Me.ListBox3.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox3.Location = New System.Drawing.Point(140, 132)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(345, 145)
        Me.TextBox3.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Please Select Computer IP Below"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please Type Below your full destination folder"
        '
        'outputfolder
        '
        Me.outputfolder.Location = New System.Drawing.Point(9, 52)
        Me.outputfolder.Multiline = True
        Me.outputfolder.Name = "outputfolder"
        Me.outputfolder.Size = New System.Drawing.Size(476, 51)
        Me.outputfolder.TabIndex = 2
        Me.outputfolder.Text = "D:\Nintendo Switch Album Backup"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(410, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(521, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 44)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "SysScreenUploader"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(670, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Original Idea by Bakatrouble"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(783, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "GUI by Soaresden"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.lineedited)
        Me.GroupBox2.Controls.Add(Me.ConfigFilePath)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(509, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(393, 356)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editing the ConfigFile"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(377, 17)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Change the drive letter to your config file and hit ""Replace"""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(263, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "If you want to replace it by this tool"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 45)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Replace URL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Edit to :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "The Line to edit"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 75)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(381, 25)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = """url = "" ..."
        '
        'lineedited
        '
        Me.lineedited.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lineedited.Location = New System.Drawing.Point(6, 123)
        Me.lineedited.Multiline = True
        Me.lineedited.Name = "lineedited"
        Me.lineedited.ReadOnly = True
        Me.lineedited.Size = New System.Drawing.Size(381, 26)
        Me.lineedited.TabIndex = 8
        '
        'ConfigFilePath
        '
        Me.ConfigFilePath.Location = New System.Drawing.Point(6, 237)
        Me.ConfigFilePath.Multiline = True
        Me.ConfigFilePath.Name = "ConfigFilePath"
        Me.ConfigFilePath.Size = New System.Drawing.Size(381, 25)
        Me.ConfigFilePath.TabIndex = 7
        Me.ConfigFilePath.Text = "X:\config\sys-screenuploader\config.ini"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(325, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Don't forget to edit your config file in your SD Card" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(922, 497)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Launching Server"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents outputfolder As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ExecuteButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lineedited As TextBox
    Friend WithEvents ConfigFilePath As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
