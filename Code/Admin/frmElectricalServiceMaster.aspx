<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmElectricalServiceMaster.aspx.cs" Inherits="Admin_frmElectricalServiceMaster" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%--<asp:content id="content1" contentplaceholderid="head" runat="server">
</asp:content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:UpdatePanel ID="Updatepanel1" runat="server">
<Triggers>
<asp:AsyncPostBackTrigger ControlID="ddluniqueno" EventName="SelectedIndexChanged" />
<asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
<asp:AsyncPostBackTrigger ControlID="btnAdd" EventName="Click" />

</Triggers>
<ContentTemplate>
<center>
<br />
<br />
<asp:Panel ID="mainpanel" runat="server">
<table style="text-align:left">
<tr>
<td colspan="6">
<center>
<h3 style="background-color: #566A27; color: #FFFFFF;">Add Electricity Service Details</h3></center>
</td>
</tr>
<tr>
<td align="left">
    House No :
</td>
<td align="left">
<asp:DropDownList ID="ddluniqueno" runat="server" AutoPostBack="True" Height="21px" 
        onselectedindexchanged="ddluniqueno_SelectedIndexChanged" Width="127px"></asp:DropDownList>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="ddluniqueno" InitialValue="--Select One--"></asp:RequiredFieldValidator>
</td>
<td align="left">
    Owner Name:
</td>
<td align="left">
<asp:TextBox ID="txtHouseNO" runat="server" ReadOnly="True"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtHouseNO"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
Connection Category Id :
</td>
<td align="left">
<asp:DropDownList ID="ddlConnectionCategoryId" runat="server" Height="18px" 
        Width="127px"></asp:DropDownList>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="ddlConnectionCategoryId" InitialValue="--Select One--"></asp:RequiredFieldValidator>
</td>
<td align="left">
ERO :
</td>
<td align="left">
<asp:TextBox ID="txtEro" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="txtEro"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
Section :
</td>
<td align="left">
<asp:TextBox ID="txtSection" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="txtSection"></asp:RequiredFieldValidator>
</td>
<td align="left">
Group :
</td>
<td align="left">
<asp:TextBox ID="txtGroup" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="txtGroup"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left"> 
No Of floors:
</td>
<td align="left">
<asp:TextBox ID="txtFloors" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="txtFloors"></asp:RequiredFieldValidator>
</td>
<td align="left">
No Of Phases:
</td>
<td align="left">
<asp:TextBox ID="txtphases" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*" ControlToValidate="txtphases"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
MP:
</td>
<td align="left">
<asp:TextBox ID="txtMp" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" ControlToValidate="txtMp"></asp:RequiredFieldValidator>
</td>
<td align="left">
Load :
</td>
<td align="left">
<asp:TextBox ID="txtLoad" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*" ControlToValidate="txtLoad"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>

<td colspan="6" bgcolor="#566A27">
<center>
<asp:Button ID="btnAdd" runat="server" Text="Submit" Height="20px" 
        onclick="btnAdd_Click" />
&nbsp;&nbsp;&nbsp;
<asp:Button ID="btnClear" runat="server" Text="Clear" Height="20px" 
        onclick="btnClear_Click" CausesValidation="False" />
        </center>
</td>
</tr>
</table>
</asp:Panel>
<br />
<br />
 <center>
                <asp:UpdateProgress ID="UpdateProgess1" runat="server">
                <ProgressTemplate>
                <div id="progess" runat="server" style="background-color:Green;font-weight:bold;font-family:Verdana; font-size:small;width:150px;height:auto;vertical-align:middle">
                    Processing....
             <img src="../Images/1asp017.gif" height="100px" width="100px" />
                </div>
                
                </ProgressTemplate>
                
                </asp:UpdateProgress>
                    <cc1:AlwaysVisibleControlExtender ID="UpdateProgess1_AlwaysVisibleControlExtender" 
                        runat="server" Enabled="True" TargetControlID="progess" 
                        HorizontalSide="Left" VerticalSide="Middle">
                    </cc1:AlwaysVisibleControlExtender>
                </center>

<asp:Label ID="lblError" runat="server"></asp:Label>
</center>
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

