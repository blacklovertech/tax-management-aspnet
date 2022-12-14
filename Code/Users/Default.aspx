<%@ Page Language="C#" MasterPageFile="~/Users/UserMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Users_Default" Title="Untitled Page" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<h2>
    &nbsp;</h2>
    <h2>
        &nbsp;</h2>
    <p>
        &nbsp;</p>
    <h1>
        <span class="style1">Welcome 
</span> 
<br class="style1" />
        <span class="style1">To
</span>
<br class="style1" />
        <span class="style1"> <%=Session["UserName"].ToString().ToUpper()%>
</span>
</h1>
</center>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">

        <link href="../jqueryslidemenu.css" rel="stylesheet" type="text/css" />

        <script src="../CS/jquery.min.js" type="text/javascript"></script>

        <script src="../CS/jqueryslidemenu.js" type="text/javascript"></script>

    <style type="text/css">
        .style1
        {
            color: #CC0000;
        }
    </style>


</asp:Content>


