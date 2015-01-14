Public Class Bitacora
    Public Sub Registrar(evento As String)
        EventLog.WriteEntry("Application", evento)
    End Sub
End Class
