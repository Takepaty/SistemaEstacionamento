
using System.Globalization;
using System.Text.RegularExpressions;



public class Estacionamento
{
    private struct Registro
    {
        public DateTime HoraEntrada;
        public string NomeCondutor;
    }

    private Dictionary<string, Registro> checkIns = new Dictionary<string, Registro>();
    private readonly double taxaPorHora = 5.00;

    private const string RegexPattern = @"^[A-Z]{3}\d{1}[A-Z]{1}\d{2}$";

    public bool PlacaValida(string placa)
    {
        string placaUpper = placa.ToUpper();
        return Regex.IsMatch(placaUpper, RegexPattern);
    }

    public void EntradaVeiculo(string placa, string nomeCondutor)
    {
        string placaUpper = placa.ToUpper();

        if (!PlacaValida(placaUpper))
        {
            Console.WriteLine(MensagemErro.PlacaInvalida);
            return;
        }

        if (string.IsNullOrWhiteSpace(nomeCondutor))
        {
            Console.WriteLine(MensagemErro.NomeCondutorInvalido);
            return;
        }

        string nomeCondutorFormatado = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomeCondutor.ToLower());

        Registro registro = new Registro
        {
            HoraEntrada = DateTime.Now,
            NomeCondutor = nomeCondutorFormatado
        };

        checkIns[placaUpper] = registro;
    }

    public double SaidaVeiculo(string placa)
    {
        string placaUpper = placa.ToUpper();

        if (!checkIns.TryGetValue(placaUpper, out Registro registro))
        {
            Console.WriteLine(MensagemErro.VeiculoNaoEncontrado);
            return 0;
        }

        double horasNoEstacionamento = (DateTime.Now - registro.HoraEntrada).TotalHours;
        double custo = CalcularCusto(horasNoEstacionamento);

        Console.WriteLine($"O custo para o veículo {placaUpper}, conduzido por {registro.NomeCondutor}, é {custo:C2}");

        checkIns.Remove(placaUpper);

        return custo;
    }

    private double CalcularCusto(double horasNoEstacionamento)
    {
        return horasNoEstacionamento * taxaPorHora;
    }

    public void ListarVeiculos()
    {
        if (checkIns.Count == 0)
        {
            Console.WriteLine(MensagemErro.NenhumVeiculoEstacionado);
            return;
        }

        Console.WriteLine("Veículos estacionados:");
        foreach (var (placa, registro) in checkIns)
        {
            Console.WriteLine($"Placa: {placa}, Data e Hora de entrada: {registro.HoraEntrada}, Nome do Condutor: {registro.NomeCondutor}");
        }
    }
}