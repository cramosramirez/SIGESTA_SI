''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cLABFAB_ANALISISXDIA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla LABFAB_ANALISISXDIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cLABFAB_ANALISISXDIA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb As New dbLABFAB_ANALISISXDIA()
    Private mEntidad As New LABFAB_ANALISISXDIA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As ListaLABFAB_ANALISISXDIA
        Try
            Dim mListaLABFAB_ANALISISXDIA As New ListaLABFAB_ANALISISXDIA
            mListaLABFAB_ANALISISXDIA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaLABFAB_ANALISISXDIA Is Nothing And recuperarForaneas Then
                For Each lEntidad As LABFAB_ANALISISXDIA In mListaLABFAB_ANALISISXDIA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLABFAB_ANALISISXDIA
            If Not mListaLABFAB_ANALISISXDIA Is Nothing Then
                For Each lEntidad As LABFAB_ANALISISXDIA In mListaLABFAB_ANALISISXDIA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaLABFAB_ANALISISXDIA
        Catch ex As Exception
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
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLABFAB_ANALISISXDIA(ByRef aEntidad As LABFAB_ANALISISXDIA, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False) As Integer
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
                Catch ex As Exception
                End Try
            End If
            Return liRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla LABFAB_ANALISISXDIA.
    ''' </summary>
    ''' <param name="ID_ANALISISXDIA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLABFAB_ANALISISXDIA(ByVal ID_ANALISISXDIA As Int32, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False) As LABFAB_ANALISISXDIA
        Try
            Dim lEntidad As New LABFAB_ANALISISXDIA
            lEntidad.ID_ANALISISXDIA = ID_ANALISISXDIA
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
                Catch ex As Exception
                End Try
            End If
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
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
    ''' <param name="aLABFAB_DIAZAFRA">Recuperar registro foraneo de la Entidad LABFAB_DIAZAFRA.</param>
    ''' <param name="aLABFAB_ANALISIS">Recuperar registro foraneo de la Entidad LABFAB_ANALISIS.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerLABFAB_ANALISISXDIAConForaneas(ByVal aEntidad As LABFAB_ANALISISXDIA, Optional ByVal aLABFAB_DIAZAFRA As Boolean = False, Optional ByVal aLABFAB_ANALISIS As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aLABFAB_DIAZAFRA, aLABFAB_ANALISIS)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LABFAB_ANALISISXDIA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ANALISISXDIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarLABFAB_ANALISISXDIA(ByVal ID_ANALISISXDIA As Int32) As Integer
        Try
            mEntidad.ID_ANALISISXDIA = ID_ANALISISXDIA
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LABFAB_ANALISISXDIA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarLABFAB_ANALISISXDIA(ByVal aEntidad As LABFAB_ANALISISXDIA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
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
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarLABFAB_ANALISISXDIA(ByVal ID_ANALISISXDIA As Int32, ByVal ID_DIAZAFRA As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal ID_ANALISIS As Int32, ByVal NO_ANALISIS As Int32, ByVal VALOR As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New LABFAB_ANALISISXDIA
            lEntidad.ID_ANALISISXDIA = ID_ANALISISXDIA
            lEntidad.ID_DIAZAFRA = ID_DIAZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.ID_ANALISIS = ID_ANALISIS
            lEntidad.NO_ANALISIS = NO_ANALISIS
            lEntidad.VALOR = VALOR
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarLABFAB_ANALISISXDIA(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLABFAB_ANALISISXDIA(ByVal ID_ANALISISXDIA As Int32, ByVal ID_DIAZAFRA As Int32, ByVal ID_ZAFRA As Int32, ByVal DIAZAFRA As Int32, ByVal ID_ANALISIS As Int32, ByVal NO_ANALISIS As Int32, ByVal VALOR As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New LABFAB_ANALISISXDIA
            lEntidad.ID_ANALISISXDIA = ID_ANALISISXDIA
            lEntidad.ID_DIAZAFRA = ID_DIAZAFRA
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.DIAZAFRA = DIAZAFRA
            lEntidad.ID_ANALISIS = ID_ANALISIS
            lEntidad.NO_ANALISIS = NO_ANALISIS
            lEntidad.VALOR = VALOR
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarLABFAB_ANALISISXDIA(lEntidad)
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
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(asColumnaOrden, asTipoOrden)
        Catch ex As Exception
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
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByRef ds As DataSet, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ds, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla LABFAB_DIAZAFRA .
    ''' </summary>
    ''' <param name="ID_DIAZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLABFAB_DIAZAFRA(ByVal ID_DIAZAFRA As Int32, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As ListaLABFAB_ANALISISXDIA
        Try
            Dim mListaLABFAB_ANALISISXDIA As New ListaLABFAB_ANALISISXDIA
            mListaLABFAB_ANALISISXDIA = mDb.ObtenerListaPorLABFAB_DIAZAFRA(ID_DIAZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaLABFAB_ANALISISXDIA Is Nothing And recuperarForaneas Then
                For Each lEntidad As LABFAB_ANALISISXDIA In mListaLABFAB_ANALISISXDIA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLABFAB_ANALISISXDIA
            If Not mListaLABFAB_ANALISISXDIA Is Nothing Then
                For Each lEntidad As LABFAB_ANALISISXDIA In mListaLABFAB_ANALISISXDIA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaLABFAB_ANALISISXDIA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla LABFAB_ANALISIS .
    ''' </summary>
    ''' <param name="ID_ANALISIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLABFAB_ANALISIS(ByVal ID_ANALISIS As Int32, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As ListaLABFAB_ANALISISXDIA
        Try
            Dim mListaLABFAB_ANALISISXDIA As New ListaLABFAB_ANALISISXDIA
            mListaLABFAB_ANALISISXDIA = mDb.ObtenerListaPorLABFAB_ANALISIS(ID_ANALISIS, asColumnaOrden, asTipoOrden)
            If Not mListaLABFAB_ANALISISXDIA Is Nothing And recuperarForaneas Then
                For Each lEntidad As LABFAB_ANALISISXDIA In mListaLABFAB_ANALISISXDIA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLABFAB_ANALISISXDIA
            If Not mListaLABFAB_ANALISISXDIA Is Nothing Then
                For Each lEntidad As LABFAB_ANALISISXDIA In mListaLABFAB_ANALISISXDIA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaLABFAB_ANALISISXDIA
        Catch ex As Exception
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
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As LABFAB_ANALISISXDIA)
        aEntidad.fkID_DIAZAFRA = (New cLABFAB_DIAZAFRA).ObtenerLABFAB_DIAZAFRA(aEntidad.ID_DIAZAFRA)
        aEntidad.fkID_ANALISIS = (New cLABFAB_ANALISIS).ObtenerLABFAB_ANALISIS(aEntidad.ID_ANALISIS)
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
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As LABFAB_ANALISISXDIA)
    End Sub

#End Region

End Class
