using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using VF.Store.Domain.Entities;

namespace VF.Store.Data.EF.Maps
{
    public class TipoDeProdutoMap :EntityTypeConfiguration<TipoDeProduto>
    {
        public TipoDeProdutoMap()
        {
            //configurações de tabela
            ToTable(nameof(TipoDeProduto));
            HasKey(pk => pk.Id);

            //configurações de campos
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.DataCadastro);

        }
        
    }
}
