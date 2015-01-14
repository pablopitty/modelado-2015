Public Class Principal
    ' Lapiz y Pincel actuan como de dos manejas diferentes sobre un papel aunque realizan las mismas acciones.

    Sub Ejecute()
        Dim p As New Papel

        Dim lapiz As IInstrumento = New Lapicero(p)
        lapiz.Color = New Color("rojo")
        lapiz.DibujeLinea(New Centimetro(3))
        lapiz.RoteDerecha(New Grados(90))
        lapiz.DibujeLinea(New Centimetro(3))

        Papel.Muestre()

        Dim pin As IInstrumento = New Pincel(p)
        lapiz.Color = New ColorTempera("rojo")
        lapiz.DibujeLinea(New Centimetro(3))
        lapiz.RoteDerecha(New Grados(90))
        lapiz.DibujeLinea(New Centimetro(3))

        Papel.Muestre()


    End Sub

End Class
