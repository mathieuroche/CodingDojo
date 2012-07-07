using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monnayeur;

namespace TestVinciVoleur
{
    [TestClass]
    public class TestMonnayeur
    {

        [TestMethod]
        public void Test1hSimple()
        {
            DateTime maintenant = new DateTime(2012, 12, 01, 14, 00, 00);
            DateTime maintenantPlusHeure = maintenant.AddHours(1);
            Monnayeur.Monnayeur m = new Monnayeur.Monnayeur();
            m.add(2); // j'ajoute 3 euros
            m.add(1);
            Assert.AreEqual<DateTime>(maintenantPlusHeure, m.date(maintenant));
        }

        [TestMethod]
        public void TestTypesPiecesFaux()
        {
            Monnayeur.Monnayeur m = new Monnayeur.Monnayeur();
            Assert.IsFalse(m.IsAcceptPiece(0.4));
        }

        [TestMethod]
        public void TestTypesPiecesVrai()
        {
            List<double> Bonnepiece = new List<double>() { 0.1, 0.2, 0.5, 1, 2 };
            Monnayeur.Monnayeur m = new Monnayeur.Monnayeur();
            foreach (double piece in Bonnepiece)
            {
                Assert.IsTrue(m.IsAcceptPiece(piece));
            }

        }
        [TestMethod]
        public void TestTroisheures()
        {
            DateTime maintenant = new DateTime(2012, 12, 01, 14, 00, 00);
            DateTime maintenantPlusHeure = maintenant.AddHours(3);
            Monnayeur.Monnayeur m = new Monnayeur.Monnayeur();
            // j'ajoute 10 euros
            m.add(2);
            m.add(2);
            m.add(2);
            m.add(2);
            m.add(2);
            Assert.AreEqual<DateTime>(maintenantPlusHeure, m.date(maintenant));

        }

        [TestMethod]
        public void TestMinutedemijournee()
        {
            Assert.AreEqual<int>(300, Monnayeur.Monnayeur.minute(11));
        }

        [TestMethod]
        public void TestMinute3h()
        {
            Assert.AreEqual<int>(180, Monnayeur.Monnayeur.minute(10));
        }

        [TestMethod]
        public void TestMontantTotal()
        {
            Monnayeur.Monnayeur mon = new Monnayeur.Monnayeur();
            mon.add(2);
            Assert.AreEqual<double>(2, mon.montantTotal);
        }
    }
}
