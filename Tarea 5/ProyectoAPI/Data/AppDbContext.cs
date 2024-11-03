using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProyectoAPI.Models;

namespace ProyectoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Producto> Productos { get; set; }
    }
}
