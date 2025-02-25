using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraUzduotis.Models
{
    public class Paskaita
    {
        public string PaskaitosPavadinimas { get; set; }
        public Zmogus Lektorius { get; set; }
        public Zmogus[] Studentai { get; set; }

        public int GautiStudentuKieki()
        {
            int kiekis = 0;
            foreach(Zmogus z in Studentai)
            {
                if(z != null)
                {
                    kiekis++;
                }
            }
            return kiekis;
        }
        public int LaisvosVietos()
        {
            int kiekis = 0;
            foreach (Zmogus z in Studentai)
            {
                if (z == null)
                {
                    kiekis++;
                }
            }
            return kiekis;
        }
        public bool ArLektoriusJaunesnisNegu30ies()
        {
            if (DateTime.Now.Year - Lektorius.GimimoData.Year < 30)
                return true;
            else
                return false;
        }
    }
}
