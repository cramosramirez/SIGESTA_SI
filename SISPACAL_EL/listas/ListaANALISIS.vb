''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaANALISIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ANALISIS',
''' es una representación en memoria de los registros de la tabla ANALISIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaANALISIS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaANALISIS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ANALISIS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ANALISIS
        Get
            Return CType((List(index)), ANALISIS)
        End Get
        Set(ByVal Value As ANALISIS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ANALISIS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ANALISIS = CType(List(i), ANALISIS)
            If s.ID_ANALISIS = value.ID_ANALISIS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ANALISIS As Int32) As ANALISIS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ANALISIS = CType(List(i), ANALISIS)
            If s.ID_ANALISIS = ID_ANALISIS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ANALISISEnumerator
        Return New ANALISISEnumerator(Me)
    End Function

    Public Class ANALISISEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaANALISIS)
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
