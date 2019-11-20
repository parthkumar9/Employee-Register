using System;
using System.Collections.Generic;

namespace MyApplication.Models_dataAnnotations
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string Position { get; set; }
        public string DeptId { get; set; }
        public string Address { get; set; }

        public Departments Departments { get; set; }
    }
}
