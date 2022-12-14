<%@ Page Language="C#" MasterPageFile="~/Users/UserMasterPage.master" AutoEventWireup="true" CodeFile="frmShowElectricalMeterReading.aspx.cs" Inherits="Users_frmShowElectricalMeterReading" Title="Untitled Page" %>

<%--
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<br />
<br />
<table>
<tr>
<td>
<h3>
    Electrical Meter Reading Details
</h3>
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td>
    <b>Electrical Service NO :
</b>
<asp:DropDownList ID="ddlElectricalServiceNo" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddlElectricalServiceNo_SelectedIndexChanged"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td style="font-weight:700">
    <asp:DetailsView ID="detailsElectricalShowDetails" runat="server" Height="50px" Width="125px" 
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
        CellPadding="4" CellSpacing="2" ForeColor="Black" 
        EmptyDataText="No TaxDetais">
        <FooterStyle BackColor="#CCCCCC" />
        <RowStyle BackColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        
    </asp:DetailsView>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblError" runat="server"></asp:Label>
</td>
</tr>
</table>
</center>
</asp:Content>

