using FastBuy.Dominio.Entidades;
using FastBuy.Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;

namespace FastBuy.Repositorio.Contexto
{
    public class FastBuyContexto : DbContext
    {
        public DbSet<Usuario>Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

    }
}
