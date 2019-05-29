using System;
using WTSTECH.BIBLIOTECANERD.DOMINIO.SHARED;

namespace WTSTECH.BIBLIOTECANERD.DOMINIO.CORE.Entidades
{
    public class Livro : EntidadeBase
    {
        public Livro(string titulo, string isbn, Autor autor, decimal preco, ImagemCapa imagem, DateTime publicacaoData)
        {
            Titulo = titulo;
            Isbn = isbn;
            Autor = autor;
            Preco = preco;
            Imagem = imagem;
            PublicacaoData = publicacaoData;
        }

        public Livro(Guid id, string titulo, string isbn, Autor autor, decimal preco, ImagemCapa imagem, DateTime publicacaoData)
        {
            Id = id;
            Titulo = titulo;
            Isbn = isbn;
            Autor = autor;
            Preco = preco;
            Imagem = imagem;
            PublicacaoData = publicacaoData;
        }

        protected Livro()
        {

        }

        public string Titulo { get; private set; }
        public string Isbn  { get; private set; }
        public Autor Autor { get; private set; }
        public decimal Preco { get; private set; }
        public ImagemCapa Imagem { get; private set; }
        public DateTime PublicacaoData { get; private set; }

        public override string ToString()
        {
            return Titulo;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
