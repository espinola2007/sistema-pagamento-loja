using SistemaPagamentoLoja;

List<Venda> vendas = new List<Venda>();

string opcao;

do
{
    Console.WriteLine("       SISTEMA DE VENDAS");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("1 - Cadastrar venda");
    Console.WriteLine("2 - Listar vendas");
    Console.WriteLine("3 - Realizar pagamento");
    Console.WriteLine("0 - Sair");
    Console.WriteLine(" ");

    Console.Write("Escolha uma opção: ");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.Write("Número da venda: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Nome do cliente: ");
        string nome = Console.ReadLine();

        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        Console.Write("Valor da compra: ");
        decimal valor = decimal.Parse(Console.ReadLine());

        Cliente cliente = new Cliente(nome, cpf);
        Venda venda = new Venda(numero, cliente, valor);

        vendas.Add(venda);

        Console.WriteLine();
        Console.WriteLine("Venda cadastrada com sucesso!");
        Console.WriteLine($"Situação: {venda.Situacao}");
    }
    else if (opcao == "2")
    {
        if (vendas.Count == 0)
        {
            Console.WriteLine("Não existem vendas cadastradas.");
        }
        else
        {
            foreach (Venda venda in vendas)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Venda: {venda.Numero}");
                Console.WriteLine($"Cliente: {venda.Cliente.Nome}");
                Console.WriteLine($"Valor original: R$ {venda.ValorCompra:F2}");
                Console.WriteLine($"Situação: {venda.Situacao}");

                if (venda.Situacao == "Pago")
                {
                    Console.WriteLine($"Forma de pagamento: {venda.FormaPagamento}");
                    Console.WriteLine($"Valor final: R$ {venda.ValorFinal:F2}");
                }
            }

            Console.WriteLine("--------------------------------");
        }
    }
    else if (opcao == "3")
    {
        Console.Write("Digite o número da venda: ");
        int numeroVenda = int.Parse(Console.ReadLine());

        Venda vendaEncontrada = null;

        foreach (Venda venda in vendas)
        {
            if (venda.Numero == numeroVenda)
            {
                vendaEncontrada = venda;
                break;
            }
        }

        if (vendaEncontrada == null)
        {
            Console.WriteLine("Venda não encontrada.");
        }
        else
        {
            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - PIX");
            Console.WriteLine("2 - Cartão de crédito");
            Console.WriteLine("3 - Dinheiro");
            Console.WriteLine("--------------------------------");

            Console.Write("Escolha uma opção: ");
            string opcaoPagamento = Console.ReadLine();

            FormaPagamento formaPagamento;
            string nomeFormaPagamento;

            if (opcaoPagamento == "1")
            {
                formaPagamento = new PagamentoPix();
                nomeFormaPagamento = "PIX";
            }
            else if (opcaoPagamento == "2")
            {
                formaPagamento = new PagamentoCartao();
                nomeFormaPagamento = "Cartão de crédito";
            }
            else if (opcaoPagamento == "3")
            {
                formaPagamento = new PagamentoDinheiro();
                nomeFormaPagamento = "Dinheiro";
            }
            else
            {
                Console.WriteLine("Forma de pagamento inválida.");
                formaPagamento = null;
                nomeFormaPagamento = "";
            }

            if (formaPagamento != null)
            {
                bool pagamentoRealizado = vendaEncontrada.Pagar(formaPagamento);

                if (pagamentoRealizado)
                {
                    Console.WriteLine($"Valor original: R$ {vendaEncontrada.ValorCompra:F2}");
                    Console.WriteLine($"Forma de pagamento: {nomeFormaPagamento}");
                    Console.WriteLine($"Valor final: R$ {vendaEncontrada.ValorFinal:F2}");
                    Console.WriteLine("Pagamento realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Essa venda já foi paga.");
                }
            }
        }
    }
    else if (opcao == "0")
    {
        Console.WriteLine("Sistema encerrado.");
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }

    Console.WriteLine();

} while (opcao != "0");