<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="frmStreetMaster.aspx.cs" Inherits="SubAdmin_frmStreetMaster" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                                    <span class="style1">Street Master</span>
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
                            Street Name :
                        </td>
                        <td>
                            <asp:TextBox ID="txtStreetName" runat="server" Width="163px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                ControlToValidate="txtStreetName"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Street Span :
                        </td>
                        <td>
                            <asp:TextBox ID="txtStreetSpan" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                                ControlToValidate="txtStreetSpan"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Street Type Name:
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlStreetName" runat="server" Width="163px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlStreetName"
                                InitialValue="--SelectOne--" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Area Name:
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlAreaName" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlAreaName" InitialValue="--SelectOne--"
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

