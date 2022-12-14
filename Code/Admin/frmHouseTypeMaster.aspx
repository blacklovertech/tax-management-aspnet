<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmHouseTypeMaster.aspx.cs" Inherits="SubAdmin_frmHouseTypeMaster" Title="Untitled Page" %>

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
<table class="tabledata">
<tr>
<td>
<center>
<h2>House Type Master Details</h2>
</center>
</td>
</tr>
<tr>
<td>

    <asp:ListView ID="ListView1" runat="server" DataKeyNames="HouseTypeId" 
        DataSourceID="SqlDataSource1" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" 
                        Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="HouseTypeIdLabel" runat="server" 
                        Text='<%# Eval("HouseTypeId") %>' />
                </td>
                <td>
                    <asp:Label ID="HouseTypeNameLabel" runat="server" 
                        Text='<%# Eval("HouseTypeName") %>' />
                </td>
                <td>
                    <asp:Label ID="HouseTypeAbbrLabel" runat="server" 
                        Text='<%# Eval("HouseTypeAbbr") %>' />
                </td>
                <td>
                    <asp:Label ID="HouseTypeDescriptionLabel" runat="server" 
                        Text='<%# Eval("HouseTypeDescription") %>' />
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
                                    HouseTypeId</th>
                                <th runat="server">
                                    HouseTypeName</th>
                                <th runat="server">
                                    HouseTypeAbbr</th>
                                <th runat="server">
                                    HouseTypeDescription</th>
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
                                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
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
                    <asp:TextBox ID="HouseTypeNameTextBox" runat="server" 
                        Text='<%# Bind("HouseTypeName") %>' />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="b1" runat="server" ControlToValidate="HouseTypeNameTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                        
                </td>
                <td>
                    <asp:TextBox ID="HouseTypeAbbrTextBox" runat="server" 
                        Text='<%# Bind("HouseTypeAbbr") %>' />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="b1" runat="server" ControlToValidate="HouseTypeAbbrTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="HouseTypeDescriptionTextBox" runat="server" 
                        Text='<%# Bind("HouseTypeDescription") %>' />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="b1" runat="server" ControlToValidate="HouseTypeDescriptionTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
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
                    <asp:Label ID="HouseTypeIdLabel" runat="server" 
                        Text='<%# Eval("HouseTypeId") %>' />
                </td>
                <td>
                    <asp:Label ID="HouseTypeNameLabel" runat="server" 
                        Text='<%# Eval("HouseTypeName") %>' />
                </td>
                <td>
                    <asp:Label ID="HouseTypeAbbrLabel" runat="server" 
                        Text='<%# Eval("HouseTypeAbbr") %>' />
                </td>
                <td>
                    <asp:Label ID="HouseTypeDescriptionLabel" runat="server" 
                        Text='<%# Eval("HouseTypeDescription") %>' />
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
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                        Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Cancel" />
                </td>
                <td>
                    <asp:Label ID="HouseTypeIdLabel1" runat="server" 
                        Text='<%# Eval("HouseTypeId") %>' />
                </td>
                <td>
                    <asp:TextBox ID="HouseTypeNameTextBox" runat="server" 
                        Text='<%# Bind("HouseTypeName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="HouseTypeAbbrTextBox" runat="server" 
                        Text='<%# Bind("HouseTypeAbbr") %>' />
                </td>
                <td>
                    <asp:TextBox ID="HouseTypeDescriptionTextBox" runat="server" 
                        Text='<%# Bind("HouseTypeDescription") %>' />
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
                    <asp:Label ID="HouseTypeIdLabel" runat="server" 
                        Text='<%# Eval("HouseTypeId") %>' />
                </td>
                <td>
                    <asp:Label ID="HouseTypeNameLabel" runat="server" 
                        Text='<%# Eval("HouseTypeName") %>' />
                </td>
                <td>
                    <asp:Label ID="HouseTypeAbbrLabel" runat="server" 
                        Text='<%# Eval("HouseTypeAbbr") %>' />
                </td>
                <td>
                    <asp:Label ID="HouseTypeDescriptionLabel" runat="server" 
                        Text='<%# Eval("HouseTypeDescription") %>' />
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:MunicipalAdministrationSystemConnectionString %>" 
        DeleteCommand="DELETE FROM [tl_HouseTypeMaster] WHERE [HouseTypeId] = @original_HouseTypeId" 
        InsertCommand="INSERT INTO [tl_HouseTypeMaster] ([HouseTypeName], [HouseTypeAbbr], [HouseTypeDescription]) VALUES (@HouseTypeName, @HouseTypeAbbr, @HouseTypeDescription)" 
        OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT * FROM [tl_HouseTypeMaster]" 
        UpdateCommand="UPDATE [tl_HouseTypeMaster] SET [HouseTypeName] = @HouseTypeName, [HouseTypeAbbr] = @HouseTypeAbbr, [HouseTypeDescription] = @HouseTypeDescription WHERE [HouseTypeId] = @original_HouseTypeId">
        <DeleteParameters>
            <asp:Parameter Name="original_HouseTypeId" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="HouseTypeName" Type="String" />
            <asp:Parameter Name="HouseTypeAbbr" Type="String" />
            <asp:Parameter Name="HouseTypeDescription" Type="String" />
            <asp:Parameter Name="original_HouseTypeId" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="HouseTypeName" Type="String" />
            <asp:Parameter Name="HouseTypeAbbr" Type="String" />
            <asp:Parameter Name="HouseTypeDescription" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>

</td>
</tr>
<tr>
<td>
    &nbsp;</td>
</tr>
<tr>
<td>
    &nbsp;</td>
</tr>
</table>
</center>
</asp:Content>

<%--<asp:Content>
</asp:Content>--%>


