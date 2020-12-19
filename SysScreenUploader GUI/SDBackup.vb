Imports System
Imports System.ComponentModel
Imports System.IO

Public Class SDBackup
    Sub ImportAllFiles()
        'Erase listboxes
        ListBox1.Items.Clear()
        'Looping through all files
        Dim i As Integer = 0
        Dim directory = AlbumFolder.Text

        'Test if Album directory exists
        If Not System.IO.Directory.Exists(AlbumFolder.Text & "\Album") Then
            MsgBox("There is no Album Folder in this folder")
            Exit Sub
        End If


        'Searches directory and it's subdirectories for all files, with *
        For Each filename As String In IO.Directory.GetFiles(directory, "*", IO.SearchOption.AllDirectories)
            'The next line of code gets only file extensions from searched directories and subdirectories
            Dim fName As String = IO.Path.GetExtension(filename)
            Dim fullpathfile As String = IO.Path.GetFullPath(filename)
            ListBox1.Items.Add(fullpathfile)
        Next

        'call datagridmaker
        Call drawgamedatagrid()

        'Visible Options and text
        CreateGameFolder.Visible = True
        Label6.Visible = True
        Button4.Visible = True
    End Sub


    Private Function GetFileName_OtherMethod(ByVal path As String) As String
        Dim _filename As String = ""
        Dim sep() As Char = {"/", "\", "//"}
        _filename = path.Split(sep).Last()
        Return _filename
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            AlbumFolder.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If

        Call ImportAllFiles()
    End Sub
    Sub drawgamedatagrid()
        'Adding Gameid to DatagridView
        Dim table As New DataTable()
        Dim dv As DataView

        Dim column As DataColumn

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "GameId"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Title"
        End With
        table.Columns.Add(column)

        'Loop for every lines in Gameid file
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader("a-gameids.txt")
        Dim line As String
        Dim gameid As String
        Dim title As String

        Do
            line = reader.ReadLine
            If line = Nothing Then GoTo jump
            gameid = line.Substring(0, Len("5F4DC26DD28F56B124850799FF65339B"))
            title = line.Substring(Len("5F4DC26DD28F56B124850799FF65339B") + 1)
            'adding to temp table
            table.Rows.Add(gameid, title)
        Loop Until line Is Nothing
jump:
        reader.Close()

        'Sorting A-Z the console
        dv = table.DefaultView
        dv.Sort = "Title asc"
        GameIdGrid.DataSource = table

        'Width for columns
        GameIdGrid.Columns("GameId").Width = 50
        GameIdGrid.Columns("Title").Width = 130
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim chemindufichier As String = ListBox1.SelectedItem
        PreviewJPG.SizeMode = PictureBoxSizeMode.Zoom

        'Preview
        If Path.GetExtension(chemindufichier) = ".mp4" Then
            PreviewJPG.Hide()
            PreviewMP4.Show()
            PreviewMP4.URL = chemindufichier
            PreviewMP4.Ctlcontrols.play()
        Else
            PreviewMP4.Ctlcontrols.stop()
            PreviewJPG.Show()
            PreviewMP4.Hide()
            PreviewJPG.Image = Image.FromFile(chemindufichier)
        End If

        'Checking Name
        Dim gameid As String = Path.GetFileName(Path.GetDirectoryName(chemindufichier))

        'loop through datagrid
        For row = 0 To GameIdGrid.Rows.Count - 2
            Dim valeurdecellule = GameIdGrid.Rows(row).Cells(0).Value.ToString

            If valeurdecellule = gameid Then
                GameTitle.Text = GameIdGrid.Rows(row).Cells(1).Value
                GameIdGrid.CurrentCell = GameIdGrid.Rows(row).Cells(1)
                Exit Sub
            End If
        Next
    End Sub

    Sub verifytitleid()
        For i = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndex = i
            Dim chemindufichier As String = ListBox1.Items(i)
            'Checking Name
            Dim gameid As String = Path.GetFileName(Path.GetDirectoryName(chemindufichier))

            'loop through datagrid
            For row = 0 To GameIdGrid.Rows.Count - 2
                Dim valeurdecellule = GameIdGrid.Rows(row).Cells(0).Value.ToString

                If valeurdecellule = gameid Then
                    'there is a gameid so we are ok go to next cell
                    GoTo nextcell
                End If
            Next

            'Preview
            If Path.GetExtension(chemindufichier) = ".mp4" Then
                PreviewJPG.Hide()
                PreviewMP4.Show()
                PreviewMP4.URL = chemindufichier
                PreviewMP4.Ctlcontrols.play()
            Else
                PreviewMP4.Ctlcontrols.stop()
                PreviewJPG.Show()
                PreviewMP4.Hide()
                PreviewJPG.Image = Image.FromFile(chemindufichier)
            End If

            'Then there is no entries : ask for gamename
            Clipboard.SetText(Path.GetFileName(Path.GetDirectoryName(chemindufichier)))
            Dim usergamename As String = InputBox(Path.GetFileName(Path.GetDirectoryName(chemindufichier)), "Checking GameID : What is this Game Name ? " & Chr(13) & "In the clipboard, Google It if you want")

            If usergamename = Nothing Then Exit Sub

            My.Computer.FileSystem.WriteAllText("a-gameids.txt", vbNewLine & gameid & vbTab & usergamename, True)
            Call drawgamedatagrid()
nextcell:
        Next

    End Sub
    Private Sub PreviewJPG_Click(sender As Object, e As EventArgs) Handles PreviewJPG.Click
        Dim photolink As String = ListBox1.Text
        Process.Start(photolink)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Path.GetExtension(ListBox1.SelectedItem) <> ".mp4" Then Exit Sub
        Dim videolink As String = ListBox1.Text

        PreviewMP4.URL = videolink
        PreviewMP4.settings.autoStart = True

    End Sub

    Private Sub SDBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prevent Resizing
        'Set fixed border
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        PreviewMP4.URL = ("")
        'Disable the minimize box And the maximize box
        Me.MaximizeBox = False
    End Sub
    Private Sub AlbumFolder_KeyDown(sender As Object, e As KeyEventArgs) Handles AlbumFolder.KeyDown
        If e.KeyValue = Keys.Enter Then
            Call ImportAllFiles()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call verifytitleid()

        For i = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndex = i
            Dim tempfilename As String = Path.GetFileName(ListBox1.Items(i))
            Dim DateOfFile As String = tempfilename.Substring(0, 8)
            Dim HourOfFile As String = tempfilename.Substring(8, 6)
            Dim positionofid As Integer = tempfilename.IndexOf("-")
            Dim tgameid As String = tempfilename.Substring(positionofid + 1)
            Dim gameid As String = tempfilename.Substring(positionofid + 1, Len(tgameid) - 4)
            Dim FileToCopy As String = ListBox1.Items(i)
            Dim destinationtocopy As String


            If CreateGameFolder.Checked = True And UseGameTitle.Checked = True Then
                destinationtocopy = DestinationPath.Text & "\" & GameTitle.Text & "\" & tempfilename
            ElseIf CreateGameFolder.Checked = True And UseGameTitle.Checked = False Then
                destinationtocopy = DestinationPath.Text & "\" & gameid & "\" & tempfilename
            ElseIf CreateGameFolder.Checked = False And UseGameTitle.Checked = True Then
                destinationtocopy = DestinationPath.Text & tempfilename
            ElseIf CreateGameFolder.Checked = False And UseGameTitle.Checked = False Then
                destinationtocopy = DestinationPath.Text & tempfilename
            End If

            'Test if Directory Don't exist, create the GameID Folder
            If Not Directory.Exists(Path.GetDirectoryName(destinationtocopy)) Then
                Directory.CreateDirectory(Path.GetDirectoryName(destinationtocopy))
            End If

            'If File don't exist, copy it
            If System.IO.File.Exists(destinationtocopy) = False Then
                System.IO.File.Copy(FileToCopy, destinationtocopy)
            End If

        Next
        MsgBox("Backup Finished")
        Process.Start(DestinationPath.Text)
    End Sub
End Class

