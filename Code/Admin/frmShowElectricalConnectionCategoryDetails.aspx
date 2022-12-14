<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmShowElectricalConnectionCategoryDetails.aspx.cs" Inherits="Admin_frmShowElectricalConnectionCategoryDetails" Title="Untitled Page" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
<center>
<h3>
ElectricalConnection Category Details
</h3>
</center>
<br />
<center>
<asp:GridView ID="Grid123" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" 
        GridLines="None">
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <RowStyle BackColor="#E3EAEB" />
    <Columns>
        <asp:BoundField DataField="ConnectionCategoryName" 
            HeaderText="ConnectionCategoryName" SortExpression="ConnectionCategoryName" />
        <asp:BoundField DataField="ConnectionCategoryAbbr" 
            HeaderText="ConnectionCategoryAbbr" SortExpression="ConnectionCategoryAbbr" />
        <asp:BoundField DataField="ConnectionCategoryMinCharge" 
            HeaderText="ConnectionCategoryMinCharge" 
            SortExpression="ConnectionCategoryMinCharge" />
        <asp:BoundField DataField="ConnectionCategoryMaxCharge" 
            HeaderText="ConnectionCategoryMaxCharge" 
            SortExpression="ConnectionCategoryMaxCharge" />
        <asp:BoundField DataField="ConnectionCategoryDescription" 
            HeaderText="ConnectionCategoryDescription" 
            SortExpression="ConnectionCategoryDescription" />
    </Columns>
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <EditRowStyle BackColor="#7C6F57" />
    <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:MunicipalAdministrationSystemConnectionString %>" 
        SelectCommand="SELECT [ConnectionCategoryName], [ConnectionCategoryAbbr], [ConnectionCategoryMinCharge], [ConnectionCategoryMaxCharge], [ConnectionCategoryDescription] FROM [tl_ElectricalConnectionCategoryMaster]">
    </asp:SqlDataSource>
</center>
</asp:Content>

