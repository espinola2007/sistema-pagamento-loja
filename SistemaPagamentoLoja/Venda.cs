namespace SistemaPagamentoLoja
{
    internal class Venda
    {
        public int Numero { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorCompra { get; }
        public string Situacao { get; private set; }

        public FormaPagamento FormaPagamento { get; private set; }
        public decimal ValorFinal { get; private set; }

        public Venda(int numero, Cliente cliente, decimal valorCompra)
        {
            if (valorCompra <= 0)
            {
                throw new ArgumentException("O valor da venda deve ser maior que zero.");
            }

            Numero = numero;
            Cliente = cliente;
            ValorCompra = valorCompra;
            Situacao = "Pendente";
        }

        public bool Pagar(FormaPagamento formaPagamento)
        {
            if (Situacao == "Pago")
            {
                return false;
            }

            ValorFinal = formaPagamento.CalcularValorFinal(ValorCompra);
            FormaPagamento = formaPagamento;
            Situacao = "Pago";

            return true;
        }
    }
}