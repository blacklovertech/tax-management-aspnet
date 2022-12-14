<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmMunicipalityTaxDetailsReports.aspx.cs" Inherits="Admin_frmMunicipalityTaxDetailsReports" Title="Untitled Page" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <script language="javascript" type="text/javascript">
 
    function callPrint(elementId)
    {
       var prtContent = document.getElementById(elementId);                
       var WinPrint = window.open('','', 'left=0,top=0,width=1000,height=600,toolbar=2,scrollbars=2,status=0');
       var docColor="Black";
       var strInnerHTML=prtContent.innerHTML;
       var strModifiedInnerHTMl=strInnerHTML.replace(/white/g,docColor);
       WinPrint.document.write(strModifiedInnerHTMl);
       WinPrint.document.close();
       WinPrint.focus();
       WinPrint.print();
       WinPrint.close();
    }
    
    
    </script>
    <center>
<table>
<tr>
<td>
<h3>
Municipality Tax Details
</h3>
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td>
<asp:Button ID="btnGetReport" OnClientClick="callPrint('divReport')" runat="server" Text="Print Report" />
</td>
</tr>
<tr>
<td>
<div id="divReport">
<asp:GridView ID="gridReport" runat="server" AllowPaging="True" ForeColor="Black" 
        onpageindexchanging="gridReport_PageIndexChanging">
</asp:GridView>
</div>
</td>
</tr>
<tr>
<td>
<br />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblError" runat="server"></asp:Label>
</td>
</tr>
</table>
</center>

</asp:Content>

<%--<asp:Content ID="Content3" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>--%>