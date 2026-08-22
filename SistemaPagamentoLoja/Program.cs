using SistemaPagamentoLoja;

Cliente cliente1 = new Cliente("Maria", "1123476509889");
Venda venda1 = new Venda(20, cliente1, 500);

//Console.WriteLine($"Nome: {cliente1.Nome}");
//Console.WriteLine($"CPF: {cliente1.CPF}");

Console.WriteLine($"Venda: {venda1.Numero}");
Console.WriteLine($"Cliente: {venda1.Cliente.Nome}");
Console.WriteLine($"Valor: R$ {venda1.ValorCompra:F2}");
Console.WriteLine($"Situação: {venda1.Situacao}");
