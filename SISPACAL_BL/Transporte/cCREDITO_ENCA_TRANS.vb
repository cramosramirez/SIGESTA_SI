''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCREDITO_ENCA_TRANS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CREDITO_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCREDITO_ENCA_TRANS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCREDITO_ENCA_TRANS()
    Private mEntidad as New CREDITO_ENCA_TRANS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCREDITO_ENCA_TRANS
        Try
            Dim mListaCREDITO_ENCA_TRANS As New ListaCREDITO_ENCA_TRANS
            mListaCREDITO_ENCA_TRANS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCREDITO_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCREDITO_ENCA_TRANS
            If Not mListaCREDITO_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCREDITO_ENCA_TRANS
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
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCREDITO_ENCA_TRANS(ByRef aEntidad As CREDITO_ENCA_TRANS, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then Return liRet
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(aEntidad)
                Catch ex as Exception
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CREDITO_ENCA_TRANS.
    ''' </summary>
    ''' <param name="ID_CREDITO_ENCA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCREDITO_ENCA_TRANS(ByVal ID_CREDITO_ENCA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As CREDITO_ENCA_TRANS
        Try
            Dim lEntidad As New CREDITO_ENCA_TRANS
            lEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then
                If liRet = 1 Then Return lEntidad
                Return Nothing
            End If
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(lEntidad)
                Catch ex as Exception
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
    ''' <param name="aCUENTA_FINAN">Recuperar registro foraneo de la Entidad CUENTA_FINAN.</param>
    ''' <param name="aPROVEEDOR_AGRICOLA">Recuperar registro foraneo de la Entidad PROVEEDOR_AGRICOLA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCREDITO_ENCA_TRANSConForaneas(ByVal aEntidad As CREDITO_ENCA_TRANS, Optional ByVal aTRANSPORTISTA As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aCUENTA_FINAN As Boolean = False, Optional ByVal aPROVEEDOR_AGRICOLA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aTRANSPORTISTA, aZAFRA, aCUENTA_FINAN, aPROVEEDOR_AGRICOLA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CREDITO_ENCA_TRANS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CREDITO_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCREDITO_ENCA_TRANS(ByVal ID_CREDITO_ENCA As Int32) As Integer
        Try
            mEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CREDITO_ENCA_TRANS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCREDITO_ENCA_TRANS(ByVal aEntidad As CREDITO_ENCA_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCREDITO_ENCA_TRANS(ByVal ID_CREDITO_ENCA As Int32, ByVal CODTRANSPORT As Int32, ByVal ID_ZAFRA As Int32, ByVal ZAFRA As String, ByVal ID_TIPO_COMPROB As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal DESCRIP_FINAN As String, ByVal ID_PROVEE As Int32, ByVal FECHA As DateTime, ByVal NO_COMPROB As String, ByVal FECHA_APLIC As DateTime, ByVal FECHA_ULTMOV As DateTime, ByVal UID_REFERENCIA As Guid, ByVal TASAINT As Decimal, ByVal CARGO As Decimal, ByVal ABONO As Decimal, ByVal SALDO As Decimal, ByVal INTERES As Decimal, ByVal IVA_INTERES As Decimal, ByVal ABONO_IVA As Decimal, ByVal ABONO_INTERES As Decimal, ByVal ABONO_INTERES_IVA As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ES_SALDO_INSOLUTO As Boolean, ByVal TIPO_INTERES As String) As Integer
        Try
            Dim lEntidad As New CREDITO_ENCA_TRANS
            lEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ZAFRA = ZAFRA
            lEntidad.ID_TIPO_COMPROB = ID_TIPO_COMPROB
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.DESCRIP_FINAN = DESCRIP_FINAN
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.FECHA = FECHA
            lEntidad.NO_COMPROB = NO_COMPROB
            lEntidad.FECHA_APLIC = FECHA_APLIC
            lEntidad.FECHA_ULTMOV = FECHA_ULTMOV
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            lEntidad.TASAINT = TASAINT
            lEntidad.CARGO = CARGO
            lEntidad.ABONO = ABONO
            lEntidad.SALDO = SALDO
            lEntidad.INTERES = INTERES
            lEntidad.IVA_INTERES = IVA_INTERES
            lEntidad.ABONO_IVA = ABONO_IVA
            lEntidad.ABONO_INTERES = ABONO_INTERES
            lEntidad.ABONO_INTERES_IVA = ABONO_INTERES_IVA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ES_SALDO_INSOLUTO = ES_SALDO_INSOLUTO
            lEntidad.TIPO_INTERES = TIPO_INTERES
            Return Me.ActualizarCREDITO_ENCA_TRANS(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCREDITO_ENCA_TRANS(ByVal aEntidad As CREDITO_ENCA_TRANS) As Integer
        Try
            Return mDb.Actualizar(aEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCREDITO_ENCA_TRANS(ByVal aEntidad As CREDITO_ENCA_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCREDITO_ENCA_TRANS(ByVal ID_CREDITO_ENCA As Int32, ByVal CODTRANSPORT As Int32, ByVal ID_ZAFRA As Int32, ByVal ZAFRA As String, ByVal ID_TIPO_COMPROB As Int32, ByVal ID_CUENTA_FINAN As Int32, ByVal DESCRIP_FINAN As String, ByVal ID_PROVEE As Int32, ByVal FECHA As DateTime, ByVal NO_COMPROB As String, ByVal FECHA_APLIC As DateTime, ByVal FECHA_ULTMOV As DateTime, ByVal UID_REFERENCIA As Guid, ByVal TASAINT As Decimal, ByVal CARGO As Decimal, ByVal ABONO As Decimal, ByVal SALDO As Decimal, ByVal INTERES As Decimal, ByVal IVA_INTERES As Decimal, ByVal ABONO_IVA As Decimal, ByVal ABONO_INTERES As Decimal, ByVal ABONO_INTERES_IVA As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ES_SALDO_INSOLUTO As Boolean, ByVal TIPO_INTERES As String) As Integer
        Try
            Dim lEntidad As New CREDITO_ENCA_TRANS
            lEntidad.ID_CREDITO_ENCA = ID_CREDITO_ENCA
            lEntidad.CODTRANSPORT = CODTRANSPORT
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ZAFRA = ZAFRA
            lEntidad.ID_TIPO_COMPROB = ID_TIPO_COMPROB
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.DESCRIP_FINAN = DESCRIP_FINAN
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.FECHA = FECHA
            lEntidad.NO_COMPROB = NO_COMPROB
            lEntidad.FECHA_APLIC = FECHA_APLIC
            lEntidad.FECHA_ULTMOV = FECHA_ULTMOV
            lEntidad.UID_REFERENCIA = UID_REFERENCIA
            lEntidad.TASAINT = TASAINT
            lEntidad.CARGO = CARGO
            lEntidad.ABONO = ABONO
            lEntidad.SALDO = SALDO
            lEntidad.INTERES = INTERES
            lEntidad.IVA_INTERES = IVA_INTERES
            lEntidad.ABONO_IVA = ABONO_IVA
            lEntidad.ABONO_INTERES = ABONO_INTERES
            lEntidad.ABONO_INTERES_IVA = ABONO_INTERES_IVA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ES_SALDO_INSOLUTO = ES_SALDO_INSOLUTO
            lEntidad.TIPO_INTERES = TIPO_INTERES
            Return Me.ActualizarCREDITO_ENCA_TRANS(lEntidad)
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
    ''' 	[GenApp]	03/11/2017	Created
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
    ''' 	[GenApp]	03/11/2017	Created
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTRANSPORTISTA(ByVal CODTRANSPORT As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCREDITO_ENCA_TRANS
        Try
            Dim mListaCREDITO_ENCA_TRANS As New ListaCREDITO_ENCA_TRANS
            mListaCREDITO_ENCA_TRANS = mDb.ObtenerListaPorTRANSPORTISTA(CODTRANSPORT, asColumnaOrden, asTipoOrden)
            If Not mListaCREDITO_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCREDITO_ENCA_TRANS
            If Not mListaCREDITO_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCREDITO_ENCA_TRANS
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCREDITO_ENCA_TRANS
        Try
            Dim mListaCREDITO_ENCA_TRANS As New ListaCREDITO_ENCA_TRANS
            mListaCREDITO_ENCA_TRANS = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaCREDITO_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCREDITO_ENCA_TRANS
            If Not mListaCREDITO_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCREDITO_ENCA_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CUENTA_FINAN .
    ''' </summary>
    ''' <param name="ID_CUENTA_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCREDITO_ENCA_TRANS
        Try
            Dim mListaCREDITO_ENCA_TRANS As New ListaCREDITO_ENCA_TRANS
            mListaCREDITO_ENCA_TRANS = mDb.ObtenerListaPorCUENTA_FINAN(ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
            If Not mListaCREDITO_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCREDITO_ENCA_TRANS
            If Not mListaCREDITO_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCREDITO_ENCA_TRANS
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AGRICOLA(ByVal ID_PROVEE As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCREDITO_ENCA_TRANS
        Try
            Dim mListaCREDITO_ENCA_TRANS As New ListaCREDITO_ENCA_TRANS
            mListaCREDITO_ENCA_TRANS = mDb.ObtenerListaPorPROVEEDOR_AGRICOLA(ID_PROVEE, asColumnaOrden, asTipoOrden)
            If Not mListaCREDITO_ENCA_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCREDITO_ENCA_TRANS
            If Not mListaCREDITO_ENCA_TRANS Is Nothing Then
                For Each lEntidad As CREDITO_ENCA_TRANS in  mListaCREDITO_ENCA_TRANS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCREDITO_ENCA_TRANS
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CREDITO_ENCA_TRANS )
        aEntidad.fkCODTRANSPORT = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(aEntidad.CODTRANSPORT)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkID_CUENTA_FINAN = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(aEntidad.ID_CUENTA_FINAN)
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
    ''' 	[GenApp]	03/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CREDITO_ENCA_TRANS )
    End Sub

#End Region

End Class
