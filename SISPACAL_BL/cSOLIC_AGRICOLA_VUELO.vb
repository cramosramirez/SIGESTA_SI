''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSOLIC_AGRICOLA_VUELO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLIC_AGRICOLA_VUELO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLIC_AGRICOLA_VUELO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLIC_AGRICOLA_VUELO()
    Private mEntidad as New SOLIC_AGRICOLA_VUELO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA_VUELO
        Try
            Dim mListaSOLIC_AGRICOLA_VUELO As New ListaSOLIC_AGRICOLA_VUELO
            mListaSOLIC_AGRICOLA_VUELO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA_VUELO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA_VUELO in  mListaSOLIC_AGRICOLA_VUELO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA_VUELO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLIC_AGRICOLA_VUELO(ByRef aEntidad As SOLIC_AGRICOLA_VUELO, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
                End Try
            End If
            Return liRet
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLIC_AGRICOLA_VUELO.
    ''' </summary>
    ''' <param name="ID_SOLIC_AGRI_VUELO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLIC_AGRICOLA_VUELO(ByVal ID_SOLIC_AGRI_VUELO As Int32, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_AGRICOLA_VUELO
        Try
            Dim lEntidad As New SOLIC_AGRICOLA_VUELO
            lEntidad.ID_SOLIC_AGRI_VUELO = ID_SOLIC_AGRI_VUELO
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="aSOLIC_AGRICOLA">Recuperar registro foraneo de la Entidad SOLIC_AGRICOLA.</param>
    ''' <param name="aPROVEEDOR_AGRICOLA">Recuperar registro foraneo de la Entidad PROVEEDOR_AGRICOLA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLIC_AGRICOLA_VUELOConForaneas(ByVal aEntidad As SOLIC_AGRICOLA_VUELO, Optional ByVal aSOLIC_AGRICOLA As Boolean = False, Optional ByVal aPROVEEDOR_AGRICOLA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aSOLIC_AGRICOLA, aPROVEEDOR_AGRICOLA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_AGRICOLA_VUELO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLIC_AGRI_VUELO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_AGRICOLA_VUELO(ByVal ID_SOLIC_AGRI_VUELO As Int32) As Integer
        Try
            mEntidad.ID_SOLIC_AGRI_VUELO = ID_SOLIC_AGRI_VUELO
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_AGRICOLA_VUELO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_AGRICOLA_VUELO(ByVal aEntidad As SOLIC_AGRICOLA_VUELO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLIC_AGRICOLA_VUELO(ByVal ID_SOLIC_AGRI_VUELO As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_PROVEE As Int32, ByVal MEDIO_APLICA As String, ByVal DESCRIP_AERONAVE As String, ByVal NOMBRE_PILOTO As String, ByVal PRECIO_UNIT_VUELO As Decimal, ByVal MZ_HORAS_VUELO As Decimal, ByVal CARGO_VUELO As Decimal, ByVal PRECIO_TOTAL_VUELO As Decimal, ByVal PRECIO_UNIT_AGUA As Decimal, ByVal MZ_REGAR_AGUA As Decimal, ByVal PRECIO_TOTAL_AGUA As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal UID_SOLIC_AGRI_VUELO As Guid) As Integer
        Try
            Dim lEntidad As New SOLIC_AGRICOLA_VUELO
            lEntidad.ID_SOLIC_AGRI_VUELO = ID_SOLIC_AGRI_VUELO
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.MEDIO_APLICA = MEDIO_APLICA
            lEntidad.DESCRIP_AERONAVE = DESCRIP_AERONAVE
            lEntidad.NOMBRE_PILOTO = NOMBRE_PILOTO
            lEntidad.PRECIO_UNIT_VUELO = PRECIO_UNIT_VUELO
            lEntidad.MZ_HORAS_VUELO = MZ_HORAS_VUELO
            lEntidad.CARGO_VUELO = CARGO_VUELO
            lEntidad.PRECIO_TOTAL_VUELO = PRECIO_TOTAL_VUELO
            lEntidad.PRECIO_UNIT_AGUA = PRECIO_UNIT_AGUA
            lEntidad.MZ_REGAR_AGUA = MZ_REGAR_AGUA
            lEntidad.PRECIO_TOTAL_AGUA = PRECIO_TOTAL_AGUA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.UID_SOLIC_AGRI_VUELO = UID_SOLIC_AGRI_VUELO
            Return Me.ActualizarSOLIC_AGRICOLA_VUELO(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_AGRICOLA_VUELO(ByVal ID_SOLIC_AGRI_VUELO As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_PROVEE As Int32, ByVal MEDIO_APLICA As String, ByVal DESCRIP_AERONAVE As String, ByVal NOMBRE_PILOTO As String, ByVal PRECIO_UNIT_VUELO As Decimal, ByVal MZ_HORAS_VUELO As Decimal, ByVal CARGO_VUELO As Decimal, ByVal PRECIO_TOTAL_VUELO As Decimal, ByVal PRECIO_UNIT_AGUA As Decimal, ByVal MZ_REGAR_AGUA As Decimal, ByVal PRECIO_TOTAL_AGUA As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal UID_SOLIC_AGRI_VUELO As Guid) As Integer
        Try
            Dim lEntidad As New SOLIC_AGRICOLA_VUELO
            lEntidad.ID_SOLIC_AGRI_VUELO = ID_SOLIC_AGRI_VUELO
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.MEDIO_APLICA = MEDIO_APLICA
            lEntidad.DESCRIP_AERONAVE = DESCRIP_AERONAVE
            lEntidad.NOMBRE_PILOTO = NOMBRE_PILOTO
            lEntidad.PRECIO_UNIT_VUELO = PRECIO_UNIT_VUELO
            lEntidad.MZ_HORAS_VUELO = MZ_HORAS_VUELO
            lEntidad.CARGO_VUELO = CARGO_VUELO
            lEntidad.PRECIO_TOTAL_VUELO = PRECIO_TOTAL_VUELO
            lEntidad.PRECIO_UNIT_AGUA = PRECIO_UNIT_AGUA
            lEntidad.MZ_REGAR_AGUA = MZ_REGAR_AGUA
            lEntidad.PRECIO_TOTAL_AGUA = PRECIO_TOTAL_AGUA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.UID_SOLIC_AGRI_VUELO = UID_SOLIC_AGRI_VUELO
            Return Me.ActualizarSOLIC_AGRICOLA_VUELO(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ds, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLIC_AGRICOLA .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA_VUELO
        Try
            Dim mListaSOLIC_AGRICOLA_VUELO As New ListaSOLIC_AGRICOLA_VUELO
            mListaSOLIC_AGRICOLA_VUELO = mDb.ObtenerListaPorSOLIC_AGRICOLA(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA_VUELO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA_VUELO in  mListaSOLIC_AGRICOLA_VUELO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA_VUELO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR_AGRICOLA .
    ''' </summary>
    ''' <param name="ID_PROVEE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AGRICOLA(ByVal ID_PROVEE As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA_VUELO
        Try
            Dim mListaSOLIC_AGRICOLA_VUELO As New ListaSOLIC_AGRICOLA_VUELO
            mListaSOLIC_AGRICOLA_VUELO = mDb.ObtenerListaPorPROVEEDOR_AGRICOLA(ID_PROVEE, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA_VUELO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA_VUELO in  mListaSOLIC_AGRICOLA_VUELO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA_VUELO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de la Tabla Foranea en la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLIC_AGRICOLA_VUELO )
        aEntidad.fkID_SOLICITUD = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
        aEntidad.fkID_PROVEE = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(aEntidad.ID_PROVEE)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLIC_AGRICOLA_VUELO )
    End Sub

#End Region

End Class
