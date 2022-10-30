﻿// <auto-generated />
using System;
using DespensaBarrial.BD.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DespensaDelBarrio.BD.Migrations
{
    [DbContext(typeof(DespensaDelBarrioDbContext))]
    [Migration("20221030001415_tablas")]
    partial class tablas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodigoCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Deposito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CantidadEnEstante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoriaEnEstante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoEstante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadMinima")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Depositos");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("DepositoId")
                        .HasColumnType("int");

                    b.Property<string>("DescripcionProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaVencimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecioProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProveedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId")
                        .IsUnique()
                        .HasFilter("[CategoriaId] IS NOT NULL");

                    b.HasIndex("DepositoId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AdministradorId")
                        .HasColumnType("int");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Producto", b =>
                {
                    b.HasOne("DespensaBarrial.BD.Datos.Entidades.Categoria", "Categoria")
                        .WithOne("Producto")
                        .HasForeignKey("DespensaBarrial.BD.Datos.Entidades.Producto", "CategoriaId");

                    b.HasOne("DespensaBarrial.BD.Datos.Entidades.Deposito", "Deposito")
                        .WithMany("Productos")
                        .HasForeignKey("DepositoId");

                    b.HasOne("DespensaBarrial.BD.Datos.Entidades.Proveedor", "Proveedor")
                        .WithMany("Productos")
                        .HasForeignKey("ProveedorId");

                    b.Navigation("Categoria");

                    b.Navigation("Deposito");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Proveedor", b =>
                {
                    b.HasOne("DespensaBarrial.BD.Datos.Entidades.Administrador", "administrador")
                        .WithMany("Proveedores")
                        .HasForeignKey("AdministradorId");

                    b.Navigation("administrador");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Administrador", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Categoria", b =>
                {
                    b.Navigation("Producto");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Deposito", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("DespensaBarrial.BD.Datos.Entidades.Proveedor", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}