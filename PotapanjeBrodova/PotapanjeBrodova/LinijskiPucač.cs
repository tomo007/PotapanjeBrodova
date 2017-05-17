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
        private List<Polje> DajKandidate()
        {
            if (pogođenaPolja.First().Redak == pogođenaPolja.Last().Redak)
               return DajHorizontalnaPolja();
            return DajVertikalnaPolja();

        }
        private List<Polje> DajHorizontalnaPolja()
        {
            List<Polje> polja = new List<Polje>();
            Polje prvo = pogođenaPolja.First(), zadnje= pogođenaPolja.Last();
            var lijevaPolja=mreža.DajNizSlobodnihPolja(prvo, Smjer.Lijevo);
            if (lijevaPolja.Count() < 0)
                polja.Add(lijevaPolja.First());
            var desnaPolja = mreža.DajNizSlobodnihPolja(zadnje, Smjer.Desno);
            if (desnaPolja.Count() > 0)
                polja.Add(desnaPolja.First());
            return polja;
        }
        private List<Polje> DajVertikalnaPolja()
        {

        }
    }
}
