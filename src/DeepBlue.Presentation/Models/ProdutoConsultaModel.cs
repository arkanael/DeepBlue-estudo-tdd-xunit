using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepBlue.Presentation.Models
{
    public class ProdutoConsultaModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
    }
}
