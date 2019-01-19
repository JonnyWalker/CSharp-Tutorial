namespace OOP
{
    class Complex
    {
        public double Real{ get; private set; }
        public double Img { get; private set; }

        public Complex(double real, double img)
        {
            Real = real;
            Img = img;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Img + b.Img);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Img - b.Img);
        }


        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Real * b.Real - a.Img * b.Img, a.Real * b.Img - a.Img* b.Real);
        }

        public override string ToString()
        {
            return "(" + Real + "," + Img + ")";
        }
    }
}
