using System.Globalization;

namespace valorDaParcela;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor inserir em números inteiros a quantidade de meses decorridos do contrato:");
        int mesesDecorridos = int.Parse(Console.ReadLine());

        Console.WriteLine("Por favor inserir sua renda em centavos:");
        int rendaMensalCentavos = int.Parse(Console.ReadLine());

        Console.WriteLine("Por favor insira o total já pago pelo aluno em centavos:");
        int totalJaPago = int.Parse(Console.ReadLine());

        if (mesesDecorridos > 60 || totalJaPago == 1800000)
        {
            Console.WriteLine("Tempo decorrido de contrato superior a 60 meses. O aluno não deve mais nada.");
        }
        else if (rendaMensalCentavos < 200000)
        {
            Console.WriteLine("O valor da parcela desse mês é R$ 0 reais. Nenhum valor é devido pois a renda do estudante está abaixo do valor mínimo de R$ 2000 reais.");
        }
        else
        {
            Console.WriteLine($"O valor da parcela a ser pago este mês é de R${((rendaMensalCentavos * 0.18)/100).ToString("F2", new CultureInfo("pt-BR"))}.");
        }
    }
}

