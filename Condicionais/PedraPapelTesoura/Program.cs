namespace PedraPapelTesoura;

class Program
{
    static void Main(string[] args)
    {
        string jogador1 = Console.ReadLine();
        string jogador2 = Console.ReadLine();

        if (jogador1 == jogador2)
        {
            Console.WriteLine("EMPATE");
        }
        else if (jogador1 == "Papel" && jogador2 == "Pedra")
        {
            Console.WriteLine("Jogador 1 venceu");
        }
        else if (jogador1 == "Pedra" && jogador2 == "Tesoura")
        {
            Console.WriteLine("Jogador 1 venceu");
        }
        else if (jogador1 == "Tesoura" && jogador2 == "Papel")
        {
            Console.WriteLine("Jogador 1 venceu");
        }
        else if (jogador1 == "Pedra" && jogador2 == "Papel")
        {
            Console.WriteLine("Jogador 2 venceu");
        }
        else if (jogador1 == "Tesoura" && jogador2 == "Pedra")
        {
            Console.WriteLine("Jogador 2 venceu");
        }
        else if (jogador1 == "Papel" && jogador2 == "Tesoura")
        {
            Console.WriteLine("Jogador 2 venceu");
        }
        else
        {
            Console.WriteLine("Por favor, inserir Pedra, Papel ou Tesoura.");
        }
    }
}

