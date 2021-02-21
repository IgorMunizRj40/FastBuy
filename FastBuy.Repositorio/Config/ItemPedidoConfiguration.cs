using FastBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastBuy.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
