using System;
using System.Collections.Generic;

namespace PIM
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        
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