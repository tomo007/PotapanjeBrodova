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
        private Polje prvoPogođenoPolje;
        private int duljinaBroda;
        private IEnumerable<Polje> dajKandidate() {
            List<Polje> kandidati = new List<Polje>();
            foreach (Smjer smjer in Enum.GetValues(typeof(Smjer))) {
               var lista= mreža.DajNizSlobodnihPolja(prvoPogođenoPolje,smjer);
            }
            return kandidati;
        }
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
