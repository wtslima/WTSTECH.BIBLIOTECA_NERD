using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using WTSTECH.BIBLIOTECANERD.INFRA.DADOS.DataModel;
using WTSTECH.BIBLIOTECANERD.INFRA.DADOS.Maps;

namespace WTSTECH.BIBLIOTECANERD.INFRA.DADOS
{
    public class BibliotecaContexto : DbContext
    {
        private readonly IHostingEnvironment _environment;
        public BibliotecaContexto(IHostingEnvironment env)
        {
            _environment = env;
        }

        public DbSet<LivroDataModel> Livros { get; set; }

        public DbSet<AutorDataModel> Autores { get; set; }

        public DbSet<ImagemCapaDataModel> ImagemCapas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                 .SetBasePath(_environment.ContentRootPath)
                 .AddJsonFile("appsettings.json")
                 .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("Default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LivroDataModel>(new LivroMap().Configure);
            modelBuilder.Entity<AutorDataModel>(new AutorMap().Configure);
            modelBuilder.Entity<ImagemCapaDataModel>(new ImagemCapaMap().Configure);


            modelBuilder.Entity<AutorDataModel>()
              .HasMany(t => t.Livros)
              .WithOne(i => i.Autor)
              .HasForeignKey(t => t.AutorId);

            modelBuilder.Entity<LivroDataModel>()
                .HasOne(a => a.Imagem)
                .WithOne(b => b.Livro)
                .HasForeignKey<ImagemCapaDataModel>(b => b.ImagemId);
        }
    }
}
