<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="frmHouseMaster.aspx.cs" Inherits="SubAdmin_frmHouseMaster" Title="Untitled Page" %>

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
            font-size: xx-small;
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
        <asp:UpdatePanel ID="updatepanel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAdd" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="ddlAreaId" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="ddlStreetName" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="txtActualNo" EventName="TextChanged" />
            </Triggers>
            <ContentTemplate>
                <br />
                <br />
                <asp:Panel ID="mainpanel" runat="server">
                <table class="tabledata" style="text-align:left">
                    <tr>
                        <td colspan="6" class="tddata">
                            <center>
                                <h4 style="background-color:#6F7F43;" class="style1">
                                    House Details</h4>
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
                            Owner Name :
                        </td>
                        <td>
                            <asp:TextBox ID="txtOwnerName" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                ControlToValidate="txtOwnerName"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Tele Phone No :
                        </td>
                        <td>
                            <asp:TextBox ID="txttelephoneno" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                                ControlToValidate="txttelephoneno"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="{0,5}-{6}"
                                ControlToValidate="txttelephoneno" ValidationExpression="\d{0,5}-\d{6}" Display="Dynamic"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Actual House No :
                        </td>
                        <td>
                            <asp:TextBox ID="txtActualNo" runat="server" 
                                OnTextChanged="txtActualNo_TextChanged" ValidationGroup="b1"></asp:TextBox>
                            <asp:Button ID="btnCheck" runat="server" Text="Check" 
                                onclick="btnCheck_Click" CausesValidation="False" ValidationGroup="b1" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                                ControlToValidate="txtActualNo"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Email id :
                        </td>
                        <td>
                            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                                ControlToValidate="txtemail"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtemail"
                                Display="Dynamic" ErrorMessage="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Area Name :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlAreaId" runat="server" AutoPostBack="True" 
                                OnSelectedIndexChanged="ddlAreaId_SelectedIndexChanged" Width="136px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlAreaId" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Street Name :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlStreetName" runat="server" AutoPostBack="True" 
                                OnSelectedIndexChanged="ddlStreetName_SelectedIndexChanged" Width="136px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlStreetName" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Plot Name :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPlotName" runat="server" Width="136px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlPlotName" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Electricity Connection Status :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlpowerStatus" runat="server" Width="136px">
                                <asp:ListItem>--SelectOne--</asp:ListItem>
                                <asp:ListItem>Yes</asp:ListItem>
                                <asp:ListItem>No</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlpowerStatus" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Gas Connection Status :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlGasStatus" runat="server" Height="18px" Width="136px">
                                <asp:ListItem>--SelectOne--</asp:ListItem>
                                <asp:ListItem>Yes</asp:ListItem>
                                <asp:ListItem>No</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlGasStatus" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Water Connection Status :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlwaterconnstatus" runat="server" Width="136px">
                                <asp:ListItem>--SelectOne--</asp:ListItem>
                                <asp:ListItem>Connected</asp:ListItem>
                                <asp:ListItem>DisConnected</asp:ListItem>
                                <asp:ListItem>TemporaryConnected</asp:ListItem>
                                <asp:ListItem>NoConnection</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlwaterconnstatus" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                   <tr>
                   <td>
                   Building ApprovalNo:
                   </td>
                   <td>
                   <asp:DropDownList ID="ddlBuildingApprovalNo" runat="server" Width="136px"></asp:DropDownList>
                   </td>
                 <td>
                 <asp:RequiredFieldValidator ID="requirebuildingNo" runat="server" 
                         ControlToValidate="ddlBuildingApprovalNo" InitialValue="--Select One--" 
                         ErrorMessage="*"></asp:RequiredFieldValidator>
                 </td>
                 <td>
                 <asp:Label ID="lblUniqueHouseno" runat="server" Text="Unique House No" 
                         Visible="false" style="font-weight: 700; color: #990000"></asp:Label>
                 </td>
                 <td>
                                  <asp:Label ID="lblHouseno" runat="server" Text="" 
                                      style="font-weight: 700; color: #990000"></asp:Label>

                 </td>
                   </tr>
                    <tr>
                        <td>
                            <br />
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="6" class="tddata" bgcolor="#6F7F43">
                            <center>
                                <asp:Button ID="btnAdd" runat="server" Text="Submit" BackColor="#999966" Font-Bold="True"
                                    ForeColor="#CC0000" OnClick="btnAdd_Click" Enabled="False" Height="20px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnClear" runat="server" Text="Clear" BackColor="#999966" Font-Bold="True"
                                    ForeColor="#CC0000" ValidationGroup="b1" Height="20px" 
                                    OnClick="btnClear_Click" Width="47px" />
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

