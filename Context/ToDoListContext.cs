using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListWindowsFormApp.Entities;

namespace ToDoListWindowsFormApp.Context
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ToDoListWindowsFormDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }
}
