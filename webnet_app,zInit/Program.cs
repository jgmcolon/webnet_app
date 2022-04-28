using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webnet_app.domain.Entities.Permission;

using webnet_app.infrastructure;

namespace webnet_app_zInit
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new MyDbContext(true))
            {

                ctx.PermissionTypes.Add(new PermissionType() { Description = "Enfermedad" });
                ctx.PermissionTypes.Add(new PermissionType() { Description = "diligencias" });
                ctx.PermissionTypes.Add(new PermissionType() { Description = "otros" });
                ctx.SaveChanges();
            }
        }
    }
}
