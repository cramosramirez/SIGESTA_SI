﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleZONAS.ascx.vb" Inherits="controles_ucVistaDetalleZONAS" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trZONA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblZONA" runat="server">Zona:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtZONA" runat="server" Width="70px" MaxLength="2"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESCRIP_ZONA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESCRIP_ZONA" runat="server">Descrip zona:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtDESCRIP_ZONA" runat="server" Width="100px" MaxLength="30"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSER_CREA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSER_CREA" runat="server">User crea:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtUSER_CREA" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorUSER_CREA" runat="server" ControlToValidate="txtUSER_CREA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^[+]?\d*$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CREA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_CREA" runat="server">Fecha crea:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_CREA" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
         <asp:Label CssClass="Normal" id="lblFECHA_CREAFormato" runat="server" >(dd/mm/yyyy)</asp:Label>
         <asp:RegularExpressionValidator id="revFECHA_CREA" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
         ErrorMessage="FECHA_CREA tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtFECHA_CREA"
         Display="Dynamic"></asp:RegularExpressionValidator>

</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSER_ACT">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSER_ACT" runat="server">User act:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtUSER_ACT" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorUSER_ACT" runat="server" ControlToValidate="txtUSER_ACT"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^[+]?\d*$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_ACT">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_ACT" runat="server">Fecha act:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_ACT" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
         <asp:Label CssClass="Normal" id="lblFECHA_ACTFormato" runat="server" >(dd/mm/yyyy)</asp:Label>
         <asp:RegularExpressionValidator id="revFECHA_ACT" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
         ErrorMessage="FECHA_ACT tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtFECHA_ACT"
         Display="Dynamic"></asp:RegularExpressionValidator>

</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
