using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webnet_app.domain.Common;

namespace webnet_app.domain.Entities.Permission
{
    [Table("Permission", Schema = "Permission")]
    public class Permission : Auditory
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }



        [ForeignKey("PermissionType")]
        public int PermissionTypeId { get; set; }
        public virtual PermissionType PermissionType { get; set; }


        [Required]
        public DateTime PermissionDate { get; set; }


    }
}
