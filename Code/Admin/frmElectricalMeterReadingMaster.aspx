<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmElectricalMeterReadingMaster.aspx.cs" Inherits="Admin_frmElectricalMeterReadingMaster" Title="Untitled Page" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="Updatepanel1" runat="server">
<Triggers>
<asp:AsyncPostBackTrigger ControlID="ddluniqueno" EventName="SelectedIndexChanged" />
<asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
<asp:AsyncPostBackTrigger ControlID="btnAdd" EventName="Click" />

</Triggers>
<ContentTemplate>
<center>
<br />
<br />
 <asp:Panel ID="mainpanel" runat="server">
<table style="text-align:left">
<tr>
<td colspan="6">
<center>
<h3 style="background-color: #566A27; color: #FFFFFF;">Add Electricity Meter Reading Details</h3>
</center>
</td>
</tr>
<tr>
<td align="left">
Unique HouseNo :
</td>
<td align="left">
<asp:DropDownList ID="ddluniqueno" runat="server" AutoPostBack="True" Height="21px" 
        onselectedindexchanged="ddluniqueno_SelectedIndexChanged" Width="127px"></asp:DropDownList>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="ddluniqueno" InitialValue="--Select One--"></asp:RequiredFieldValidator>
</td>
<td align="left">
    Electrical Service No :
</td>
<td align="left">
    <asp:DropDownList ID="ddlElectricalServiceNo" runat="server" 
        AutoPostBack="True" Height="21px" 
        onselectedindexchanged="ddlElectricalServiceNo_SelectedIndexChanged" 
        Width="127px">
    </asp:DropDownList>
</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td align="left" class="style1">
Previous Reading:
</td>
<td align="left" class="style1">
<asp:TextBox ID="txtPreviousReading" runat="server"></asp:TextBox>
</td>
<td class="style1">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txtPreviousReading"></asp:RequiredFieldValidator>
</td>
<td align="left" class="style1">
Present Reading :
</td>
<td align="left" class="style1">
<asp:TextBox ID="txtPresentReading" runat="server"></asp:TextBox>
</td>
<td class="style1">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="txtPresentReading"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
Units Consumed :
</td>
<td align="left">
<asp:TextBox ID="txtConsumed" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="txtConsumed"></asp:RequiredFieldValidator>
</td>
<td align="left">
Emergency Charges :
</td>
<td align="left">
<asp:TextBox ID="txtemergencyCharge" runat="server" ValidationGroup="b1"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
        ErrorMessage="*" ControlToValidate="txtemergencyCharge" ValidationGroup="b1"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left"> 
Cust Charges :
</td>
<td align="left">
<asp:TextBox ID="txtCustCharges" runat="server" ValidationGroup="b1"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
        ErrorMessage="*" ControlToValidate="txtCustCharges" ValidationGroup="b1"></asp:RequiredFieldValidator>
</td>
<td align="left">
Ed:
</td>
<td align="left">
<asp:TextBox ID="txtEd" runat="server" ValidationGroup="b1"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
        ErrorMessage="*" ControlToValidate="txtEd" ValidationGroup="b1"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left" class="style1">
AddlCharges:
</td>
<td align="left" class="style1">
<asp:TextBox ID="txtAddlCharges" runat="server" ValidationGroup="b1"></asp:TextBox>
</td>
<td class="style1">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
        ErrorMessage="*" ControlToValidate="txtAddlCharges" ValidationGroup="b1"></asp:RequiredFieldValidator>
</td>
<td align="left" class="style1">
Fsa Charges :
</td>
<td align="left" class="style1">
<asp:TextBox ID="txtfsacharges" runat="server" ValidationGroup="b1"></asp:TextBox>
</td>
<td class="style1">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
        ErrorMessage="*" ControlToValidate="txtfsacharges" ValidationGroup="b1"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
Acd Charges:
</td>
<td align="left">
<asp:TextBox ID="txtAcdCharges" runat="server" ValidationGroup="b1"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
        ErrorMessage="*" ControlToValidate="txtAcdCharges" ValidationGroup="b1"></asp:RequiredFieldValidator>
</td>
<td align="left">
Bill Amount :
</td>
<td align="left">
<asp:TextBox ID="txtBillAmount" runat="server" ValidationGroup="b1"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
        ErrorMessage="*" ControlToValidate="txtBillAmount" ValidationGroup="b1"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="left">
Adj Amount:
</td>
<td align="left">
<asp:TextBox ID="txtAdjamount" runat="server" ValidationGroup="b1"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
        ErrorMessage="*" ControlToValidate="txtAdjamount" ValidationGroup="b1"></asp:RequiredFieldValidator>
</td>
<td align="left" valign="top">
Net Amount : 
    <asp:Button ID="btnNetAMount" runat="server" Text="Count" 
        onclick="btnNetAMount_Click" ValidationGroup="b1" />

</td>
<td align="left">
<asp:TextBox ID="txtnetAmount" runat="server" ValidationGroup="b1"></asp:TextBox>
</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td align="left">
Arreas:
</td>
<td align="left">
<asp:TextBox ID="txtArreas" runat="server"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="*" ControlToValidate="txtArreas"></asp:RequiredFieldValidator>
</td>
<td align="left">
Date Of Electricity Bill :
</td>
<td align="left">
<asp:TextBox ID="txtDateelectricityBill" runat="server"></asp:TextBox>
    <cc1:CalendarExtender ID="txtDateelectricityBill_CalendarExtender" 
        runat="server" Enabled="True" TargetControlID="txtDateelectricityBill">
    </cc1:CalendarExtender>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ErrorMessage="*" ControlToValidate="txtDateelectricityBill"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td colspan="6" bgcolor="#566A27">
<center>
<asp:Button ID="btnAdd" runat="server" Text="Submit" Height="20px" 
        onclick="btnAdd_Click" Enabled="False" />
&nbsp;&nbsp;&nbsp;
<asp:Button ID="btnClear" runat="server" Text="Clear" Height="20px" 
        onclick="btnClear_Click" CausesValidation="False" />
        </center>
</td>
</tr>
</table>
</asp:Panel>
<br />
<br />
<center>
<asp:UpdateProgress ID="Updateprogress1" runat="server">
<ProgressTemplate>
<div id="progess" runat="server" style="background-color:Green;font-weight:bold;font-family:Verdana;font-size:small;width:150px;height:auto;vertical-align:middle">
Processing....
<img src="../Images/1asp017.gif" height="100px" width="100px" />
</div>
</ProgressTemplate>
</asp:UpdateProgress>
<cc1:AlwaysVisibleControlExtender ID="Externder1" runat="server" Enabled="true" TargetControlID="progess" HorizontalSide="Center" VerticalSide="Middle"></cc1:AlwaysVisibleControlExtender>
</center>
 
<asp:Label ID="lblError" runat="server"></asp:Label>
</center>
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <link href="../jqueryslidemenu.css" rel="stylesheet" type="text/css" />

        <script src="../CS/jquery.min.js" type="text/javascript"></script>

        <script src="../CS/jqueryslidemenu.js" type="text/javascript"></script>

    <style type="text/css">
    .style1
    {
        height: 26px;
    }
</style>




































</asp:Content>


