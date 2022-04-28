<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="webnet_app.View.Permission.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">List of Permissions</h3>
        </div>
        <div class="panel-body">

            <div class="table-responsive">
                <table class="table table-bordered table-hover">
                    <asp:Repeater ID="Repeater1" runat="server">

                        <HeaderTemplate>

                            <tr>
                                <td>FirstName
                                </td>
                                <td>LastName
                                </td>
                                <td>PermissionDate
                                </td>
                                <td>PermissionType
                                </td>

                                <td></td>
                            </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>

                                <td>
                                    <%#Eval("FirstName") %>
                                </td>
                                <td>
                                    <%#Eval("LastName") %>
                                </td>
                                <td>
                                    <%#Eval("PermissionDate") %>
                                </td>
                                <td>
                                    <%#Eval("PermissionType") %>
                                </td>

                                <td>
                                    <a runat="server" href='<%#Eval("RowId", "~/View/Permission/Item?RowId={0}") %>'>Edit</a>
                                    |
                            <a runat="server" href='<%#Eval("RowId", "~/View/Permission/Delete?RowId={0}") %>'>Delete</a>
                                </td>

                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                        </FooterTemplate>

                    </asp:Repeater>

                </table>
            </div>


        </div>
    </div>



</asp:Content>
