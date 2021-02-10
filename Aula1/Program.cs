using System;


namespace Aula1
{
    class Program
    {
        static void Main()
        {
            int num1, num2, resultado;

            Console.WriteLine("Numero1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero2: ");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("Soma: {0}", resultado);
            Console.ReadKey();
        }
    }
}
