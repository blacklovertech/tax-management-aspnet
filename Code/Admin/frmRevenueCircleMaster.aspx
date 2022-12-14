<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmRevenueCircleMaster.aspx.cs" Inherits="Admin_frmRevenueCircleMaster" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <asp:UpdatePanel ID="panel123" runat="server">
    <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnSubmit" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
            </Triggers>
    <ContentTemplate>   
    
    <center>
&nbsp;
<br />
<asp:Panel ID="mainpanel" runat="server">
<table style="text-align:left">
<tr>
<td colspan="3">
<center>
<h3 class="style1" style="background-color: #6D8143; color: #FFFFFF;">
Add Revenue Circle Details
</h3>
</center>
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td align="left">
Revenue Circle Name :
</td>
<td>
<asp:TextBox ID="txtRevenueName" runat="server" Width="181px"></asp:TextBox>
</td>
<td>
<asp:RequiredFieldValidator ID="requireName" runat="server" ErrorMessage="*" ControlToValidate="txtRevenueName"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left" valign="top">
Revenue Description :
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
Revenue Circle Abbrvation :
</td>
<td>
<asp:TextBox ID="txtAbbrvation" runat="server" Width="181px"></asp:TextBox>
</td>
<td>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtAbbrvation"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
Revenue Circle Span :
</td>
<td>
<asp:TextBox ID="txtSpan" runat="server" Width="181px"></asp:TextBox>
</td>
<td>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtSpan"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td colspan="3" bgcolor="#6E8043">
<center>
<asp:Button ID="btnSubmit" runat="server" Text="Submit" Height="20px" 
        onclick="btnSubmit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="btnClear" runat="server" Text="Clear" Height="20px" Width="59px" 
        onclick="btnClear_Click" CausesValidation="False" />
        </center>
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
                        HorizontalSide="Left" VerticalSide="Middle">
                    </cc1:AlwaysVisibleControlExtender>
                </center>
<br />
<asp:Label ID="lblError" runat="server"></asp:Label>
</center>
</ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

<%--<asp:Content ID="Content3" runat="server" contentplaceholderid="head">

        <link href="../jqueryslidemenu.css" rel="stylesheet" type="text/css" />

        <script src="../CS/jquery.min.js" type="text/javascript"></script>

        <script src="../CS/jqueryslidemenu.js" type="text/javascript"></script>

    <style type="text/css">
        .style1
        {
            color: #FFFFFF;
        }
    </style>


</asp:Content>
--%>

