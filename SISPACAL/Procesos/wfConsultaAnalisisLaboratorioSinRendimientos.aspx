﻿<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfConsultaAnalisisLaboratorioSinRendimientos.aspx.vb" Inherits="Procesos_wfConsultaAnalisisLaboratorioSinRendimientos" %>
<%@ Register Src="~/controles/ucAnalisisLaboratorioCalidad.ascx" TagName="ucAnalisisLaboratorioCalidad" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>    
        <uc1:ucAnalisisLaboratorioCalidad id="ucAnalisisLaboratorioCalidad1" MOSTRAR_RENDIMIENTOS="false" TIPO_OPERACION="Consulta" runat="server"></uc1:ucAnalisisLaboratorioCalidad>    
    </ContentTemplate>                 
    </asp:UpdatePanel>      
</asp:Content>

