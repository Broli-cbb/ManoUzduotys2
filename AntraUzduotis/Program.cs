using AntraUzduotis.Models;
using System;

namespace Ciklai
{
    public class Program
    {
        string ilgasTekstas;
        public static void Main()
        {
            Program p = new Program();
            p.ilgasTekstas = Console.ReadLine();

            string[] zodziai = p.ilgasTekstas.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach(var zodis in zodziai)
            {
                Console.WriteLine(zodis);
            }
        }

    }
}