<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="frmAreaTypeMaster.aspx.cs" Inherits="SubAdmin_frmAreaTypeMaster" Title="Untitled Page" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
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
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <table class="tabledata" style="text-align:left">
            <tr>
                <td>
                    <center>
                        <h3>
                            Area Type Master
                        </h3>
                    </center>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ListView ID="ListView1" runat="server" DataKeyNames="AreaTypeId" DataSourceID="SqlDataSource1"
                        InsertItemPosition="LastItem">
                        <AlternatingItemTemplate>
                            <tr style="background-color: #FFF8DC;">
                                <td>
                                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeIdLabel" runat="server" Text='<%# Eval("AreaTypeId") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeNameLabel" runat="server" Text='<%# Eval("AreaTypeName") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeAbbrLabel" runat="server" Text='<%# Eval("AreaTypeAbbr") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeDescLabel" runat="server" Text='<%# Eval("AreaTypeDesc") %>' />
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server">
                                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;
                                            border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;
                                            font-family: Verdana, Arial, Helvetica, sans-serif;">
                                            <tr runat="server" style="background-color: #DCDCDC; color: #000000;">
                                                <th runat="server">
                                                </th>
                                                <th runat="server">
                                                    AreaTypeId
                                                </th>
                                                <th runat="server">
                                                    AreaTypeName
                                                </th>
                                                <th runat="server">
                                                    AreaTypeAbbr
                                                </th>
                                                <th runat="server">
                                                    AreaTypeDesc
                                                </th>
                                            </tr>
                                            <tr id="itemPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif;
                                        color: #000000;">
                                        <asp:DataPager ID="DataPager1" runat="server">
                                            <Fields>
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
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
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    <asp:TextBox ID="AreaTypeNameTextBox" runat="server" Text='<%# Bind("AreaTypeName") %>' />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="b1" ControlToValidate="AreaTypeNameTextBox"
                                        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                                </td>
                                <td>
                                    <asp:TextBox ID="AreaTypeAbbrTextBox" runat="server" Text='<%# Bind("AreaTypeAbbr") %>' />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="b1" ControlToValidate="AreaTypeAbbrTextBox"
                                        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                                </td>
                                <td>
                                    <asp:TextBox ID="AreaTypeDescTextBox" runat="server" Text='<%# Bind("AreaTypeDesc") %>' />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="b1" runat="server"
                                        ControlToValidate="AreaTypeDescTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </InsertItemTemplate>
                        <SelectedItemTemplate>
                            <tr style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">
                                <td>
                                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeIdLabel" runat="server" Text='<%# Eval("AreaTypeId") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeNameLabel" runat="server" Text='<%# Eval("AreaTypeName") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeAbbrLabel" runat="server" Text='<%# Eval("AreaTypeAbbr") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeDescLabel" runat="server" Text='<%# Eval("AreaTypeDesc") %>' />
                                </td>
                            </tr>
                        </SelectedItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse;
                                border-color: #999999; border-style: none; border-width: 1px;">
                                <tr>
                                    <td>
                                        No data was returned.
                                    </td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <EditItemTemplate>
                            <tr style="background-color: #008A8C; color: #FFFFFF;">
                                <td>
                                    <asp:Button ID="UpdateButton" ValidationGroup="c1" runat="server" CommandName="Update"
                                        Text="Update" />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeIdLabel1" runat="server" Text='<%# Eval("AreaTypeId") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="AreaTypeNameTextBox" runat="server" Text='<%# Bind("AreaTypeName") %>' />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="c1" ControlToValidate="AreaTypeNameTextBox"
                                        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                                </td>
                                <td>
                                    <asp:TextBox ID="AreaTypeAbbrTextBox" runat="server" Text='<%# Bind("AreaTypeAbbr") %>' />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ValidationGroup="c1"
                                        ControlToValidate="AreaTypeAbbrTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                                </td>
                                <td>
                                    <asp:TextBox ID="AreaTypeDescTextBox" runat="server" Text='<%# Bind("AreaTypeDesc") %>' />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ValidationGroup="c1"
                                        ControlToValidate="AreaTypeDescTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <tr style="background-color: #DCDCDC; color: #000000;">
                                <td>
                                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeIdLabel" runat="server" Text='<%# Eval("AreaTypeId") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeNameLabel" runat="server" Text='<%# Eval("AreaTypeName") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeAbbrLabel" runat="server" Text='<%# Eval("AreaTypeAbbr") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="AreaTypeDescLabel" runat="server" Text='<%# Eval("AreaTypeDesc") %>' />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MunicipalAdministrationSystemConnectionString %>"
                        DeleteCommand="DELETE FROM [tl_AreaTypeMaster] WHERE [AreaTypeId] = @AreaTypeId"
                        InsertCommand="INSERT INTO [tl_AreaTypeMaster] ([AreaTypeName], [AreaTypeAbbr], [AreaTypeDesc]) VALUES (@AreaTypeName, @AreaTypeAbbr, @AreaTypeDesc)"
                        SelectCommand="SELECT * FROM [tl_AreaTypeMaster]" UpdateCommand="UPDATE [tl_AreaTypeMaster] SET [AreaTypeName] = @AreaTypeName, [AreaTypeAbbr] = @AreaTypeAbbr, [AreaTypeDesc] = @AreaTypeDesc WHERE [AreaTypeId] = @AreaTypeId">
                        <DeleteParameters>
                            <asp:Parameter Name="AreaTypeId" Type="Int32" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="AreaTypeName" Type="String" />
                            <asp:Parameter Name="AreaTypeAbbr" Type="String" />
                            <asp:Parameter Name="AreaTypeDesc" Type="String" />
                            <asp:Parameter Name="AreaTypeId" Type="Int32" />
                        </UpdateParameters>
                        <InsertParameters>
                            <asp:Parameter Name="AreaTypeName" Type="String" />
                            <asp:Parameter Name="AreaTypeAbbr" Type="String" />
                            <asp:Parameter Name="AreaTypeDesc" Type="String" />
                        </InsertParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    </center>
</asp:Content>
