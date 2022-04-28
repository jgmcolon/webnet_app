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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var ctx = new MyDbContext())
            {


                

                if (!string.IsNullOrEmpty(Request.QueryString["RowId"]))
                {

                    string RowId = Request.QueryString["RowId"];



                    if (RowId.IsGuid())
                    {

                        Guid rowId = RowId.ToGuid();

                        var permission = ctx.Permissions.Where(x => x.RowId.Equals(rowId)).Include(pt => pt.PermissionType).FirstOrDefault();


                        if (permission != null)
                        {
                            lbFirstName.Text = permission.FirstName;
                            lbLastName.Text = permission.LastName;
                            lbPermissionTypeId.Text = permission.PermissionType.Description;
                            lbPermissionDate.Text = permission.PermissionDate.ToString("MM/dd/yyyy");
                            
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

                    if (!string.IsNullOrWhiteSpace(hdRowID.Value))
                    {


                        Guid rowId = hdRowID.Value.ToGuid();

                        var permission = ctx.Permissions.Where(x => x.RowId.Equals(rowId)).FirstOrDefault();

                        ctx.Entry(permission).State = EntityState.Deleted;
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