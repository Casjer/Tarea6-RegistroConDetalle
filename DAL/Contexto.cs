using Microsoft.EntityFrameworkCore;
using Pedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Pedidos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Para Suplidores
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 1,
                Nombres = "Rood Jerry Pierre"
            });

            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 2,
                Nombres = "Clifford Millien"
            });

            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 3,
                Nombres = "Cassandra Ticoiny"
            });

            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 4,
                Nombres = "Luckens Pierre"
            });

            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 5,
                Nombres = "Casjer Pierre"
            });

            //Para Productos
            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 1,
                Descripcion = "fresa",
                Costo = 100,
                Inventario = 100

            });

            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 2,
                Descripcion = "Manzana",
                Costo = 150,
                Inventario = 200
            });

            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 3,
                Descripcion = "Uva",
                Costo = 100,
                Inventario = 70
            });

            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 4,
                Descripcion = "Peach",
                Costo = 50,
                Inventario = 100
            });

            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 5,
                Descripcion = "berry",
                Costo = 110,
                Inventario = 30
            });

        }

    }
}
