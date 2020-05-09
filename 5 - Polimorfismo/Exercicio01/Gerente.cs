namespace Exercicio03
{
    public class Gerente : Funcionario
    {
        public double Bonificacao { get; private set; } = 500.00;

        public override double CalcularSalario()
        {
            // Gerentes ganham 6 salários mínimos, mais sua bonificação.
            return (6 * base.salarioMinimo) + Bonificacao;
        }
        
    }
}