﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantLABFAB_ETAPA.ascx.vb" Inherits="controles_ucMantLABFAB_ETAPA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLABFAB_ETAPA" Src="~/controlesLabFab/ucListaLABFAB_ETAPA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleLABFAB_ETAPA" Src="~/controlesLabFab/ucVistaDetalleLABFAB_ETAPA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Etapas</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaLABFAB_ETAPA id="ucListaLABFAB_ETAPA1" runat="server"></uc1:ucListaLABFAB_ETAPA>
                <uc1:ucVistaDetalleLABFAB_ETAPA ID="ucVistaDetalleLABFAB_ETAPA1" runat="server" Visible="false" ></uc1:ucVistaDetalleLABFAB_ETAPA></TD>
        </TR>
    </TBODY>
</TABLE>
