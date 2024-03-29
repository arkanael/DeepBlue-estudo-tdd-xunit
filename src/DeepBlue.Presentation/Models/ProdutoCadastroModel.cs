﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeepBlue.Presentation.Models
{
    public class ProdutoCadastroModel
    {
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o preço.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe a quantidade.")]
        public int Quantidade { get; set; }

    }
}
