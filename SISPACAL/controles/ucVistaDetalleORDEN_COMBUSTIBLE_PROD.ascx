﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleORDEN_COMBUSTIBLE_PROD.ascx.vb" Inherits="controles_ucVistaDetalleORDEN_COMBUSTIBLE_PROD" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_ORDEN_COMBUSTIBLE_PROD">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ORDEN_COMBUSTIBLE_PROD" runat="server">Id orden combustible prod:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_ORDEN_COMBUSTIBLE_PROD" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ORDEN_COMBUS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ORDEN_COMBUS" runat="server">Orden combustible:</asp:label></TD>
		<TD>
			<cc1:ddlORDEN_COMBUSTIBLE id="ddlORDEN_COMBUSTIBLEID_ORDEN_COMBUS" runat="server" CssClass="DDLClass"></cc1:ddlORDEN_COMBUSTIBLE></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PRODUCTO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_PRODUCTO" runat="server">Producto combustible:</asp:label></TD>
		<TD>
			<cc1:ddlPRODUCTO_COMBUSTIBLE id="ddlPRODUCTO_COMBUSTIBLEID_PRODUCTO" runat="server" CssClass="DDLClass"></cc1:ddlPRODUCTO_COMBUSTIBLE></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCANTIDAD">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCANTIDAD" runat="server">Cantidad:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtCANTIDAD" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvCANTIDAD" runat="server" Display="Dynamic" ControlToValidate="txtCANTIDAD" ErrorMessage="Cantidad es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorCANTIDAD" runat="server" ControlToValidate="txtCANTIDAD"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPRECIO_VENTA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPRECIO_VENTA" runat="server">Precio venta:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtPRECIO_VENTA" runat="server" Width="100px"></asp:TextBox><asp:RequiredFieldValidator id="rfvPRECIO_VENTA" runat="server" Display="Dynamic" ControlToValidate="txtPRECIO_VENTA" ErrorMessage="Precio venta es Requerido"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorPRECIO_VENTA" runat="server" ControlToValidate="txtPRECIO_VENTA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_CREA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSUARIO_CREA" runat="server">Usuario crea:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CREA" runat="server" Width="100px" MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator id="rfvUSUARIO_CREA" runat="server" Display="Dynamic" ControlToValidate="txtUSUARIO_CREA" ErrorMessage="Usuario crea es Requerido"></asp:RequiredFieldValidator>
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
<asp:RequiredFieldValidator id="rfvFECHA_CREA" runat="server" Display="Dynamic" ControlToValidate="txtFECHA_CREA" ErrorMessage="Fecha crea es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_ACT">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSUARIO_ACT" runat="server">Usuario act:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_ACT" runat="server" Width="100px" MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator id="rfvUSUARIO_ACT" runat="server" Display="Dynamic" ControlToValidate="txtUSUARIO_ACT" ErrorMessage="Usuario act es Requerido"></asp:RequiredFieldValidator>
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
<asp:RequiredFieldValidator id="rfvFECHA_ACT" runat="server" Display="Dynamic" ControlToValidate="txtFECHA_ACT" ErrorMessage="Fecha act es Requerido"></asp:RequiredFieldValidator>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
