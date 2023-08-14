namespace NotaEmConceito;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira sua nota:");
        string nota = Console.ReadLine();

        if (nota < 4)
        {
            Console.WriteLine("O estudante obteve o conteito E.");
        }
        else if (nota < 6 )
        {
            Console.WriteLine("O estudante obteve o conteito D.");
        }
        else if (nota < 8)
        {
            Console.WriteLine("O estudante obteve o conteito C.");
        }
        else if (nota < 9)
        {
            Console.WriteLine("O estudante obteve o conteito B.");
        }
        else if (nota < 10)
        {
            Console.WriteLine("O estudante obteve o conteito A.");
        }
        else
            Console.WriteLine("Por favor inserir um número entre 0 e 10.");
    }
}

