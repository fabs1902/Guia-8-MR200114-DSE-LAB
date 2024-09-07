﻿// <auto-generated />
using System;
using LibroAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibroAPI.Migrations
{
    [DbContext(typeof(LibroContext))]
    partial class LibroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibroAPI.Models.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AnioPublicacion")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnioPublicacion = 1967,
                            Autor = "Gabriel García Márquez",
                            Nombre = "Cien años de soledad"
                        },
                        new
                        {
                            Id = 2,
                            AnioPublicacion = 1605,
                            Autor = "Don Quijote de la Mancha",
                            Nombre = "Don Quijote de la Mancha"
                        },
                        new
                        {
                            Id = 3,
                            AnioPublicacion = 1985,
                            Autor = "Gabriel García Márquez",
                            Nombre = "El amor en los tiempos del cólera"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
