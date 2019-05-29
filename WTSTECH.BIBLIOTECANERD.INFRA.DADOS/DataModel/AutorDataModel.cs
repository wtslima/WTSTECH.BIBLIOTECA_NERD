using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WTSTECH.BIBLIOTECANERD.INFRA.DADOS.DataModel
{
    public class AutorDataModel
    {
        public Guid AutorId { get; set; }
        public string Nome { get; set; }
        [ForeignKey("AutorId")]
        public ICollection<LivroDataModel> Livros { get; set; }
    }
}
