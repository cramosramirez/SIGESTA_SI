﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucReporteServiciosEsp.ascx.vb" Inherits="controlesFinanciero_ucReporteServiciosEsp" %>
<%@ Register Src="~/controles/ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>
<%@ Register Src="~/controlesFinanciero/ucCriteriosServiciosEsp.ascx" TagName="ucCriteriosServiciosEsp" TagPrefix="uc1" %>
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
            <uc1:ucCriteriosServiciosEsp ID="ucCriteriosServiciosEsp1" runat="server"></uc1:ucCriteriosServiciosEsp>
        </td>
    </tr>
   <tr>
        <td>
            <uc1:ucVisorReporte ID="ucVisorReporte1" runat="server"></uc1:ucVisorReporte>
        </td>
    </tr>
</table>