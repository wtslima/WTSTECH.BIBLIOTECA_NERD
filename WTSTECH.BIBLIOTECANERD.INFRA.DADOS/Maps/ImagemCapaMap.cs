using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WTSTECH.BIBLIOTECANERD.INFRA.DADOS.DataModel;

namespace WTSTECH.BIBLIOTECANERD.INFRA.DADOS.Maps
{
    public class ImagemCapaMap : IEntityTypeConfiguration<ImagemCapaDataModel>
    {
        public void Configure(EntityTypeBuilder<ImagemCapaDataModel> builder)
        {
            builder.ToTable("TB_IMAGEM_CAPA");

            builder.HasKey(i => i.ImagemId);

            builder.Property(i => i.ImagemId)
                .IsRequired()
                .HasColumnName("IDT_IMAGEM_CAPA");

            builder.Property(i => i.Foto)
                .HasColumnName("DES_FOTO")
                .HasColumnType("image");

        }
    }
}
