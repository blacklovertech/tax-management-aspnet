<%@ Page Language="C#" MasterPageFile="~/Users/UserMasterPage.master" AutoEventWireup="true" CodeFile="frmSearchMeterReadings.aspx.cs" Inherits="Users_frmSearchMeterReadings" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <center>
<br />
<br />
<h3>
        Search Electrical Bill&nbsp; Details
</h3>
<br />
<table>
<tr>
<td>
Start Date:
</td>
<td>
<asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
    <cc1:CalendarExtender ID="txtStartDate_CalendarExtender" runat="server" 
        Enabled="True" TargetControlID="txtStartDate">
    </cc1:CalendarExtender>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtStartDate" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
</td>
<td>
End Date:
</td>
<td>
<asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
    <cc1:CalendarExtender ID="txtEndDate_CalendarExtender" runat="server" 
        Enabled="True" TargetControlID="txtEndDate">
    </cc1:CalendarExtender>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtEndDate" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>

</td>
<td>
<asp:Button ID="btnSearch" runat="server" Text ="Search" 
        onclick="btnSearch_Click" />
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td colspan="5">
<asp:GridView ID="gridShowMunicipalityDetails" runat="server" BackColor="#CCCCCC" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
        CellSpacing="2" ForeColor="Black" AllowPaging="True" 
        onpageindexchanging="gridShowMunicipalityDetails_PageIndexChanging">
    <FooterStyle BackColor="#CCCCCC" />
    <RowStyle BackColor="White" />
    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</td>
</tr>
<tr>
<td colspan="5">
<asp:Label ID="lblError" runat="server"></asp:Label>
</td>
</tr>
</table>
</center>



</asp:Content>



