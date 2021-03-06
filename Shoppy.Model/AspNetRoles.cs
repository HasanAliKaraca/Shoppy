
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shoppy.Model
{

    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public string Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
