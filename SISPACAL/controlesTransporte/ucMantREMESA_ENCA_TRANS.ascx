﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantREMESA_ENCA_TRANS.ascx.vb" Inherits="controles_ucMantREMESA_ENCA_TRANS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaREMESA_ENCA_TRANS" Src="~/controlesTransporte/ucListaREMESA_ENCA_TRANS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleREMESA_ENCA_TRANS" Src="~/controlesTransporte/ucVistaDetalleREMESA_ENCA_TRANS.ascx" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<dx:ASPxCallbackPanel ID="cpMantREMESA_ENCA_TRANS" ClientInstanceName="cpMantREMESA_ENCA_TRANS" runat="server" ShowLoadingPanel="false" Width="100%" >
<SettingsLoadingPanel Enabled="False"></SettingsLoadingPanel>
    <ClientSideEvents EndCallback="OnEndCallback" ></ClientSideEvents>
    <PanelCollection>
        <dx:PanelContent ID="PanelContent6" runat="server">  
            <TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
                <TBODY>
	                   <TR>
			               <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
                    </TR>
		               <TR>
		                   <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Remesa enca trans</asp:Label></TD>
		               </TR>
		               <TR>
			               <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		               </TR>
	                   <TR>
                        <TD><uc1:ucListaREMESA_ENCA_TRANS id="ucListaREMESA_ENCA_TRANS1" runat="server"></uc1:ucListaREMESA_ENCA_TRANS>
                            <uc1:ucVistaDetalleREMESA_ENCA_TRANS ID="ucVistaDetalleREMESA_ENCA_TRANS1" runat="server" Visible="false" ></uc1:ucVistaDetalleREMESA_ENCA_TRANS></TD>
                    </TR>
                </TBODY>
            </TABLE>
    </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
