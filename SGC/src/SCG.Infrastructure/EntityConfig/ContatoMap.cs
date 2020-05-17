using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCG.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCG.Infrastructure.EntityConfig
{
 
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            //Nome da tabela
            builder.ToTable("Contato");
         //   builder.HasOne(x => x.Cliente).WithMany().HasForeignKey("ClienteId");
            builder.HasKey(x => x.ContatoId);
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(255).IsRequired();
        }
    }
}
