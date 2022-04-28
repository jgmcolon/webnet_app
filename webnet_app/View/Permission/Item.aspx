<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="webnet_app.View.Permission.Item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">Permiso</h3>
        </div>
        <div class="panel-body">

            <div class="form-group">
                <label for="FirstName" class="col-sm-2 control-label">Firstname</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtFirstName" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1"
                        runat="server"
                        ControlToValidate="txtFirstName"
                        ErrorMessage='Input your first name.'
                        EnableClientScript="true"
                        SetFocusOnError="true"
                        Text="*">
                    </asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="Lastname" class="col-sm-2 control-label">Lastname</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator2"
                        runat="server"
                        ControlToValidate="txtLastName"
                        ErrorMessage='Input your last name.'
                        EnableClientScript="true"
                        SetFocusOnError="true"
                        Text="*">
                    </asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="form-group">
                <label for="PermissionTypeId" class="col-sm-2 control-label">Permission Type</label>
                <div class="col-sm-10">
                    <asp:DropDownList ID="ddlPermissionTypeId" AutoPostBack="false" runat="server"
                        AppendDataBoundItems="true" CssClass="form-control">
                    </asp:DropDownList>


                </div>
            </div>

            <div class="form-group">
                <label for="PermissionTypeId" class="col-sm-2 control-label">Permission Date</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtPermissionDate" CssClass="form-control docs-date" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator3"
                        runat="server"
                        ControlToValidate="txtPermissionDate"
                        ErrorMessage='Input your Permission Date.'
                        EnableClientScript="true"
                        SetFocusOnError="true"
                        Text="*">
                    </asp:RequiredFieldValidator>
                </div>
            </div>





            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <br />
                    <asp:Button ID="btnSubmit" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="BtnSubmit_Click" />

                </div>
            </div>

            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <asp:HiddenField ID="hdRowID" runat="server" />
                    <asp:ValidationSummary
                        ID="ValidationSummary1"
                        runat="server"
                        HeaderText="Following error occurs....."
                        ShowMessageBox="false"
                        DisplayMode="BulletList"
                        ShowSummary="true"
                        BackColor="Snow"
                        Width="450"
                        ForeColor="Red"
                        Font-Size="X-Large"
                        Font-Italic="true" />
                </div>
            </div>


        </div>
    </div>

    <script>
        $('.docs-date').datepicker();
    </script>

</asp:Content>
