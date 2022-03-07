using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //vytvoření slovníku který má jako klíč číslo a jako hodnotu text
            Dictionary<string, string> slovník = new Dictionary<string, string>();
            Console.WriteLine("kolik chcete čísel");
            string input = Console.ReadLine();
            int inputCislo = Convert.ToInt32(input);

            for (int pocitadlo = 0; pocitadlo < inputCislo; pocitadlo++)
            {
                Console.WriteLine("zadej jmeno");
                string sjok1 = Console.ReadLine();
                Console.WriteLine("zadej tel.číslo");
                string cislo = Console.ReadLine();
                slovník.Add(sjok1, cislo);
            }
            foreach (var radekSlovniku in slovník)
            Console.WriteLine($"Klíč: {radekSlovniku.Key}, Hodnota: {radekSlovniku.Value}");

        }
    }
}
