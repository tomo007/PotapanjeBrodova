﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
   public class RedFiksneDuljine<T> : Queue<T> {
        private int maksimalnaDuljina;
        public RedFiksneDuljine(int maksimalnaDuljina) {
            this.maksimalnaDuljina = maksimalnaDuljina;
        }
        public new void Enqueue(T element) {
            base.Enqueue(element);
            while (base.Count > maksimalnaDuljina) {
                Dequeue();
            }
        }
    }
}
