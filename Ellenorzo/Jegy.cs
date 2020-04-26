using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellenorzo
{
    class Jegy
    {
        int erdemjegy;

        public Jegy(int jegy)
        {
            Erdemjegy = jegy;
        }

        public int Erdemjegy { get => erdemjegy; set => erdemjegy = value; }
    }
}
