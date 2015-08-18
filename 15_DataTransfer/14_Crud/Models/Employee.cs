using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _14_Crud.Models
{
    [MetadataType(typeof(EmployeeChange))]
    public partial class Employee
    {
    }

    public class EmployeeChange
    {
        
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [Display(Name="Department")]
        public int DepartmentId { get; set; }
    }
}
