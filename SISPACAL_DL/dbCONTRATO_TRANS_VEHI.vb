Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbCONTRATO_TRANS_VEHI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla CONTRATO_TRANS_VEHI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbCONTRATO_TRANS_VEHI
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
    ''' 	[GenApp]	25/09/2017	Created
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
    ''' 	[GenApp]	25/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CONTRATO_TRANS_VEHI
        lEntidad = CType(aEntidad, CONTRATO_TRANS_VEHI)

        Dim lID As Int32
        If lEntidad.ID_CONTRA_TRANS_VEHI =  0 _
            Or lEntidad.ID_CONTRA_TRANS_VEHI = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_CONTRA_TRANS_VEHI = lID

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
    ''' 	[GenApp]	25/09/2017	Created
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
    ''' Función que Elimina un Registro de la Tabla CONTRATO_TRANS_VEHI que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_TRANS_VEHI que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2017	Created
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
    ''' 	[GenApp]	25/09/2017	Created
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
                dbAsignarEntidades.AsignarCONTRATO_TRANS_VEHI(dr, CType(aEntidad,CONTRATO_TRANS_VEHI))
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
    ''' 	[GenApp]	25/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As CONTRATO_TRANS_VEHI, Optional ByVal aCONTRATO_TRANS As Boolean = False, Optional ByVal aTRANSPORTE As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aCONTRATO_TRANS Or aTRANSPORTE Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(CONTRATO_TRANS_VEHI), GetType(SqlParameter), strCampos, strWhere, 0, "CONTRATO_TRANS_VEHI")
            strSQL.AppendLine("SELECT " + strCampos)
            If aCONTRATO_TRANS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CONTRATO_TRANS, Nothing, GetType(CONTRATO_TRANS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTRANSPORTE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TRANSPORTE, Nothing, GetType(TRANSPORTE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM CONTRATO_TRANS_VEHI")
            numTabla = 0
            If aCONTRATO_TRANS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CONTRATO_TRANS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CONTRA_TRANS = CONTRATO_TRANS_VEHI.ID_CONTRA_TRANS")
            End If
            If aTRANSPORTE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TRANSPORTE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TRANSPORTE = CONTRATO_TRANS_VEHI.ID_TRANSPORTE")
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
                dbAsignarEntidades.AsignarCONTRATO_TRANS_VEHI(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aCONTRATO_TRANS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCONTRATO_TRANS(dr, aEntidad.fkID_CONTRA_TRANS, "T" + numTabla.ToString())
                End If
                If aTRANSPORTE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTRANSPORTE(dr, aEntidad.fkID_TRANSPORTE, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_CONTRA_TRANS_VEHI),0) + 1 ")
        strSQL.AppendLine(" FROM CONTRATO_TRANS_VEHI ")

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
    ''' 	[GenApp]	25/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCONTRATO_TRANS_VEHI

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTRATO_TRANS_VEHI))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCONTRATO_TRANS_VEHI

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_TRANS_VEHI
                dbAsignarEntidades.AsignarCONTRATO_TRANS_VEHI(dr, mEntidad)
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
    ''' 	[GenApp]	25/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTRATO_TRANS_VEHI))
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
    ''' 	[GenApp]	25/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTRATO_TRANS_VEHI))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("CONTRATO_TRANS_VEHI".ToCharArray())

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
    ''' 	[GenApp]	25/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT CONTRATO_TRANS_VEHI.ID_CONTRA_TRANS_VEHI, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.ID_CONTRA_TRANS, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.ID_TRANSPORTE, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.ID_TIPOTRANS, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.REMOLQUE, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.PLACA, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.CAPACIDAD, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.MARCA, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.ANIO, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.USUARIO_CREA, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.FECHA_CREA, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.USUARIO_ACT, ")
        strSQL.AppendLine(" CONTRATO_TRANS_VEHI.FECHA_ACT ")
        strSQL.AppendLine(" FROM CONTRATO_TRANS_VEHI ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CONTRA_TRANS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCONTRATO_TRANS(ByVal ID_CONTRA_TRANS As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCONTRATO_TRANS_VEHI

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTRATO_TRANS_VEHI))
        strSQL.Append(" WHERE ID_CONTRA_TRANS = @ID_CONTRA_TRANS ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CONTRA_TRANS", SqlDbType.Int)
        args(0).Value = ID_CONTRA_TRANS

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTRATO_TRANS_VEHI

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_TRANS_VEHI
                dbAsignarEntidades.AsignarCONTRATO_TRANS_VEHI(dr, mEntidad)
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
    ''' <param name="ID_TRANSPORTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTRANSPORTE(ByVal ID_TRANSPORTE As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCONTRATO_TRANS_VEHI

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTRATO_TRANS_VEHI))
        strSQL.Append(" WHERE ID_TRANSPORTE = @ID_TRANSPORTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TRANSPORTE", SqlDbType.Int)
        args(0).Value = ID_TRANSPORTE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTRATO_TRANS_VEHI

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_TRANS_VEHI
                dbAsignarEntidades.AsignarCONTRATO_TRANS_VEHI(dr, mEntidad)
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
