using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
namespace test
{
    [TestClass]
    public class TestLinijskiPucač
    {
        [TestMethod]
        public void LinijskiPucač_GađajVraćaJednoOdDvaPoljaLijevoIliDesnoOdHorizontalnogNiza()
        {
            Mreza mreža = new Mreza(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(2, 4) };
            LinijskiPucač puc = new LinijskiPucač(mreža, polja, 3);
            Polje p = puc.Gađaj();
            Polje[] kandidati = { new Polje(2, 2), new Polje(2, 5) };
            CollectionAssert.Contains(kandidati, p);

        }
        public void LinijskiPucač_GađajVraćaJednoOdDvaPoljaGoreIliDoljeOdVertikalnogNiza()
        {
            Mreza mreža = new Mreza(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(3, 3) };
            LinijskiPucač puc = new LinijskiPucač(mreža, polja, 3);
            Polje p = puc.Gađaj();
            Polje[] kandidati = { new Polje(1, 3), new Polje(4, 3) };
            CollectionAssert.Contains(kandidati, p);
        }
        public void LinijskiPucač_GađajVraćaSamoSlobodnoPoljeLijevoOdHorizontalnogNiza()
        {
            Mreza mreža = new Mreza(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(2, 4) };
            mreža.UkloniPolje(2, 5);
            LinijskiPucač puc = new LinijskiPucač(mreža, polja, 3);
            Assert.AreEqual( new Polje(2,2),puc.Gađaj());
         
        }
        public void LinijskiPucač_GađajVraćaSamoSlobodnoPoljeDesnoOdHorizontalnogNiza()
        {
            Mreza mreža = new Mreza(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(2, 4) };
            mreža.UkloniPolje(2, 2);
            LinijskiPucač puc = new LinijskiPucač(mreža, polja, 3);
            Assert.AreEqual(new Polje(2, 5), puc.Gađaj());
        }
        public void LinijskiPucač_GađajVraćaSamoSlobodnoPoljeGoreOdVertikalnogNiza()
        {
            Mreza mreža = new Mreza(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(3, 3) };
            mreža.UkloniPolje(4, 3);
            LinijskiPucač puc = new LinijskiPucač(mreža, polja, 3);
            Polje p = puc.Gađaj();
            Assert.AreEqual(new Polje(1, 3), puc.Gađaj());
           
        }
        public void LinijskiPucač_GađajVraćaSamoSlobodnoPoljeDoljeOdVertikalnogNiza()
        {
            Mreza mreža = new Mreza(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(3, 3) };
            mreža.UkloniPolje(1, 3);
            LinijskiPucač puc = new LinijskiPucač(mreža, polja, 3);
            Polje p = puc.Gađaj();
            Assert.AreEqual(new Polje(4, 3), puc.Gađaj());
        }
    }
}
