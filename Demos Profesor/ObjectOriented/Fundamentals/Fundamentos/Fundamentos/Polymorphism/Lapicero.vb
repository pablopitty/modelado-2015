
Class Lapicero
    Implements IInstrumento

    Private _p As Papel

    Sub New(p As Papel)
        ' TODO: Complete member initialization 
        _p = p
    End Sub

    Public Property Color As Color Implements IInstrumento.Color

    Public Sub DibujeLinea(centimetro As Centimetro) Implements IInstrumento.DibujeLinea

    End Sub

    Public Sub RoteDerecha(grados As Grados) Implements IInstrumento.RoteDerecha

    End Sub
End Class
