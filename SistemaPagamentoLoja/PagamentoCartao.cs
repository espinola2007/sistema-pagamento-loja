using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPagamentoLoja
{
    internal class PagamentoCartao : FormaPagamento
    {
        public override decimal CalcularValorFinal(decimal valor)
        {
            return valor * 1.03m;
        }
    }
}