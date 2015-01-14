Namespace D.Despues
    Public Class Bitacora
        Implements INotificador

        Public Sub Registrar(evento As String) Implements INotificador.Registrar
            EventLog.WriteEntry("Application", evento)

        End Sub
    End Class
End Namespace
