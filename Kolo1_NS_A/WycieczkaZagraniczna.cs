using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_A
{
    class WycieczkaZagraniczna:Wycieczka
    {
        private int miesiac;

        public WycieczkaZagraniczna(string miejsce, double cena, int miesiac)
            :base(miejsce, cena)
        {
            this.miesiac = miesiac;
        }

        public void FirstMinute()
        {
            if(miesiac %2 ==0)
            {
                this.cena = 0.8 * this.cena;
            }
            else
            {
                this.cena = 0.9 * this.cena;
            }
        }
    }
}
