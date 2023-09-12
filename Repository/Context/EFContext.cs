using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{

        public class EFContext : DbContext
        {
        public EFContext(DbContextOptions<EFContext> options):
            base(options){ }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ProductEntity> Product { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }

        }
    }

