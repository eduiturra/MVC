using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _6_Create.Models
{

   
    public class IDepartament
    {

        int ID { get; set; }
        String Name { get; set; }
    }


     [Table("Departamento")]
    public class Departament : IDepartament
    {

        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        
        public String Telefono { get; set; }
    }
}