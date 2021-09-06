using System;

namespace BR_JS.Comuns.Validacoes
{
    public class ValidacoesSenhas
    {
        public static void validarTamanhoSenha(string senha, string excessao)
        {
            if(senha.Length < 4)
            {
                throw new Exception(excessao);
            }
        }

        public static string Encriptar(string senha)
        {
            senha += "|2d331cca-f6c0-40c0-bb43-6e32989c2881";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(senha));
            System.Text.StringBuilder sbString = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sbString.Append(data[i].ToString("x2"));
            return sbString.ToString();
        }
    }
}
