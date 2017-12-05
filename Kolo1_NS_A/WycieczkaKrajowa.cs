using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_A
{
    class WycieczkaKrajowa:Wycieczka
    {
        private bool allInclusive;

        public WycieczkaKrajowa(string miejsce, double cena, bool all)
            :base(miejsce,cena)
        {
            this.allInclusive = all;
        }

        public void LastMinute()
        {
            this.cena = this.cena / 2;
        }
    }
}
