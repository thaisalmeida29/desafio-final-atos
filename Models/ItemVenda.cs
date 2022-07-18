using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desafio_final_atos.Models
{
    public class ItemVenda
    {
        [Key()]
        public int IdItemVenda { get; set; }

        [ForeignKey("Produto")]
        [Display(Name = "Produto")]
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        [ForeignKey("Venda")]
        [Display(Name = "Id Venda")]
        public int IdVenda { get; set; }
        public virtual Venda Venda { get; set; }
        public int Quantidade { get; set; }

        [Display(Name = "Preço Unitário")]
        public decimal PrecoUnitario { get; set; }

        [Display(Name = "Preço Total")]
        public decimal PrecoTotal { get; set; }
        public object Preco { get; internal set; }
    }
}
