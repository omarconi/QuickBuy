﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            //builder utiliza o padrão Fluent
            builder.Property(u => u.eMail)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
