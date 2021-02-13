Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SDBackup.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RecoverToSD.Show()
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

            NotifyIcon1.Icon = My.Resources.Menu
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "SysScreenUploader Menu"
            NotifyIcon1.BalloonTipText = "Menu Running in TrayIcon"
            NotifyIcon1.ShowBalloonTip(30000)

            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prevent Resizing
        'Set fixed border
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D

        'Disable the minimize box And the maximize box
        Me.MaximizeBox = False
    End Sub


End Class