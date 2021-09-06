using System;
using System.Collections.Generic;
using System.Text;

namespace BR_JS.Infraestrutura.Interfaces.InterfaceServicos
{
    public interface IUsuarioServico : IDisposable
    {
        public void Registrar(string nome, string email, string senha, string confirmacaoSenha);
        public void MudarNome(string email,string nome);
        public void MudarEmail(string email, string novoEmail);
        public void MudarSenha(string email,string senha, string confirmacaoSenha);
    }
}
