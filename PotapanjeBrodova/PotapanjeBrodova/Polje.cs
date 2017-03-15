using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
   public class Polje:IEquatable<Polje>
    {
        public Polje(int Redak, int Stupac) {
            this.Redak = Redak;
            this.Stupac = Stupac;

        }
        public readonly int Redak, Stupac;

        public bool Equals(Polje other)
        {
            return Redak == other.Redak && Stupac == other.Stupac;
        }
    }
}
