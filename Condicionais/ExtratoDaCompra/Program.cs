using System.Globalization;

namespace ExtratoDaCompra;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o valor do produto comprado em centavos:");
        int valorProduto = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o número de parcelas:");
        int parcelasTotais = int.Parse(Console.ReadLine());

        Console.WriteLine("insira a quantidade de parcelas pagas até o momento:");
        int parcelasPagas = int.Parse(Console.ReadLine());

        int valorParcela = (valorProduto / parcelasTotais) / 100;

        int parcelasRestantes = parcelasTotais - parcelasPagas;

        Console.WriteLine($"Restam {parcelasRestantes} de R$ {valorParcela.ToString("F2", new CultureInfo("pt-BR"))}");
    }
}

