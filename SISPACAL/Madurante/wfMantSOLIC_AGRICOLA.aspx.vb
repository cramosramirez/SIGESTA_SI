Imports SISPACAL.BL

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : wfMantSOLIC_AGRICOLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de la Página para el Mantenimiento de Registros
''' de la tabla SOLIC_AGRICOLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class wfMantSOLIC_AGRICOLA
    Inherits wfBase

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim bOpcion As New cOPCION
        If Not bOpcion.UsuarioTienePermiso(Me.ObtenerUsuario, Me.NombrePagina) Then Response.Redirect("~/Default.aspx")
    End Sub
End Class
