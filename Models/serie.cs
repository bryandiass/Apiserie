using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apiserie.Models
{
    [Table("Series")]
    public class serie
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Nome { get; set; }

        public string? Genero { get; set; }

        public string? Plataforma { get; set;}

        public int Ano { get; set; }

        public string Sinopse { get; set; }

        public string? Foto { get; set; }


    }
}
