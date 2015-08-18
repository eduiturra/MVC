using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _6_Create.Models
{
     [Table("Departamento")]
    public class Departament
    {

        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        
        public String Telefono { get; set; }
    }
}