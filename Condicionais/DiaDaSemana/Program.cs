namespace DiaDaSemana;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número entre 1 e 7:");
        int diaDaSemana = int.Parse(Console.ReadLine());

        if (diaDaSemana == 1)
        {
            Console.WriteLine("Segunda-feira");
        }
        else if (diaDaSemana == 2)
        {
            Console.WriteLine("Terça-feira");
        }
        else if (diaDaSemana == 3)
        {
            Console.WriteLine("Quarta-feira");
        }
        else if (diaDaSemana == 4)
        {
            Console.WriteLine("Quinta-feira");
        }
        else if (diaDaSemana == 5)
        {
            Console.WriteLine("Sexta-feira");
        }
        else if (diaDaSemana == 6)
        {
            Console.WriteLine("Sábado");
        }
        else if (diaDaSemana == 7)
        {
            Console.WriteLine("Domingo");
        }
        else
        {
            Console.WriteLine("Digite um número entre 1 e 7.");
        }
    }
}

