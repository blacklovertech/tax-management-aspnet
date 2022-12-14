<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="frmEditHouseMaster.aspx.cs" Inherits="SubAdmin_frmEditHouseMaster"
    Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
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
<asp:AsyncPostBackTrigger ControlID="ddlActualNO" EventName="SelectedIndexChanged" />
</Triggers>
<ContentTemplate>

 <asp:Panel ID="mainpanel" runat="server">
        <table class="tabledata" style="text-align:left">
            <tr>
                <td colspan="6" class="tddata">
                    <center>
                        <h4>
                            Modify House Master Details
                        </h4>
                    </center>
                </td>
            </tr>
            <tr>
            <td>Actual House No</td>
            <td>
            <asp:DropDownList ID="ddlActualNO" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlActualNO_SelectedIndexChanged"></asp:DropDownList>
            </td>
     <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" InitialValue="--SelectOne--" ControlToValidate="ddlActualNO"></asp:RequiredFieldValidator>
     </td>
                <td>
                    Owner Name :
                </td>
                <td>
                    <asp:TextBox ID="txtOwnerName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtOwnerName"
                        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
              
            </tr>
            <tr>
                  <td>
                    Telephone No :
                </td>
                <td>
                    <asp:TextBox ID="txttelephoneno" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txttelephoneno"
                        runat="server" ErrorMessage="*" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="*" ControlToValidate="txttelephoneno" Display="Dynamic" 
                        ValidationExpression="\d{0,5}-\d{6}"></asp:RegularExpressionValidator>
                </td>
                <td>
                    Email Id :
                </td>
                <td>
                    <asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtEmailid"
                        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ErrorMessage="*" ControlToValidate="txtEmailid" Display="Dynamic" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="6" class="tddata">
                    <center>
                        <asp:Button ID="btnAdd" runat="server" Text="Submit" BackColor="#999966" Font-Bold="True"
                            ForeColor="#CC0000" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" BackColor="#999966" Font-Bold="True"
                            ForeColor="#CC0000" OnClick="btnClear_Click" ValidationGroup="b1" />
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
