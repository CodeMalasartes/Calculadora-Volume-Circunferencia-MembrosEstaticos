using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Insira o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            double volume = Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de Pi é: "+ Pi.ToString("F2", CultureInfo.InvariantCulture ));

        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0) ;
        }
    }
}
