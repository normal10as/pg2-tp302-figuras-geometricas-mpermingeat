Public Class Figuras
    Private _nombre As String


    Public Sub New()
        Me.Nombre = ""


    End Sub
    '////////// Properties /////////////////////
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    '/////////////Metodos////////////////////
    Public Overridable Function CalcularArea() As Single


    End Function
End Class
