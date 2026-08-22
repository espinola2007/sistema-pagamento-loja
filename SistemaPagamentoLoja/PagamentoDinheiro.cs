namespace SistemaPagamentoLoja
{
    internal class PagamentoDinheiro : FormaPagamento
    {
        public override decimal CalcularValorFinal(decimal valor)
        {
            return valor;
        }
    }
}