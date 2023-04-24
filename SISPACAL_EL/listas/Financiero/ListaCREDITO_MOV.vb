''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaCREDITO_MOV
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CREDITO_MOV',
''' es una representación en memoria de los registros de la tabla CREDITO_MOV
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCREDITO_MOV
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCREDITO_MOV )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CREDITO_MOV)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CREDITO_MOV
        Get
            Return CType((List(index)), CREDITO_MOV)
        End Get
        Set(ByVal Value As CREDITO_MOV)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CREDITO_MOV) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CREDITO_MOV = CType(List(i), CREDITO_MOV)
            If s.ID_CREDITO_MOV = value.ID_CREDITO_MOV Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CREDITO_MOV As Int32) As CREDITO_MOV
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CREDITO_MOV = CType(List(i), CREDITO_MOV)
            If s.ID_CREDITO_MOV = ID_CREDITO_MOV Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CREDITO_MOVEnumerator
        Return New CREDITO_MOVEnumerator(Me)
    End Function

    Public Class CREDITO_MOVEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCREDITO_MOV)
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
