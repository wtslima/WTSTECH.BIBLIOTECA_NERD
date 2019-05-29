using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WTSTECH.BIBLIOTECANERD.INFRA.DADOS.DataModel;

namespace WTSTECH.BIBLIOTECANERD.INFRA.DADOS.Maps
{
    public class AutorMap : IEntityTypeConfiguration<AutorDataModel>
    {
        public void Configure(EntityTypeBuilder<AutorDataModel> builder)
        {
            builder.ToTable("TB_AUTOR");

            builder.HasKey(a => a.AutorId);

            builder.Property(a => a.AutorId)
                .IsRequired()
                .HasColumnName("IDT_AUTOR");

            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnName("NOM_NOME");
            
        }
    }
}
