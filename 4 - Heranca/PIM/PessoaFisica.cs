using System;
using System.Collections.Generic;

namespace PIM
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        
        public override void Incluir()
        {
            
        }

        public override void Alterar()
        {

        }

        public override void Excluir()
        {

        }

        public override List<Cliente> Listar()
        {
            return null;
        }
    }
}