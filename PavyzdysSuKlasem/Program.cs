using PavyzdysSuKlasem.Models;

namespace PavyzdysSuKlasem
{
    public class Program
    {
        public static void Main()
        {
            Program p = new Program();

            Console.WriteLine("Kiek gyvunu noresite ivesti? ");
            int n = int.Parse(Console.ReadLine());
            Gyvunas[] gyvunai = new Gyvunas[n];
            for (int i = 0; i < n; i++)
            {
                gyvunai[i] = p.IvestiGyvuna();
            }
            foreach(Gyvunas gyvunas in gyvunai)
            {
                p.SpausdintiGyvuna(gyvunas);
            }
            
        }
        public Gyvunas IvestiGyvuna()
        {
            Console.WriteLine("Iveskite gyvuno varda:");
            string vardas = Console.ReadLine();

            Console.WriteLine("Iveskite gyvuno rusi:");
            string rusis = Console.ReadLine();

            Console.WriteLine("Iveskite gyvuno amziu:");
            int amzius = int.Parse(Console.ReadLine());

            return new Gyvunas(vardas, rusis, amzius);
        }

        public void SpausdintiGyvuna(Gyvunas gyvunas)
        {
            Console.WriteLine($"Vardas: {gyvunas.Vardas} | Rusis: {gyvunas.Rusis} | Gyvuno gimimo metai: {gyvunas.GautiGyvunoGimimoMetus()}");
        }
        
    }

}