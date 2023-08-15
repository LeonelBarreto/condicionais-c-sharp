using System.Globalization;

namespace CompraComDesconto;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o método de pagamento: debito, credito, cheque ou dinheiro?");
        string formaDePagamento = Console.ReadLine();

        Console.WriteLine("Qual o valor total da compra em centavos?");
        int valorDaCompra = int.Parse(Console.ReadLine());

        float valorComDesconto = 0;

        if(formaDePagamento == "cheque")
        {
            valorComDesconto = (valorDaCompra * 97) / 100;
        }
        else if(formaDePagamento == "credito")
        {
            valorComDesconto = (valorDaCompra * 95) / 100;
        }
        else if(formaDePagamento == "debito" || formaDePagamento == "dinheiro")
        {
            valorComDesconto = (valorDaCompra * 90) / 100;
        }
        else
        {
            Console.WriteLine("Por favor, inserir apenas os meios de pagamentos informados e o valor da compra em centavos.");
        }
        Console.WriteLine("");
        Console.WriteLine($"O valor total a ser pago é R$ {(valorComDesconto / 100).ToString("F2", new CultureInfo("pt-BR"))}");
    }
}

