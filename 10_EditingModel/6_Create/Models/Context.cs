using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _6_Create.Models
{
    public class Context : DbContext
    {
        public DbSet<Departament> Departamentos { get; set; }
    }
}