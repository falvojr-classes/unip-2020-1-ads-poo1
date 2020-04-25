using System;
using System.Collections.Generic;

namespace PIM
{
    public class Endereco : BaseCRUD<Endereco>
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }     
        
        public void Incluir()
        {
            
        }

        public void Alterar()
        {

        }

        public void Excluir()
        {

        }

        public List<Endereco> Listar()
        {
            return null;
        }  
    }
}