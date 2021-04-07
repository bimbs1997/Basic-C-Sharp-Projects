using FinalAssignment.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Data
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> students { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-34NE4MI\\SQLEXPRESS;Database=CheckDb;User ID=AhmadProject;Password=online786;");
        }
    }
}
