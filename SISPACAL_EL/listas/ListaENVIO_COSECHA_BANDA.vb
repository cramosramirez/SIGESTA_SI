''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaENVIO_COSECHA_BANDA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ENVIO_COSECHA_BANDA',
''' es una representación en memoria de los registros de la tabla ENVIO_COSECHA_BANDA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/11/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaENVIO_COSECHA_BANDA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaENVIO_COSECHA_BANDA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ENVIO_COSECHA_BANDA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ENVIO_COSECHA_BANDA
        Get
            Return CType((List(index)), ENVIO_COSECHA_BANDA)
        End Get
        Set(ByVal Value As ENVIO_COSECHA_BANDA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ENVIO_COSECHA_BANDA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_COSECHA_BANDA = CType(List(i), ENVIO_COSECHA_BANDA)
            If s.ID_ENVIO_BANDA = value.ID_ENVIO_BANDA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ENVIO_BANDA As Int32) As ENVIO_COSECHA_BANDA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ENVIO_COSECHA_BANDA = CType(List(i), ENVIO_COSECHA_BANDA)
            If s.ID_ENVIO_BANDA = ID_ENVIO_BANDA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ENVIO_COSECHA_BANDAEnumerator
        Return New ENVIO_COSECHA_BANDAEnumerator(Me)
    End Function

    Public Class ENVIO_COSECHA_BANDAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaENVIO_COSECHA_BANDA)
            Me.Local = Mappings
            Me.Base = Local.GetEnumerator()
        End Sub

        ReadOnly Property Current() As Object Implements IEnumerator.Current
            Get
                Return Base.Current
            End Get
        End Property

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            Return Base.MoveNext()
        End Function

        Sub Reset() Implements IEnumerator.Reset
            Base.Reset()
        End Sub
    End Class
End Class
