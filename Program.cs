using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double cm = 100, metros, km = 1000, cmValor, kmValor;
            Console.WriteLine("\n---Medidas---");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nDigite em metros: ");
            Console.ResetColor();
            metros = Convert.ToDouble(Console.ReadLine());

            cmValor = metros * cm;
            kmValor = metros / km;
            Console.WriteLine("\n---Resultado---");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n {cmValor} cm\n {metros} m\n {kmValor} km\n");
            Console.ResetColor();
        }
    }
}
