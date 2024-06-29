using Microsoft.EntityFrameworkCore;
using Ödev_20240505.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_20240505.Context
{
    internal class AppDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Gender> Genders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DENIZ\SQL; Initial Catalog = HS-15StudyStudents; Integrated Security = True; TrustServerCertificate = True");
        }
    }

   
}
