using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Console.WriteLine("Entre com seu nome completo: ");
                string pessoa = Console.ReadLine();
                Console.WriteLine("Quantos quartos tem na casa? ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o preço de um produto");
                double preço = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine("Entre seu ultimo nome, idade e altura na mesma linha: ");

                string[] vet = Console.ReadLine().Split(' ');
                string nome = vet[0];
                int idade = int.Parse(vet[1]);
                double altura = double.Parse(vet[2], CI);

                Console.WriteLine(pessoa);
                Console.WriteLine(quarto);
                Console.WriteLine(preço.ToString("F2", CI));
                Console.WriteLine(nome);
                Console.WriteLine(idade);
                Console.WriteLine(altura.ToString("F2", CI));

            }
        }
    }
}