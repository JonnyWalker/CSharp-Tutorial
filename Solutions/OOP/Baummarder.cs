namespace OOP
{
    class Baummarder : Tier
    {
        public Baummarder(double gewicht) : base(gewicht)
        {
        }

        protected override bool canEat(ref Tier tier)
        {
            if (tier is Eichhoernchen)
            {
                return tier.IsAlive;
            }
            return false;
        }
    }
}
