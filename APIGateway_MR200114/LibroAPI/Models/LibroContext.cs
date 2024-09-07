using Microsoft.EntityFrameworkCore;

namespace LibroAPI.Models
{
    public class LibroContext : DbContext
    {
        public LibroContext(DbContextOptions<LibroContext> options) : base(options) { }

        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Libro>().HasData(
                new Libro
                {
                    Id = 1,
                    Nombre = "Cien años de soledad",
                    Autor = "Gabriel García Márquez",
                    AnioPublicacion = 1967
                },
                new Libro
                {
                    Id = 2,
                    Nombre = "Don Quijote de la Mancha",
                    Autor = "Don Quijote de la Mancha",
                    AnioPublicacion = 1605
                },
                new Libro
                {
                    Id = 3,
                    Nombre = "El amor en los tiempos del cólera",
                    Autor = "Gabriel García Márquez",
                    AnioPublicacion = 1985
                }

                );
        }
    }
}
