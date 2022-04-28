using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webnet_app.domain.Common
{
    
    public class Auditory
    {
        protected Auditory()
        {
            
            RowId = Guid.NewGuid();
        }


        [Required]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid RowId { get; set; }

    }
}
