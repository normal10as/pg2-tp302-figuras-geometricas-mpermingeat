Public Class Cuadrado
    Inherits Figuras

    Private _lado As UShort


    Sub New(nombre As String, lado As UShort)
        MyBase.New(nombre)
        Me.Lado = lado

    End Sub

    Public Property Lado() As UShort
        Get
            Return _lado
        End Get
        Set(ByVal value As UShort)
            _lado = value
        End Set
    End Property

    Public Overrides Function CalcularArea() As Single

        Return _lado * _lado
    End Function
End Class
