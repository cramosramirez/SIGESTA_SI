Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbCREDITO_MOV_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla CREDITO_MOV_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/11/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbCREDITO_MOV_TRANS
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
    ''' 	[GenApp]	15/11/2017	Created
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
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CREDITO_MOV_TRANS
        lEntidad = CType(aEntidad, CREDITO_MOV_TRANS)

        Dim lID As Int32
        If lEntidad.ID_CREDITO_MOV =  0 _
            Or lEntidad.ID_CREDITO_MOV = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_CREDITO_MOV = lID

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
    ''' 	[GenApp]	15/11/2017	Created
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
    ''' Función que Elimina un Registro de la Tabla CREDITO_MOV_TRANS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CREDITO_MOV_TRANS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2017	Created
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
    ''' 	[GenApp]	15/11/2017	Created
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
                dbAsignarEntidades.AsignarCREDITO_MOV_TRANS(dr, CType(aEntidad,CREDITO_MOV_TRANS))
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
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As CREDITO_MOV_TRANS, Optional ByVal aCREDITO_ENCA_TRANS As Boolean = False, Optional ByVal aCATORCENA_ZAFRA As Boolean = False, Optional ByVal aPLANILLA_BASE As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aCREDITO_ENCA_TRANS Or aCATORCENA_ZAFRA Or aPLANILLA_BASE Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(CREDITO_MOV_TRANS), GetType(SqlParameter), strCampos, strWhere, 0, "CREDITO_MOV_TRANS")
            strSQL.AppendLine("SELECT " + strCampos)
            If aCREDITO_ENCA_TRANS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CREDITO_ENCA_TRANS, Nothing, GetType(CREDITO_ENCA_TRANS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCATORCENA_ZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CATORCENA_ZAFRA, Nothing, GetType(CATORCENA_ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPLANILLA_BASE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PLANILLA_BASE, Nothing, GetType(PLANILLA_BASE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM CREDITO_MOV_TRANS")
            numTabla = 0
            If aCREDITO_ENCA_TRANS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CREDITO_ENCA_TRANS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CREDITO_ENCA = CREDITO_MOV_TRANS.ID_CREDITO_ENCA")
            End If
            If aCATORCENA_ZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CATORCENA_ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CATORCENA = CREDITO_MOV_TRANS.ID_CATORCENA AND T" + numTabla.ToString() + ".ID_CATORCENA = CREDITO_MOV_TRANS.ID_CATORCENA_VTO")
            End If
            If aPLANILLA_BASE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PLANILLA_BASE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PLANILLA_BASE = CREDITO_MOV_TRANS.ID_PLANILLA_BASE")
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
                dbAsignarEntidades.AsignarCREDITO_MOV_TRANS(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aCREDITO_ENCA_TRANS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCREDITO_ENCA_TRANS(dr, aEntidad.fkID_CREDITO_ENCA, "T" + numTabla.ToString())
                End If
                If aCATORCENA_ZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCATORCENA_ZAFRA(dr, aEntidad.fkID_CATORCENA, "T" + numTabla.ToString())
                End If
                If aPLANILLA_BASE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPLANILLA_BASE(dr, aEntidad.fkID_PLANILLA_BASE, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_CREDITO_MOV),0) + 1 ")
        strSQL.AppendLine(" FROM CREDITO_MOV_TRANS ")

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
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCREDITO_MOV_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CREDITO_MOV_TRANS))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCREDITO_MOV_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CREDITO_MOV_TRANS
                dbAsignarEntidades.AsignarCREDITO_MOV_TRANS(dr, mEntidad)
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
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CREDITO_MOV_TRANS))
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
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CREDITO_MOV_TRANS))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("CREDITO_MOV_TRANS".ToCharArray())

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
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT CREDITO_MOV_TRANS.ID_CREDITO_MOV, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.ID_CREDITO_ENCA, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.FECHA, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.UID_REFERENCIA, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.ID_CATORCENA, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.CARGO, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.ABONO, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.SALDO, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.ABONO_IVA, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.ABONO_INTERES, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.ABONO_INTERES_IVA, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.USUARIO_CREA, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.FECHA_CREA, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.USUARIO_ACT, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.FECHA_ACT, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.CODIBANCO, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.NO_DOCUMENTO, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.FECHA_ULTMOV, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.TASAINT, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.SALDO_INICIAL, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.TIPO_INTERES, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.PLAZO_DIAS, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.ID_PLANILLA_BASE, ")
        strSQL.AppendLine(" CREDITO_MOV_TRANS.ID_CATORCENA_VTO ")
        strSQL.AppendLine(" FROM CREDITO_MOV_TRANS ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CREDITO_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCREDITO_ENCA_TRANS(ByVal ID_CREDITO_ENCA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCREDITO_MOV_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CREDITO_MOV_TRANS))
        strSQL.Append(" WHERE ID_CREDITO_ENCA = @ID_CREDITO_ENCA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CREDITO_ENCA", SqlDbType.Int)
        args(0).Value = ID_CREDITO_ENCA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCREDITO_MOV_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CREDITO_MOV_TRANS
                dbAsignarEntidades.AsignarCREDITO_MOV_TRANS(dr, mEntidad)
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
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCREDITO_MOV_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CREDITO_MOV_TRANS))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCREDITO_MOV_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CREDITO_MOV_TRANS
                dbAsignarEntidades.AsignarCREDITO_MOV_TRANS(dr, mEntidad)
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
    ''' <param name="ID_PLANILLA_BASE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPLANILLA_BASE(ByVal ID_PLANILLA_BASE As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCREDITO_MOV_TRANS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CREDITO_MOV_TRANS))
        strSQL.Append(" WHERE ID_PLANILLA_BASE = @ID_PLANILLA_BASE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PLANILLA_BASE", SqlDbType.Int)
        args(0).Value = ID_PLANILLA_BASE

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCREDITO_MOV_TRANS

        Try
            Do While dr.Read()
                Dim mEntidad As New CREDITO_MOV_TRANS
                dbAsignarEntidades.AsignarCREDITO_MOV_TRANS(dr, mEntidad)
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
