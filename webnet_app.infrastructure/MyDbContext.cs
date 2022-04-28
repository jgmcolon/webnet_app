
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using webnet_app.domain.Entities.Permission;

namespace webnet_app.infrastructure
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(bool reset = false) : base("name=rrhh_db")
        {
            if (reset) 
            {
                Database.SetInitializer<MyDbContext>(new zDBInitializer());

            }
            else
            {
                Database.SetInitializer<MyDbContext>(null);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Permission>().HasRequired(x => x.PermissionType).WithMany().HasForeignKey(x => x.PermissionTypeId);
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Permission> Permissions { get; set; }

        public DbSet<PermissionType> PermissionTypes { get; set; }

   
    }
}
