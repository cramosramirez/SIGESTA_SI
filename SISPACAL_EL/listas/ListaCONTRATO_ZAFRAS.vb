''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCONTRATO_ZAFRAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_ZAFRAS',
''' es una representación en memoria de los registros de la tabla CONTRATO_ZAFRAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/07/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_ZAFRAS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCONTRATO_ZAFRAS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CONTRATO_ZAFRAS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CONTRATO_ZAFRAS
        Get
            Return CType((List(index)), CONTRATO_ZAFRAS)
        End Get
        Set(ByVal Value As CONTRATO_ZAFRAS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CONTRATO_ZAFRAS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_ZAFRAS = CType(List(i), CONTRATO_ZAFRAS)
            If s.ID_CONTRATO_ZAFRAS = value.ID_CONTRATO_ZAFRAS Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CONTRATO_ZAFRAS As Int32) As CONTRATO_ZAFRAS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CONTRATO_ZAFRAS = CType(List(i), CONTRATO_ZAFRAS)
            If s.ID_CONTRATO_ZAFRAS = ID_CONTRATO_ZAFRAS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CONTRATO_ZAFRASEnumerator
        Return New CONTRATO_ZAFRASEnumerator(Me)
    End Function

    Public Class CONTRATO_ZAFRASEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCONTRATO_ZAFRAS)
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
