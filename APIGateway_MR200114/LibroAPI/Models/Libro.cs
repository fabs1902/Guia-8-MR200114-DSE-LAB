using System.ComponentModel.DataAnnotations;

namespace LibroAPI.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public  string? Autor { get; set; }

        public int? AnioPublicacion { get; set; }


    }
}
