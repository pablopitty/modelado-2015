Namespace OC.Antes

    Public Class Empleado
        ' Nuevo: tipo de empleado
        Public Property Tipo As Integer

        Private eventos As New Bitacora

        Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double
            Dim resultado As Double = 0

            Try
                Dim salarioBase = salarioMensual * diasLaborados / 30

                If Tipo = 1 Then
                    resultado += salarioBase * 0.1
                ElseIf Tipo = 2 Then
                    resultado += salarioBase * 0.2
                Else
                    resultado = salarioBase
                End If

            Catch ex As Exception
                ' Extraemos la responsabilidad a otra clase
                eventos.Registrar("No se pudo calcular el salario del empleado. El error fue " + ex.ToString)
            End Try

            Return resultado

        End Function

    End Class

End Namespace
