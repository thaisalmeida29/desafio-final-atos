using System.ComponentModel.DataAnnotations;

namespace desafio_final_atos.Models
{
    public class Cliente
    {
        [Key()]
        public int IdCliente { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        [Display(Name = "Endereço")]
        public string Complemento { get; set; }
        public string Cidade { get; set; }



    }
}
