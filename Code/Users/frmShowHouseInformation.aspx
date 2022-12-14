<%@ Page Language="C#" MasterPageFile="~/Users/UserMasterPage.master" AutoEventWireup="true" CodeFile="frmShowHouseInformation.aspx.cs" Inherits="Users_frmShowHouseInformation" Title="Untitled Page" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<center>
<table>
<tr>
<td>
<h3>
House Information Details
</h3>
</td>
</tr>
<tr>
<td style="font-weight: 700;text-align:left">
    <asp:DetailsView ID="dethousedetails" runat="server" AutoGenerateRows="False" 
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
        CellPadding="4" CellSpacing="2" ForeColor="Black" Height="50px" Width="125px">
        <FooterStyle BackColor="#CCCCCC" />
        <RowStyle BackColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <Fields>
            <asp:BoundField DataField="OwnerName" HeaderText="OwnerName" />
            <asp:BoundField DataField="TelephoneNo" HeaderText="TelephoneNo" />
            <asp:BoundField DataField="EmailId" HeaderText="EmailId" />
            <asp:BoundField DataField="ActualHOuseno" HeaderText="ActualHouseno" />
            <asp:BoundField DataField="HOuseRegistrationDate" 
                HeaderText="HOuseRegistrationDate" />
            <asp:BoundField DataField="PlotOwnerName" HeaderText="PlotOwnerName" />
            <asp:CheckBoxField DataField="ElectricityConnectionStatus" 
                HeaderText="ElectricityConnectionStatus" />
            <asp:CheckBoxField DataField="GasConnectionStatus" 
                HeaderText="GasConnectionStatus" />
            <asp:BoundField DataField="WaterConnectionStatus" 
                HeaderText="WaterConnectionStatus" />
        </Fields>
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

