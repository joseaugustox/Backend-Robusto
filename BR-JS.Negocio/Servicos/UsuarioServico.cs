using BR_JS.Comuns.Recursos;
using BR_JS.Dominio.Modelos;
using BR_JS.Infraestrutura.Interfaces.InterfaceServicos;
using BR_JS.Infraestrutura.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BR_JS.Negocio.Servicos
{
    class UsuarioServico : IUsuarioServico
    {

        private IUsuarioRepositorio _repositorio;
        public void MudarEmail(string email, string novoEmail)
        {
            Usuario u =_repositorio.ObterUsuarioPorEmail(novoEmail);
            if(u != null)
            {
                throw new Exception(ErrosComuns.EmailJaExiste);
            }
            else
            {
                Usuario usuario = _repositorio.ObterUsuarioPorEmail(email);
                usuario.MudarEmail(novoEmail);
                usuario.ValidarUsuario();
                _repositorio.Atualizar(usuario);
            }
        }

        public void MudarNome(string email,string nome)
        {
            Usuario usuario = _repositorio.ObterUsuarioPorEmail(email);
            usuario.MudarNome(nome);
        }

        public void MudarSenha(string email,string senha, string confirmacaoSenha)
        {
            Usuario usuario = _repositorio.ObterUsuarioPorEmail(email);
            usuario.MudarSenha(senha, confirmacaoSenha);
        }

        public void Registrar(string nome, string email, string senha, string confirmacaoSenha)
        {
            Usuario usuario = _repositorio.ObterUsuarioPorEmail(email);
            if(usuario != null)
            {
                throw new Exception(ErrosComuns.EmailJaExiste);
            }
            else
            {
                Usuario usuarioCriacao = new Usuario(nome, email);
                usuarioCriacao.CriarSenha(senha, confirmacaoSenha);
                usuarioCriacao.ValidarUsuario();
                _repositorio.Criar(usuarioCriacao);
            }
        }

         public void Dispose()
        {
            this.Dispose();
        }
    }
}
