using BR_JS.Dominio.Modelos;
using System;

namespace BR_JS.Infraestrutura.InterfacesRepositorios
{
    public interface IUsuarioRepositorio : IDisposable
    {
        public Usuario ObterUsuarioPorId(Guid id);
        public Usuario ObterUsuarioPorEmail(string email);
        public void Criar(Usuario usuario);
        public void Atualizar(Usuario usuario);
        public void Remover(Guid id);
    }
}
