namespace IsencaoImpostoRenda;

class Program
{
    static void Main(string[] args)
    {
        bool aposentado = bool.Parse(Console.ReadLine());
        bool portadorDeDoenca = bool.Parse(Console.ReadLine());
        float rendimentoAnual = float.Parse(Console.ReadLine());

        if (aposentado == true || portadorDeDoenca == true)
        {
            Console.WriteLine("Isento/a!");
        }
        else if (rendimentoAnual < 28559.70)
        {
            Console.WriteLine("Vaza, Leão! Já está difícil sem você!");
        }
        else
        {
            Console.Write("Pega, Leão!");
        }
    }
}

