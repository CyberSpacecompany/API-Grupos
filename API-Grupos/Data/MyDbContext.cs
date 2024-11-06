using API_Grupo.Models;
using API_Grupos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Grupos.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
        public DbSet<Grupo> Grupo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.IDgrupo);
                entity.Property(e => e.nombre_grupo).IsRequired();
                entity.ToTable("Grupo");
                entity.HasOne<Usuario>().WithMany().HasForeignKey(e => e.IDgrupo).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IDusuario);
                entity.ToTable("Usuario");
            });
        }

    }
}