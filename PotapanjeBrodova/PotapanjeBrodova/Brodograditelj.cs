using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class Brodograditelj
    {
        private Random slucajni = new Random();
        public Flota SloziFlotu(Mreza mreza, IEnumerable<int> duljineBrodova) {
            Flota flota = new Flota();
            TerminatorPolja terminator = new TerminatorPolja(mreza);
            foreach (int i in duljineBrodova) {
                var nizovi=mreza.DajNizoveSlobodnihPolja(i);
                int index=slucajni.Next(nizovi.Count());
                var niz=nizovi.ElementAt(index);
                flota.DodajBrod(niz);
                terminator.UkloniPolja(niz);
            }
            //TODO:obratiti paznju na slucaj da se ne mogu svi brodovi sloziti
            return flota;
        }
    }
}
