''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCONTRATO_CTAS_PROVI
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CONTRATO_CTAS_PROVI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/07/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCONTRATO_CTAS_PROVI
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCONTRATO_CTAS_PROVI()
    Private mEntidad as New CONTRATO_CTAS_PROVI
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_CTAS_PROVI
        Try
            Dim mListaCONTRATO_CTAS_PROVI As New ListaCONTRATO_CTAS_PROVI
            mListaCONTRATO_CTAS_PROVI = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_CTAS_PROVI Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_CTAS_PROVI in  mListaCONTRATO_CTAS_PROVI
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_CTAS_PROVI
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
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCONTRATO_CTAS_PROVI(ByRef aEntidad As CONTRATO_CTAS_PROVI, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CONTRATO_CTAS_PROVI.
    ''' </summary>
    ''' <param name="ID_CONTRATO_CTAS_PROVI"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCONTRATO_CTAS_PROVI(ByVal ID_CONTRATO_CTAS_PROVI As Int32, ByVal Optional recuperarForaneas As Boolean = False) As CONTRATO_CTAS_PROVI
        Try
            Dim lEntidad As New CONTRATO_CTAS_PROVI
            lEntidad.ID_CONTRATO_CTAS_PROVI = ID_CONTRATO_CTAS_PROVI
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
    ''' <param name="aCONTRATO_FINAN">Recuperar registro foraneo de la Entidad CONTRATO_FINAN.</param>
    ''' <param name="aCONTRATO">Recuperar registro foraneo de la Entidad CONTRATO.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aCUENTA_FINAN">Recuperar registro foraneo de la Entidad CUENTA_FINAN.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCONTRATO_CTAS_PROVIConForaneas(ByVal aEntidad As CONTRATO_CTAS_PROVI, Optional ByVal aCONTRATO_FINAN As Boolean = False, Optional ByVal aCONTRATO As Boolean = False, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aCUENTA_FINAN As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aCONTRATO_FINAN, aCONTRATO, aZAFRA, aCUENTA_FINAN)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_CTAS_PROVI que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CONTRATO_CTAS_PROVI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_CTAS_PROVI(ByVal ID_CONTRATO_CTAS_PROVI As Int32) As Integer
        Try
            mEntidad.ID_CONTRATO_CTAS_PROVI = ID_CONTRATO_CTAS_PROVI
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_CTAS_PROVI que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_CTAS_PROVI(ByVal aEntidad As CONTRATO_CTAS_PROVI, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCONTRATO_CTAS_PROVI(ByVal ID_CONTRATO_CTAS_PROVI As Int32, ByVal ID_CONTRATO_FINAN As Int32, ByVal CODICONTRATO As String, ByVal ID_ZAFRA As Int32, ByVal FECHA_APLICA As DateTime, ByVal CONCEPTO As String, ByVal PROVISION As Decimal, ByVal ID_CUENTA_FINAN As Int32, ByVal UID_SOLICITUD As Guid, ByVal ZAFRA As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New CONTRATO_CTAS_PROVI
            lEntidad.ID_CONTRATO_CTAS_PROVI = ID_CONTRATO_CTAS_PROVI
            lEntidad.ID_CONTRATO_FINAN = ID_CONTRATO_FINAN
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.FECHA_APLICA = FECHA_APLICA
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.PROVISION = PROVISION
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.UID_SOLICITUD = UID_SOLICITUD
            lEntidad.ZAFRA = ZAFRA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarCONTRATO_CTAS_PROVI(lEntidad)
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
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_CTAS_PROVI(ByVal aEntidad As CONTRATO_CTAS_PROVI) As Integer
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
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_CTAS_PROVI(ByVal aEntidad As CONTRATO_CTAS_PROVI, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_CTAS_PROVI(ByVal ID_CONTRATO_CTAS_PROVI As Int32, ByVal ID_CONTRATO_FINAN As Int32, ByVal CODICONTRATO As String, ByVal ID_ZAFRA As Int32, ByVal FECHA_APLICA As DateTime, ByVal CONCEPTO As String, ByVal PROVISION As Decimal, ByVal ID_CUENTA_FINAN As Int32, ByVal UID_SOLICITUD As Guid, ByVal ZAFRA As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New CONTRATO_CTAS_PROVI
            lEntidad.ID_CONTRATO_CTAS_PROVI = ID_CONTRATO_CTAS_PROVI
            lEntidad.ID_CONTRATO_FINAN = ID_CONTRATO_FINAN
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.FECHA_APLICA = FECHA_APLICA
            lEntidad.CONCEPTO = CONCEPTO
            lEntidad.PROVISION = PROVISION
            lEntidad.ID_CUENTA_FINAN = ID_CUENTA_FINAN
            lEntidad.UID_SOLICITUD = UID_SOLICITUD
            lEntidad.ZAFRA = ZAFRA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarCONTRATO_CTAS_PROVI(lEntidad)
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
    ''' 	[GenApp]	12/07/2015	Created
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
    ''' 	[GenApp]	12/07/2015	Created
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
    ''' la Tabla CONTRATO_FINAN .
    ''' </summary>
    ''' <param name="ID_CONTRATO_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO_FINAN(ByVal ID_CONTRATO_FINAN As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_CTAS_PROVI
        Try
            Dim mListaCONTRATO_CTAS_PROVI As New ListaCONTRATO_CTAS_PROVI
            mListaCONTRATO_CTAS_PROVI = mDb.ObtenerListaPorCONTRATO_FINAN(ID_CONTRATO_FINAN, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_CTAS_PROVI Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_CTAS_PROVI in  mListaCONTRATO_CTAS_PROVI
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_CTAS_PROVI
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CONTRATO .
    ''' </summary>
    ''' <param name="CODICONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO(ByVal CODICONTRATO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_CTAS_PROVI
        Try
            Dim mListaCONTRATO_CTAS_PROVI As New ListaCONTRATO_CTAS_PROVI
            mListaCONTRATO_CTAS_PROVI = mDb.ObtenerListaPorCONTRATO(CODICONTRATO, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_CTAS_PROVI Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_CTAS_PROVI in  mListaCONTRATO_CTAS_PROVI
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_CTAS_PROVI
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
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_CTAS_PROVI
        Try
            Dim mListaCONTRATO_CTAS_PROVI As New ListaCONTRATO_CTAS_PROVI
            mListaCONTRATO_CTAS_PROVI = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_CTAS_PROVI Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_CTAS_PROVI in  mListaCONTRATO_CTAS_PROVI
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_CTAS_PROVI
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
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCUENTA_FINAN(ByVal ID_CUENTA_FINAN As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_CTAS_PROVI
        Try
            Dim mListaCONTRATO_CTAS_PROVI As New ListaCONTRATO_CTAS_PROVI
            mListaCONTRATO_CTAS_PROVI = mDb.ObtenerListaPorCUENTA_FINAN(ID_CUENTA_FINAN, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_CTAS_PROVI Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_CTAS_PROVI in  mListaCONTRATO_CTAS_PROVI
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_CTAS_PROVI
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
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CONTRATO_CTAS_PROVI )
        aEntidad.fkID_CONTRATO_FINAN = (New cCONTRATO_FINAN).ObtenerCONTRATO_FINAN(aEntidad.ID_CONTRATO_FINAN)
        aEntidad.fkCODICONTRATO = (New cCONTRATO).ObtenerCONTRATO(aEntidad.CODICONTRATO)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkID_CUENTA_FINAN = (New cCUENTA_FINAN).ObtenerCUENTA_FINAN(aEntidad.ID_CUENTA_FINAN)
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
    ''' 	[GenApp]	12/07/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CONTRATO_CTAS_PROVI )
    End Sub

#End Region

End Class
