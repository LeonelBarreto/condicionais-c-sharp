namespace RematriculaEscolar;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a idade do aluno:");
        int idadeAluno = int.Parse(Console.ReadLine());

        Console.WriteLine("Ele está acompanhado de um responsável? Insira 'true'para verdadeiro e 'false' para falso.");
        bool acompanhadoResponsavel = bool.Parse(Console.ReadLine());

        if(idadeAluno >= 18)
        {
            Console.WriteLine("Rematrícula realizada com sucesso.");
        }
        else if(idadeAluno < 18 && acompanhadoResponsavel == true)
        {
            Console.WriteLine("Rematrícula realizada com sucesso.");
        }
        else if (idadeAluno < 18 && acompanhadoResponsavel == false)
        {
            Console.WriteLine("Não é possível refazer a matrícula.");
        }
        else
        {
            Console.WriteLine("Por favor, inserir uma idade válida e informar se está acompanhado de um responsável usando apenas 'true' ou 'false'.");
        }
    }
}

