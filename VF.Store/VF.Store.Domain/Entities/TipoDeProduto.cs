using System.Collections.Generic;

namespace VF.Store.Domain.Entities
{

    public class TipoDeProduto:Entity
    {

        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
