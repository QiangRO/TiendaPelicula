using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaPelicula.Modelos
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Fecha Publicacion")]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }
        public string Genero { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Precio { get; set; }
    }
}
