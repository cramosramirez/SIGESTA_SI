<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPROVEEDOR_AGRICOLA.ascx.vb" Inherits="controles_ucListaPROVEEDOR_AGRICOLA" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register src="ucVistaDetallePROVEEDOR_AGRICOLA.ascx" tagname="ucVistaDetallePROVEEDOR_AGRICOLA" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_PROVEE" Width="100%">
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
                    CommandArgument='<%# Bind("ID_PROVEE") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PROVEE") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PROVEE" ReadOnly="True" VisibleIndex="2" Caption="Id provee" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE" VisibleIndex="3" Caption="Nombre" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="4" Caption="Dui" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="5" Caption="Nit" />
        <dx:GridViewDataTextColumn FieldName="NRC" VisibleIndex="6" Caption="Nrc" />
        <dx:GridViewDataTextColumn FieldName="TIPO_CONTRIBUYENTE" VisibleIndex="7" Caption="Tipo contribuyente" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="8" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="9" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="10" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="11" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ZAFRA" VisibleIndex="12" Caption="Zafra" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="13" Visible="false">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetallePROVEEDOR_AGRICOLA ID="ucVistaDetallePROVEEDOR_AGRICOLA1" runat="server" 
                ID_PROVEE='<%# Bind("ID_PROVEE") %>' NOMBRE='<%# Bind("NOMBRE") %>' DUI='<%# Bind("DUI") %>' NIT='<%# Bind("NIT") %>' NRC='<%# Bind("NRC") %>' TIPO_CONTRIBUYENTE='<%# Bind("TIPO_CONTRIBUYENTE") %>' USUARIO_CREA='<%# Bind("USUARIO_CREA") %>' FECHA_CREA='<%# Bind("FECHA_CREA") %>' USUARIO_ACT='<%# Bind("USUARIO_ACT") %>' FECHA_ACT='<%# Bind("FECHA_ACT") %>' ZAFRA='<%# Bind("ZAFRA") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarPROVEEDOR_AGRICOLA" DeleteMethod="EliminarPROVEEDOR_AGRICOLA" UpdateMethod="ActualizarPROVEEDOR_AGRICOLA"
    TypeName="SISPACAL.BL.cPROVEEDOR_AGRICOLA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="TIPO_CONTRIBUYENTE" Type="Int32" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="ZAFRA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROVEE" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
