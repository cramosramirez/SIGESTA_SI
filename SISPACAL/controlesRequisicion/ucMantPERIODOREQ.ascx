﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPERIODOREQ.ascx.vb" Inherits="controles_ucMantPERIODOREQ" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPERIODOREQ" Src="~/controlesRequisicion/ucListaPERIODOREQ.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePERIODOREQ" Src="~/controlesRequisicion/ucVistaDetallePERIODOREQ.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Periodoreq</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPERIODOREQ id="ucListaPERIODOREQ1" runat="server"></uc1:ucListaPERIODOREQ>
                <uc1:ucVistaDetallePERIODOREQ ID="ucVistaDetallePERIODOREQ1" runat="server" Visible="false" ></uc1:ucVistaDetallePERIODOREQ></TD>
        </TR>
    </TBODY>
</TABLE>
