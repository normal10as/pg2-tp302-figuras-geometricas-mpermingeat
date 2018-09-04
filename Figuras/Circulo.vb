Public Class Circulo
    Inherits Figuras

    Private _radio As UShort


    Sub New(nombre, base, altura)
        Me.Nombre = nombre
        Me.Radio = 0

    End Sub

    Public Property Radio() As UShort
        Get
            Return _radio
        End Get
        Set(ByVal value As UShort)
            _radio = value
        End Set
    End Property

    Public Overrides Function CalcularArea() As Single
        Return Math.PI * _radio ^ 2
    End Function
End Class
