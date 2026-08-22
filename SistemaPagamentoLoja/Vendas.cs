using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPagamentoLoja
{
    internal class Venda
    {
        public int Numero {  get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorCompra { get; }
        public string Situacao { get; private set; }

        public Venda (int numero, Cliente cliente ,decimal valorCompra) 
        { 
            Numero = numero;
            Cliente = cliente;
            ValorCompra = valorCompra;
            Situacao = "Pendente";
        }


    }
}
