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
        
        public override void Incluir()
        {
            
        }

        public override void Alterar()
        {

        }

        public override void Excluir()
        {

        }

        public override List<Endereco> Listar()
        {
            return null;
        }  
    }
}