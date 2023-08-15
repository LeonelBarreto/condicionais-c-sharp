namespace ConsumoDeAguaIngerida;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira em números (se for decimal usar ponto e não vírgula) a quantidade de água ingerida:");
        float quantidadeAguaIngerida = float.Parse(Console.ReadLine());

        if(quantidadeAguaIngerida < 1.5)
        {
            Console.WriteLine("Risco Alto - Você está ingerindo pouquíssima água. Beba mais água!");
        }
        else if (quantidadeAguaIngerida >= 1.5 && quantidadeAguaIngerida <= 3)
        {
            Console.WriteLine("Risco Moderado - Você está ingerindo pouca água. Beba mais!");
        }
        else
        {
            Console.WriteLine("Risco Baixo - Você está ingerindo uma boa quantidade de água. Parabéns!");
        }
    }
}

