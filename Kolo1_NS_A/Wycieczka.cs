using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_A
{
    class Wycieczka
    {
        protected double cena;
        protected string miejsce;

        public Wycieczka(string miejsce, double cena)
        {
            this.miejsce = miejsce;
            this.cena = cena;
        }

        public string Info()
        {
            return miejsce + " " + cena;
        }
    }
}
