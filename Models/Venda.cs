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

        [ForeignKey("Produto")]
        [Display(Name = "Produto")]
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        [Display(Name = "Preço Unitário")]
        public decimal PrecoUnitario { get; set; }
        [Display(Name = "Preço Total")]
        public decimal PrecoTotal { get; set; }
    }
}
