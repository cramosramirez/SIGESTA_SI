﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantENVIO.ascx.vb" Inherits="controles_ucMantENVIO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaENVIO" Src="~/controles/ucListaENVIO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleENVIO" Src="~/controles/ucVistaDetalleENVIO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Envio</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaENVIO id="ucListaENVIO1" runat="server"></uc1:ucListaENVIO>
                <uc1:ucVistaDetalleENVIO ID="ucVistaDetalleENVIO1" runat="server" Visible="false" ></uc1:ucVistaDetalleENVIO></TD>
        </TR>
    </TBODY>
</TABLE>
