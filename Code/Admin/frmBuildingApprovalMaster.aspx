<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmBuildingApprovalMaster.aspx.cs" Inherits="SubAdmin_frmBuildingApprovalMaster" Title="Untitled Page" %>
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
                                <h4 class="style1" style="background-color: #6E7F43">
                                    Building Approval Master
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
                            House Type Name :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlHouseTypeid" runat="server" Width="163px"></asp:DropDownList> 
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlHouseTypeid" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Building Description :
                        </td>
                        <td rowspan="2">
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="67px"></asp:TextBox>
                        </td>
                        <td rowspan="2">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                                ControlToValidate="txtDescription"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Area Name :
                        </td>
                        <td>
                            <asp:DropDownList  ID="ddlAreaName" runat="server" Width="163px" 
                                AutoPostBack="True" onselectedindexchanged="ddlAreaName_SelectedIndexChanged"></asp:DropDownList> 
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" InitialValue="--SelectOne--" ControlToValidate="ddlAreaName"
                                ErrorMessage="*"></asp:RequiredFieldValidator>
                       
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Street Name :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlStreetName" runat="server" Width="163px" 
                                AutoPostBack="True" onselectedindexchanged="ddlStreetName_SelectedIndexChanged">
                                <asp:ListItem>prasanth nagar</asp:ListItem>
                                <asp:ListItem>basti</asp:ListItem>
                            </asp:DropDownList> 
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlStreetName" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Plot Name :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPlotName" runat="server" Height="23px" Width="163px">
                                <asp:ListItem>101</asp:ListItem>
                                <asp:ListItem>102</asp:ListItem>
                                <asp:ListItem>201</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                                InitialValue="--SelectOne--" ControlToValidate="ddlPlotName"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                    <td>
                    No Of Floors Appr
                    </td>
                    <td>
                    <asp:TextBox ID="txtNOofFloor" Width="163px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="txtNOofFloor"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                    Plinth Area
                    </td>
                    <td>
                    <asp:TextBox ID="txtplithArea" runat="server" Width="163px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="txtplithArea"></asp:RequiredFieldValidator>
                    </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6" bgcolor="#6E7F43">
                            <center>
                                <asp:Button ID="btnAdd" runat="server" Text="Submit" BackColor="#BED3E9" Font-Bold="True"
                                    ForeColor="#CC0000" OnClick="btnAdd_Click" Height="20px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;
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


