''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cLABFAB_DIAZAFRA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla LABFAB_DIAZAFRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cLABFAB_DIAZAFRA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbLABFAB_DIAZAFRA()
    Private mEntidad as New LABFAB_DIAZAFRA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLABFAB_DIAZAFRA
        Try
            Dim mListaLABFAB_DIAZAFRA As New ListaLABFAB_DIAZAFRA
            mListaLABFAB_DIAZAFRA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaLABFAB_DIAZAFRA
            If Not mListaLABFAB_DIAZAFRA Is Nothing Then
                For Each lEntidad As LABFAB_DIAZAFRA in  mListaLABFAB_DIAZAFRA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaLABFAB_DIAZAFRA
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
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLABFAB_DIAZAFRA(ByRef aEntidad As LABFAB_DIAZAFRA, ByVal Optional recuperarHijas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla LABFAB_DIAZAFRA.
    ''' </summary>
    ''' <param name="ID_DIAZAFRA"></param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLABFAB_DIAZAFRA(ByVal ID_DIAZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False) As LABFAB_DIAZAFRA
        Try
            Dim lEntidad As New LABFAB_DIAZAFRA
            lEntidad.ID_DIAZAFRA = ID_DIAZAFRA
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
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
    ''' Función que Elimina un Registro de la Tabla LABFAB_DIAZAFRA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_DIAZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarLABFAB_DIAZAFRA(ByVal ID_DIAZAFRA As Int32) As Integer
        Try
            mEntidad.ID_DIAZAFRA = ID_DIAZAFRA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LABFAB_DIAZAFRA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarLABFAB_DIAZAFRA(ByVal aEntidad As LABFAB_DIAZAFRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarLABFAB_DIAZAFRA(ByVal ID_DIAZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal ID_ZAFRA As Int32, ByVal CIERRE_LABFAB As DateTime, ByVal ACTIVO As Boolean) As Integer
        Try
            Dim lEntidad As New LABFAB_DIAZAFRA
            lEntidad.ID_DIAZAFRA = ID_DIAZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.CIERRE_LABFAB = CIERRE_LABFAB
            lEntidad.ACTIVO = ACTIVO
            Return Me.ActualizarLABFAB_DIAZAFRA(lEntidad)
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
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLABFAB_DIAZAFRA(ByVal aEntidad As LABFAB_DIAZAFRA) As Integer
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
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLABFAB_DIAZAFRA(ByVal aEntidad As LABFAB_DIAZAFRA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLABFAB_DIAZAFRA(ByVal ID_DIAZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal ID_ZAFRA As Int32, ByVal CIERRE_LABFAB As DateTime, ByVal ACTIVO As Boolean) As Integer
        Try
            Dim lEntidad As New LABFAB_DIAZAFRA
            lEntidad.ID_DIAZAFRA = ID_DIAZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.CIERRE_LABFAB = CIERRE_LABFAB
            lEntidad.ACTIVO = ACTIVO
            Return Me.ActualizarLABFAB_DIAZAFRA(lEntidad)
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
    ''' 	[GenApp]	17/11/2015	Created
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
    ''' 	[GenApp]	17/11/2015	Created
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
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As LABFAB_DIAZAFRA )
    End Sub

#End Region

End Class
