﻿<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="wfAsignarRequisicionREQENCA.aspx.vb" Inherits="Requisicion_wfAsignarRequisicionREQENCA" %>
<%@ Register Src="~/controlesRequisicion/ucMantREQENCA.ascx" TagName="ucMantREQENCA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantREQENCA id="ucMantREQENCA1" ETAPA_SIGUIENTE="RequisicionAsignada" runat="server"></uc1:ucMantREQENCA>
</asp:Content>
