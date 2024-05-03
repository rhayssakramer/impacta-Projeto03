using System.ComponentModel.DataAnnotations;

namespace impacta_Projeto03.Models
{
    public class Acesso
    {
        [Display(Name = "ID")]
        public int AcessoID { get; set; }
        
        [Display(Name = "Nível de Acesso")]
        public string? NivelAcesso { get; set; }
    }
}
