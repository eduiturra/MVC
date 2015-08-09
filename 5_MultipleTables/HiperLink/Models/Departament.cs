    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HiperLink.Models
{
    [Table("Departamento")]
    public class Department
    {
        
        public int ID { get; set; }
        public String Name { get; set; }
       
    }
}