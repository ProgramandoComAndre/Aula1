using System;


namespace Aula1
{
    class Program
    {
        static void Main()
        {
            //variaveis
            int num1, num2, resultado;

            //leitura dos numeros
            Console.WriteLine("Numero1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero2: ");
            num2 = int.Parse(Console.ReadLine());

            //soma dos numeros
            resultado = num1 + num2;

            //apresentacao dos resultados
            Console.WriteLine("Soma: {0}", resultado); 
            Console.ReadKey();
        }
    }
}
