using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    public enum TekstilMarka
    {
        Kigili = 1,
        Beymen = 2,
        PierreCarden = 3,
        AltinYildiz = 4,
        Polo = 5
    }

    class Tekstil : Product
    {

        public string Tur { get; set; }
        public int Beden { get; set; }
        public string Uretici { get; set; }
        public TekstilMarka Marka { get; set; }


    }
}
