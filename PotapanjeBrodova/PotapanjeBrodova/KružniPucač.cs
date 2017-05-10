using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {
        private Mreza mreža;
        Polje prvoPogođenoPolje;
        int duljinaBroda;
        public KružniPucač(Mreza mreža,  Polje pogođeno,int duljinaBroda) {
            this.mreža = mreža;
            this.prvoPogođenoPolje= pogođeno;
            this.duljinaBroda = duljinaBroda;

        }
        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Polje Gađaj()
        {
            throw new NotImplementedException();
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }
    }
}
