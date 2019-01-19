namespace OOP
{
    class Uhu : Tier
    {
        public Uhu(double gewicht) : base(gewicht)
        {
        }

        protected override bool canEat(ref Tier tier)
        {
            if (tier is Eichhoernchen || tier is Baummarder)
            {
                return tier.IsAlive;
            }
            return false;
        }

        public void Fliegen()
        {
            if (AktuellesGewicht-10 > InitialGewicht)
            {
                AktuellesGewicht -= 10;
            }
        }
    }
}
