using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using VF.Store.Data.ADO;
using VF.Store.Data.ADO.Repositorios;
using VF.Store.Data.EF;
using VF.Store.Data.EF.Repositorios;
using VF.Store.Domain.Contracts.Repositorios;

namespace VF.Store.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<VFStoreDataContextADO>();

            container.RegisterType<IProdutoRepositorio, ProdutoRepositorioEF>();
            container.RegisterType<ITipoDeProdutoRepositorio, TipoDeProdutoRepositorioEF>();
            container.RegisterType<IUsuarioRepositorio, UsuarioRepositorioADO>();

            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}