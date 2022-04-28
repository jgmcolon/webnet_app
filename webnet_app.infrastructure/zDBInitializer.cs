using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webnet_app.infrastructure
{
    public class zDBInitializer : DropCreateDatabaseAlways<MyDbContext>
    {

    }
}
