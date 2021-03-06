namespace Exercicio03
{
    public class Consultor : Funcionario
    {
        public double ValorHora { get; set; }
        public double HorasTrabalhadas { get; set; }

        public override double CalcularSalario()
        {
            // Consultores ganham somente pelas horas que trabalharam.
            return HorasTrabalhadas * ValorHora;
        }
    }
}