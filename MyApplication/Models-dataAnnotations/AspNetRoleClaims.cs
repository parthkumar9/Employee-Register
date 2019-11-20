using System;
using System.Collections.Generic;

namespace MyApplication.Models_dataAnnotations
{
    public partial class AspNetRoleClaims
    {
        public string Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string RoleId { get; set; }
    }
}
