using FastBuy.Dominio.Entidades;
using FastBuy.Repositorio.Repositorios;

namespace FastBuy.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var ususarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var ususario = new Usuario();

            UsuarioRepositorio.Adicionar(Usuario);
        }
    }
}
