namespace DominoBucha;

class Program
{
    static void Main(string[] args)
    {
        int ladoA = int.Parse(Console.ReadLine());
        int ladoB = int.Parse(Console.ReadLine());

        if (ladoA != ladoB)
        {
            Console.WriteLine("Não é uma bucha!");
        }
        else if (ladoA == 0 && ladoB == 0)
        {
            Console.WriteLine("Bucha de BRANCO!");
        }
        else if (ladoA == 1 && ladoB == 1)
        {
            Console.WriteLine("Bucha de ÁS!");
        }
        else if (ladoA == 2 && ladoB == 2)
        {
            Console.WriteLine("Bucha de DUQUE!");
        }
        else if (ladoA == 3 && ladoB == 3)
        {
            Console.WriteLine("Bucha de TERNO!");
        }
        else if (ladoA == 4 && ladoB == 4)
        {
            Console.WriteLine("Bucha de QUADRA!");
        }
        else if (ladoA == 5 && ladoB == 5)
        {
            Console.WriteLine("Bucha de QUINA!");
        }
        else if (ladoA == 6 && ladoB == 6)
        {
            Console.WriteLine("Bucha de SENA!");
        }
        else
        {
            Console.WriteLine("Por favor, inserir números válidos (0 a 6).");
        }
    }
}

