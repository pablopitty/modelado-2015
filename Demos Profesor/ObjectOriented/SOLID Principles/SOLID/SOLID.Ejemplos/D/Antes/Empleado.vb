Namespace D.Antes

    Public Class Empleado

        Private eventos As INotificador

        Function CalculePlanilla(manejaExcepciones As Integer, salarioMensual As Double, diasLaborados As Integer) As Double
            Dim resultado As Double = 0

            Try
                resultado = salarioMensual * diasLaborados / 30

            Catch ex As Exception

                ' Viola SRP al tener que decidir como manejar excepciones
                ' Use DI para invertir la responsabilidad

                If manejaExcepciones = 1 Then
                    eventos = New Bitacora
                ElseIf manejaExcepciones = 2 Then
                    eventos = New BitacoraBaseDeDatos
                Else
                    eventos = New NotificadorEmail
                End If

                eventos.Registrar("No se pudo calcular el salario del empleado. El error fue " + ex.ToString)

            End Try

            Return resultado

        End Function

    End Class

End Namespace
