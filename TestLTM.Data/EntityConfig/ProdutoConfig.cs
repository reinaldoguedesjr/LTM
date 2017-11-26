using System;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using TestLTM.Domain.Entities;

namespace TestLTM.Data.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(c => c.IdProduto);

            Property(c => c.NomeProduto)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.DataInclusao)
                .IsRequired();
        }
    }
}
