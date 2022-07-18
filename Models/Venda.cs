using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desafio_final_atos.Models
{
    public class Venda
    {
        [Key()]
        public int IdVenda { get; set; }
        [ForeignKey("Cliente")]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

        [Display(Name = "Preço Total")]
        public decimal PrecoTotal { get; set; }

        public IEnumerable<ItemVenda> ItemVendas { get; set; }
    }
}
