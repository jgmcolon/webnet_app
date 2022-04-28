using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webnet_app.domain.Extensions;
using webnet_app.infrastructure;


namespace webnet_app.View.Permission
{
    public partial class Item : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (var ctx = new MyDbContext())
            {


                ddlPermissionTypeId.DataSource = ctx.PermissionTypes.Where(x => x.Active.Equals(true)).ToList();
                ddlPermissionTypeId.Items.Clear();
                ddlPermissionTypeId.DataTextField = "Description";
                ddlPermissionTypeId.DataValueField = "Id";
                ddlPermissionTypeId.DataBind();

                if (!string.IsNullOrEmpty(Request.QueryString["RowId"]))
                {

                    string RowId = Request.QueryString["RowId"];



                    if (RowId.IsGuid())
                    {

                        Guid rowId = RowId.ToGuid();

                        var permission = ctx.Permissions.Where(x => x.RowId.Equals(rowId)).FirstOrDefault();

                        if (permission != null) {
                            txtFirstName.Text = permission.FirstName;
                            txtLastName.Text = permission.LastName;
                            ddlPermissionTypeId.SelectedValue = permission.PermissionTypeId.ToString();
                            txtPermissionDate.Text = permission.PermissionDate.ToString("MM/dd/yyyy");
                            hdRowID.Value = RowId;
                        }
                    }
                }
            }
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new MyDbContext())
                {

                    if (string.IsNullOrWhiteSpace(hdRowID.Value))
                    {
                        var permission = new domain.Entities.Permission.Permission
                        {
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            PermissionTypeId = ddlPermissionTypeId.SelectedValue.ToInt(),
                            PermissionDate = txtPermissionDate.Text.ToDate("en-US")

                        };




                        ctx.Permissions.Add(permission);
                    }
                    else
                    {
                        Guid rowId = hdRowID.Value.ToGuid();

                        var permission = ctx.Permissions.Where(x => x.RowId.Equals(rowId)).FirstOrDefault();


                        permission.FirstName = txtFirstName.Text;
                        permission.LastName = txtLastName.Text;
                        permission.PermissionTypeId = ddlPermissionTypeId.SelectedValue.ToInt();
                        permission.PermissionDate = txtPermissionDate.Text.ToDate("en-US");

                        ctx.Entry(permission).State = EntityState.Modified;

                    }

                    ctx.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                Response.Write($"<script type=\"text/javascript\">alert('{ex.InnerException?.Message}');</script>");
            }
        }
    }
}