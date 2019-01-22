namespace OOP
{
    class Eichhoernchen : Tier
    {
        public Eichhoernchen(double gewicht) : base(gewicht)
        {
        }

        protected override bool CanEat(ref Tier tier)
        {
            return false;
        }
    }
}
