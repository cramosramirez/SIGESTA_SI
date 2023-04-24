Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbORDEN_COMBUSTIBLE_AUTORIZACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla ORDEN_COMBUSTIBLE_AUTORIZACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/02/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbORDEN_COMBUSTIBLE_AUTORIZACION
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
    ''' 	[GenApp]	25/02/2014	Created
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
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ORDEN_COMBUSTIBLE_AUTORIZACION
        lEntidad = CType(aEntidad, ORDEN_COMBUSTIBLE_AUTORIZACION)

        Dim lID As Int32
        If lEntidad.ID_ORDEN_COMBUS_AUTO =  0 _
            Or lEntidad.ID_ORDEN_COMBUS_AUTO = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_ORDEN_COMBUS_AUTO = lID

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
    ''' 	[GenApp]	25/02/2014	Created
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
    ''' Función que Elimina un Registro de la Tabla ORDEN_COMBUSTIBLE_AUTORIZACION que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ORDEN_COMBUSTIBLE_AUTORIZACION que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
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
    ''' 	[GenApp]	25/02/2014	Created
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
                dbAsignarEntidades.AsignarORDEN_COMBUSTIBLE_AUTORIZACION(dr, CType(aEntidad,ORDEN_COMBUSTIBLE_AUTORIZACION))
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As ORDEN_COMBUSTIBLE_AUTORIZACION, Optional ByVal aTIPO_PROVEEDOR As Boolean = False, Optional ByVal aORDEN_COMBUSTIBLE As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aTIPO_PROVEEDOR Or aORDEN_COMBUSTIBLE Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(ORDEN_COMBUSTIBLE_AUTORIZACION), GetType(SqlParameter), strCampos, strWhere, 0, "ORDEN_COMBUSTIBLE_AUTORIZACION")
            strSQL.AppendLine("SELECT " + strCampos)
            If aTIPO_PROVEEDOR Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_PROVEEDOR, Nothing, GetType(TIPO_PROVEEDOR), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aORDEN_COMBUSTIBLE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ORDEN_COMBUSTIBLE, Nothing, GetType(ORDEN_COMBUSTIBLE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM ORDEN_COMBUSTIBLE_AUTORIZACION")
            numTabla = 0
            If aTIPO_PROVEEDOR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_PROVEEDOR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_PROVEEDOR = ORDEN_COMBUSTIBLE_AUTORIZACION.ID_TIPO_PROVEEDOR")
            End If
            If aORDEN_COMBUSTIBLE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ORDEN_COMBUSTIBLE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ORDEN_COMBUS = ORDEN_COMBUSTIBLE_AUTORIZACION.ID_ORDEN_COMBUS")
            End If
            strSQL.Append(strWhere)
        Else
            strSQL.Append(Me.QuerySelect(aEntidad, args))
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarORDEN_COMBUSTIBLE_AUTORIZACION(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aTIPO_PROVEEDOR Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_PROVEEDOR(dr, aEntidad.fkID_TIPO_PROVEEDOR, "T" + numTabla.ToString())
                End If
                If aORDEN_COMBUSTIBLE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarORDEN_COMBUSTIBLE(dr, aEntidad.fkID_ORDEN_COMBUS, "T" + numTabla.ToString())
                End If
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
        strSQL.AppendLine("SELECT isnull(max(ID_ORDEN_COMBUS_AUTO),0) + 1 ")
        strSQL.AppendLine(" FROM ORDEN_COMBUSTIBLE_AUTORIZACION ")

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
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaORDEN_COMBUSTIBLE_AUTORIZACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ORDEN_COMBUSTIBLE_AUTORIZACION))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaORDEN_COMBUSTIBLE_AUTORIZACION

        Try
            Do While dr.Read()
                Dim mEntidad As New ORDEN_COMBUSTIBLE_AUTORIZACION
                dbAsignarEntidades.AsignarORDEN_COMBUSTIBLE_AUTORIZACION(dr, mEntidad)
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
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ORDEN_COMBUSTIBLE_AUTORIZACION))
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
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ORDEN_COMBUSTIBLE_AUTORIZACION))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("ORDEN_COMBUSTIBLE_AUTORIZACION".ToCharArray())

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
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT ORDEN_COMBUSTIBLE_AUTORIZACION.ID_ORDEN_COMBUS_AUTO, ")
        strSQL.AppendLine(" ORDEN_COMBUSTIBLE_AUTORIZACION.CODIGO, ")
        strSQL.AppendLine(" ORDEN_COMBUSTIBLE_AUTORIZACION.ID_TIPO_PROVEEDOR, ")
        strSQL.AppendLine(" ORDEN_COMBUSTIBLE_AUTORIZACION.ID_ORDEN_COMBUS, ")
        strSQL.AppendLine(" ORDEN_COMBUSTIBLE_AUTORIZACION.AUTORIZACION_APLICADA, ")
        strSQL.AppendLine(" ORDEN_COMBUSTIBLE_AUTORIZACION.USUARIO_CREA, ")
        strSQL.AppendLine(" ORDEN_COMBUSTIBLE_AUTORIZACION.FECHA_CREA, ")
        strSQL.AppendLine(" ORDEN_COMBUSTIBLE_AUTORIZACION.USUARIO_ACT, ")
        strSQL.AppendLine(" ORDEN_COMBUSTIBLE_AUTORIZACION.FECHA_ACT ")
        strSQL.AppendLine(" FROM ORDEN_COMBUSTIBLE_AUTORIZACION ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_TIPO_PROVEEDOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_PROVEEDOR(ByVal ID_TIPO_PROVEEDOR As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaORDEN_COMBUSTIBLE_AUTORIZACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ORDEN_COMBUSTIBLE_AUTORIZACION))
        strSQL.Append(" WHERE ID_TIPO_PROVEEDOR = @ID_TIPO_PROVEEDOR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_PROVEEDOR", SqlDbType.Int)
        args(0).Value = ID_TIPO_PROVEEDOR

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaORDEN_COMBUSTIBLE_AUTORIZACION

        Try
            Do While dr.Read()
                Dim mEntidad As New ORDEN_COMBUSTIBLE_AUTORIZACION
                dbAsignarEntidades.AsignarORDEN_COMBUSTIBLE_AUTORIZACION(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ORDEN_COMBUS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/02/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorORDEN_COMBUSTIBLE(ByVal ID_ORDEN_COMBUS As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaORDEN_COMBUSTIBLE_AUTORIZACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ORDEN_COMBUSTIBLE_AUTORIZACION))
        strSQL.Append(" WHERE ID_ORDEN_COMBUS = @ID_ORDEN_COMBUS ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_ORDEN_COMBUS", SqlDbType.Int)
        args(0).Value = ID_ORDEN_COMBUS

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaORDEN_COMBUSTIBLE_AUTORIZACION

        Try
            Do While dr.Read()
                Dim mEntidad As New ORDEN_COMBUSTIBLE_AUTORIZACION
                dbAsignarEntidades.AsignarORDEN_COMBUSTIBLE_AUTORIZACION(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

#End Region

#End Region

End Class
