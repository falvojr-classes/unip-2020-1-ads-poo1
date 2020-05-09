namespace Exercicio03
{
    public abstract class Funcionario
    {
        protected readonly double salarioMinimo = 1045.00;

        public string Nome { get; set; }
        public long Cpf { get; set; }

        public abstract double CalcularSalario();
    }
}