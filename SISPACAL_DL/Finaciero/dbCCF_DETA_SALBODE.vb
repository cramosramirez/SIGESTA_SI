Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbCCF_DETA_SALBODE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla CCF_DETA_SALBODE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbCCF_DETA_SALBODE
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
    ''' 	[GenApp]	05/09/2017	Created
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
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CCF_DETA_SALBODE
        lEntidad = CType(aEntidad, CCF_DETA_SALBODE)

        Dim lID As Int32
        If lEntidad.ID_CCF_DETA_SAL =  0 _
            Or lEntidad.ID_CCF_DETA_SAL = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_CCF_DETA_SAL = lID

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
    ''' 	[GenApp]	05/09/2017	Created
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
    ''' Función que Elimina un Registro de la Tabla CCF_DETA_SALBODE que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CCF_DETA_SALBODE que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
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
    ''' 	[GenApp]	05/09/2017	Created
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
                dbAsignarEntidades.AsignarCCF_DETA_SALBODE(dr, CType(aEntidad,CCF_DETA_SALBODE))
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
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As CCF_DETA_SALBODE, Optional ByVal aCCF_ENCA As Boolean = False, Optional ByVal aSALBODE_DETA As Boolean = False, Optional ByVal aSOLIC_AGRICOLA As Boolean = False, Optional ByVal aPRODUCTO As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aCCF_ENCA Or aSALBODE_DETA Or aSOLIC_AGRICOLA Or aPRODUCTO Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(CCF_DETA_SALBODE), GetType(SqlParameter), strCampos, strWhere, 0, "CCF_DETA_SALBODE")
            strSQL.AppendLine("SELECT " + strCampos)
            If aCCF_ENCA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CCF_ENCA, Nothing, GetType(CCF_ENCA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSALBODE_DETA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SALBODE_DETA, Nothing, GetType(SALBODE_DETA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSOLIC_AGRICOLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SOLIC_AGRICOLA, Nothing, GetType(SOLIC_AGRICOLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPRODUCTO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PRODUCTO, Nothing, GetType(PRODUCTO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM CCF_DETA_SALBODE")
            numTabla = 0
            If aCCF_ENCA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CCF_ENCA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CCF_ENCA = CCF_DETA_SALBODE.ID_CCF_ENCA")
            End If
            If aSALBODE_DETA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SALBODE_DETA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SALBODE_DETA = CCF_DETA_SALBODE.ID_SALBODE_DETA")
            End If
            If aSOLIC_AGRICOLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SOLIC_AGRICOLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SOLICITUD = CCF_DETA_SALBODE.ID_SOLICITUD")
            End If
            If aPRODUCTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PRODUCTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PRODUCTO = CCF_DETA_SALBODE.ID_PRODUCTO")
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
                dbAsignarEntidades.AsignarCCF_DETA_SALBODE(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aCCF_ENCA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCCF_ENCA(dr, aEntidad.fkID_CCF_ENCA, "T" + numTabla.ToString())
                End If
                If aSALBODE_DETA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSALBODE_DETA(dr, aEntidad.fkID_SALBODE_DETA, "T" + numTabla.ToString())
                End If
                If aSOLIC_AGRICOLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSOLIC_AGRICOLA(dr, aEntidad.fkID_SOLICITUD, "T" + numTabla.ToString())
                End If
                If aPRODUCTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPRODUCTO(dr, aEntidad.fkID_PRODUCTO, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT isnull(max(ID_CCF_DETA_SAL),0) + 1 ")
        strSQL.AppendLine(" FROM CCF_DETA_SALBODE ")

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
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_DETA_SALBODE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_DETA_SALBODE))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCCF_DETA_SALBODE

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_DETA_SALBODE
                dbAsignarEntidades.AsignarCCF_DETA_SALBODE(dr, mEntidad)
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
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_DETA_SALBODE))
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
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_DETA_SALBODE))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("CCF_DETA_SALBODE".ToCharArray())

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
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT CCF_DETA_SALBODE.ID_CCF_DETA_SAL, ")
        strSQL.AppendLine(" CCF_DETA_SALBODE.ID_CCF_ENCA, ")
        strSQL.AppendLine(" CCF_DETA_SALBODE.ID_SALBODE_DETA, ")
        strSQL.AppendLine(" CCF_DETA_SALBODE.ID_SOLICITUD, ")
        strSQL.AppendLine(" CCF_DETA_SALBODE.ID_PRODUCTO, ")
        strSQL.AppendLine(" CCF_DETA_SALBODE.NOMBRE_PRODUCTO, ")
        strSQL.AppendLine(" CCF_DETA_SALBODE.PRESENTACION, ")
        strSQL.AppendLine(" CCF_DETA_SALBODE.CANTIDAD_CCF, ")
        strSQL.AppendLine(" CCF_DETA_SALBODE.PRECIO_UNITARIO_CCF, ")
        strSQL.AppendLine(" CCF_DETA_SALBODE.TOTAL_CCF ")
        strSQL.AppendLine(" FROM CCF_DETA_SALBODE ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CCF_ENCA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCCF_ENCA(ByVal ID_CCF_ENCA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_DETA_SALBODE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_DETA_SALBODE))
        strSQL.Append(" WHERE ID_CCF_ENCA = @ID_CCF_ENCA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CCF_ENCA", SqlDbType.Int)
        args(0).Value = ID_CCF_ENCA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_DETA_SALBODE

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_DETA_SALBODE
                dbAsignarEntidades.AsignarCCF_DETA_SALBODE(dr, mEntidad)
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
    ''' <param name="ID_SALBODE_DETA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSALBODE_DETA(ByVal ID_SALBODE_DETA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_DETA_SALBODE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_DETA_SALBODE))
        strSQL.Append(" WHERE ID_SALBODE_DETA = @ID_SALBODE_DETA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_SALBODE_DETA", SqlDbType.Int)
        args(0).Value = ID_SALBODE_DETA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_DETA_SALBODE

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_DETA_SALBODE
                dbAsignarEntidades.AsignarCCF_DETA_SALBODE(dr, mEntidad)
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
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_DETA_SALBODE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_DETA_SALBODE))
        strSQL.Append(" WHERE ID_SOLICITUD = @ID_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_SOLICITUD", SqlDbType.Int)
        args(0).Value = ID_SOLICITUD

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_DETA_SALBODE

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_DETA_SALBODE
                dbAsignarEntidades.AsignarCCF_DETA_SALBODE(dr, mEntidad)
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
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPRODUCTO(ByVal ID_PRODUCTO As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCCF_DETA_SALBODE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CCF_DETA_SALBODE))
        strSQL.Append(" WHERE ID_PRODUCTO = @ID_PRODUCTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_PRODUCTO", SqlDbType.Int)
        args(0).Value = ID_PRODUCTO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCCF_DETA_SALBODE

        Try
            Do While dr.Read()
                Dim mEntidad As New CCF_DETA_SALBODE
                dbAsignarEntidades.AsignarCCF_DETA_SALBODE(dr, mEntidad)
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
