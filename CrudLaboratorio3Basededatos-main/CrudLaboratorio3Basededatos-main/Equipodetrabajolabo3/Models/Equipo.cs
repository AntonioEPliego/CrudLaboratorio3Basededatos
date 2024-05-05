using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Equipodetrabajolabo3.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [DisplayName("Activo")]
        public bool activo { get; set; }
        public string? detalles { get; set; }
    }
}
