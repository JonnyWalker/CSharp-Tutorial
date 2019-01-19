namespace OOP
{
    class Techniker
    {
        public void KaffeemaschinenAngleichen(Kaffeemaschine km0, Kaffeemaschine km1)
        {
            if(km0.Wasser < km1.Wasser)
            {
                km0.WasserAuffuellen(km1.Wasser);
            }
            if (km1.Wasser < km0.Wasser)
            {
                km1.WasserAuffuellen(km0.Wasser);
            }
            if (km0.Bohnen < km1.Bohnen)
            {
                km0.BohnenAuffuellen(km1.Bohnen);
            }
            if (km1.Bohnen < km0.Bohnen)
            {
                km1.BohnenAuffuellen(km0.Bohnen);
            }
        }

        public void FuellMich(ref Kaffeemaschine k, double menge)
        {
            if(k==null)
            {
                k = new Kaffeemaschine();
            }
            if(k.Wasser < menge)
            {
                k.BohnenAuffuellen(menge);
            }
        }
    }
}
