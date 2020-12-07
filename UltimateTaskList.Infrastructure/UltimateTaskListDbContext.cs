using Microsoft.EntityFrameworkCore;
using System;
using UltimateTaskList.Domain.Entities;

namespace UltimateTaskList.Infrastructure
{
    public class UltimateTaskListDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }

        public UltimateTaskListDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UltimateTaskListDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
