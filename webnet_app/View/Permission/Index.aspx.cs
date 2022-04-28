using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webnet_app.domain.Entities.Permission;
using webnet_app.domain.ViewModel;
using webnet_app.infrastructure;

namespace webnet_app.View.Permission
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var ctx = new MyDbContext())
            {

                var  data = ctx.Permissions.Include(pt => pt.PermissionType).AsEnumerable().Select(x => new PermissionViewModel
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Id = x.Id,
                    PermissionType = x.PermissionType.Description,
                    RowId = x.RowId.ToString(),
                    PermissionDate = x.PermissionDate.ToString("dd-MMM-yyyy")
                }).ToList();

                Repeater1.DataSource = data;
                Repeater1.DataBind();
            }
        }
    }
}