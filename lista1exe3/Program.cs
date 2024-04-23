using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe3
{
    internal class Program
    {
        private static object lado;

        static void Main(string[] args)
        {
            Console.WriteLine("digite o valor da diagonal do quadrado:");
            double diagonal = Convert.ToDouble(Console.ReadLine());

            // Cauculando o lado do quadrado utilizando o teorema de pitágoras
            double lado = diagonal / Math.Sqrt(2);

            // calculando a area do quadrado
            double area = lado * lado;

            Console.WriteLine($" a area do quadrado é: {area}");
        }
    }
}
