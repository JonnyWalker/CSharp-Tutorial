namespace OOP
{
    class Eichhoernchen : Tier
    {
        public Eichhoernchen(double gewicht) : base(gewicht)
        {
        }

        protected override bool canEat(ref Tier tier)
        {
            return false;
        }
    }
}
