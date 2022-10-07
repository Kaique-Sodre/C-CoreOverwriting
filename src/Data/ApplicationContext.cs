using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using src.Entities;

namespace src.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=sobrecrevendo_comportamento;Integrated Security=true";

            optionsBuilder
                // .LogTo(Console.WriteLine)
                .UseSqlServer(connectionString)
                // .ReplaceService<IQuerySqlGeneratorFactory, MySqlServerQueryGeneratorFactory>()
                .EnableSensitiveDataLogging();
        }
    }
}