namespace NomeParaExibicao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o seu primeiro nome (ou não):");
        string nome = Console.ReadLine();

        Console.WriteLine("Insira o seu sobrenome (ou não):");
        string sobrenome = Console.ReadLine();

        Console.WriteLine("Insira o seu apelido (ou não):");
        string apelido = Console.ReadLine();

        if (nome)
        {
            Console.WriteLine($"{nome}");
        }
        else if (nome && sobrenome)
        {
            Console.WriteLine($"{nome} {sobrenome}");
        }
        else if (apelido)
        {
            Console.WriteLine($"{apelido}");
        }
        else
        {
            Console.WriteLine("Você deve inserir pelo menos nome, sobrenome ou apelido.");
        }
    }
}

