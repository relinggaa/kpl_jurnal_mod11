using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AljabarLibraries;

namespace MainConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] hasil1 = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("Akar: " + hasil1[0] + ", " + hasil1[1]);

            double[] hasil2 = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil Kuadrat: " + hasil2[0] + ", " + hasil2[1] + ", " + hasil2[2]);

            Console.ReadLine();
        }
    }
}
