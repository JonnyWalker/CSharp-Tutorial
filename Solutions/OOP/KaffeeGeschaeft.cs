using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class KaffeeGeschaeft
    {
        private double _preisProKg;

        public double PreisProKg
        {
            get
            {
                return _preisProKg;
            }

            set
            {
                if (value >= 5 && value <= 30)
                {
                    _preisProKg = value;
                }
            }
        }

        KaffeeGeschaeft(double preisProKg)
        {
            PreisProKg = preisProKg;
        }

        public double KaufeKaffee(Kaffeemaschine maschine, double menge)
        {
            double tatsaechlicheMenge = maschine.BohnenAuffuellen(menge);
            return PreisProKg * tatsaechlicheMenge;
        }
    }
}
