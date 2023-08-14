namespace MontanhaRussa;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira sua idade (apenas números):");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Alguma patologia? Insira apenas true ou false:");
        bool patologia = bool.Parse(Console.ReadLine());

        Console.WriteLine("Insira sua altura (apenas números inteiros) em centimetros:");
        int alturaMinimaEmCm = int.Parse(Console.ReadLine());

        Console.WriteLine("Você é estudante? Insira apenas true ou false:");
        bool estudante = bool.Parse(Console.ReadLine());

        if (idade < 12 || idade >=65 || patologia == true || alturaMinimaEmCm < 150)
        {
            Console.WriteLine("Acesso Negado!");
        }
        else if (idade < 18 || estudante == true)
        {
            Console.WriteLine("10 Reais!");
        }
        else
        {
            Console.WriteLine("20 Reais");
        }
    }
}

