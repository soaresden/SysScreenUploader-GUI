Imports System
Imports System.IO
Public Class SDBackup
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        'Erase listboxes
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()


        'Looping through all files
        Dim i As Integer = 0
        Dim directory = AlbumFolder.Text

        'Searches directory and it's subdirectories for all files, with *
        For Each filename As String In IO.Directory.GetFiles(directory, "*", IO.SearchOption.AllDirectories)

            'The next line of code gets only file extensions from searched directories and subdirectories
            Dim fName As String = IO.Path.GetExtension(filename)
            Dim fullpathfile As String = IO.Path.GetFullPath(filename)

            If fName = ".jpg" Then
                ListBox1.Items.Add(fullpathfile)

            ElseIf fName = ".mp4" Then
                ListBox2.Items.Add(fullpathfile)

            Else

            End If
        Next


        'Visible Options and text
        CreateGameFolder.Visible = True
        Label6.Visible = True
        Button4.Visible = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer

        Dim str As String = ""
        Dim maxlist1 As Integer = ListBox1.Items.Count - 1
        Dim maxlist2 As Integer = ListBox2.Items.Count - 1

        For i = 0 To maxlist1
            ListBox1.SelectedIndex = i
            str = ListBox1.Text
            Dim tempfilename As String = GetFileName_OtherMethod(str)

            Dim numbercar As Integer = Len(tempfilename)
            Dim DateOfFile As String = tempfilename.Substring(0, 8)
            Dim HourOfFile As String = tempfilename.Substring(8, 6)
            Dim positionofid As Integer = tempfilename.IndexOf("-")
            Dim tempGameID As String = tempfilename.Substring(17)
            Dim GameID As String = tempGameID.Substring(0, Len(tempGameID) - 4)

            Dim FileToCopy As String = ListBox1.Text
            Dim BackupFile As String

            If CreateGameFolder.Checked = True Then

                'Test if Directory Don't exist, create the GameID Folder
                If Not Directory.Exists(DestinationPath.Text & "\" & GameID) Then
                    Directory.CreateDirectory(DestinationPath.Text & "\" & GameID)
                End If

                BackupFile = DestinationPath.Text & "\" & GameID & "\" & tempfilename

            Else
                BackupFile = DestinationPath.Text & "\" & tempfilename
            End If

            'If File don't exist, copy it
            If System.IO.File.Exists(BackupFile) = False Then
                System.IO.File.Copy(FileToCopy, BackupFile)
            End If

        Next

        For i = 0 To maxlist2
            ListBox2.SelectedIndex = i
            str = ListBox2.Text
            Dim tempfilename2 As String = GetFileName_OtherMethod(str)

            Dim numbercar2 As Integer = Len(tempfilename2)
            Dim DateOfFile2 As String = tempfilename2.Substring(0, 8)
            Dim HourOfFile2 As String = tempfilename2.Substring(8, 6)
            Dim positionofid2 As Integer = tempfilename2.IndexOf("-")
            Dim tempGameID2 As String = tempfilename2.Substring(17)
            Dim GameID2 As String = tempGameID2.Substring(0, Len(tempGameID2) - 4)

            Dim FileToCopy2 As String = ListBox2.Text
            Dim BackupFile2 As String

            If CreateGameFolder.Checked = True Then

                'Test if Directory Don't exist, create the GameID Folder
                If Not Directory.Exists(DestinationPath.Text & "\" & GameID2) Then
                    Directory.CreateDirectory(DestinationPath.Text & "\" & GameID2)
                End If

                BackupFile2 = DestinationPath.Text & "\" & GameID2 & "\" & tempfilename2

            Else
                BackupFile2 = DestinationPath.Text & "\" & tempfilename2
            End If

            'If File don't exist, copy it
            If System.IO.File.Exists(BackupFile2) = False Then
                System.IO.File.Copy(FileToCopy2, BackupFile2)
            End If

        Next

        MsgBox("Backup Finished")

        Process.Start(DestinationPath.Text)


    End Sub

    Private Function GetFileName_OtherMethod(ByVal path As String) As String
        Dim _filename As String = ""
        Dim sep() As Char = {"/", "\", "//"}
        _filename = path.Split(sep).Last()
        Return _filename
    End Function
End Class

