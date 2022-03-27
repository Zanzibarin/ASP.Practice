using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace ASP.FinalProject.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Cource> Cources { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}