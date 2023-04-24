''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cCONTRATO_FINAN
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CONTRATO_FINAN
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/06/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCONTRATO_FINAN
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCONTRATO_FINAN()
    Private mEntidad as New CONTRATO_FINAN
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_FINAN
        Try
            Dim mListaCONTRATO_FINAN As New ListaCONTRATO_FINAN
            mListaCONTRATO_FINAN = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_FINAN Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_FINAN in  mListaCONTRATO_FINAN
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_FINAN
            If Not mListaCONTRATO_FINAN Is Nothing Then
                For Each lEntidad As CONTRATO_FINAN in  mListaCONTRATO_FINAN
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_FINAN
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
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCONTRATO_FINAN(ByRef aEntidad As CONTRATO_FINAN, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CONTRATO_FINAN.
    ''' </summary>
    ''' <param name="ID_CONTRATO_FINAN"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCONTRATO_FINAN(ByVal ID_CONTRATO_FINAN As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As CONTRATO_FINAN
        Try
            Dim lEntidad As New CONTRATO_FINAN
            lEntidad.ID_CONTRATO_FINAN = ID_CONTRATO_FINAN
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
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aCONTRATO">Recuperar registro foraneo de la Entidad CONTRATO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCONTRATO_FINANConForaneas(ByVal aEntidad As CONTRATO_FINAN, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aCONTRATO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aCONTRATO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_FINAN que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CONTRATO_FINAN"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_FINAN(ByVal ID_CONTRATO_FINAN As Int32) As Integer
        Try
            mEntidad.ID_CONTRATO_FINAN = ID_CONTRATO_FINAN
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_FINAN que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_FINAN(ByVal aEntidad As CONTRATO_FINAN, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCONTRATO_FINAN(ByVal ID_CONTRATO_FINAN As Int32, ByVal ID_ZAFRA As Int32, ByVal CODICONTRATO As String, ByVal MZ As Decimal, ByVal TONEL_MZ As Decimal, ByVal TONEL As Decimal, ByVal REND_COSECHA As Decimal, ByVal LIBRAS As Decimal, ByVal VIP As Decimal, ByVal VALOR_CONTRA As Decimal, ByVal PROVI_ROZA As Decimal, ByVal PROVI_ALZA As Decimal, ByVal PROVI_TRANS As Decimal, ByVal PROVISION As Decimal, ByVal CARGO As Decimal, ByVal ABONO As Decimal, ByVal DISPONIBLE As Decimal, ByVal ZAFRA As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New CONTRATO_FINAN
            lEntidad.ID_CONTRATO_FINAN = ID_CONTRATO_FINAN
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.MZ = MZ
            lEntidad.TONEL_MZ = TONEL_MZ
            lEntidad.TONEL = TONEL
            lEntidad.REND_COSECHA = REND_COSECHA
            lEntidad.LIBRAS = LIBRAS
            lEntidad.VIP = VIP
            lEntidad.VALOR_CONTRA = VALOR_CONTRA
            lEntidad.PROVI_ROZA = PROVI_ROZA
            lEntidad.PROVI_ALZA = PROVI_ALZA
            lEntidad.PROVI_TRANS = PROVI_TRANS
            lEntidad.PROVISION = PROVISION
            lEntidad.CARGO = CARGO
            lEntidad.ABONO = ABONO
            lEntidad.DISPONIBLE = DISPONIBLE
            lEntidad.ZAFRA = ZAFRA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarCONTRATO_FINAN(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_FINAN(ByVal aEntidad As CONTRATO_FINAN) As Integer
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
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_FINAN(ByVal aEntidad As CONTRATO_FINAN, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_FINAN(ByVal ID_CONTRATO_FINAN As Int32, ByVal ID_ZAFRA As Int32, ByVal CODICONTRATO As String, ByVal MZ As Decimal, ByVal TONEL_MZ As Decimal, ByVal TONEL As Decimal, ByVal REND_COSECHA As Decimal, ByVal LIBRAS As Decimal, ByVal VIP As Decimal, ByVal VALOR_CONTRA As Decimal, ByVal PROVI_ROZA As Decimal, ByVal PROVI_ALZA As Decimal, ByVal PROVI_TRANS As Decimal, ByVal PROVISION As Decimal, ByVal CARGO As Decimal, ByVal ABONO As Decimal, ByVal DISPONIBLE As Decimal, ByVal ZAFRA As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New CONTRATO_FINAN
            lEntidad.ID_CONTRATO_FINAN = ID_CONTRATO_FINAN
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.MZ = MZ
            lEntidad.TONEL_MZ = TONEL_MZ
            lEntidad.TONEL = TONEL
            lEntidad.REND_COSECHA = REND_COSECHA
            lEntidad.LIBRAS = LIBRAS
            lEntidad.VIP = VIP
            lEntidad.VALOR_CONTRA = VALOR_CONTRA
            lEntidad.PROVI_ROZA = PROVI_ROZA
            lEntidad.PROVI_ALZA = PROVI_ALZA
            lEntidad.PROVI_TRANS = PROVI_TRANS
            lEntidad.PROVISION = PROVISION
            lEntidad.CARGO = CARGO
            lEntidad.ABONO = ABONO
            lEntidad.DISPONIBLE = DISPONIBLE
            lEntidad.ZAFRA = ZAFRA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarCONTRATO_FINAN(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	02/06/2015	Created
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
    ''' 	[GenApp]	02/06/2015	Created
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
    ''' la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_FINAN
        Try
            Dim mListaCONTRATO_FINAN As New ListaCONTRATO_FINAN
            mListaCONTRATO_FINAN = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_FINAN Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_FINAN in  mListaCONTRATO_FINAN
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_FINAN
            If Not mListaCONTRATO_FINAN Is Nothing Then
                For Each lEntidad As CONTRATO_FINAN in  mListaCONTRATO_FINAN
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_FINAN
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
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO(ByVal CODICONTRATO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_FINAN
        Try
            Dim mListaCONTRATO_FINAN As New ListaCONTRATO_FINAN
            mListaCONTRATO_FINAN = mDb.ObtenerListaPorCONTRATO(CODICONTRATO, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_FINAN Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_FINAN in  mListaCONTRATO_FINAN
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_FINAN
            If Not mListaCONTRATO_FINAN Is Nothing Then
                For Each lEntidad As CONTRATO_FINAN in  mListaCONTRATO_FINAN
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_FINAN
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
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CONTRATO_FINAN )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkCODICONTRATO = (New cCONTRATO).ObtenerCONTRATO(aEntidad.CODICONTRATO)
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
    ''' 	[GenApp]	02/06/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CONTRATO_FINAN )
    End Sub

#End Region

End Class
