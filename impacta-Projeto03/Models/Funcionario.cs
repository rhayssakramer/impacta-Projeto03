using System.ComponentModel.DataAnnotations;

namespace impacta_Projeto03.Models
{
    public class Funcionario
    {
        [Display(Name = "ID")]
        public string? FuncionarioID { get; set; }

        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Display(Name = "CPF")]
        public string? CPF { get; set; }

        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }

        [Display(Name = "Cargo")]
        public string? Cargo { get; set; }

        [Display(Name = "Data de Contratação")]
        public DateTime DataContratacao { get; set; }

        [Display(Name = "Endereço")]
        public string? Rua { get; set; }

        [Display(Name = "Número")]
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
