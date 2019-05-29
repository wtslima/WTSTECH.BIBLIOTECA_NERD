using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WTSTECH.BIBLIOTECANERD.INFRA.DADOS.DataModel
{
    public class LivroDataModel
    {
        [Key]
        public Guid LivroId { get; set; }
        public string Titulo { get;  set; }
        public int Isbn { get;  set; }
        [ForeignKey("AutorId")]
        public virtual AutorDataModel Autor { get;  set; }
        public decimal Preco { get;  set; }
        [ForeignKey("ImagemId")]
        public virtual ImagemCapaDataModel Imagem { get;  set; }
        public Guid ImagemId { get; set; }
        public Guid AutorId { get; set; }
        public DateTime PublicacaoData { get;  set; }
    }
}
