using System;

namespace OOP
{
    class Kaffeemaschine
    {
        private static double maxWasser;
        private static double maxBohnen;
        private double gesamtMengeKaffeProduziert;
        public double Wasser { get; private set; }
        public double Bohnen { get; private set; }
        public double GesamtMengeKaffeProduziert { get; private set; }
        public event EventHandler KaffeIstZubereitet;

        public Kaffeemaschine()
        {
            Bohnen = 0;
            Wasser = 0;
            gesamtMengeKaffeProduziert = 0;
            maxBohnen = 100;
            maxWasser = 100;
        }

        public double WasserAuffuellen(double menge)
        {
            if (Wasser+menge<=maxWasser)
            {
                Wasser += menge;
                return menge;
            } 
            else
            {
                Wasser = maxWasser;
                return maxWasser - Wasser;
            }
        }

        public double BohnenAuffuellen(double menge)
        {
            if (Bohnen + menge <= maxBohnen)
            {
                Bohnen += menge;
                return menge;
            }
            else
            {
                Bohnen = maxBohnen;
                return maxBohnen - Bohnen;
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
            if (Bohnen<mengeBohnen || Wasser<mengeWasser)
            {
                return false;
            }
            else
            {
                Bohnen -= mengeBohnen;
                Wasser -= mengeWasser;
                gesamtMengeKaffeProduziert += menge;
                KaffeIstZubereitet(this, null);
                return true;
            }
        }

        public override bool Equals(object other)
        {
            if(other is Kaffeemaschine)
            {
                Kaffeemaschine m = other as Kaffeemaschine;
                return m.Bohnen == this.Bohnen && m.Wasser == this.Wasser;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return int.Parse(Wasser.ToString()+Bohnen.ToString()); // FIXME: performance
        }

        public static bool operator ==(Kaffeemaschine k0, Kaffeemaschine k1)
        {
            if (!(k0 is null))
            {
                return k0.Equals(k1);
            }
            if (!(k1 is null))
            {
                return k1.Equals(k0);
            }
            return false;
        }

        public static bool operator !=(Kaffeemaschine k0, Kaffeemaschine k1)
        {
            return !(k0==k1);
        }
    }
}
