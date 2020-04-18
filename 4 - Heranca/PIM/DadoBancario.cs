using System;
using System.Collections.Generic;

namespace PIM
{
    public class DadoBancario : BaseCRUD<DadoBancario>
    {
        public string Banco { get; set; } 
        public string Agencia { get; set; }    
        public string Conta { get; set; }    
        
        public override void Incluir()
        {
            
        }

        public override void Alterar()
        {

        }

        public override void Excluir()
        {

        }

        public override List<DadoBancario> Listar()
        {
            return null;
        }   
    }
}