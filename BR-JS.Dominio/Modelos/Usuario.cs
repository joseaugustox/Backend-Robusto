using BR_JS.Comuns.Recursos;
using BR_JS.Comuns.Validacoes;
using System;

namespace BR_JS.Dominio.Modelos
{
    public class Usuario
    {
        public Usuario(string nome, string email)
        {
            Id = new Guid();
            Nome = nome;
            Email = email;
        }
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string  Email{ get; private set; }
        public string Senha { get; private set; }
        public void CriarSenha(string senha, string confirmacaoSenha)
        {
            ValidacoesGlobais.validarArgumentoNulo(senha, ErrosComuns.senhaNula);
            ValidacoesGlobais.validarArgumentoNulo(confirmacaoSenha, ErrosComuns.senhaNula);
            ValidacoesGlobais.validarArgumentosDiferentes(senha, confirmacaoSenha, ErrosComuns.senhasDiferentes);
            ValidacoesSenhas.validarTamanhoSenha(senha, ErrosComuns.senhaPequena);

            Senha = ValidacoesSenhas.Encriptar(senha);
        }
        public void ValidarUsuario()
        {
            ValidacoesGlobais.validarArgumentoNulo(Nome, ErrosComuns.nomeUsuarioNulo);
            ValidacoesGlobais.validarTamanhoArgumento(Nome, 3, 60, ErrosComuns.nomePequeno);
            ValidacoesGlobais.validarArgumentoNulo(Email, ErrosComuns.emailUsuarioNulo);
        }
        public void MudarEmail(string novoEmail)
        {
            Email = novoEmail;
        }
        public void MudarSenha(string senha, string confirmacaoSenha)
        {
            CriarSenha(senha, confirmacaoSenha);
        }
        public void MudarNome(string novoNome)
        {
            Nome = novoNome;
        }
    }
}
