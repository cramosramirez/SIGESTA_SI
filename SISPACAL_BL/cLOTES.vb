''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cLOTES
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla LOTES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/01/2020	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cLOTES
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbLOTES()
    Private mEntidad as New LOTES
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES
        Try
            Dim mListaLOTES As New ListaLOTES
            mListaLOTES = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaLOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLOTES
            If Not mListaLOTES Is Nothing Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaLOTES
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLOTES(ByRef aEntidad As LOTES, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla LOTES.
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLOTES(ByVal ACCESLOTE As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As LOTES
        Try
            Dim lEntidad As New LOTES
            lEntidad.ACCESLOTE = ACCESLOTE
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
    ''' <param name="aPROVEEDOR">Recuperar registro foraneo de la Entidad PROVEEDOR.</param>
    ''' <param name="aAGRONOMO">Recuperar registro foraneo de la Entidad AGRONOMO.</param>
    ''' <param name="aVARIEDAD">Recuperar registro foraneo de la Entidad VARIEDAD.</param>
    ''' <param name="aUBICACION">Recuperar registro foraneo de la Entidad UBICACION.</param>
    ''' <param name="aCONTRATO">Recuperar registro foraneo de la Entidad CONTRATO.</param>
    ''' <param name="aMAESTRO_LOTES">Recuperar registro foraneo de la Entidad MAESTRO_LOTES.</param>
    ''' <param name="aLOTES_TRASPASO">Recuperar registro foraneo de la Entidad LOTES_TRASPASO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerLOTESConForaneas(ByVal aEntidad As LOTES, Optional ByVal aPROVEEDOR As Boolean = False, Optional ByVal aAGRONOMO As Boolean = False, Optional ByVal aVARIEDAD As Boolean = False, Optional ByVal aUBICACION As Boolean = False, Optional ByVal aCONTRATO As Boolean = False, Optional ByVal aMAESTRO_LOTES As Boolean = False, Optional ByVal aLOTES_TRASPASO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPROVEEDOR, aAGRONOMO, aVARIEDAD, aUBICACION, aCONTRATO, aMAESTRO_LOTES, aLOTES_TRASPASO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LOTES que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarLOTES(ByVal ACCESLOTE As String) As Integer
        Try
            mEntidad.ACCESLOTE = ACCESLOTE
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla LOTES que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarLOTES(ByVal aEntidad As LOTES, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarLOTES(ByVal ACCESLOTE As String, ByVal ANIOZAFRA As String, ByVal CODIPROVEEDOR As String, ByVal CODILOTE As String, ByVal CODIAGRON As String, ByVal CODIVARIEDA As String, ByVal CODIUBICACION As String, ByVal CODICONTRATO As String, ByVal NOMBLOTE As String, ByVal AREA As Decimal, ByVal TONELADAS As Decimal, ByVal TONEL_TC As Decimal, ByVal ZONA As String, ByVal EDAD_LOTE As Decimal, ByVal USER_CREA As Int32, ByVal FECHA_CREA As DateTime, ByVal USER_ACT As Int32, ByVal FECHA_ACT As DateTime, ByVal ID_MAESTRO As Int32, ByVal TIPO_DERECHO As Int32, ByVal SUB_ZONA As String, ByVal ID_LOTE_TRASPASO As Int32, ByVal AREA_CANA As Decimal, ByVal RIESGO_PIEDRA As Boolean, ByVal REPARA_ACCESO As Boolean, ByVal SIN_ACCESO_PROPIO As Boolean) As Integer
        Try
            Dim lEntidad As New LOTES
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.ANIOZAFRA = ANIOZAFRA
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.CODILOTE = CODILOTE
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.CODIVARIEDA = CODIVARIEDA
            lEntidad.CODIUBICACION = CODIUBICACION
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.NOMBLOTE = NOMBLOTE
            lEntidad.AREA = AREA
            lEntidad.TONELADAS = TONELADAS
            lEntidad.TONEL_TC = TONEL_TC
            lEntidad.ZONA = ZONA
            lEntidad.EDAD_LOTE = EDAD_LOTE
            lEntidad.USER_CREA = USER_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USER_ACT = USER_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_MAESTRO = ID_MAESTRO
            lEntidad.TIPO_DERECHO = TIPO_DERECHO
            lEntidad.SUB_ZONA = SUB_ZONA
            lEntidad.ID_LOTE_TRASPASO = ID_LOTE_TRASPASO
            lEntidad.AREA_CANA = AREA_CANA
            lEntidad.RIESGO_PIEDRA = RIESGO_PIEDRA
            lEntidad.REPARA_ACCESO = REPARA_ACCESO
            lEntidad.SIN_ACCESO_PROPIO = SIN_ACCESO_PROPIO
            Return Me.AgregarLOTES(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarLOTES(ByVal aEntidad As LOTES) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLOTES(ByVal ACCESLOTE As String, ByVal ANIOZAFRA As String, ByVal CODIPROVEEDOR As String, ByVal CODILOTE As String, ByVal CODIAGRON As String, ByVal CODIVARIEDA As String, ByVal CODIUBICACION As String, ByVal CODICONTRATO As String, ByVal NOMBLOTE As String, ByVal AREA As Decimal, ByVal TONELADAS As Decimal, ByVal TONEL_TC As Decimal, ByVal ZONA As String, ByVal EDAD_LOTE As Decimal, ByVal USER_CREA As Int32, ByVal FECHA_CREA As DateTime, ByVal USER_ACT As Int32, ByVal FECHA_ACT As DateTime, ByVal ID_MAESTRO As Int32, ByVal TIPO_DERECHO As Int32, ByVal SUB_ZONA As String, ByVal ID_LOTE_TRASPASO As Int32, ByVal AREA_CANA As Decimal, ByVal RIESGO_PIEDRA As Boolean, ByVal REPARA_ACCESO As Boolean, ByVal SIN_ACCESO_PROPIO As Boolean) As Integer
        Try
            Dim lEntidad As New LOTES
            lEntidad.ACCESLOTE = ACCESLOTE
            lEntidad.ANIOZAFRA = ANIOZAFRA
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.CODILOTE = CODILOTE
            lEntidad.CODIAGRON = CODIAGRON
            lEntidad.CODIVARIEDA = CODIVARIEDA
            lEntidad.CODIUBICACION = CODIUBICACION
            lEntidad.CODICONTRATO = CODICONTRATO
            lEntidad.NOMBLOTE = NOMBLOTE
            lEntidad.AREA = AREA
            lEntidad.TONELADAS = TONELADAS
            lEntidad.TONEL_TC = TONEL_TC
            lEntidad.ZONA = ZONA
            lEntidad.EDAD_LOTE = EDAD_LOTE
            lEntidad.USER_CREA = USER_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USER_ACT = USER_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ID_MAESTRO = ID_MAESTRO
            lEntidad.TIPO_DERECHO = TIPO_DERECHO
            lEntidad.SUB_ZONA = SUB_ZONA
            lEntidad.ID_LOTE_TRASPASO = ID_LOTE_TRASPASO
            lEntidad.AREA_CANA = AREA_CANA
            lEntidad.RIESGO_PIEDRA = RIESGO_PIEDRA
            lEntidad.REPARA_ACCESO = REPARA_ACCESO
            lEntidad.SIN_ACCESO_PROPIO = SIN_ACCESO_PROPIO
            Return Me.ActualizarLOTES(lEntidad)
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
    ''' 	[GenApp]	02/01/2020	Created
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
    ''' 	[GenApp]	02/01/2020	Created
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
    ''' la Tabla PROVEEDOR .
    ''' </summary>
    ''' <param name="CODIPROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES
        Try
            Dim mListaLOTES As New ListaLOTES
            mListaLOTES = mDb.ObtenerListaPorPROVEEDOR(CODIPROVEEDOR, asColumnaOrden, asTipoOrden)
            If Not mListaLOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLOTES
            If Not mListaLOTES Is Nothing Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaLOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla AGRONOMO .
    ''' </summary>
    ''' <param name="CODIAGRON"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorAGRONOMO(ByVal CODIAGRON As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES
        Try
            Dim mListaLOTES As New ListaLOTES
            mListaLOTES = mDb.ObtenerListaPorAGRONOMO(CODIAGRON, asColumnaOrden, asTipoOrden)
            If Not mListaLOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLOTES
            If Not mListaLOTES Is Nothing Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaLOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla VARIEDAD .
    ''' </summary>
    ''' <param name="CODIVARIEDA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorVARIEDAD(ByVal CODIVARIEDA As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES
        Try
            Dim mListaLOTES As New ListaLOTES
            mListaLOTES = mDb.ObtenerListaPorVARIEDAD(CODIVARIEDA, asColumnaOrden, asTipoOrden)
            If Not mListaLOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLOTES
            If Not mListaLOTES Is Nothing Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaLOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla UBICACION .
    ''' </summary>
    ''' <param name="CODIUBICACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUBICACION(ByVal CODIUBICACION As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES
        Try
            Dim mListaLOTES As New ListaLOTES
            mListaLOTES = mDb.ObtenerListaPorUBICACION(CODIUBICACION, asColumnaOrden, asTipoOrden)
            If Not mListaLOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLOTES
            If Not mListaLOTES Is Nothing Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaLOTES
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO(ByVal CODICONTRATO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES
        Try
            Dim mListaLOTES As New ListaLOTES
            mListaLOTES = mDb.ObtenerListaPorCONTRATO(CODICONTRATO, asColumnaOrden, asTipoOrden)
            If Not mListaLOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLOTES
            If Not mListaLOTES Is Nothing Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaLOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MAESTRO_LOTES .
    ''' </summary>
    ''' <param name="ID_MAESTRO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMAESTRO_LOTES(ByVal ID_MAESTRO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES
        Try
            Dim mListaLOTES As New ListaLOTES
            mListaLOTES = mDb.ObtenerListaPorMAESTRO_LOTES(ID_MAESTRO, asColumnaOrden, asTipoOrden)
            If Not mListaLOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLOTES
            If Not mListaLOTES Is Nothing Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaLOTES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla LOTES_TRASPASO .
    ''' </summary>
    ''' <param name="ID_LOTE_TRASPASO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorLOTES_TRASPASO(ByVal ID_LOTE_TRASPASO As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaLOTES
        Try
            Dim mListaLOTES As New ListaLOTES
            mListaLOTES = mDb.ObtenerListaPorLOTES_TRASPASO(ID_LOTE_TRASPASO, asColumnaOrden, asTipoOrden)
            If Not mListaLOTES Is Nothing And recuperarForaneas Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaLOTES
            If Not mListaLOTES Is Nothing Then
                For Each lEntidad As LOTES in  mListaLOTES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaLOTES
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As LOTES )
        aEntidad.fkCODIPROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(aEntidad.CODIPROVEEDOR)
        aEntidad.fkCODIAGRON = (New cAGRONOMO).ObtenerAGRONOMO(aEntidad.CODIAGRON)
        aEntidad.fkCODIVARIEDA = (New cVARIEDAD).ObtenerVARIEDAD(aEntidad.CODIVARIEDA)
        aEntidad.fkCODIUBICACION = (New cUBICACION).ObtenerUBICACION(aEntidad.CODIUBICACION)
        aEntidad.fkCODICONTRATO = (New cCONTRATO).ObtenerCONTRATO(aEntidad.CODICONTRATO)
        aEntidad.fkID_MAESTRO = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(aEntidad.ID_MAESTRO)
        aEntidad.fkID_LOTE_TRASPASO = (New cLOTES_TRASPASO).ObtenerLOTES_TRASPASO(aEntidad.ID_LOTE_TRASPASO)
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
    ''' 	[GenApp]	02/01/2020	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As LOTES )
    End Sub

#End Region

End Class
