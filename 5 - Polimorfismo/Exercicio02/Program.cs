using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinario claudio = new Veterinario();
            claudio.Nome = "Cláudio";
            
            Zoologico zoo = new Zoologico();
            zoo.RazaoSocial = "Zoológico Municipal de Araraquara-SP";
            zoo.Veterinario = claudio;

            Animal leao = new Leao();
            leao.Apelido = "Simba";

            Animal elefante = new Elefante();
            elefante.Apelido = "Dumbo";

            Animal preguica = new Preguica();
            preguica.Apelido = "Cid";

            zoo.Animais.Add(leao);
            zoo.Animais.Add(elefante);
            zoo.Animais.Add(preguica);

            zoo.ExaminarAnimais();
        }
    }
}
