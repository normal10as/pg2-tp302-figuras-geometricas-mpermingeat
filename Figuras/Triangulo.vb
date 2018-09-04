Public Class Triangulo
    Inherits Figuras

    Private _base As UShort
    Private _altura As UShort

    Sub New(nombre, base, altura)
        Me.Nombre = nombre
        Me.Base = 0
        Me.Altura = 0
    End Sub

    Public Property Base() As UShort
        Get
            Return _base
        End Get
        Set(ByVal value As UShort)
            _base = value
        End Set
    End Property
    Public Property Altura() As UShort
        Get
            Return _altura
        End Get
        Set(ByVal value As UShort)
            _altura = value
        End Set
    End Property
    Public Overrides Function CalcularArea() As Single

        Return _base * _altura / 2
    End Function
End Class
