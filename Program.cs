using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula08, Calcule a area do triangulo, tipo double
            //Jonas valereo - Técnico em Informátia 

            //Declarando as variaveis tipo double

            double b, h, area;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a base do triangulo: ");
            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a altura do triangulo: ");
            h = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
          

            //Declarando a variavel area do triangulo

            area = (b * h )/ 2;

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("Area do triangulo: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Parabéns, tente de novo!!!");

            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa


        }
    }
}
