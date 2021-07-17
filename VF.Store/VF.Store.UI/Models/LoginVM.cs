using System.ComponentModel.DataAnnotations;

namespace VF.Store.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "{0} é obrigatório"), StringLength(80, ErrorMessage = "Limite de {1} caracteres excedido")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "{0} inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public string Senha { get; set; }

        public bool PermanecerLogado { get; set; }

        public string ReturnUrl { get; set; }
    }
}


