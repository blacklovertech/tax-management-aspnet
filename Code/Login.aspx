<%@ Page Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" Title="Untitled Page" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style6
        {
            font-size: large;
            font-weight: bold;
            color: #FFFFCC;
            background-color: #546138;
        }
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <br />
        <table width="60%" border="1" style="border-color: #5A5D5A; border-width: 1px;">
            <tr>
                <td bgcolor="#566A27" class="style1">
                   <asp:Label ID="lblLogin" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <table>
                        <tr>
                            <td style="text-align: right">
                                <b>Enter UserName :</b>
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtUsername" runat="server" Width="160px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ControlToValidate="txtUsername" ID="RequiredFieldValidator1"
                                    runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right">
                                <b>Enter Password :</b>
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtPassword" runat="server" Width="160px" TextMode="Password"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ControlToValidate="txtPassword" ID="RequiredFieldValidator2"
                                    runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="4">
                                <asp:Button ID="btnLogin" Text="Log In" runat="server" OnClick="btnLogin_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                            </td>
                        </tr>
                        <tr>
                        <td colspan="4" style="text-align: right">
                        <asp:LinkButton ID="linkShow" runat="server" Text="New User Sign Up" 
                                PostBackUrl="~/frmUsersMaster.aspx" style="font-weight: 700" 
                                ValidationGroup="c" Visible="False"></asp:LinkButton>
                        </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMsg" runat="server" Style="font-weight: 700; font-size: xx-small;
                        color: #FF3300"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#C97536" style="background-color: #525F37">
                    <br />
                </td>
            </tr>
        </table>
    </center>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <link href="jqueryslidemenu.css" rel="Stylesheet" type="text/css" />

        <script src="CS/jquery.min.js" type="text/javascript"></script>

        <script src="CS/jqueryslidemenu.js" type="text/javascript"></script>

    <style type="text/css">
    .style1
    {
        color: #FFFFFF;
        font-size: medium;
        font-weight: bold;
    }
</style>










</asp:Content>

