using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prova_desenvolvedor.Models
{
    public class Ativo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Code { get; set; }
        public decimal Price { get; set; }
    }
}
