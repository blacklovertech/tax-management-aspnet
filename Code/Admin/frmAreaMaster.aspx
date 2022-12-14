<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmAreaMaster.aspx.cs" Inherits="SubAdmin_frmAreaMaster" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%--
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
                <asp:Panel ID="ProcessPanel" runat="server">
                <table class="tabledata" style="text-align:left">
                    <tr>
                        <td colspan="6">
                            <center>
                                <h4 class="head" style="background-color: #6D8044">
                                    Area Master
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
                            Area Name :
                        </td>
                        <td>
                            <asp:TextBox ID="txtAreaName" runat="server" Width="163px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                ControlToValidate="txtAreaName"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Area Span :
                        </td>
                        <td>
                            <asp:TextBox ID="txtAreaSpan" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                                ControlToValidate="txtAreaSpan"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Area Type Name:
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlAreaTypeName" runat="server" Width="163px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlAreaTypeName"
                                InitialValue="--SelectOne--" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Area Identity Date:
                        </td>
                        <td>
                            <asp:TextBox ID="txtDate" runat="server" Width="163px"></asp:TextBox>
                            <cc1:CalendarExtender ID="CalendarExtender1" TargetControlID="txtDate" runat="server">
                            </cc1:CalendarExtender>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDate"
                                ErrorMessage="*"></asp:RequiredFieldValidator>
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
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnClear" runat="server" Text="Clear" BackColor="#BED3E9" Font-Bold="True"
                                    ForeColor="#CC0000" OnClick="btnClear_Click" ValidationGroup="b1" 
                                    Height="20px" />
                            </center>
                        </td>
                    </tr>
                </table>
                 </asp:Panel>
                <br />
                <br />
                <center>
                <asp:UpdateProgress ID="Updateprogess1" runat="server">
                <ProgressTemplate>
                <div id="progress" runat="server" style="background-color:Gray; font-weight: bold; font-family: Verdana; font-size: medium;width:300px;height:auto;vertical-align:middle">
               <center>
               Processing......<br />
               <img src="../Images/Process.gif" height="100px" width="100px" />
               </center> 
               
                </div>
                </ProgressTemplate>
                </asp:UpdateProgress>
                    <cc1:AlwaysVisibleControlExtender ID="Updateprogess1_AlwaysVisibleControlExtender" 
                        runat="server" Enabled="True" TargetControlID="progress">
                    </cc1:AlwaysVisibleControlExtender>
                    </center>
               
                <br />
                <br />
                <asp:Label ID="lblError" CssClass="lbldata" runat="server"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    </center>
</asp:Content>

