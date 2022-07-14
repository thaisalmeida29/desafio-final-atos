using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desafio_final_atos.Models
{
    public class Venda
    {
        [Key()]
        public int IdVenda { get; set; }
        [ForeignKey("Cliente")]
        [Display(Name = "Id do Cliente")]
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

      
        [Display(Name = "Produto")]
        public string NomeProduto { get; set; }
     
        public List<ItemVenda> ItemVendas { get; set; } = new List<ItemVenda>();

        public decimal ValorTotalVenda => ItemVendas.Sum(i => i.PrecoTotal);

    }
}
