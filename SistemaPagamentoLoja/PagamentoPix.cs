using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPagamentoLoja
{
    internal class PagamentoPix : FormaPagamento
    {
        public override decimal CalcularValorFinal(decimal valor)
        {
            return valor * 0.95m;
        }
    }
}
