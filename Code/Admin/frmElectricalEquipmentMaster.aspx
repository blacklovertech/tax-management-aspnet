<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmElectricalEquipmentMaster.aspx.cs" Inherits="Admin_frmElectricalEquipmentMaster" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
&nbsp;<center>
&nbsp;
<asp:UpdatePanel ID="updatepanel1" runat="server">
<Triggers>
<asp:AsyncPostBackTrigger ControlID="btnSubmit" EventName="Click" />
<asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />

</Triggers>
<ContentTemplate>

<br />
 <asp:Panel ID="mainpanel" runat="server">
<table style="text-align:left">
<tr>
<td colspan="3">
<h3 class="style1" style="background-color: #6D8143; color: #FFFFFF;" 
        align="center">
Add Electrical Equipment Details
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
Electrical Equipment Name :
</td>
<td>
<asp:TextBox ID="txtEquipmentName" runat="server" Width="181px"></asp:TextBox>
</td>
<td>
<asp:RequiredFieldValidator ID="requireName" runat="server" ErrorMessage="*" ControlToValidate="txtEquipmentName"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left" valign="top">
Electrical Equipment Description :
</td>
<td>
<asp:TextBox ID="txtdescrip" TextMode="MultiLine" runat="server"></asp:TextBox>
</td>
<td>
<asp:RequiredFieldValidator ID="requireDesc" runat="server" ControlToValidate="txtdescrip" ErrorMessage="*"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
Electrical Equipment Abbrvation :
</td>
<td>
<asp:TextBox ID="txtAbbrvation" runat="server" Width="181px"></asp:TextBox>
</td>
<td>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtAbbrvation"></asp:RequiredFieldValidator>
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
        onclick="btnClear_Click" CausesValidation="False" />
</td>
</tr>
</table>
</asp:Panel>
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
                        HorizontalSide="Center" VerticalSide="Middle">
                    </cc1:AlwaysVisibleControlExtender>
                </center>

<br />


<asp:Label ID="lblError" runat="server"></asp:Label>
</ContentTemplate>
</asp:UpdatePanel>
</center>
</asp:Content>

