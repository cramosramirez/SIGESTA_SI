Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbANALISIS_PRECOSECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla ANALISIS_PRECOSECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	24/09/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbANALISIS_PRECOSECHA
    Inherits dbBase

#Region " Metodos Generador "

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
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ANALISIS_PRECOSECHA
        lEntidad = CType(aEntidad, ANALISIS_PRECOSECHA)

        Dim lID As Int32
        If lEntidad.ID_ANALISIS_PRE =  0 _
            Or lEntidad.ID_ANALISIS_PRE = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_ANALISIS_PRE = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ANALISIS_PRECOSECHA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ANALISIS_PRECOSECHA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Eliminar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryDelete(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QuerySelect(aEntidad, args))

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarANALISIS_PRECOSECHA(dr, CType(aEntidad,ANALISIS_PRECOSECHA))
            Else
                Return 0
            End If
        Catch ex As Exception 
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Object

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT isnull(max(ID_ANALISIS_PRE),0) + 1 ")
        strSQL.AppendLine(" FROM ANALISIS_PRECOSECHA ")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaANALISIS_PRECOSECHA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ANALISIS_PRECOSECHA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaANALISIS_PRECOSECHA

        Try
            Do While dr.Read()
                Dim mEntidad As New ANALISIS_PRECOSECHA
                dbAsignarEntidades.AsignarANALISIS_PRECOSECHA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ANALISIS_PRECOSECHA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

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
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ANALISIS_PRECOSECHA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("ANALISIS_PRECOSECHA".ToCharArray())

        SqlHelper.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve en el StringBuilder que recibe como parámetro el Query
    ''' de la Tabla de la Clase.
    ''' </summary>
    ''' <param name="strSQL">StringBuilder donde se escribe el Query</param>
    ''' <remarks>
    ''' Obsoleto, se recomienda utilizar los métodos del ancestro para esta operación.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	24/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT ANALISIS_PRECOSECHA.ID_ANALISIS_PRE, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.ACCESLOTE, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.ID_ZAFRA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.NO_ANALISIS, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.FECHA_MUESTRA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.NO_MUESTRA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.AREA_MUESTRA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.BAGAZO_BRUTO, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.BAGAZO_NETO, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.POL, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.BRIX, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.FIBRA_CANA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.HUMEDAD, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.POL_JUGO, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.JUGO_CANA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.POL_CANA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.PUREZA_JUGO, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.PUREZA_AZUCAR, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.SJM, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.RENDIA_CALC1, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.RENDIA_CALC2, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.POL_LECTURA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.PH, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.AZUCAR_REDUCTORES, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.CANT_JUGO_ML, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.VOL_TITULANTE, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.OBSERVACION, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.ALMIDON_JUGO, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.ACIDEZ_JUGO, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.ABSORVANCIA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.DEXTRANA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.USUARIO_LEE_BAGAZO_BRUTO, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.FECHA_LEE_BAGAZO_BRUTO, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.USUARIO_LEE_BAGAZO_TARA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.FECHA_LEE_BAGAZO_TARA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.USUARIO_LEE_POL, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.FECHA_LEE_POL, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.USUARIO_LEE_BRIX, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.FECHA_LEE_BRIX, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.USUARIO_CREA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.FECHA_CREA, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.USUARIO_ACT, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.FECHA_CT, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.BRIX_DILU, ")
        strSQL.AppendLine(" ANALISIS_PRECOSECHA.ABSORBANCIA_ALMIDON ")
        strSQL.AppendLine(" FROM ANALISIS_PRECOSECHA ")

    End Sub

#Region "Obtener Listas Por Foraneas"
#End Region

#End Region

End Class
