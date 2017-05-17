using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class LinijskiPucač : IPucač
    {
        private Mreza mreža;
        private List<Polje> pogođenaPolja;
        private int duljinaBroda;
        private Random izbornik = new Random();
        private Polje gađanoPolje;
        public LinijskiPucač(Mreza mreža, IEnumerable<Polje> pogođena, int duljinaBroda)
        {
            this.mreža = mreža;
            this.pogođenaPolja =new List<Polje>( pogođena);
            this.duljinaBroda = duljinaBroda;

        }
        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                return pogođenaPolja;
            }
        }

        public Polje Gađaj()
        {
            var kandidati = DajKandidate();
            gađanoPolje= kandidati[izbornik.Next(kandidati.Count())];
            return gađanoPolje;

        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            switch (rezultat)
            {
                case RezultatGađanja.Promašaj:
                    return;
                case RezultatGađanja.Pogodak:
                    pogođenaPolja.Add(gađanoPolje);

                    return;
                case RezultatGađanja.Potopljen:
                    pogođenaPolja.Add(gađanoPolje);
                    TerminatorPolja terminator = new TerminatorPolja(mreža);
                    terminator.UkloniPolja(pogođenaPolja);
                    return;
                default:
                    Debug.Assert(false);
                    break;
            }
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
           throw new NotImplementedException();

        }
    }
}
