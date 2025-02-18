using System.Runtime.InteropServices;

namespace Projetos;

class Program
{
    static void Main(string[] args)
    {
        // Titulo do console
        Console.WriteLine("\t===  Calculadora em C#  ===");

        Console.Write("Digite o primeiro número que deseja calcular: ");
        int primeiro_num_digit = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o primeiro número que deseja calcular: ");
        int segundo_num_digit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\t=== Operação === ");
        Console.WriteLine("\n1 - Adição ");
        Console.WriteLine("2 - Subtração ");
        Console.WriteLine("3 - Multiplicação ");
        Console.WriteLine("4 - Divisão");
        Console.Write("Digite a operação desejada: ");

        int operador = Convert.ToInt32(Console.ReadLine());
        double resultado = 0;

        switch (operador)
        {
            case 1:
                resultado = primeiro_num_digit + segundo_num_digit;
                break;
            case 2:
                resultado = primeiro_num_digit - segundo_num_digit;
                break;
            case 3:
                resultado = primeiro_num_digit * segundo_num_digit;
                break;       
            case 4:
                resultado = primeiro_num_digit / segundo_num_digit;
                break;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Resultado = ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(resultado);
        Console.ResetColor();
    }
}
