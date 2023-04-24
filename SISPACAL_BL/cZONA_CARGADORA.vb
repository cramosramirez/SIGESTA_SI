''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cZONA_CARGADORA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ZONA_CARGADORA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cZONA_CARGADORA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbZONA_CARGADORA()
    Private mEntidad as New ZONA_CARGADORA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaZONA_CARGADORA
        Try
            Dim mListaZONA_CARGADORA As New ListaZONA_CARGADORA
            mListaZONA_CARGADORA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaZONA_CARGADORA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ZONA_CARGADORA in  mListaZONA_CARGADORA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaZONA_CARGADORA
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
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerZONA_CARGADORA(ByRef aEntidad As ZONA_CARGADORA, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ZONA_CARGADORA.
    ''' </summary>
    ''' <param name="ID_ZONA_CARGA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerZONA_CARGADORA(ByVal ID_ZONA_CARGA As Int32, ByVal Optional recuperarForaneas As Boolean = False) As ZONA_CARGADORA
        Try
            Dim lEntidad As New ZONA_CARGADORA
            lEntidad.ID_ZONA_CARGA = ID_ZONA_CARGA
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
    ''' <param name="aCARGADORA">Recuperar registro foraneo de la Entidad CARGADORA.</param>
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerZONA_CARGADORAConForaneas(ByVal aEntidad As ZONA_CARGADORA, Optional ByVal aCARGADORA As Boolean = False, Optional ByVal aZAFRA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aCARGADORA, aZAFRA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ZONA_CARGADORA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ZONA_CARGA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarZONA_CARGADORA(ByVal ID_ZONA_CARGA As Int32) As Integer
        Try
            mEntidad.ID_ZONA_CARGA = ID_ZONA_CARGA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ZONA_CARGADORA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarZONA_CARGADORA(ByVal aEntidad As ZONA_CARGADORA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarZONA_CARGADORA(ByVal ID_ZONA_CARGA As Int32, ByVal ZONA As String, ByVal ID_CARGADORA As Int32, ByVal ID_ZAFRA As Int32, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New ZONA_CARGADORA
            lEntidad.ID_ZONA_CARGA = ID_ZONA_CARGA
            lEntidad.ZONA = ZONA
            lEntidad.ID_CARGADORA = ID_CARGADORA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarZONA_CARGADORA(lEntidad)
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
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarZONA_CARGADORA(ByVal ID_ZONA_CARGA As Int32, ByVal ZONA As String, ByVal ID_CARGADORA As Int32, ByVal ID_ZAFRA As Int32, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New ZONA_CARGADORA
            lEntidad.ID_ZONA_CARGA = ID_ZONA_CARGA
            lEntidad.ZONA = ZONA
            lEntidad.ID_CARGADORA = ID_CARGADORA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarZONA_CARGADORA(lEntidad)
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
    ''' 	[GenApp]	08/03/2015	Created
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
    ''' 	[GenApp]	08/03/2015	Created
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
    ''' la Tabla CARGADORA .
    ''' </summary>
    ''' <param name="ID_CARGADORA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCARGADORA(ByVal ID_CARGADORA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaZONA_CARGADORA
        Try
            Dim mListaZONA_CARGADORA As New ListaZONA_CARGADORA
            mListaZONA_CARGADORA = mDb.ObtenerListaPorCARGADORA(ID_CARGADORA, asColumnaOrden, asTipoOrden)
            If Not mListaZONA_CARGADORA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ZONA_CARGADORA in  mListaZONA_CARGADORA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaZONA_CARGADORA
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
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaZONA_CARGADORA
        Try
            Dim mListaZONA_CARGADORA As New ListaZONA_CARGADORA
            mListaZONA_CARGADORA = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaZONA_CARGADORA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ZONA_CARGADORA in  mListaZONA_CARGADORA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaZONA_CARGADORA
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
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ZONA_CARGADORA )
        aEntidad.fkID_CARGADORA = (New cCARGADORA).ObtenerCARGADORA(aEntidad.ID_CARGADORA)
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
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
    ''' 	[GenApp]	08/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ZONA_CARGADORA )
    End Sub

#End Region

End Class
