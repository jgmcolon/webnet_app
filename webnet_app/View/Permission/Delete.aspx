<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="webnet_app.View.Permission.Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">Delete Permissions</h3>
        </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="FirstName" class="col-sm-2 control-label">Firstname</label>
                <div class="col-sm-10">
                    <asp:Label ID="lbFirstName" CssClass="form-control" runat="server"></asp:Label>
                </div>
            </div>
            <div class="form-group">
                <label for="Lastname" class="col-sm-2 control-label">Lastname</label>
                <div class="col-sm-10">
                    <asp:Label ID="lbLastName" CssClass="form-control" runat="server"></asp:Label>

                </div>
            </div>

            <div class="form-group">
                <label for="PermissionTypeId" class="col-sm-2 control-label">Permission Type</label>
                <div class="col-sm-10">
                    <asp:Label ID="lbPermissionTypeId" runat="server">
                    </asp:Label>


                </div>
            </div>

            <div class="form-group">
                <label for="PermissionTypeId" class="col-sm-2 control-label">Permission Date</label>
                <div class="col-sm-10">
                    <asp:Label ID="lbPermissionDate" CssClass="form-control docs-date" runat="server"></asp:Label>
                    <asp:HiddenField ID="hdRowID" runat="server" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <br />
                    <asp:Button ID="btnSubmit" runat="server" Text="Delete" CssClass="btn btn-primary" OnClick="BtnSubmit_Click" />

                </div>
            </div>

        </div>
    </div>
</asp:Content>
