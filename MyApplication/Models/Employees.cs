using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApplication.Models
{
    public partial class Employees
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee Name is required!!")]
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

        public static implicit operator string(Employees v)
        {
            throw new NotImplementedException();
        }
    }
}
