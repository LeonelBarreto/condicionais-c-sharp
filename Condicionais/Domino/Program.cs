namespace Domino;

class Program
{
    static void Main(string[] args)
    {
        int ladoA = int.Parse(Console.ReadLine());
        int ladoB = int.Parse(Console.ReadLine());

        if (ladoA == ladoB)
        {
            Console.WriteLine("Sim!");
        }
        else
        {
            Console.WriteLine("Não!");
        }
    }
}

