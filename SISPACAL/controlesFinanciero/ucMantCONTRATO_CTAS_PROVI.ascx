﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCONTRATO_CTAS_PROVI.ascx.vb" Inherits="controles_ucMantCONTRATO_CTAS_PROVI" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO_CTAS_PROVI" Src="~/controlesFinanciero/ucListaCONTRATO_CTAS_PROVI.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTRATO_CTAS_PROVI" Src="~/controlesFinanciero/ucVistaDetalleCONTRATO_CTAS_PROVI.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Contrato ctas provi</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCONTRATO_CTAS_PROVI id="ucListaCONTRATO_CTAS_PROVI1" runat="server"></uc1:ucListaCONTRATO_CTAS_PROVI>
                <uc1:ucVistaDetalleCONTRATO_CTAS_PROVI ID="ucVistaDetalleCONTRATO_CTAS_PROVI1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTRATO_CTAS_PROVI></TD>
        </TR>
    </TBODY>
</TABLE>
