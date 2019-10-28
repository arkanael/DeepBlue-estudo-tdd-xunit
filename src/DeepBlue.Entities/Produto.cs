﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DeepBlue.Entities
{
    public class Produto 
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
