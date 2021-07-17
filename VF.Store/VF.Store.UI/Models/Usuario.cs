using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VF.Store.UI.Models
{
    [Table(nameof(Usuario))]
    public class Usuario : Entity
    {
        [Column(TypeName = "varchar"), StringLength(100), Required]
        public string Nome { get; set; }
        [Column(TypeName = "varchar"), StringLength(80), Required]
        public string Email { get; set; }
        [Column(TypeName = "varchar"), StringLength(250), Required]
        public string Senha { get; set; }
    }
}
