namespace OOP
{
    class Arena<T,V> where T: Tier where V : Tier
    {
        public Tier ShowDown(T t, V v)
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
