using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace impacta_Projeto03.Models
{
    public class Cliente
    {
        [Display(Name = "ID")]
        public int ClienteID { get; set; }

        [Display(Name = "Nome")]
        public string? NomeCliente { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }

        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Display(Name = "Rua")]
        public string? Rua { get; set; }

        [Display(Name = "Nº")]
        public int Numero { get; set; }

        [Display(Name = "Complemento")]
        public string? Complemento { get; set; }

        [Display(Name = "Bairro")]
        public string? Bairro { get; set; }

        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        [Display(Name = "Estado")]
        public string? Estado { get; set; }

        [Display(Name = "CEP")]
        public string? CEP { get; set; }
    }
}
