using BR_JS.Dominio.Modelos;
using BR_JS.Infraestrutura.InterfacesRepositorios;
using BR_JS.Infraestrutura.Repositorios;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(IUsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio())
                {
                    Guid id = Guid.Parse("3F46244D-6F70-47F0-3B78-08D8D699D1A4");
                    Usuario isi = usuarioRepositorio.ObterUsuarioPorId(id);
                    usuarioRepositorio.Atualizar(isi);
                    Console.WriteLine(isi.Nome);
                }               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
