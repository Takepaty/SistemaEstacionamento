
public class Menu
{
    private Estacionamento estacionamento;

    public Menu(Estacionamento estacionamento)
    {
        this.estacionamento = estacionamento;
    }

    public void ExibirMenu()
    {
        bool exibirMenu = true;

        Console.WriteLine("Seja bem-vindo ao PMB Estacionamento.");

        while (exibirMenu)
        {
            Console.WriteLine();
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1 - Check-in de Veículo");
            Console.WriteLine("2 - Check-out de Veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            string opcao = Console.ReadLine();

            if (OpcaoInvalida(opcao))
            {
                Console.WriteLine(MensagemErro.OpçãoInvalida);
                continue;
            }

            switch (opcao)
            {
                case "1":
                    ExecutarCheckIn();
                    break;

                case "2":
                    ExecutarCheckOut();
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;

                case "4":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Pressione Enter para continuar");
            Console.ReadLine();

            Console.Clear();
        }

        Console.WriteLine("O programa foi encerrado!");
    }

    private bool OpcaoInvalida(string opcao)
    {
        return opcao == null || string.IsNullOrWhiteSpace(opcao);
    }

    private void ExecutarCheckIn()
    {
        Console.WriteLine("Digite a placa do veículo para Check-in:");
        string placaEntrada = Console.ReadLine();
        Console.WriteLine("Digite o nome do condutor:");
        string nomeCondutor = Console.ReadLine();
        estacionamento.EntradaVeiculo(placaEntrada, nomeCondutor);
    }

    private void ExecutarCheckOut()
    {
        Console.WriteLine("Digite a placa do veículo para Check-out:");
        string placaSaida = Console.ReadLine();
        double custo = estacionamento.SaidaVeiculo(placaSaida);
        Console.WriteLine($"Custo: {custo:C2}");
    }

}