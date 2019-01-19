namespace OOP
{
    abstract class Tier
    {
        public double AktuellesGewicht { get; protected set; }
        public double InitialGewicht { get; private set; }
        public bool IsAlive { get; private set; }

        public Tier(double gewicht)
        {
            AktuellesGewicht = gewicht;
            InitialGewicht = gewicht;
            IsAlive = true;
        }

        protected abstract bool canEat(ref Tier tier);

        public void Eat(ref Tier tier)
        {
            if (canEat(ref tier))
            {
                tier.WirdGetoetet();
                this.AktuellesGewicht += tier.AktuellesGewicht;
                //Verdauen();
            }
        }

        public void Verdauen()
        {
            if(AktuellesGewicht> InitialGewicht)
            {
                double zusaetzlichesGewicht = AktuellesGewicht - InitialGewicht;
                AktuellesGewicht = zusaetzlichesGewicht * 0.05;
            }
        }

        public void WirdGetoetet()
        {
            IsAlive = false;
        }
    }
}
