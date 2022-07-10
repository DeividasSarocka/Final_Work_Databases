using Final_Work_Databases.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Work_Databases
{
    public class StudentsDbContext : DbContext
    {

        public DbSet<Department> Departments { get; set; } //susikuriam properties dbset tipo ir modelio klasiu potipio (entityframework'ui)
        public DbSet<Lecture> Lectures { get; set; }   
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=localhost;Database=StudentsDb;Trusted_Connection=True;");
            //Add-Migration InitialCreate Package Manager Console ivesti, kad sukurti migracija
            //Update-DataBase

        }

    }
}
 