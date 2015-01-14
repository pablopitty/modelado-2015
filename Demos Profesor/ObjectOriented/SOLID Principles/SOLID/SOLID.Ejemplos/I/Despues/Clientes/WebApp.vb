Namespace I.Despues

    Public Class WebApp

        Public Sub Acciones()
            Dim empl As IEmpleadoRegularConBonificaciones = New EmpleadoConBonificaciones

            ' Necesito calcular bonificaciones!
            empl.CalculeBonificaciones()

        End Sub

    End Class

End Namespace
