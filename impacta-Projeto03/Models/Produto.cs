using System.ComponentModel.DataAnnotations;

namespace impacta_Projeto03.Models
{
    public class Produto
    {
        [Display(Name = "Id Produto")]
        public int ProdutoID { get; set; }

        [Display(Name = "Valor Unitário")]
        public decimal ValorUnitario { get; set; }

        [Display(Name = "Preço de Venda")]
        public decimal PrecoVenda { get; set; }

        [Display(Name = "Fornecedor")]
        public string? Fornecedor { get; set; }

        [Display(Name = "Categoria")]
        public string? Categoria { get; set; }
        
    }
}
