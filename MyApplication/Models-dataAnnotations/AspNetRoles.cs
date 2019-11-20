using System;
using System.Collections.Generic;

namespace MyApplication.Models_dataAnnotations
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string NormalizedName { get; set; }

        public ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
    }
}
