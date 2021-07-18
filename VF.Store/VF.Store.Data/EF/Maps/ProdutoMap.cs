using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using VF.Store.Domain.Entities;

namespace VF.Store.Data.EF.Maps
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            //definições de tabela
            ToTable(nameof(Produto));
            HasKey(i => i.Id);

            //definições de colunas
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Preco)
                .HasColumnType("money")
                .IsRequired();

            Property(c => c.Quantidade)
                .HasColumnType("int")
                .IsRequired();

            Property(c => c.TipoDeProdutoId)
                .HasColumnType("int");

            Property(c => c.DataCadastro);

            //relacionamentos
            HasRequired(prod => prod.TipoDeProduto)
                .WithMany(tipo => tipo.Produtos)
                .HasForeignKey(fk => fk.TipoDeProdutoId);

        }
    }
}
