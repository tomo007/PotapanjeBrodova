using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class LinijskiPucač : IPucač
    {
        private Mreza mreža;
        private IEnumerable<Polje> pogođenaPolja;
        private int duljinaBroda;
        public LinijskiPucač(Mreza mreža, IEnumerable<Polje> pogođena, int duljinaBroda)
        {
            this.mreža = mreža;
            this.pogođenaPolja = pogođena;
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
