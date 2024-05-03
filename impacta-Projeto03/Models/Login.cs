using System.ComponentModel.DataAnnotations;

namespace impacta_Projeto03.Models
{
    public class Login
    {
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Display(Name = "Senha")]
        public string? Senha { get; set; }
    }
}
