namespace OOP
{
    class Kaffeemaschine
    {
        private static double maxWasser;
        private static double maxBohnen;
        private double bohnen;
        private double wasser;
        private double gesamtMengeKaffeProduziert;
        public double Wasser { get; private set; }
        public double Bohnen { get; private set; }
        public double GesamtMengeKaffeProduziert { get; private set; }

        public Kaffeemaschine()
        {
            bohnen = 0;
            wasser = 0;
            gesamtMengeKaffeProduziert = 0;
        }

        public double WasserAuffuellen(double menge)
        {
            if (wasser+menge<=maxWasser)
            {
                wasser += menge;
                return menge;
            } 
            else
            {
                wasser = maxWasser;
                return maxWasser - wasser;
            }
        }

        public double BohnenAuffuellen(double menge)
        {
            if (bohnen + menge <= maxBohnen)
            {
                bohnen += menge;
                return menge;
            }
            else
            {
                bohnen = maxBohnen;
                return maxBohnen - bohnen;
            }
        }

        public bool MacheKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            double mengeBohnen = 0;
            double mengeWasser = 0;
            if(verhaeltnisWasserBohnen==1)
            {
                mengeBohnen = menge * 0.5;
                mengeWasser = menge * 0.5;
            }
            else if (verhaeltnisWasserBohnen==0.5)
            {
                mengeBohnen = menge * 2/3;
                mengeWasser = menge * 1/3;
            }
            else if (verhaeltnisWasserBohnen == 2)
            {
                mengeBohnen = menge * 1 / 3;
                mengeWasser = menge * 2 / 3;
            }
            if (bohnen<mengeBohnen || wasser<mengeWasser)
            {
                return false;
            }
            else
            {
                bohnen -= mengeBohnen;
                wasser -= mengeWasser;
                return true;
            }
        }
    }
}
