using BR_JS.Infraestrutura.Dados;
using BR_JS.Infraestrutura.InterfacesRepositorios;
using BR_JS.Infraestrutura.Repositorios;
using Unity;
using Unity.Lifetime;

namespace BR_JS.Principio
{
    public static class ResolucaoDeDependencia
    {
        public static void Resolucao (UnityContainer container)
        {
            container.RegisterType<DadosEmContexto, DadosEmContexto>(new HierarchicalLifetimeManager());
            container.RegisterType<IUsuarioRepositorio, UsuarioRepositorio>(new HierarchicalLifetimeManager());
        }
    }
}
