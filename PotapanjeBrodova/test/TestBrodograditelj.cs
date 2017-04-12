using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    [TestClass]
    public class TestBrodograditelj
    {
        [TestMethod]
        public void Brodograditelj_SloziFlotuVracaFlotuSBrodovimaZadaneDuljine()
        {
            Brodograditelj b = new Brodograditelj();
            Mreza mreza = new Mreza(10,10);
            IEnumerable<int> duljineBrodova = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };
            Flota f= b.SloziFlotu(mreza, duljineBrodova);
            Assert.AreEqual(duljineBrodova.Count(), f.BrojBrodova);
            //TODO:provjera ima li samo jedan brod duljine 5
            //TODO:provjera imali dva broda duljine 4...
        }
    }
}
