<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPROVEEDOR_AGRICOLA.ascx.vb" Inherits="controles_ucMantPROVEEDOR_AGRICOLA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROVEEDOR_AGRICOLA" Src="~/controlesInventario/ucListaPROVEEDOR_AGRICOLA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePROVEEDOR_AGRICOLA" Src="~/controlesInventario/ucVistaDetallePROVEEDOR_AGRICOLA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Proveedor agricola</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPROVEEDOR_AGRICOLA id="ucListaPROVEEDOR_AGRICOLA1" runat="server"></uc1:ucListaPROVEEDOR_AGRICOLA>
                <uc1:ucVistaDetallePROVEEDOR_AGRICOLA ID="ucVistaDetallePROVEEDOR_AGRICOLA1" runat="server" Visible="false" ></uc1:ucVistaDetallePROVEEDOR_AGRICOLA></TD>
        </TR>
    </TBODY>
</TABLE>
