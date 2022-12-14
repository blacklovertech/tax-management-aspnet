<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmplotMaster.aspx.cs" Inherits="SubAdmin_frmplotMaster" Title="Untitled Page" %>
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
        </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
        <asp:UpdatePanel ID="updatepanel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAdd" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
            </Triggers>
            <ContentTemplate>
            <br />
            <br />
            <asp:Panel ID="mainpanel" runat="server">
                <table class="tabledata" style="text-align:left">
                    <tr>
                        <td colspan="6">
                            <center>
                                <h4 class="head" style="background-color:#6F7F43;">
                                    Plot Master
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
                        Plot Owner Name :
                    </td>
                    <td>
<asp:TextBox ID="txtplotownerName" runat="server" Width="163px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtplotownerName"></asp:RequiredFieldValidator>
                      </td>
                   <td >
                       Plot Description :
                    </td>
                    <td rowspan="2">
                      <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"  
                            Height="67px"></asp:TextBox>
                    </td>
                    <td rowspan="2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtDescription"></asp:RequiredFieldValidator>
                      </td>
                    </tr>
                    <tr>
                    <td>
                        Phone No :
                    </td>
                    <td>
                    <asp:TextBox ID="txtPhoneNo" runat="server" Width="163px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPhoneNo" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="txtPhoneNo" ErrorMessage="{0,5}-{123456}" 
                            ValidationExpression="\d{0,5}-\d{6}" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                     
                    
                    
                    </tr>
                     <tr>
                    <td>
                        Area Name :
                    </td>
                    <td>
                    <asp:DropDownList ID="ddlareaName" runat="server" Width="163px" AutoPostBack="True" 
                            onselectedindexchanged="ddlareaName_SelectedIndexChanged"></asp:DropDownList> 
                       
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="ddlareaName" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                    </td>
                    
                    <td>
                        Street Name :</td>
                    <td>
                    <asp:DropDownList ID="ddlstreetid" runat="server" Height="23px" Width="163px"></asp:DropDownList>
                    </td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" InitialValue="--SelectOne--" ControlToValidate="ddlstreetid"></asp:RequiredFieldValidator>
</td>
                    </tr>
                     <tr>
                        <td>
                        <br />
                        </td>                        
                    </tr>
                    <tr>
                        <td colspan="6" bgcolor="#6F7F43">
                            <center>
                                <asp:Button ID="btnAdd" runat="server" Text="Submit" BackColor="#BED3E9" Font-Bold="True"
                                    ForeColor="#CC0000" OnClick="btnAdd_Click" Height="20px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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

