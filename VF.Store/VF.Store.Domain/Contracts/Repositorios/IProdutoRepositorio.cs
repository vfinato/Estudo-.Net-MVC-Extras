using System.Collections.Generic;
using VF.Store.Domain.Entities;

namespace VF.Store.Domain.Contracts.Repositorios
{
    public interface IProdutoRepositorio : IRepositorio<Produto>
    {

        IEnumerable<Produto> GetByNameContains(string contains);

    }
}
