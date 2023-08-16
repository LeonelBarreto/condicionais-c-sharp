namespace RematriculaEscolar;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a idade do aluno:");
        int idadeAluno = int.Parse(Console.ReadLine());

        Console.WriteLine("Ele está acompanhado de um responsável? Insira 'true'para verdadeiro e 'false' para falso.");
        bool acompanhadoResponsavel = bool.Parse(Console.ReadLine());

        if(idadeAluno >= 18 || acompanhadoResponsavel == true)
        {
            Console.WriteLine("Rematrícula realizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Não é possível refazer a matrícula.");
        }
    }
}

