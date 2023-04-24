Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbCANTON
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla CANTON
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/07/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbCANTON
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
    ''' 	[GenApp]	02/07/2014	Created
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
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CANTON
        lEntidad = CType(aEntidad, CANTON)


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
    ''' 	[GenApp]	02/07/2014	Created
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
    ''' Función que Elimina un Registro de la Tabla CANTON que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CANTON que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
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
    ''' 	[GenApp]	02/07/2014	Created
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
                dbAsignarEntidades.AsignarCANTON(dr, CType(aEntidad,CANTON))
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
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As CANTON, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aZONAS As Boolean = False, Optional ByVal aSUB_ZONAS As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aDEPARTAMENTO Or aMUNICIPIO Or aZONAS Or aSUB_ZONAS Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(CANTON), GetType(SqlParameter), strCampos, strWhere, 0, "CANTON")
            strSQL.AppendLine("SELECT " + strCampos)
            If aDEPARTAMENTO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New DEPARTAMENTO, Nothing, GetType(DEPARTAMENTO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMUNICIPIO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MUNICIPIO, Nothing, GetType(MUNICIPIO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aZONAS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ZONAS, Nothing, GetType(ZONAS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSUB_ZONAS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SUB_ZONAS, Nothing, GetType(SUB_ZONAS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM CANTON")
            numTabla = 0
            If aDEPARTAMENTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN DEPARTAMENTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODI_DEPTO = CANTON.CODI_DEPTO")
            End If
            If aMUNICIPIO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MUNICIPIO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODI_MUNI = CANTON.CODI_MUNI")
            End If
            If aZONAS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ZONAS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ZONA = CANTON.ZONA")
            End If
            If aSUB_ZONAS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SUB_ZONAS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".SUB_ZONA = CANTON.SUB_ZONA")
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
                dbAsignarEntidades.AsignarCANTON(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aDEPARTAMENTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarDEPARTAMENTO(dr, aEntidad.fkCODI_DEPTO, "T" + numTabla.ToString())
                End If
                If aMUNICIPIO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMUNICIPIO(dr, aEntidad.fkCODI_MUNI, "T" + numTabla.ToString())
                End If
                If aZONAS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarZONAS(dr, aEntidad.fkZONA, "T" + numTabla.ToString())
                End If
                If aSUB_ZONAS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSUB_ZONAS(dr, aEntidad.fkSUB_ZONA, "T" + numTabla.ToString())
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

        Return -1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCANTON

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CANTON))
        strSQL.Append(" WHERE CODI_DEPTO = @CODI_DEPTO ") 
        strSQL.Append(" AND CODI_MUNI = @CODI_MUNI ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
        args(0).Value = CODI_DEPTO
        args(1) = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
        args(1).Value = CODI_MUNI

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCANTON

        Try
            Do While dr.Read()
                Dim mEntidad As New CANTON
                dbAsignarEntidades.AsignarCANTON(dr, mEntidad)
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
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPresencia(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCANTON

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CANTON))
        strSQL.Append(" WHERE CODI_DEPTO = @CODI_DEPTO ")
        strSQL.Append(" AND CODI_MUNI = @CODI_MUNI ")
        strSQL.Append(" AND EXISTS(SELECT 1 FROM MAESTRO_LOTES M WHERE M.CODI_DEPTO = CANTON.CODI_DEPTO AND M.CODI_MUNI = CANTON.CODI_MUNI AND M.CODI_CANTON = CANTON.CODI_CANTON)")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
        args(0).Value = CODI_DEPTO
        args(1) = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
        args(1).Value = CODI_MUNI

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCANTON

        Try
            Do While dr.Read()
                Dim mEntidad As New CANTON
                dbAsignarEntidades.AsignarCANTON(dr, mEntidad)
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
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CANTON))
        strSQL.Append(" WHERE CODI_DEPTO = @CODI_DEPTO ") 
        strSQL.Append(" AND CODI_MUNI = @CODI_MUNI ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
        args(0).Value = CODI_DEPTO
        args(1) = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
        args(1).Value = CODI_MUNI

        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CANTON))
        strSQL.Append(" WHERE CODI_DEPTO = @CODI_DEPTO ") 
        strSQL.Append(" AND CODI_MUNI = @CODI_MUNI ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
        args(0).Value = CODI_DEPTO
        args(1) = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
        args(1).Value = CODI_MUNI

        Dim tables(0) As String
        tables(0) = New String("CANTON".ToCharArray())

        SqlHelper.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

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
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT CANTON.CODI_CANTON, ")
        strSQL.AppendLine(" CANTON.CODI_DEPTO, ")
        strSQL.AppendLine(" CANTON.CODI_MUNI, ")
        strSQL.AppendLine(" CANTON.NOMBRE_CANTON, ")
        strSQL.AppendLine(" CANTON.KILOMETROS, ")
        strSQL.AppendLine(" CANTON.POSICION_GEO, ")
        strSQL.AppendLine(" CANTON.COORDENADAS, ")
        strSQL.AppendLine(" CANTON.USUARIO_CREA, ")
        strSQL.AppendLine(" CANTON.FECHA_CREA, ")
        strSQL.AppendLine(" CANTON.USUARIO_ACT, ")
        strSQL.AppendLine(" CANTON.FECHA_ACT, ")
        strSQL.AppendLine(" CANTON.ZONA, ")
        strSQL.AppendLine(" CANTON.SUB_ZONA ")
        strSQL.AppendLine(" FROM CANTON ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="CODI_DEPTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODI_DEPTO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCANTON

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CANTON))
        strSQL.Append(" WHERE CODI_DEPTO = @CODI_DEPTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
        args(0).Value = CODI_DEPTO

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCANTON

        Try
            Do While dr.Read()
                Dim mEntidad As New CANTON
                dbAsignarEntidades.AsignarCANTON(dr, mEntidad)
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
    ''' <param name="CODI_DEPTO"></param>
    ''' <param name="CODI_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCANTON

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CANTON))
        strSQL.Append(" WHERE CODI_DEPTO = @CODI_DEPTO ") 
        strSQL.Append(" AND CODI_MUNI = @CODI_MUNI ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@CODI_DEPTO", SqlDbType.VarChar)
        args(0).Value = CODI_DEPTO
        args(1) = New SqlParameter("@CODI_MUNI", SqlDbType.VarChar)
        args(1).Value = CODI_MUNI

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCANTON

        Try
            Do While dr.Read()
                Dim mEntidad As New CANTON
                dbAsignarEntidades.AsignarCANTON(dr, mEntidad)
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
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorZONAS(ByVal ZONA As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCANTON

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CANTON))
        strSQL.Append(" WHERE ZONA = @ZONA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ZONA", SqlDbType.VarChar)
        args(0).Value = ZONA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCANTON

        Try
            Do While dr.Read()
                Dim mEntidad As New CANTON
                dbAsignarEntidades.AsignarCANTON(dr, mEntidad)
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
    ''' <param name="ZONA"></param>
    ''' <param name="SUB_ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/07/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSUB_ZONAS(ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCANTON

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CANTON))
        strSQL.Append(" WHERE ZONA = @ZONA ") 
        strSQL.Append(" AND SUB_ZONA = @SUB_ZONA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ZONA", SqlDbType.VarChar)
        args(0).Value = ZONA
        args(1) = New SqlParameter("@SUB_ZONA", SqlDbType.VarChar)
        args(1).Value = SUB_ZONA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCANTON

        Try
            Do While dr.Read()
                Dim mEntidad As New CANTON
                dbAsignarEntidades.AsignarCANTON(dr, mEntidad)
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
