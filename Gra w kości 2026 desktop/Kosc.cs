namespace Gra_w_kości_2026_desktop
{
    public class Kosc
    {
        public static int LiczbaKosci = 0;
        public string[] ZdjecieKosci = ["kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"];
        public int LiczbaOczek;
        public int ZdjecieId;
        public bool CzyDostepna;

        public Kosc(int wartoscWyrzucona)
        {
            if (wartoscWyrzucona < 1 || wartoscWyrzucona > 6)
                wartoscWyrzucona = 0;

            LiczbaOczek = wartoscWyrzucona;
            LiczbaKosci++;
            CzyDostepna = true;
            ZdjecieId = wartoscWyrzucona;
        }

        public Kosc()
        {
            Random random = new();
            int randomNum = random.Next(1, 7);

            LiczbaOczek = randomNum;
            ZdjecieId = randomNum;
            LiczbaKosci++;
            CzyDostepna = true;
        }

        public void RzucKostka()
        {
            if (!CzyDostepna)
                return;

            Random random = new();
            int randomNum = random.Next(1, 7);

            LiczbaOczek = randomNum;
            ZdjecieId = randomNum;
        }

        public void ZablokujKosc()
        {
            CzyDostepna = false;
        }

        public string LiczbaOczekToString()
        {
            switch (LiczbaOczek)
            {
                case 1:
                    return "jeden";
                case 2:
                    return "dwa";
                case 3:
                    return "trzy";
                case 4:
                    return "cztery";
                case 5:
                    return "pięc";
                case 6:
                    return "sześć";
                default:
                    return "";
            }
        }
    }
}
