﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSUPERVISOR.ascx.vb" Inherits="controles_ucMantSUPERVISOR" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSUPERVISOR" Src="~/controles/ucListaSUPERVISOR.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSUPERVISOR" Src="~/controles/ucVistaDetalleSUPERVISOR.ascx" %>
<style type="text/css">  
    div.centraTabla
    {
        font-size: small;     
        font-family: Tahoma;                   	
        text-align: center;
        padding-bottom: 15px; 
        padding-top: 10px;
        padding-left: 15px;
        padding-right: 15px 
    }

    div.centraTabla table {
        margin: 0 auto;
        text-align: left;
    }    
</style>
<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<div class="centraTabla">  
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>	       
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Supervisor</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaSUPERVISOR id="ucListaSUPERVISOR1" runat="server"></uc1:ucListaSUPERVISOR>
                <uc1:ucVistaDetalleSUPERVISOR ID="ucVistaDetalleSUPERVISOR1" runat="server" Visible="false" 
                 VerUSUARIO_CREA = "false" 
                 VerFECHA_CREA  = "false" 
                 VerUSUARIO_ACT = "false" 
                 VerFECHA_ACT = "false" 
                /></TD>
        </TR>
    </TBODY>
</TABLE>
</div>
