Public Class Class1
    Implements IDisposable

    Public Event OutputRead(ByVal output As String)

    Private WithEvents _process As Process

    Public Sub Execute(ByVal filePath As String, ByVal arguments As String)
        If _process IsNot Nothing Then
            Throw New Exception("Already watching process")
        End If
        _process = New Process()
        _process.StartInfo.FileName = filePath
        _process.StartInfo.UseShellExecute = False
        _process.StartInfo.RedirectStandardInput = True
        _process.StartInfo.RedirectStandardOutput = True
        _process.Start()
        _process.BeginOutputReadLine()
    End Sub

    Private Sub _process_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles _process.OutputDataReceived
        If _process.HasExited Then
            _process.Dispose()
            _process = Nothing
        End If
        RaiseEvent OutputRead(e.Data)
    End Sub

    Private disposedValue As Boolean = False
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If _process IsNot Nothing Then
                    _process.Kill()
                    _process.Dispose()
                    _process = Nothing
                End If
            End If
        End If
        Me.disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
