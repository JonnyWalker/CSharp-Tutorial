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

        protected abstract bool CanEat(ref Tier tier);

        public void Eat(ref Tier tier)
        {
            if (CanEat(ref tier))
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

        public Tier ShowDown<T,V>(T t, V v) where T:Tier where V:Tier 
        {
            Tier tier0 = t as Tier;
            Tier tier1 = v as Tier;
            tier0.Eat(ref tier1);
            if (!tier1.IsAlive)
            {
                return tier0;
            }
            tier1.Eat(ref tier0);
            if (!tier0.IsAlive)
            {
                return tier1;
            }
            return null;
        }
    }
}
