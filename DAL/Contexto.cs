using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using PrimerP_Ap2.Models;

namespace PrimerP_Ap2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet <Productos> Productos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Productos.db");
        }
    }
}