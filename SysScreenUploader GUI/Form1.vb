Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Prevent Resizing
        'Set fixed border
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D

        'Disable the minimize box And the maximize box
        Me.MaximizeBox = False

        'Updating IP adresses
        Call IpSearch()

        'Hide the CMD button
        ExecuteButton.Visible = False
        TextBox3.Visible = False
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub CMDForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True

            NotifyIcon1.Icon = My.Resources.icon
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "SysScreenUploader Server"
            NotifyIcon1.BalloonTipText = "Continue Running in TrayIcon"
            NotifyIcon1.ShowBalloonTip(30000)

            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Forcing Exit Server on close

        Dim myProcesses() As Process
        Dim myProcess As Process
        ' Returns array containing all instances of "python".

        myProcesses = Process.GetProcessesByName("py")
        For Each myProcess In myProcesses
            myProcess.CloseMainWindow()
        Next
    End Sub

    Private Sub IpSearch()
        Me.ListBox3.Items.Clear()
        Me.ListBox3.Items.Add(getip(ListBox3))
    End Sub

    Public Function getip(ByVal lst As ListBox) As ListBox
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim hostEntry = System.Net.Dns.GetHostEntry(strHostName)
        Dim addressList As New List(Of System.Net.IPAddress)

        For Each address In hostEntry.AddressList
            If address.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                lst.Items.Add(address)
            End If
        Next
        Return lst

    End Function

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        'Visible Textbox
        TextBox3.Visible = True

        Dim outputdirectory As String = outputfolder.Text
        Dim actualip As String = ListBox3.Text

        Dim actualpath As String = Application.StartupPath & "\"
        Dim finalphrase = Chr(34) & actualpath & "local_dir.py" & Chr(34)
        Dim fin = " -h " & actualip & " -o " & Chr(34) & outputdirectory & Chr(34)

        'Showing the command
        TextBox3.Text = finalphrase & fin

        'Editing line edited textbox
        lineedited.Text = "url = http://" & actualip & ":8080/"

        'Make CMD visible
        ExecuteButton.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExecuteButton.Click
        Dim beginadress = Chr(34) & Application.StartupPath & "\local_dir.py" & Chr(34)
        Dim finalarguments As String = " -h " & ListBox3.Text & " -o " & Chr(34) & outputfolder.Text & Chr(34)
        Dim commandfull = beginadress & finalarguments

        Process.Start(beginadress, finalarguments)

    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jumbofile As String = ConfigFilePath.Text
        Dim newline As String = lineedited.Text

        If System.IO.File.Exists(jumbofile) Then
            Dim lines() As String = IO.File.ReadAllLines(jumbofile)
            For i As Integer = 0 To lines.Length - 1
                If lines(i).Contains("url") Then
                    lines(i) = newline
                End If
            Next
            IO.File.WriteAllLines(jumbofile, lines) 'assuming you want to write the file
            MsgBox("File Edited Successfully")
        Else
            MsgBox("File Was not Found")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            outputfolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

End Class