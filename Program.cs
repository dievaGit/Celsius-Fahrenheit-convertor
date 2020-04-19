using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorCelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius = 0.0f, convertor = 0.0f;
            Console.Write("Escriba los grados celsius:");
            celsius = Convert.ToSingle(Console.ReadLine());

            convertor = (celsius * 9 / 5) + 32;
            Console.WriteLine("Estos grados celsius representan {0} grados fahrenheit", convertor);

            Console.ReadKey();



        }
    }
}
