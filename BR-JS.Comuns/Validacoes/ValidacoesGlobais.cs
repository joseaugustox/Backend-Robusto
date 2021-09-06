using System;

namespace BR_JS.Comuns.Validacoes
{
    public class ValidacoesGlobais
    {
        public static void validarArgumentoNulo(string argumento, string excessao)
        {
            if(string.IsNullOrEmpty(argumento))
            {
                throw new Exception(excessao);
            }
        }
        public static void validarArgumentosDiferentes(string argumento1, string argumento2, string excessao)
        {
            if(argumento1 != argumento2)
            {
                throw new Exception(excessao);
            }
        }
        public static void validarTamanhoArgumento(string argumento,int tamanhoMinimo, int tamanhoMaximo, string excessao)
        {
            if(argumento.Length < tamanhoMaximo && argumento.Length > tamanhoMaximo)
            {
                throw new Exception(excessao);
            }
        }
    }
}
