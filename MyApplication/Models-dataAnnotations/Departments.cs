using System;
using System.Collections.Generic;

namespace MyApplication.Models_dataAnnotations
{
    public partial class Departments
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string NoOfEmp { get; set; }
        public int? AvgAge { get; set; }

        public Employees Dept { get; set; }
    }
}
