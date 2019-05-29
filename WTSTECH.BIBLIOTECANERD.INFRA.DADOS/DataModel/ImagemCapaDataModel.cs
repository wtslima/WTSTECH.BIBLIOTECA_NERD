using System;
using System.Collections.Generic;
using System.Text;

namespace WTSTECH.BIBLIOTECANERD.INFRA.DADOS.DataModel
{
    public class ImagemCapaDataModel
    {
        public Guid ImagemId { get;  set; }
        public Guid LivroId { get;  set; }
        public byte[] Foto { get;  set; }
        public virtual LivroDataModel Livro { get; set; }
    }
}
