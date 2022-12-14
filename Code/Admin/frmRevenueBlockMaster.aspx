<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="frmRevenueBlockMaster.aspx.cs" Inherits="Admin_frmRevenueBlockMaster"
    Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<center>
<asp:UpdatePanel ID="updatepanel" runat="server">
<Triggers>
<asp:AsyncPostBackTrigger ControlID="btnSubmit" EventName="Click" />
<asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
</Triggers>
<ContentTemplate>

    &nbsp;<center>
        &nbsp;
        <br />
        <asp:Panel ID="mainpanel" runat="server">
        <table style="text-align: left">
            <tr>
                <td colspan="3">
                    <center>
                        <h3 class="style1" style="background-color: #6D8143; color: #FFFFFF;">
                            Add Revenue Block Details
                        </h3>
                    </center>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td align="left">
                    Revenue Block Name :
                </td>
                <td>
                    <asp:TextBox ID="txtRevenueName" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="requireName" runat="server" ErrorMessage="*" ControlToValidate="txtRevenueName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="left" valign="top">
                    Revenue Block Description :
                </td>
                <td>
                    <asp:TextBox ID="txtdescrip" TextMode="MultiLine" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="requireDesc" runat="server" ControlToValidate="txtdescrip"
                        ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Revenue Block Abbrvation :
                </td>
                <td>
                    <asp:TextBox ID="txtAbbrvation" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                        ControlToValidate="txtAbbrvation"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="left">
                    Revenue Block Span :
                </td>
                <td>
                    <asp:TextBox ID="txtSpan" runat="server" Width="181px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                        ControlToValidate="txtSpan"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="left">
                    Revenue Block Name :
                </td>
                <td>
                    <asp:DropDownList ID="ddlRevenuName" runat="server" Width="181px">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                        ControlToValidate="ddlRevenuName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="3" bgcolor="#6E8043">
                    <center>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" Height="20px" OnClick="btnSubmit_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnClear" runat="server" Text="Clear" Height="20px" Width="59px"
                            OnClick="btnClear_Click" CausesValidation="False" />
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
                        HorizontalSide="Center" VerticalSide="Middle">
                    </cc1:AlwaysVisibleControlExtender>
                </center>


        
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </ContentTemplate>
</asp:UpdatePanel>
    </center>
</asp:Content>
