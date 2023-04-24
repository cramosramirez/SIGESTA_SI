﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucReporteRozaInjiboaRela.ascx.vb" Inherits="controlesCenso_ucReporteRozaInjiboaRela" %>
<%@ Register Src="~/controles/ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>
<%@ Register Src="~/controlesCenso/ucCriteriosRozaInjiboaRela.ascx" TagName="ucCriteriosRozaInjiboaRela" TagPrefix="uc1" %>
<%@ Register Src="~/controlesCenso/ucVisorReporte.ascx" TagName="ucVisorReporte" TagPrefix="uc1" %>

<style type="text/css">     
    .EncabezadoSecciones
        {
            font-size: 16px;            
            color: #3333CC;
            font-family: Calibri;    
        }   
</style>
<table id="TableMant" border="0" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td>
            <uc1:ucBarraNavegacion ID="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
        </td>
    </tr>
    <tr>
        <td align="center" class="EncabezadoSecciones">
            <asp:Label ID="lblTitulo" runat="server" style="Z-INDEX: 101" />
        </td>
    </tr>
    <tr><td><hr /></td></tr>
    <tr>
        <td>
            <uc1:ucCriteriosRozaInjiboaRela ID="ucCriteriosRozaInjiboaRela1" runat="server"></uc1:ucCriteriosRozaInjiboaRela>
        </td>
    </tr>
   <tr>
        <td>
            <uc1:ucVisorReporte ID="ucVisorReporte1" runat="server"></uc1:ucVisorReporte>
        </td>
    </tr>
</table>