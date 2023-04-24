''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaLABFAB_INFOVAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LABFAB_INFOVAR',
''' es una representación en memoria de los registros de la tabla LABFAB_INFOVAR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLABFAB_INFOVAR
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaLABFAB_INFOVAR )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As LABFAB_INFOVAR)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As LABFAB_INFOVAR
        Get
            Return CType((List(index)), LABFAB_INFOVAR)
        End Get
        Set(ByVal Value As LABFAB_INFOVAR)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As LABFAB_INFOVAR) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_INFOVAR = CType(List(i), LABFAB_INFOVAR)
            If s.ID_INFOVAR = value.ID_INFOVAR Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_INFOVAR As Int32) As LABFAB_INFOVAR
        Dim i As Integer = 0
        While i < List.Count
            Dim s As LABFAB_INFOVAR = CType(List(i), LABFAB_INFOVAR)
            If s.ID_INFOVAR = ID_INFOVAR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As LABFAB_INFOVAREnumerator
        Return New LABFAB_INFOVAREnumerator(Me)
    End Function

    Public Class LABFAB_INFOVAREnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaLABFAB_INFOVAR)
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
