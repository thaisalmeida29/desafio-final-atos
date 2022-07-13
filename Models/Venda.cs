using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desafio_final_atos.Models
{
    public class Venda
    {
        [Key()]
        public int Id { get; set; }
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

        [Required]
        public string Nome { get; set; }
     
        public List<ItemVenda> ItemVendas { get; set; } = new List<ItemVenda>();

        public decimal ValorTotalVenda => ItemVendas.Sum(i => i.PrecoTotal);

    }
}
