namespace ParOuImpar;

class Program
{
    static void Main(string[] args)
    {
        int jogador1 = int.Parse(Console.ReadLine());
        int jogador2 = int.Parse(Console.ReadLine());

        int soma = jogador1 + jogador2;
        int resto = soma % 2;

        if(resto == 0)
        {
            Console.WriteLine("PAR!");
        }
        else
        {
            Console.WriteLine("ÍMPAR!");
        }
    }
}

