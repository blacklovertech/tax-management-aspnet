<%@ Page Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true"
    CodeFile="frmUsersMaster.aspx.cs" Inherits="Admin_frmUsersMaster" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .tabledata
        {
            font-family: Verdana;
            font-weight: bold;
            font-size: xx-small;
            text-align: left;
            background-color: #BEBE7C;
        }
        .lbldata
        {
            font-weight: bold;
            font-family: Verdana;
            color: #FF0066;
        }
        .head
        {
            color: #663300;
        }
        .tddata
        {
            background-color: #74743A;
            color: White;
        }
        .top
        {
            vertical-align: top;
        }
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <asp:UpdatePanel ID="updatepanel12" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAdd" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
            </Triggers>
            <ContentTemplate>
                <br />
                <br />
                <table bgcolor="#CCDDB3">
                    <tr>
                        <td colspan="3" class="tddata">
                            <center>
                                <h5 class="style1" style="height: 20px; background-color: #6E8043;">
                                    Birth Registration</h5>
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
                            &nbsp;First Name
                        </td>
                        <td>
                            <asp:TextBox ID="txtfirstName" Width="150px" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                                ControlToValidate="txtfirstName"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;Middle Name
                        </td>
                        <td>
                            <asp:TextBox ID="txtMiddleName" Width="150px" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                                ControlToValidate="txtMiddleName"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;Last Name :
                        </td>
                        <td>
                            <asp:TextBox ID="txtLastName" Width="150px" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*"
                                ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Date Of Birth :
                        </td>
                        <td>
                            <asp:TextBox ID="txtDateofBirth" Width="150px" runat="server"></asp:TextBox>
                            <cc1:CalendarExtender ID="CalendarExtender1" TargetControlID="txtDateofBirth" runat="server">
                            </cc1:CalendarExtender>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*"
                                ControlToValidate="txtDateofBirth"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="top">
                            Address :
                        </td>
                        <td>
                            <asp:TextBox ID="txtAddress" runat="server" Height="56px" TextMode="MultiLine" Width="150px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*"
                                ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
                        </td>
                    </tr>  
                    <tr>
                        <td>
                            Email Id :
                        </td>
                        <td>
                            <asp:TextBox ID="txtEmailId" Width="150px" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                ControlToValidate="txtMiddleName"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ErrorMessage="*" ControlToValidate="txtEmailId" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            House No:
                        </td>
                        <td>
                            <asp:TextBox ID="txtHouseNo" Width="150px" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                                ControlToValidate="txtHouseNo"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;Phone No:
                        </td>
                        <td>
                            <asp:TextBox ID="txtPhoneNO" Width="150px" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                                ControlToValidate="txtPhoneNO"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                ErrorMessage="{10}" ControlToValidate="txtPhoneNO" 
                                ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                        </td>
                    </tr>                  
                    <tr>
                        <td>
                            User Name</td>
                        <td>
                            <asp:TextBox ID="txtUserName" Width="150px" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*"
                                ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                        </td>
                    </tr> 
                       <tr>
                        <td>
                            &nbsp;Pass Word:
                        </td>
                        <td>
                            <asp:TextBox ID="txtPassword" Width="150px" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*"
                                ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                        </td>
                    </tr>  
                        <tr>
                        <td>
                            Confirm Pass Word:
                        </td>
                        <td>
                            <asp:TextBox ID="txtConformPassword" Width="150px" runat="server" 
                                TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="*"
                                ControlToValidate="txtConformPassword"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="*" 
                                ControlToCompare="txtPassword" ControlToValidate="txtConformPassword"></asp:CompareValidator>
                        </td>
                    </tr>                 
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" class="tddata">
                            <center style="height: 18px; background-color: #6E8043;">
                                <asp:Button ID="btnAdd" runat="server" Text="Submit" OnClick="btnAdd_Click" BackColor="#6E8043"
                                    Font-Bold="True" ForeColor="#CC0000" Height="21px" />
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" ValidationGroup="b1"
                                    BackColor="#6E8043" Font-Bold="True" ForeColor="#CC0000" Height="21px" />
                            </center>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <asp:Label ID="lblError" CssClass="lbldata" runat="server"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    </center>
</asp:Content>
<%--<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
        <link href="jqueryslidemenu.css" rel="stylesheet" type="text/css" />

        <script src="CS/jquery.min.js" type="text/javascript"></script>

        <script src="CS/jqueryslidemenu.js" type="text/javascript"></script>

    <style type="text/css">
    .style1
    {
        color: #FFFFFF;
    }
</style>




</asp:Content>--%>