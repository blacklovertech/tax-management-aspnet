<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmShowElectricalEquipmentMaster.aspx.cs" Inherits="Admin_frmShowElectricalEquipmentMaster" Title="Untitled Page" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<br />
<br />
<h3>
Electrical Equipment Details
</h3>
<asp:GridView ID="gridElectricalEquipment" runat="server" 
        AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" 
        ForeColor="#333333" GridLines="None" style="margin-right: 0px">
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <RowStyle BackColor="#E3EAEB" />
    <Columns>
        <asp:BoundField DataField="ElectricalEquipmentName" 
            HeaderText="ElectricalEquipmentName" SortExpression="ElectricalEquipmentName" />
        <asp:BoundField DataField="ElectricalEquipmentAbbr" 
            HeaderText="ElectricalEquipmentAbbr" SortExpression="ElectricalEquipmentAbbr" />
        <asp:BoundField DataField="ElectricalEquipmentDesc" 
            HeaderText="ElectricalEquipmentDesc" SortExpression="ElectricalEquipmentDesc" />
    </Columns>
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <EditRowStyle BackColor="#7C6F57" />
    <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:MunicipalAdministrationSystemConnectionString %>" 
        SelectCommand="SELECT [ElectricalEquipmentName], [ElectricalEquipmentAbbr], [ElectricalEquipmentDesc] FROM [tl_ElectricalEquipmentMaster]">
    </asp:SqlDataSource>
</center>
</asp:Content>

