using System;
using System.Collections.Generic;

namespace PIM
{
    public class DadoBancario : BaseCRUD<DadoBancario>
    {
        public string Banco { get; set; } 
        public string Agencia { get; set; }    
        public string Conta { get; set; }    
        
        public void Incluir()
        {
            
        }

        public void Alterar()
        {

        }

        public void Excluir()
        {

        }

        public List<DadoBancario> Listar()
        {
            return null;
        }   
    }
}