<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmCategoryusageMaster.aspx.cs" Inherits="SubAdmin_frmCategoryusageMaster" Title="Untitled Page" %>

<%--    <style type="text/css">
        .tabledata
        {
            font-family: Verdana;
            font-weight: bold;
            font-size: xx-small;
            text-align: left;
            color: #FF3300;
            background-color: #B1B163;
        }
        .lbldata
        {
            font-weight: bold;
            font-family: Verdana;
            color: #FF0066;
        }
        .head
        {
            color: Yellow;
            background-color: #339966;
        }
        .top
        {
            vertical-align: top;
        }
        .right
        {
            text-align: right;
        }
    </style>--%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<table width="100%" style="text-align:left" >
<tr>
<td>
<center>
<h3>
Category Usage Master
</h3>
</center>
</td>
</tr>
<tr>
<td>

    <asp:ListView ID="ListView1" runat="server" 
        DataKeyNames="CategoryusageMasterId" DataSourceID="SqlDataSource1" 
        InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" 
                        Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="CategoryusageMasterIdLabel" runat="server" 
                        Text='<%# Eval("CategoryusageMasterId") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryusageNameLabel" runat="server" 
                        Text='<%# Eval("CategoryusageName") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryusageDescLabel" runat="server" 
                        Text='<%# Eval("CategoryusageDesc") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryusageAbbrLabel" runat="server" 
                        Text='<%# Eval("CategoryusageAbbr") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="itemPlaceholderContainer" runat="server" border="1" 
                            style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                <th runat="server">
                                </th>
                                <th runat="server">
                                    CategoryusageMasterId</th>
                                <th runat="server">
                                    CategoryusageName</th>
                                <th runat="server">
                                    CategoryusageDesc</th>
                                <th runat="server">
                                    CategoryusageAbbr</th>
                            </tr>
                            <tr ID="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" 
                        style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                        <asp:DataPager ID="DataPager1" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                                    ShowLastPageButton="True" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" ValidationGroup="b1" runat="server" CommandName="Insert" 
                        Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Clear" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="CategoryusageNameTextBox" runat="server" 
                        Text='<%# Bind("CategoryusageName") %>' />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="b1" ControlToValidate="CategoryusageNameTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="CategoryusageDescTextBox" runat="server" 
                        Text='<%# Bind("CategoryusageDesc") %>' />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="b1" ControlToValidate="CategoryusageDescTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="CategoryusageAbbrTextBox" runat="server" 
                        Text='<%# Bind("CategoryusageAbbr") %>' />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="b1" ControlToValidate="CategoryusageAbbrTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </InsertItemTemplate>
        <SelectedItemTemplate>
            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" 
                        Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="CategoryusageMasterIdLabel" runat="server" 
                        Text='<%# Eval("CategoryusageMasterId") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryusageNameLabel" runat="server" 
                        Text='<%# Eval("CategoryusageName") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryusageDescLabel" runat="server" 
                        Text='<%# Eval("CategoryusageDesc") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryusageAbbrLabel" runat="server" 
                        Text='<%# Eval("CategoryusageAbbr") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" 
                style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>
                        No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EditItemTemplate>
            <tr style="background-color:#008A8C;color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" ValidationGroup="c1" runat="server" CommandName="Update" 
                        Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Cancel" />
                </td>
                <td>
                    <asp:Label ID="CategoryusageMasterIdLabel1" runat="server" 
                        Text='<%# Eval("CategoryusageMasterId") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CategoryusageNameTextBox" runat="server" 
                        Text='<%# Bind("CategoryusageName") %>' />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="c1" runat="server" ErrorMessage="*" ControlToValidate="CategoryusageNameTextBox"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="CategoryusageDescTextBox" runat="server" 
                        Text='<%# Bind("CategoryusageDesc") %>' />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ValidationGroup="c1" ErrorMessage="*" ControlToValidate="CategoryusageDescTextBox"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="CategoryusageAbbrTextBox" runat="server" 
                        Text='<%# Bind("CategoryusageAbbr") %>' />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ValidationGroup="c1" ErrorMessage="*" ControlToValidate="CategoryusageAbbrTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </EditItemTemplate>
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" 
                        Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="CategoryusageMasterIdLabel" runat="server" 
                        Text='<%# Eval("CategoryusageMasterId") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryusageNameLabel" runat="server" 
                        Text='<%# Eval("CategoryusageName") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryusageDescLabel" runat="server" 
                        Text='<%# Eval("CategoryusageDesc") %>' />
                </td>
                <td>
                    <asp:Label ID="CategoryusageAbbrLabel" runat="server" 
                        Text='<%# Eval("CategoryusageAbbr") %>' />
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>

</td>
</tr>
<tr>
<td>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:MunicipalAdministrationSystemConnectionString %>" 
        DeleteCommand="DELETE FROM [tl_Categoryusagemaster] WHERE [CategoryusageMasterId] = @CategoryusageMasterId" 
        InsertCommand="INSERT INTO [tl_Categoryusagemaster] ([CategoryusageName], [CategoryusageDesc], [CategoryusageAbbr]) VALUES (@CategoryusageName, @CategoryusageDesc, @CategoryusageAbbr)" 
        SelectCommand="SELECT * FROM [tl_Categoryusagemaster]" 
        UpdateCommand="UPDATE [tl_Categoryusagemaster] SET [CategoryusageName] = @CategoryusageName, [CategoryusageDesc] = @CategoryusageDesc, [CategoryusageAbbr] = @CategoryusageAbbr WHERE [CategoryusageMasterId] = @CategoryusageMasterId">
        <DeleteParameters>
            <asp:Parameter Name="CategoryusageMasterId" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="CategoryusageName" Type="String" />
            <asp:Parameter Name="CategoryusageDesc" Type="String" />
            <asp:Parameter Name="CategoryusageAbbr" Type="String" />
            <asp:Parameter Name="CategoryusageMasterId" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="CategoryusageName" Type="String" />
            <asp:Parameter Name="CategoryusageDesc" Type="String" />
            <asp:Parameter Name="CategoryusageAbbr" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
</td>
</tr>
</table>
</center>
</asp:Content>

