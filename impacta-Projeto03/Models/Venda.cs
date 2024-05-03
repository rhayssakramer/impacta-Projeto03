using System.ComponentModel.DataAnnotations;

namespace impacta_Projeto03.Models
{
    public class Venda
    {
        [Display(Name = "ID Venda")]
        public int VendaID { get; set; }

        [Display(Name = "ID Funcionário")]
        public int FuncionarioID { get; set; }

        [Display(Name = "ID Cliente")]
        public int ClienteID { get; set; }

        [Display(Name = "Data da Venda")]
        public DateTime DataVenda { get; set; }

        [Display(Name = "Produto")]
        public string? Produto { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Valor Unitário")]
        public decimal ValorUnitario { get; set; }

        [Display(Name = "Total Venda")]
        public decimal TotalVenda { get; set; }
        
    }
}
