using System.Collections.Generic;
using System.Linq;
using WTSTECH.BIBLIOTECANERD.DOMINIO.SHARED;

namespace WTSTECH.BIBLIOTECANERD.DOMINIO.CORE.Entidades
{
    public class Autor : EntidadeBase
    {
        private readonly IList<Livro> _livros;

        public Autor(string nome)
        {
            Nome = nome;
            _livros = new List<Livro>();
        }

        public string Nome { get; private set; }
        public IReadOnlyCollection<Livro> Livros => _livros.ToArray();

        public void AddLivros(Livro livro)
        {
            _livros.Add(livro);
        }

        public override string ToString()
        {
            return Nome;
        }
        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}
