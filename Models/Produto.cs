using System.ComponentModel.DataAnnotations;

namespace desafio_final_atos.Models
{
    public class Produto
    {
        [Key]
 
        public int Id { get; set; }
        [Required]
        public string CodEAN { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Preco { get; set; }
        [Required]
        public string Estoque { get; set; }
        [Required]
        public string Marca { get; set; }

        
    }
}
