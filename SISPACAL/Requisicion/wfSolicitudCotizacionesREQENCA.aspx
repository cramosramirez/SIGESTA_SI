﻿<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfSolicitudCotizacionesREQENCA.aspx.vb" Inherits="Requisicion_wfSolicitudCotizacionesREQENCA" %>
<%@ Register Src="~/controlesRequisicion/ucMantREQENCA.ascx" TagName="ucMantREQENCA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantREQENCA id="ucMantREQENCA1"  ETAPA_SIGUIENTE="CotizacionSolicitada" runat="server"></uc1:ucMantREQENCA>
</asp:Content>

