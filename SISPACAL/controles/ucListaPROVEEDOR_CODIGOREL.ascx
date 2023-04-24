﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPROVEEDOR_CODIGOREL.ascx.vb" Inherits="controles_ucListaPROVEEDOR_CODIGOREL" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetallePROVEEDOR_CODIGOREL.ascx" tagname="ucVistaDetallePROVEEDOR_CODIGOREL" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_PROVEE_CODIGOREL">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_PROVEE_CODIGOREL") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PROVEE_CODIGOREL") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PROVEE_CODIGOREL" ReadOnly="True" VisibleIndex="2" Caption="Id provee codigorel" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR" VisibleIndex="3" Caption="Codiproveedor" />
        <dx:GridViewDataTextColumn FieldName="CODIPROVEEDOR_REL" VisibleIndex="4" Caption="Codiproveedor rel" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="5" Caption="Usuario act" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="6" Caption="Fecha act" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="7">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetallePROVEEDOR_CODIGOREL ID="ucVistaDetallePROVEEDOR_CODIGOREL1" runat="server" 
                ID_PROVEE_CODIGOREL='<%# Bind("ID_PROVEE_CODIGOREL") %>' CODIPROVEEDOR='<%# Bind("CODIPROVEEDOR") %>' CODIPROVEEDOR_REL='<%# Bind("CODIPROVEEDOR_REL") %>' USUARIO_ACT='<%# Bind("USUARIO_ACT") %>' FECHA_ACT='<%# Bind("FECHA_ACT") %>' />
             <div style="text-align:right; padding:2px 2px 2px 2px"><table cellpadding="0" cellspacing="0">
                    <tr><td><dx:ASPxButton ID="btnGuardar" runat="server" AutoPostBack="False" Text="Guardar" Width="74px">   
                                <ClientSideEvents Click="function(s, e){if(!s.CauseValidation())return false;eval(s.cp_NombreClienteLista).UpdateEdit();}" />
                            </dx:ASPxButton></td>
                        <td style="padding-left: 13px;"><dx:ASPxButton ID="btnCancelar" runat="server" AutoPostBack="False" Text="Cancelar" Width="74px" CausesValidation="False">
                                <ClientSideEvents Click="function(s, e){eval(s.cp_NombreClienteLista).CancelEdit();}" />                            
             </dx:ASPxButton></td></tr></table></div>
        </EditForm>
        <EmptyDataRow>
            <dx:ASPxButton ID="btnAgregar" runat="server" AutoPostBack="False" Text="Agregar">
                <ClientSideEvents Click="function(s, e) {eval(s.cp_NombreClienteLista).AddNewRow();}" />
            </dx:ASPxButton>
            <dx:ASPxLabel ID="lblEmptyDataRow" runat="server" Text="No existen registros para mostrar"></dx:ASPxLabel>
        </EmptyDataRow>
    </Templates>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPROVEEDOR_CODIGOREL" DeleteMethod="EliminarPROVEEDOR_CODIGOREL" UpdateMethod="ActualizarPROVEEDOR_CODIGOREL"
    TypeName="SISPACAL.BL.cPROVEEDOR_CODIGOREL">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROVEE_CODIGOREL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR_REL" Type="String" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROVEE_CODIGOREL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR_REL" Type="String" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROVEE_CODIGOREL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR" InsertMethod="AgregarPROVEEDOR_CODIGOREL" DeleteMethod="EliminarPROVEEDOR_CODIGOREL" UpdateMethod="ActualizarPROVEEDOR_CODIGOREL"
    TypeName="SISPACAL.BL.cPROVEEDOR_CODIGOREL">
    <SelectParameters>
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROVEE_CODIGOREL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR_REL" Type="String" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROVEE_CODIGOREL" Type="Int32" />
        <asp:Parameter Name="CODIPROVEEDOR" Type="String" />
        <asp:Parameter Name="CODIPROVEEDOR_REL" Type="String" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROVEE_CODIGOREL" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
