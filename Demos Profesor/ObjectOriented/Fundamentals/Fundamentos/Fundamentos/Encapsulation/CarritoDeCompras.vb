''' <summary>
''' Una compra de productos sin envio
''' </summary>
''' <remarks></remarks>
Class CarritoDeCompras

    ' Encapsulation means hiding the code and data into a single unit to protect 
    ' the data from the outside world.

    Private productos As IList(Of Producto)

    Sub AgregarProducto(p As Producto)
        ' logica
    End Sub

    Sub CambiarCantidadDeProducto(p As Producto, nuevaCantidad As Integer)
        ' logica
    End Sub

    Sub EliminarProducto(p As Producto)
        ' logica
    End Sub

    Sub AplicarDescuento(d As Descuento)
        ' logica

    End Sub

    Sub AplicarImpuestos(i As List(Of Impuesto))
        ' logica

    End Sub

    Function AplicarCompra() As ConfirmacionDeCompra
        ' logica

    End Function

End Class
