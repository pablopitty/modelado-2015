Public Class User
    Public Property Nombre As String
    Public Property FechaDeIngreso As Date
    Public Property CantidadDeRecomendaciones As Integer
    Public Property Clave As String

    Public Function PuedeIniciarSesion(clave As String) As Boolean
        Return String.Equals(clave, Me.Clave)
    End Function

End Class
