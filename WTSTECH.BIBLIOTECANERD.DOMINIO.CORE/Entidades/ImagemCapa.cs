using System;
using WTSTECH.BIBLIOTECANERD.DOMINIO.SHARED;

namespace WTSTECH.BIBLIOTECANERD.DOMINIO.CORE.Entidades
{
    public class ImagemCapa : EntidadeBase
    {
        protected ImagemCapa()
        {

        }

        public ImagemCapa(Guid id, Guid livroId, byte[] foto)
        {
            Id = id;
            LivroId = livroId;
            Foto = foto;
        }
        public ImagemCapa(Guid livroId, byte[] foto)
        {
            LivroId = livroId;
            Foto = foto;
        }

        public Guid LivroId { get; private set; }
        public byte[] Foto { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
