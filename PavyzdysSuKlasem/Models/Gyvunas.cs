using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavyzdysSuKlasem.Models
{
    public class Gyvunas
    {
        public string Vardas { get; set; }
        public string Rusis { get; set; }
        public int Amzius { get; set; }

        public Gyvunas(string vardas, string rusis, int amzius)
        {
            Vardas = vardas;
            Rusis = rusis;
            Amzius = amzius;
        }
        public int GautiGyvunoGimimoMetus()
        {
            return DateTime.Now.Year - Amzius;
        }
    }
}
