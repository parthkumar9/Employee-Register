﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApplication.Models
{
    public partial class Employees
    {
        [Key]
        public int EmployeeId { get; set; }


        [Display(Name = "Employee Name")]
        [StringLength(50)]
        public string EmpName { get; set; }


        [StringLength(50)]
        public string Position { get; set; }

        [Display(Name = "Department Id")]
        [StringLength(50)]
        public string DeptId { get; set; }

        [InverseProperty("Dept")]
        public Departments Departments { get; set; }
    }
}