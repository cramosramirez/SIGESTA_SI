''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSOLIC_PROD_TRANS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLIC_PROD_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLIC_PROD_TRANS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLIC_PROD_TRANS()
    Private mEntidad as New SOLIC_PROD_TRANS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_PROD_TRANS
        Try
            Dim mListaSOLIC_PROD_TRANS As New ListaSOLIC_PROD_TRANS
            mListaSOLIC_PROD_TRANS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_PROD_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_PROD_TRANS in  mListaSOLIC_PROD_TRANS
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_PROD_TRANS
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
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLIC_PROD_TRANS(ByRef aEntidad As SOLIC_PROD_TRANS, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLIC_PROD_TRANS.
    ''' </summary>
    ''' <param name="ID_SOLIC_PROD_TRANS"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLIC_PROD_TRANS(ByVal ID_SOLIC_PROD_TRANS As Int32, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_PROD_TRANS
        Try
            Dim lEntidad As New SOLIC_PROD_TRANS
            lEntidad.ID_SOLIC_PROD_TRANS = ID_SOLIC_PROD_TRANS
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
    ''' <param name="aSOLIC_ENCA_TRANS">Recuperar registro foraneo de la Entidad SOLIC_ENCA_TRANS.</param>
    ''' <param name="aPROVEEDOR_AGRICOLA">Recuperar registro foraneo de la Entidad PROVEEDOR_AGRICOLA.</param>
    ''' <param name="aPRODUCTO">Recuperar registro foraneo de la Entidad PRODUCTO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLIC_PROD_TRANSConForaneas(ByVal aEntidad As SOLIC_PROD_TRANS, Optional ByVal aSOLIC_ENCA_TRANS As Boolean = False, Optional ByVal aPROVEEDOR_AGRICOLA As Boolean = False, Optional ByVal aPRODUCTO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aSOLIC_ENCA_TRANS, aPROVEEDOR_AGRICOLA, aPRODUCTO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_PROD_TRANS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLIC_PROD_TRANS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_PROD_TRANS(ByVal ID_SOLIC_PROD_TRANS As Int32) As Integer
        Try
            mEntidad.ID_SOLIC_PROD_TRANS = ID_SOLIC_PROD_TRANS
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_PROD_TRANS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_PROD_TRANS(ByVal aEntidad As SOLIC_PROD_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLIC_PROD_TRANS(ByVal ID_SOLIC_PROD_TRANS As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_PROVEE As Int32, ByVal ID_PRODUCTO As Int32, ByVal NOMBRE_PRODUCTO As String, ByVal PRESENTACION As String, ByVal CANTIDAD As Decimal, ByVal PRECIO_UNITARIO As Decimal, ByVal SUB_TOTAL As Decimal) As Integer
        Try
            Dim lEntidad As New SOLIC_PROD_TRANS
            lEntidad.ID_SOLIC_PROD_TRANS = ID_SOLIC_PROD_TRANS
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.PRESENTACION = PRESENTACION
            lEntidad.CANTIDAD = CANTIDAD
            lEntidad.PRECIO_UNITARIO = PRECIO_UNITARIO
            lEntidad.SUB_TOTAL = SUB_TOTAL
            Return Me.ActualizarSOLIC_PROD_TRANS(lEntidad)
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
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_PROD_TRANS(ByVal aEntidad As SOLIC_PROD_TRANS) As Integer
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
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_PROD_TRANS(ByVal aEntidad As SOLIC_PROD_TRANS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_PROD_TRANS(ByVal ID_SOLIC_PROD_TRANS As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_PROVEE As Int32, ByVal ID_PRODUCTO As Int32, ByVal NOMBRE_PRODUCTO As String, ByVal PRESENTACION As String, ByVal CANTIDAD As Decimal, ByVal PRECIO_UNITARIO As Decimal, ByVal SUB_TOTAL As Decimal) As Integer
        Try
            Dim lEntidad As New SOLIC_PROD_TRANS
            lEntidad.ID_SOLIC_PROD_TRANS = ID_SOLIC_PROD_TRANS
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.PRESENTACION = PRESENTACION
            lEntidad.CANTIDAD = CANTIDAD
            lEntidad.PRECIO_UNITARIO = PRECIO_UNITARIO
            lEntidad.SUB_TOTAL = SUB_TOTAL
            Return Me.ActualizarSOLIC_PROD_TRANS(lEntidad)
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
    ''' 	[GenApp]	25/10/2017	Created
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
    ''' 	[GenApp]	25/10/2017	Created
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
    ''' la Tabla SOLIC_ENCA_TRANS .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLIC_ENCA_TRANS(ByVal ID_SOLICITUD As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_PROD_TRANS
        Try
            Dim mListaSOLIC_PROD_TRANS As New ListaSOLIC_PROD_TRANS
            mListaSOLIC_PROD_TRANS = mDb.ObtenerListaPorSOLIC_ENCA_TRANS(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_PROD_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_PROD_TRANS in  mListaSOLIC_PROD_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_PROD_TRANS
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
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AGRICOLA(ByVal ID_PROVEE As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_PROD_TRANS
        Try
            Dim mListaSOLIC_PROD_TRANS As New ListaSOLIC_PROD_TRANS
            mListaSOLIC_PROD_TRANS = mDb.ObtenerListaPorPROVEEDOR_AGRICOLA(ID_PROVEE, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_PROD_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_PROD_TRANS in  mListaSOLIC_PROD_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_PROD_TRANS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PRODUCTO .
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPRODUCTO(ByVal ID_PRODUCTO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_PROD_TRANS
        Try
            Dim mListaSOLIC_PROD_TRANS As New ListaSOLIC_PROD_TRANS
            mListaSOLIC_PROD_TRANS = mDb.ObtenerListaPorPRODUCTO(ID_PRODUCTO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_PROD_TRANS Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_PROD_TRANS in  mListaSOLIC_PROD_TRANS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_PROD_TRANS
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
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLIC_PROD_TRANS )
        aEntidad.fkID_SOLICITUD = (New cSOLIC_ENCA_TRANS).ObtenerSOLIC_ENCA_TRANS(aEntidad.ID_SOLICITUD)
        aEntidad.fkID_PROVEE = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(aEntidad.ID_PROVEE)
        aEntidad.fkID_PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(aEntidad.ID_PRODUCTO)
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
    ''' 	[GenApp]	25/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLIC_PROD_TRANS )
    End Sub

#End Region

End Class
