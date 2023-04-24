''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PLANILLA',
''' es una representación en memoria de los registros de la tabla PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/12/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPLANILLA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPLANILLA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PLANILLA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PLANILLA
        Get
            Return CType((List(index)), PLANILLA)
        End Get
        Set(ByVal Value As PLANILLA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PLANILLA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANILLA = CType(List(i), PLANILLA)
            If s.ID_CATORCENA = value.ID_CATORCENA _
            And s.CODIPROVEEDOR_TRANSPORTISTA = value.CODIPROVEEDOR_TRANSPORTISTA _
            And s.ID_TIPO_PLANILLA = value.ID_TIPO_PLANILLA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32) As PLANILLA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PLANILLA = CType(List(i), PLANILLA)
            If s.ID_CATORCENA = ID_CATORCENA _
            And s.CODIPROVEEDOR_TRANSPORTISTA = CODIPROVEEDOR_TRANSPORTISTA _
            And s.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PLANILLAEnumerator
        Return New PLANILLAEnumerator(Me)
    End Function

    Public Class PLANILLAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPLANILLA)
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
