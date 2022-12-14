<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmStreetTypeMaster.aspx.cs" Inherits="SubAdmin_frmStreetTypeMaster" Title="Untitled Page" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .tabledata
        {
            font-family: Verdana;
            font-weight: bold;
            font-size: xx-small;
            text-align: left;
            color: #FF3300;
            background-color:#B1B163;
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
        </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<table class="tabledata" style="text-align:left">
<tr>
<td>
<center>
<h3>Street Type Master </h3>
</center>
</td>
</tr>
<tr>
<td>

    <asp:ListView ID="ListView1" runat="server" DataKeyNames="StreetTypeId" 
        DataSourceID="SqlDataSource1" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" 
                        Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="StreetTypeIdLabel" runat="server" 
                        Text='<%# Eval("StreetTypeId") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetTypeNameLabel" runat="server" 
                        Text='<%# Eval("StreetTypeName") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetTypeAbbrLabel" runat="server" 
                        Text='<%# Eval("StreetTypeAbbr") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetTypeDescriptionLabel" runat="server" 
                        Text='<%# Eval("StreetTypeDescription") %>' />
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
                                    StreetTypeId</th>
                                <th runat="server">
                                    StreetTypeName</th>
                                <th runat="server">
                                    StreetTypeAbbr</th>
                                <th runat="server">
                                    StreetTypeDescription</th>
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
                    <asp:Button ID="InsertButton" runat="server" ValidationGroup="b1" CommandName="Insert" 
                        Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Clear" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="StreetTypeNameTextBox" runat="server" 
                        Text='<%# Bind("StreetTypeName") %>' />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="b1" runat="server" ControlToValidate="StreetTypeNameTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                        
                </td>
                <td>
                    <asp:TextBox ID="StreetTypeAbbrTextBox" runat="server" 
                        Text='<%# Bind("StreetTypeAbbr") %>' />
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="b1" runat="server" ControlToValidate="StreetTypeAbbrTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="StreetTypeDescriptionTextBox" runat="server" 
                        Text='<%# Bind("StreetTypeDescription") %>' />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="b1" runat="server" ControlToValidate="StreetTypeDescriptionTextBox" ErrorMessage="*"></asp:RequiredFieldValidator> 
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
                    <asp:Label ID="StreetTypeIdLabel" runat="server" 
                        Text='<%# Eval("StreetTypeId") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetTypeNameLabel" runat="server" 
                        Text='<%# Eval("StreetTypeName") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetTypeAbbrLabel" runat="server" 
                        Text='<%# Eval("StreetTypeAbbr") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetTypeDescriptionLabel" runat="server" 
                        Text='<%# Eval("StreetTypeDescription") %>' />
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
                    <asp:Label ID="StreetTypeIdLabel1" runat="server" 
                        Text='<%# Eval("StreetTypeId") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StreetTypeNameTextBox" runat="server" 
                        Text='<%# Bind("StreetTypeName") %>' />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="c1" runat="server" ControlToValidate="StreetTypeNameTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="StreetTypeAbbrTextBox" runat="server" 
                        Text='<%# Bind("StreetTypeAbbr") %>' />
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="c1" runat="server" ControlToValidate="StreetTypeNameTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="StreetTypeDescriptionTextBox" runat="server" 
                        Text='<%# Bind("StreetTypeDescription") %>' />
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="c1" runat="server" ControlToValidate="StreetTypeNameTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
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
                    <asp:Label ID="StreetTypeIdLabel" runat="server" 
                        Text='<%# Eval("StreetTypeId") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetTypeNameLabel" runat="server" 
                        Text='<%# Eval("StreetTypeName") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetTypeAbbrLabel" runat="server" 
                        Text='<%# Eval("StreetTypeAbbr") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetTypeDescriptionLabel" runat="server" 
                        Text='<%# Eval("StreetTypeDescription") %>' />
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
        DeleteCommand="DELETE FROM [tl_StreetTypeMaster] WHERE [StreetTypeId] = @StreetTypeId" 
        InsertCommand="INSERT INTO [tl_StreetTypeMaster] ([StreetTypeName], [StreetTypeAbbr], [StreetTypeDescription]) VALUES (@StreetTypeName, @StreetTypeAbbr, @StreetTypeDescription)" 
        SelectCommand="SELECT * FROM [tl_StreetTypeMaster]" 
        UpdateCommand="UPDATE [tl_StreetTypeMaster] SET [StreetTypeName] = @StreetTypeName, [StreetTypeAbbr] = @StreetTypeAbbr, [StreetTypeDescription] = @StreetTypeDescription WHERE [StreetTypeId] = @StreetTypeId">
        <DeleteParameters>
            <asp:Parameter Name="StreetTypeId" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="StreetTypeName" Type="String" />
            <asp:Parameter Name="StreetTypeAbbr" Type="String" />
            <asp:Parameter Name="StreetTypeDescription" Type="String" />
            <asp:Parameter Name="StreetTypeId" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="StreetTypeName" Type="String" />
            <asp:Parameter Name="StreetTypeAbbr" Type="String" />
            <asp:Parameter Name="StreetTypeDescription" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
    </td>
</tr>


</table>
</center>
</asp:Content>

