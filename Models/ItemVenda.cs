using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desafio_final_atos.Models
{
    public class ItemVenda
    {
        [Key()]
        public int Id { get; set; }
        [ForeignKey("Venda")]
        public int IdVenda { get; set; }
        public virtual Venda Venda { get; set; }

        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoUnitario { get; set; }

        public decimal PrecoTotal { get; set; }

    }
}
