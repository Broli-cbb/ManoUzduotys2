using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraUzduotis.Models
{
    public class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateOnly GimimoData { get; set; }


        public Zmogus(string vardas, string pavarde, string gimimoData)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoData = DateOnly.Parse(gimimoData);
        }
    }
}
