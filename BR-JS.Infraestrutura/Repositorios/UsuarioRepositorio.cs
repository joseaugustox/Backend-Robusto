using BR_JS.Dominio.Modelos;
using BR_JS.Infraestrutura.Dados;
using BR_JS.Infraestrutura.InterfacesRepositorios;
using System;
using System.Linq;

namespace BR_JS.Infraestrutura.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private DadosEmContexto _contexto = new DadosEmContexto();
        public void Criar(Usuario usuario)
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();
        }

         public void Atualizar(Usuario usuario)
        {
            _contexto.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Remover(Guid id)
        {
             Usuario usuario = ObterUsuarioPorId(id);
            _contexto.Usuarios.Remove(usuario);
            _contexto.SaveChanges();
        }

        public Usuario ObterUsuarioPorId(Guid id)
        {
            return _contexto.Usuarios.Where(x => x.Id == id).FirstOrDefault();
        }
        public Usuario ObterUsuarioPorEmail(string email)
        {
            return _contexto.Usuarios.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();

        }
        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
