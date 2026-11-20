using ConsoleApp2;

namespace KosciTest
{
    [TestClass]
    public sealed class Test1
    {
        Kosc kosc = new();

        [TestMethod]
        public void zakres_rzutu()
        {
            kosc.rzut_koscia();
            Assert.IsInRange(1, 6, kosc.wyrzucone_oczka);
        }
        [TestMethod]
        public void czy_dostepna()
        {
            kosc.rzut_koscia();

            int stara_wartosc = kosc.wyrzucone_oczka;
            kosc.czy_dostepna = false;
            kosc.rzut_koscia();

            Assert.AreEqual(stara_wartosc, kosc.wyrzucone_oczka);
        }
    }
}
