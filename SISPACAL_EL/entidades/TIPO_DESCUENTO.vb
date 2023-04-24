''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.TIPO_DESCUENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row TIPO_DESCUENTO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="TIPO_DESCUENTO")> Public Class TIPO_DESCUENTO
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_TIPO_DESCTO As Int32, aNOMBRE_TIPO_DESCTO As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aID_GRUPO_DESC As Int32)
        Me._ID_TIPO_DESCTO = aID_TIPO_DESCTO
        Me._NOMBRE_TIPO_DESCTO = aNOMBRE_TIPO_DESCTO
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ID_GRUPO_DESC = aID_GRUPO_DESC
    End Sub

#Region " Properties "

    Private _ID_TIPO_DESCTO As Int32
    <Column(Name:="Id tipo descto", Storage:="ID_TIPO_DESCTO", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_DESCTO() As Int32
        Get
            Return _ID_TIPO_DESCTO
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_DESCTO = Value
            OnPropertyChanged("ID_TIPO_DESCTO")
        End Set
    End Property 

    Private _NOMBRE_TIPO_DESCTO As String
    <Column(Name:="Nombre tipo descto", Storage:="NOMBRE_TIPO_DESCTO", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_TIPO_DESCTO() As String
        Get
            Return _NOMBRE_TIPO_DESCTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_DESCTO = Value
            OnPropertyChanged("NOMBRE_TIPO_DESCTO")
        End Set
    End Property 

    Private _NOMBRE_TIPO_DESCTOOld As String
    Public Property NOMBRE_TIPO_DESCTOOld() As String
        Get
            Return _NOMBRE_TIPO_DESCTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_TIPO_DESCTOOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREA As DateTime
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property 

    Private _FECHA_CREAOld As DateTime
    Public Property FECHA_CREAOld() As DateTime
        Get
            Return _FECHA_CREAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREAOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property 

    Private _ID_GRUPO_DESC As Int32
    <Column(Name:="Id grupo desc", Storage:="ID_GRUPO_DESC", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_GRUPO_DESC() As Int32
        Get
            Return _ID_GRUPO_DESC
        End Get
        Set(ByVal Value As Int32)
            _ID_GRUPO_DESC = Value
            OnPropertyChanged("ID_GRUPO_DESC")
        End Set
    End Property 

    Private _ID_GRUPO_DESCOld As Int32
    Public Property ID_GRUPO_DESCOld() As Int32
        Get
            Return _ID_GRUPO_DESCOld
        End Get
        Set(ByVal Value As Int32)
            _ID_GRUPO_DESCOld = Value
        End Set
    End Property 

    Private _fkID_GRUPO_DESC As GRUPO_DESCUENTOS
    Public Property fkID_GRUPO_DESC() As GRUPO_DESCUENTOS
        Get
            Return _fkID_GRUPO_DESC
        End Get
        Set(ByVal Value As GRUPO_DESCUENTOS)
            _fkID_GRUPO_DESC = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
