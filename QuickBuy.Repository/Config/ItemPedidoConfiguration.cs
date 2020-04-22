using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(ip => ip.Id);

            builder.Property(ip => ip.ProdutoId)
                .IsRequired();
            builder.Property(ip => ip.Quantidade)
                .IsRequired();
        }
    }
}
