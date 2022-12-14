<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmElectricalServiceequipMents.aspx.cs" Inherits="Admin_frmElectricalServiceequipMents" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
&nbsp;<center>
&nbsp;
<br />
<asp:UpdatePanel ID="UpdatePanel" runat="server">
<Triggers>
<asp:AsyncPostBackTrigger ControlID="btnSubmit" EventName="Click" />
<asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
</Triggers>
<ContentTemplate>

<asp:Panel ID="mainpanel" runat="server">
<table style="text-align:left">
<tr>
<td colspan="3">
<h3 class="style1" style="background-color: #6D8143; color: #FFFFFF;" 
        align="center">
Add Electrical Service Equipments Details
</h3>
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td align="left">
    Electrical Service No</td>
<td>
    <asp:DropDownList ID="ddlServiceNo" runat="server" Height="36px" Width="181px" 
        onselectedindexchanged="ddlServiceNo_SelectedIndexChanged">
    </asp:DropDownList>
</td>
<td>
<asp:RequiredFieldValidator ID="requireName" runat="server" ErrorMessage="*" ControlToValidate="ddlServiceNo" InitialValue="--Select One--"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
    Electrical Equipment Id: </td>
<td>
<asp:DropDownList ID="ddlEquipmentId" runat="server" Width="181px"></asp:DropDownList>
</td>
<td>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="ddlEquipmentId" InitialValue="--Select One--"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
    Equipment Waltage : </td>
<td>
<asp:TextBox ID="txtWaltage" runat="server" Width="181px"></asp:TextBox>
</td>
<td>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtWaltage"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
    Consumaption Units Average : </td>
<td>
<asp:TextBox ID="txtUnitsAverage" runat="server" Width="181px"></asp:TextBox>
</td>
<td>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtUnitsAverage"></asp:RequiredFieldValidator>
</td>
</tr>

<tr>
<td>
<br />
</td>
</tr>
<tr>
<td colspan="3" bgcolor="#6E8043" align="center">
<asp:Button ID="btnSubmit" runat="server" Text="Submit" Height="20px" 
        onclick="btnSubmit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="btnClear" runat="server" Text="Clear" Height="20px" Width="59px" 
        CausesValidation="False" onclick="btnClear_Click" />
</td>
</tr>
</table>
</asp:Panel>
<br />
<br />
<asp:UpdateProgress ID="UpdateProgress1" runat="server">
<ProgressTemplate>
      <div id="progress" runat="server" style="background-color:Gray; font-weight: bold; font-family: Verdana; font-size: medium;width:250px;height:auto;vertical-align:middle">
               <center>
               Processing......<br />
               <img src="../Images/Process.gif" height="100px" width="100px" />
               </center> 
               
                </div>                
                </ProgressTemplate>          
</asp:UpdateProgress>
<cc1:AlwaysVisibleControlExtender ID="ControlId" runat="server" HorizontalSide="Center" VerticalSide="Middle" TargetControlID="progress"></cc1:AlwaysVisibleControlExtender>
<asp:Label ID="lblError" runat="server"></asp:Label>
</ContentTemplate>
</asp:UpdatePanel>
</center>
</asp:Content>

