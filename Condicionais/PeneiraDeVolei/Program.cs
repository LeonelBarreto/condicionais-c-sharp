using System.Globalization;

namespace PeneiraDeVolei;

class Program
{
    static void Main(string[] args)
    {
        int alturaCandidatoEmCm = int.Parse(Console.ReadLine());
     
        if (alturaCandidatoEmCm >= 180)
        {
            Console.WriteLine("Aprovado!");
        }
        else
        {
            Console.WriteLine("Reprovado!");
        }
    }
}

