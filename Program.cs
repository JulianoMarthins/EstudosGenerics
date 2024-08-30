using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testes.Entities;

namespace Testes {
    internal class Program {
        static void Main (string[] args) {

            PrintService<double> printService = new PrintService<double>();

            Console.Write("How many values? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) {
                Console.Write($"Digite o {i + 1}° valor: ");
                double value = double.Parse(Console.ReadLine());
                printService.AddValue(value);
            }

            printService.Print();

            Console.Write("First value: ");
            Console.WriteLine(printService.First());
        }
    }
}
