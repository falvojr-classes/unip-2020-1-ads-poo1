using System;
using System.Collections.Generic;

namespace PIM
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}