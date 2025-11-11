using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rincon.Models;

namespace rincon.Views.Data
{
    public class DBContex: DbContext
    {
        public DBContex(DbContextOptions<DBContex> options) : base(options) { }
        public DbSet<usuarioModel> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuarioModel>().HasKey(U => U.userId);
            modelBuilder.Entity<usuarioModel>().Property(U => U.userId).ValueGeneratedOnAdd();
        }

        
            
        
    }
} 