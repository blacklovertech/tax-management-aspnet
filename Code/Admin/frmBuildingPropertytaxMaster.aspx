<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmBuildingPropertytaxMaster.aspx.cs" Inherits="SubAdmin_frmBuildingPropertytaxMaster" Title="Untitled Page" %>
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
    .style1
    {
        height: 25px;
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
                                <h4 style="background-color:#6E7F43" class="style1">
                                    Building Property Tax Master</h4>
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
                                Height="17px" Width="126px" 
                                onselectedindexchanged="ddlHouseNO_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td >
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                                ControlToValidate="ddlHouseNO" InitialValue="--SelectOne--"></asp:RequiredFieldValidator>
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
                                Property Tax Amount :
                        </td>
                        <td>
                            <asp:TextBox ID="txtPropertyTaxValue" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                                ControlToValidate="txtPropertyTaxValue"></asp:RequiredFieldValidator>
                       </td>
                            <td>
                                Education Tax Amount :
                        </td>
                        <td>
                            <asp:TextBox ID="txtEducationTax" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*"
                                ControlToValidate="txtEducationTax"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    
                    <tr>
                   
                        <td>
                            Library Cess Amount :
                        </td>
                        <td>
                   <asp:TextBox ID="txtLibraryCess" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*"
                                ControlToValidate="txtLibraryCess"></asp:RequiredFieldValidator>
                        </td>
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
                        <td colspan="6" class="tddata" bgcolor="#6E7F43">
                            <center>
                                <asp:Button ID="btnAdd" runat="server" Text="Submit" BackColor="#999966" Font-Bold="True"
                                    ForeColor="#CC0000" OnClick="btnAdd_Click" Height="20px" />
                                <asp:Button ID="btnClear" runat="server" Text="Clear" BackColor="#999966" Font-Bold="True"
                                    ForeColor="#CC0000" ValidationGroup="b1" Height="20px" 
                                    OnClick="btnClear_Click" />
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


