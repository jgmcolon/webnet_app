using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webnet_app.domain.Common
{
    public class Maintenance
    {
        protected Maintenance()
        {
            Active = true;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }


        [Required]
        public bool Active { get; set; }

    }
}
