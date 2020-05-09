namespace Exercicio03
{
    public class Vendedor : Funcionario
    {
        public double Comissao { get; set; }
        public long NumeroVendas { get; set; }

        public override double CalcularSalario()
        {
            // Vendedores ganham 1 salário mínimo, mais uma comissão por vendas.
            return base.salarioMinimo + (NumeroVendas * Comissao);
        }

    }
}