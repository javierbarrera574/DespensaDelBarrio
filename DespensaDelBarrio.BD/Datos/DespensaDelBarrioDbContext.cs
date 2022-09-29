using DespensaBarrial.BD.Datos.Entidades;
using DespensaDelBarrio.BD.Datos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DespensaBarrial.BD.Datos
{
    public class DespensaDelBarrioDbContext : DbContext
    {
        public DespensaDelBarrioDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>()
                .HasMany(p => p.Categorias)
                .WithOne();

            modelBuilder.
                Entity<ProveedoresProductos>().
                HasKey(prop =>
            new 
            {
                prop.ProveedoresId, prop.ProductosId 
            });


            modelBuilder.Entity<ProveedoresProductos>().
                HasOne(pp => pp.Productos).
                WithMany(p => p.ProveedorProductos).
                HasForeignKey(pa => pa.ProductosId);

            modelBuilder.Entity<ProveedoresProductos>().
                HasOne(pp => pp.Proveedores).
                WithMany(p => p.ProveedorProductos).
                HasForeignKey(p => p.ProveedoresId);

            modelBuilder.Entity<Administrador>().
                HasOne(em => em.Empleado).
                WithOne(a=>a.Administrador).
                HasForeignKey<Empleado>(fk=>fk.AdministradorId);

            modelBuilder.Entity<Administrador>().
                HasMany(p => p.Proveedores).
                WithOne().
                HasForeignKey(A => A.AdministadorId);


        }


        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<Proveedores> Proveedores { get; set; }

        public DbSet<Empleado> empleado { get; set; }

        public DbSet<Deposito> stockDeposito { get; set; }

        public DbSet<Administrador> administrador { get; set; }


        public DbSet<ProveedoresProductos> ProveedoresProductos { get; set; }
    }
}
