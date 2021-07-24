using System;
using System.Collections.Generic;
using System.Linq;
using VF.Store.Domain.Contracts.Repositorios;
using VF.Store.Domain.Entities;


namespace VF.Store.Data.ADO.Repositorios
{
    public class UsuarioRepositorioADO : IUsuarioRepositorio
    {
        private readonly VFStoreDataContextADO _ctx;

        public UsuarioRepositorioADO(VFStoreDataContextADO ctx)
        {
            _ctx = ctx;
        }
        public Usuario Get(string email)
        {
            var query = $@"SELECT U.ID,
                                 U.NOME,
	                             U.EMAIL,
	                             U.SENHA,
	                             U.DATACADASTRO
                            FROM USUARIO U
                           WHERE EMAIL = '{email}'";

            var dR = _ctx.ExecutarDataReader(query);

            if (dR.HasRows)
            {
                var usuarios = new List<Usuario>();
                while (dR.Read())
                {
                    usuarios.Add(new Usuario()
                    {
                        Id = (int)dR["ID"],
                        Nome = dR["NOME"].ToString(),
                        Email = dR["EMAIL"].ToString(),
                        Senha = dR["SENHA"].ToString(),
                        DataCadastro = (DateTime)dR["DATACADASTRO"]
                    });
                }
                dR.Close();
                return usuarios.First();
            }

            return null;
        }


        public void Dispose()
        {
        }
        



        public IEnumerable<Usuario> Get()
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Usuario entidade)
        {
            throw new NotImplementedException();
        }

        public void Edit(Usuario entidade)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario entidade)
        {
            throw new NotImplementedException();
        }

      
    }
}
