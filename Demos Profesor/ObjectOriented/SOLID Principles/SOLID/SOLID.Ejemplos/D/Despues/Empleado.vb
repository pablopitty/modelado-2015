Namespace D.Despues

    Public Class Empleado

        Private eventos As INotificador

        ' Ahora, es responsabilidad del cliente de la clase el indicar como se maneja los eventos
        ' asi, la clase Empleado se conncentra solamente en su responsabilidad
        Sub Empleado(manejaEventos As INotificador)
            eventos = manejaEventos
        End Sub

        Function CalculePlanilla(manejaExcepciones As Integer, salarioMensual As Double, diasLaborados As Integer) As Double
            Dim resultado As Double = 0

            Try
                resultado = salarioMensual * diasLaborados / 30

            Catch ex As Exception

                eventos.Registrar("No se pudo calcular el salario del empleado. El error fue " + ex.ToString)

            End Try

            Return resultado

        End Function

    End Class

End Namespace
