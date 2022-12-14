<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmMunicipalitytaxmaster.aspx.cs" Inherits="SubAdmin_frmMunicipalitytaxmaster" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
                        <td colspan="6" class="tddata">
                            <center>
                                <h4 class="style1" style="background-color: #6E7F45">
                                    Municipality Taxes </h4>
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
                            House Number :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlHouseNO" runat="server" AutoPostBack="True" 
                                Height="17px" Width="128px" 
                                onselectedindexchanged="ddlHouseNO_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlHouseNO" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Locality Name :
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlLocalityName" runat="server" AutoPostBack="True" 
                                Width="128px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlLocalityName" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Tax Assenment No :
                        </td>
                        <td>
                            <asp:TextBox ID="txtAssenmentNo" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                ControlToValidate="txtAssenmentNo"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Building Approval No :
                        </td>
                         <td>
                            <asp:TextBox ID="txtBuildingApprovalNo" ReadOnly="true" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                                ControlToValidate="txtBuildingApprovalNo"></asp:RequiredFieldValidator>
                             </td>
                    </tr>
                       <tr>
                        <td>
                            Revenue Circle Name:
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRevenueCircleName" runat="server" AutoPostBack="True" 
                                 Width="128px" 
                                onselectedindexchanged="ddlRevenueCircleName_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlRevenueCircleName" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Revenue Block Name :</td>
                        <td>
                            <asp:DropDownList ID="ddlBlockName" runat="server" AutoPostBack="True" 
                                Width="128px" onselectedindexchanged="ddlBlockName_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlBlockName" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            NO Of Floors :
                        </td>
                        <td>
                            <asp:TextBox ID="txtNoofFloors" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                                ControlToValidate="txtNoofFloors"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Property Tax Value :
                        </td>
                        <td>
                            <asp:TextBox ID="txtPropertyTaxValue" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                                ControlToValidate="txtPropertyTaxValue"></asp:RequiredFieldValidator>
                       </td>
                    </tr>
                    
                    <tr>
                        <td>
                            Education Tax Value :
                        </td>
                        <td>
                            <asp:TextBox ID="txtEducationTax" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*"
                                ControlToValidate="txtEducationTax"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            Library Cess :
                        </td>
                        <td>
                   <asp:TextBox ID="txtLibraryCess" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*"
                                ControlToValidate="txtLibraryCess"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            UAC-Penalty :
                        </td>
                        <td>
                          <asp:TextBox ID="txtPenalty" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*"
                                ControlToValidate="txtPenalty"></asp:RequiredFieldValidator>
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
                                    ForeColor="#CC0000" OnClick="btnAdd_Click" Height="20px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnClear" runat="server" Text="Clear" BackColor="#999966" Font-Bold="True"
                                    ForeColor="#CC0000" ValidationGroup="b1" Height="20px" 
                                    OnClick="btnClear_Click" Width="56px" />
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
                        HorizontalSide="Center" VerticalSide="Middle">
                    </cc1:AlwaysVisibleControlExtender>
                </center>
                <br />
                <asp:Label ID="lblError" CssClass="lbldata" runat="server"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    </center>
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