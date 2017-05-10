using PotapanjeBrodova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class SlučajniPucač : IPucač
    { 
        private Mreza mreza;
        private int duljinaBroda;

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public SlučajniPucač(Mreza mreza, int duljinaBroda) {
             this.mreza = mreza;
             this.duljinaBroda = duljinaBroda;

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
