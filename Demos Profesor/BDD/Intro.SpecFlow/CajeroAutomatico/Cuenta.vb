Public Class Cuenta

    Private saldo As Integer

    Public Sub SetSaldoInicial(monto As Integer)
        saldo = monto
    End Sub

    Public Function GetSaldo() As Integer
        Return saldo
    End Function

    Public Sub HacerRetiro(monto As Integer)
        If saldo >= monto Then
            saldo = saldo - monto
        End If
    End Sub

End Class
