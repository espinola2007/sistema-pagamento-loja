using System;
using System.Collections.Generic;
using System.Text;

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
