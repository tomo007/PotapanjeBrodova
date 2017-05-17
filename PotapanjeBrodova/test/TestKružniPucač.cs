using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestKružnogPucača
    {
        [TestMethod]
        public void KružniPucač_GađajDajeJednoOdOkolnihPolja()
        {
            Mreza Mreza = new Mreza(5, 5);
            KružniPucač puc = new KružniPucač(Mreza, new Polje(2, 2), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(1, 2), new Polje(2, 1), new Polje(3, 2), new Polje(2, 3) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }

        [TestMethod]
        public void KružniPucač_GađajDajeJednoOdPoljaDesnoIliLijevo()
        {
            Mreza Mreza = new Mreza(1, 5);
            KružniPucač puc = new KružniPucač(Mreza, new Polje(0, 2), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(0, 1), new Polje(0, 3) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }

        [TestMethod]
        public void KružniPucač_GađajDajeOkolnaPoljaKojaNisuEliminirana()
        {
            Mreza Mreza = new Mreza(5, 5);
            Mreza.UkloniPolje(1, 2);
            Mreza.UkloniPolje(3, 2);
            KružniPucač puc = new KružniPucač(Mreza, new Polje(2, 2), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(2, 1), new Polje(2, 3) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }

        [TestMethod]
        public void KružniPucač_GađajDajeJedinoOkolnoPoljeKojeNijeEliminirano()
        {
            Mreza Mreza = new Mreza(5, 5);
            Mreza.UkloniPolje(1, 2);
            Mreza.UkloniPolje(3, 2);
            Mreza.UkloniPolje(2, 1);
            KružniPucač puc = new KružniPucač(Mreza, new Polje(2, 2), 3);
            Polje gađano = puc.Gađaj();
            Assert.AreEqual(new Polje(2, 3), gađano);
        }

        [TestMethod]
        public void KružniPucač_GađajDajePoljaDesnoIIspodZaPogođenoPoljeUGornjemLijevomKutu()
        {
            Mreza Mreza = new Mreza(5, 5);
            KružniPucač puc = new KružniPucač(Mreza, new Polje(0, 0), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(0, 1), new Polje(1, 0) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }

        [TestMethod]
        public void KružniPucač_GađajDajePoljaLijevoIIznadZaPogođenoPoljeUDonjemDesnomKutu()
        {
            Mreza Mreza = new Mreza(5, 5);
            KružniPucač puc = new KružniPucač(Mreza, new Polje(4, 4), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(3, 4), new Polje(4, 3) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }
    }
}