﻿<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfEdicionEnvio.aspx.vb" Inherits="Procesos_wfEdicionEnvio" %>
<%@ Register Src="~/controles/ucComprobanteEnvio.ascx" TagName="ucComprobanteEnvio" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <ContentTemplate>    
        <uc1:ucComprobanteEnvio id="ucComprobanteEnvio1"  TIPO_OPERACION="Edicion" runat="server"></uc1:ucComprobanteEnvio>
    </ContentTemplate>     
</asp:Content>

