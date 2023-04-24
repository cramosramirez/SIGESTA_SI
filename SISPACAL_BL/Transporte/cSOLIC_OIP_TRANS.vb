''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSOLIC_OIP_TRANS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLIC_OIP_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLIC_OIP_TRANS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLIC_OIP_TRANS()
    Private mEntidad as New SOLIC_OIP_TRANS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_OIP_TRANS
        Try
            Dim mListaSOLIC_OIP_TRANS As New ListaSOLIC_OIP_TRANS
            mListaSOLIC_OIP_TRANS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_OIP_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_OIP_TRANS in  mListaSOLIC_OIP_TRANS
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_OIP_TRANS
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
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLIC_OIP_TRANS(ByRef aEntidad As SOLIC_OIP_TRANS, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLIC_OIP_TRANS.
    ''' </summary>
    ''' <param name="ID_OIP_TRANS"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLIC_OIP_TRANS(ByVal ID_OIP_TRANS As Int32, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_OIP_TRANS
        Try
            Dim lEntidad As New SOLIC_OIP_TRANS
            lEntidad.ID_OIP_TRANS = ID_OIP_TRANS
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
    ''' <param name="aTRANSPORTISTA">Recuperar registro foraneo de la Entidad TRANSPORTISTA.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aBANCOS">Recuperar registro foraneo de la Entidad BANCOS.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLIC_OIP_TRANSConForaneas(ByVal aEntidad As SOLIC_OIP_TRANS, Optional ByVal aTRANSPORTISTA As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aBANCOS As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aTRANSPORTISTA, aZAFRA, aBANCOS)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_OIP_TRANS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_OIP_TRANS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_OIP_TRANS(ByVal ID_OIP_TRANS As Int32) As Integer
        Try
            mEntidad.ID_OIP_TRANS = ID_OIP_TRANS
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_OIP_TRANS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_OIP_TRANS(ByVal aEntidad As SOLIC_OIP_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLIC_OIP_TRANS(ByVal ID_OIP_TRANS As Int32, ByVal CODTRANSPORT As Int32, ByVal ID_ZAFRA As Int32, ByVal CODIBANCO As Int32, ByVal FECHA As DateTime, ByVal MONTO As Decimal, ByVal CUOTA_CORTE As Decimal, ByVal UID_OIP_TRANS As Guid, ByVal PORC_DESC As Decimal, ByVal PORC_DESCEFECTIVO As Decimal, ByVal NUM_OIP_ZAFRA As Int32, ByVal REFERENCIA_GF As String, ByVal ES_ACEPTADA As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New SOLIC_OIP_TRANS
            lEntidad.ID_OIP_TRANS = ID_OIP_TRANS
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.CODIBANCO = CODIBANCO
            lEntidad.FECHA = FECHA
            lEntidad.MONTO = MONTO
            lEntidad.CUOTA_CORTE = CUOTA_CORTE
            lEntidad.UID_OIP_TRANS = UID_OIP_TRANS
            lEntidad.PORC_DESC = PORC_DESC
            lEntidad.PORC_DESCEFECTIVO = PORC_DESCEFECTIVO
            lEntidad.NUM_OIP_ZAFRA = NUM_OIP_ZAFRA
            lEntidad.REFERENCIA_GF = REFERENCIA_GF
            lEntidad.ES_ACEPTADA = ES_ACEPTADA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarSOLIC_OIP_TRANS(lEntidad)
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
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_OIP_TRANS(ByVal ID_OIP_TRANS As Int32, ByVal CODTRANSPORT As Int32, ByVal ID_ZAFRA As Int32, ByVal CODIBANCO As Int32, ByVal FECHA As DateTime, ByVal MONTO As Decimal, ByVal CUOTA_CORTE As Decimal, ByVal UID_OIP_TRANS As Guid, ByVal PORC_DESC As Decimal, ByVal PORC_DESCEFECTIVO As Decimal, ByVal NUM_OIP_ZAFRA As Int32, ByVal REFERENCIA_GF As String, ByVal ES_ACEPTADA As Boolean, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New SOLIC_OIP_TRANS
            lEntidad.ID_OIP_TRANS = ID_OIP_TRANS
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.CODIBANCO = CODIBANCO
            lEntidad.FECHA = FECHA
            lEntidad.MONTO = MONTO
            lEntidad.CUOTA_CORTE = CUOTA_CORTE
            lEntidad.UID_OIP_TRANS = UID_OIP_TRANS
            lEntidad.PORC_DESC = PORC_DESC
            lEntidad.PORC_DESCEFECTIVO = PORC_DESCEFECTIVO
            lEntidad.NUM_OIP_ZAFRA = NUM_OIP_ZAFRA
            lEntidad.REFERENCIA_GF = REFERENCIA_GF
            lEntidad.ES_ACEPTADA = ES_ACEPTADA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarSOLIC_OIP_TRANS(lEntidad)
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
    ''' 	[GenApp]	24/10/2017	Created
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
    ''' 	[GenApp]	24/10/2017	Created
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
    ''' la Tabla TRANSPORTISTA .
    ''' </summary>
    ''' <param name="CODTRANSPORT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_OIP_TRANS
        Try
            Dim mListaSOLIC_OIP_TRANS As New ListaSOLIC_OIP_TRANS
            mListaSOLIC_OIP_TRANS = mDb.ObtenerListaPorTRANSPORTISTA(CODTRANSPORT, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_OIP_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_OIP_TRANS in  mListaSOLIC_OIP_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_OIP_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_OIP_TRANS
        Try
            Dim mListaSOLIC_OIP_TRANS As New ListaSOLIC_OIP_TRANS
            mListaSOLIC_OIP_TRANS = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_OIP_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_OIP_TRANS in  mListaSOLIC_OIP_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_OIP_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla BANCOS .
    ''' </summary>
    ''' <param name="CODIBANCO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorBANCOS(ByVal CODIBANCO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_OIP_TRANS
        Try
            Dim mListaSOLIC_OIP_TRANS As New ListaSOLIC_OIP_TRANS
            mListaSOLIC_OIP_TRANS = mDb.ObtenerListaPorBANCOS(CODIBANCO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_OIP_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_OIP_TRANS in  mListaSOLIC_OIP_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_OIP_TRANS
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
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLIC_OIP_TRANS )
        aEntidad.fkCODTRANSPORT = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(aEntidad.CODTRANSPORT)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkCODIBANCO = (New cBANCOS).ObtenerBANCOS(aEntidad.CODIBANCO)
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
    ''' 	[GenApp]	24/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLIC_OIP_TRANS )
    End Sub

#End Region

End Class
