﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrabajoPracticoVerdadero.Comunes.datos;

namespace TrabajoPracticoVerdadero.Comunes.Migrations
{
    [DbContext(typeof(dbContext))]
    partial class dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrabajoPracticoVerdadero.Comunes.datos.Entidades.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodCliente")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("ID");

                    b.HasIndex(new[] { "CodCliente" }, "UQ_Cliente_CodCliente")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TrabajoPracticoVerdadero.Comunes.datos.Entidades.Producto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("CodProducto")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex(new[] { "CodProducto" }, "UQ_Product_CodProducto")
                        .IsUnique();

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("TrabajoPracticoVerdadero.Comunes.datos.Entidades.Producto", b =>
                {
                    b.HasOne("TrabajoPracticoVerdadero.Comunes.datos.Entidades.Cliente", "Cliente")
                        .WithMany("Productos")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("TrabajoPracticoVerdadero.Comunes.datos.Entidades.Cliente", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
