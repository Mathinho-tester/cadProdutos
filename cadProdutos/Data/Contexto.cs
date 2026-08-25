using CadProdutos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadProdutos.Data
{
    public class Contexto : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = @"Host=projetoscti.com.br;Port=54432;Username=ra2557092;Password=XPHdKkK8asCR6J;Database=cti_db;";
            optionsBuilder.UseNpgsql(connectionString, options =>
            {
                
                options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorCodesToAdd: null
                );
            });
        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}