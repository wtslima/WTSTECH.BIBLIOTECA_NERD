using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WTSTECH.BIBLIOTECANERD.INFRA.DADOS.DataModel;

namespace WTSTECH.BIBLIOTECANERD.INFRA.DADOS.Maps
{
    public class LivroMap : IEntityTypeConfiguration<LivroDataModel>
    {
        public void Configure(EntityTypeBuilder<LivroDataModel> builder)
        {
            builder.ToTable("TB_LIVRO");

            builder.HasKey(l => l.LivroId);

            builder.Property(l => l.LivroId)
                .HasColumnName("IDT_LIVRO")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(l => l.Titulo)
                .HasColumnName("NOM_TITULO")
                .HasColumnType("nvarchar")
                .HasMaxLength(140)
                .IsRequired();

            builder.Property(l => l.Isbn)
                .HasColumnName("NUM_ISBN")
                .HasColumnType("int")
                .HasMaxLength(13)
                .IsRequired();

            builder.Property(l => l.Preco)
                .HasColumnName("FLT_PRECO")
                .HasColumnType("money")
                .IsRequired();

            builder.Property(l => l.ImagemId)
               .HasColumnName("IDT_IMAGEM_CAPA")
               .HasMaxLength(8)
               .IsRequired();

            builder.Property(l => l.AutorId)
               .HasColumnName("IDT_AUTOR")
               .HasMaxLength(8)
               .IsRequired();




        }
    }
}
