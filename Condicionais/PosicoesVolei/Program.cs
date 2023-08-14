namespace PosicoesVolei;

class Program
{
    static void Main(string[] args)
    {
        int alturaCandidatoEmCm = int.Parse(Console.ReadLine());

        if (alturaCandidatoEmCm < 180)
        {
            Console.WriteLine("Reprovado!");
        }
        else if(alturaCandidatoEmCm <= 185)
        {
            Console.WriteLine("Libero");
        }
        else if (alturaCandidatoEmCm <= 195)
        {
            Console.WriteLine("Ponteiro");
        }
        else if (alturaCandidatoEmCm <= 205)
        {
            Console.WriteLine("Oposto");
        }
        else
        {
            Console.WriteLine("Central");
        }
    }
}

