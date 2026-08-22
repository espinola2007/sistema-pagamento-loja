using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPagamentoLoja
{
    internal abstract class FormaPagamento
    {
        public abstract decimal CalcularValorFinal(decimal valor);
    }
}
