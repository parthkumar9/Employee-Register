using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApplication.Models
{
    public partial class Departments
    {


        [Key]
        [Display(Name = "Department Id")]
        public int DeptId { get; set; }

        [Required(ErrorMessage = "Department Name is required!!")]
        [Display(Name = "Department Name")]
        [StringLength(50)]
        public string DeptName { get; set; }

        [Display(Name = "No. Of Employees")]
        [StringLength(50)]
        public string NoOfEmp { get; set; }


        [Range(0,50, ErrorMessage = "Age must be between 0 and 50")]
        [Display(Name = "Average Age")]
        public int? AvgAge { get; set; }

        [ForeignKey("DeptId")]
        [InverseProperty("Departments")]
        public Employees Dept { get; set; }
    }
}
