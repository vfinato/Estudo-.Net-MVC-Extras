using VF.Store.Domain.Entities;

namespace VF.Store.Domain.Contracts.Repositorios
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Usuario Get(string email);
    }
}
