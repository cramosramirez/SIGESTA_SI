''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaREMESA_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'REMESA_ENCA_TRANS',
''' es una representación en memoria de los registros de la tabla REMESA_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/01/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaREMESA_ENCA_TRANS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaREMESA_ENCA_TRANS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As REMESA_ENCA_TRANS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As REMESA_ENCA_TRANS
        Get
            Return CType((List(index)), REMESA_ENCA_TRANS)
        End Get
        Set(ByVal Value As REMESA_ENCA_TRANS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As REMESA_ENCA_TRANS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REMESA_ENCA_TRANS = CType(List(i), REMESA_ENCA_TRANS)
            If s.ID_REMESA_ENCA = value.ID_REMESA_ENCA Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_REMESA_ENCA As Int32) As REMESA_ENCA_TRANS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As REMESA_ENCA_TRANS = CType(List(i), REMESA_ENCA_TRANS)
            If s.ID_REMESA_ENCA = ID_REMESA_ENCA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As REMESA_ENCA_TRANSEnumerator
        Return New REMESA_ENCA_TRANSEnumerator(Me)
    End Function

    Public Class REMESA_ENCA_TRANSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaREMESA_ENCA_TRANS)
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
