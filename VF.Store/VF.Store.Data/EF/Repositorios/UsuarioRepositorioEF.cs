using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VF.Store.Domain.Contracts.Repositorios;
using VF.Store.Domain.Entities;

namespace VF.Store.Data.EF.Repositorios
{
    public class UsuarioRepositorioEF : RepositorioEF<Usuario>, IUsuarioRepositorio
    {
        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }
    }
}
