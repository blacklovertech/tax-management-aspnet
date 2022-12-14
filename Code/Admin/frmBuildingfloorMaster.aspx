<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmBuildingfloorMaster.aspx.cs" Inherits="SubAdmin_frmBuildingfloorMaster" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .tabledata
        {
            font-family: Verdana;
            font-weight: bold;
            font-size: xx-small;
            text-align: left;
        }
        .lbldata
        {
            font-weight: bold;
            font-family: Verdana;
            color: #FF0066;
            font-size: x-small;
        }
        .head
        {
            color: #FFFF66;
        }
        .top
        {
            vertical-align: top;
        }
        .right
        {
            text-align: right;
        }
    .style1
    {
        color: #FFFFFF;
    }
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
<center>
 <asp:UpdatePanel ID="updatepanel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAdd" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="ddlBuildingApprno" EventName="SelectedIndexChanged" />
            </Triggers>
            <ContentTemplate>
            
  <asp:Panel ID="mainpanel" runat="server">

<table class="tabledata" style="text-align:left">
<tr>
<td colspan="3">
<center>
<h4 style="background-color:#6E7F43">
    <span class="style1">Building Floor Master</span>
</h4>
</center>

</td>

</tr>
<tr>
<td>
<br />
</td>
</tr>

<tr>
<td>
Building Approval No
</td>
<td>
<asp:DropDownList ID="ddlBuildingApprno" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddlBuildingApprno_SelectedIndexChanged"></asp:DropDownList>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlBuildingApprno" ErrorMessage="*" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
Floor No
</td>
<td>
<asp:DropDownList ID="ddlFloorNo" runat="server">
</asp:DropDownList>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlFloorNo" ErrorMessage="*" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
Floor Plinth Area 
</td>
<td>
<asp:TextBox ID="txtPlintArea" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPlintArea" ErrorMessage="*"></asp:RequiredFieldValidator>
</td>
</tr>
 <tr>
                        <td colspan="3" bgcolor="#6E7F43">
                            <center>
                                <asp:Button ID="btnAdd" runat="server" Text="Submit" BackColor="#BED3E9" Font-Bold="True"
                                    ForeColor="#CC0000" OnClick="btnAdd_Click" Height="20px" />
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnClear" runat="server" Text="Clear" BackColor="#BED3E9" Font-Bold="True"
                                    ForeColor="#CC0000" OnClick="btnClear_Click" ValidationGroup="b1" 
                                    Height="20px" />
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
                <asp:Label ID="lblError" CssClass="lbldata" runat="server"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        </center> 
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
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


