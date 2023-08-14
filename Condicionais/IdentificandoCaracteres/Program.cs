namespace IdentificandoCaracteres;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a letra ou número");
        string caractere = Console.ReadLine();

        if (caractere == "A" || caractere == "E" || caractere == "I" || caractere == "O" || caractere == "U")
        {
            Console.WriteLine("Vogal Maiúscula.");
        } else if (caractere == "a" || caractere == "e" || caractere == "i" || caractere == "o" || caractere == "u")
        {
            Console.WriteLine("Vogal Minúscula.");
        }
        else if (caractere == "0" || caractere == "1" || caractere == "2" || caractere == "3" || caractere == "4" ||
            caractere == "5" || caractere == "6" || caractere == "7" || caractere == "8" || caractere == "9")
        {
            Console.WriteLine("Número.");
        }
        else
        {
            Console.WriteLine("Consoante");
        }
    }
}

