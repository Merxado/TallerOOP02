using System.Net.Http.Headers;

namespace _ShapesBackend {

    public abstract class Shapes
    {
        public string Name { get; }

        protected Shapes(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimiter();

        public override string ToString()
        {
            return $"{Name,-15} => Area.....: {GetArea(),10:F5}    Perimiter: {GetPerimiter(),10:F5}";
        }
    }

    public class Circle : Shapes
    {
        private double _r;

        public double R
        {
            get => _r;
            set
            {
                ValidateR(value);
                _r = value;
            }
        }
        public Circle(double r) : base("Cricle")
        {
            R = r;
        }

        private void ValidateR(double r)
        {
            if (r <= 0)
                throw new Exception("Invalid radius");
        }
        public override double GetArea()
        {
            return Math.PI * _r * _r;
        }

        public override double GetPerimiter()
        {
            return 2 * Math.PI * _r;
        }
    }

    public class Square : Shapes
    {
        private double _a;

        public double A
        {
            get => _a;
            set
            {
                ValidateA(value);
                _a = value;
            }
        }

        public Square(double a) : base("Square")
        {
            A = a;
        }

        protected void ValidateA(double a)
        {
            if (a <= 0)
                throw new Exception("Invalid side");
        }

        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimiter()
        {
            return 4 * _a;
        }
    }

    public class Rhombus : Shapes
    {
        private double _d1;
        private double _d2;
        private double _a;

        public Rhombus(double d1, double d2, double a) : base(Rhombus)
        {
            _d1 = d1;
            _d1 = d2;
            _a = a;
        }

        public override double Area()
        {
            return (_d1 * _d2) / 2;
        }

        public override double Perimiter()
        {
            return 4 * _a;
        }
    }

    public class Kite : Shapes
    {
        private double _d1;
        private double _d2;
        private double _a;
        private double _b;

        public Kite(double d1, double d2, double a, double b) : base("Kite")
        {
            _d1 = d1;
            _d2 = d2;
            _a = a;
            _b = b;
        }

        public override double Area()
        {
            return (_d1 * _d2) / 2;
        }

        public override double Perimiter()
        {
            return 2 * (_a + _b);
        }
    }

    public class Rectangle : Square
    {
        protected double _b;

        public double B
        {
            get => _b;
            set
            {
                ValidateB(value);
                _b = value;
            }
        }

        public Rectangle(double a, double b) : base(a)
        {
            B = b;
        }

        protected void ValidateB(double b)
        {
            if (b <= 0)
                throw new Exception("Invalid side B");
        }
        public override double GetArea()
        {
            return _a * _b;
        }

        public override double GetPerimiter()
        {
            return 2 * (_a + _b);
        }
    }

    public class Triangle : Rectangle
    {
        protected double _c;
        protected double _h;

        public double C
        {
            get => _c;
            set
            {
                Validatec(value);
                _c = value;
            }
        }

        public double H
        {
            get => _h;
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        public Triangle(double a, double b, double c, double h) : base(a, b)
        {
            C = c;
            H = h;
        }

        protected void ValidateC(double c)
        {
            if (c <= 0)
                throw new Exception("Invalid side C");
        }

        protected void ValidateH(double h)
        {
            if (h <= 0)
                throw new Exception("Invalid height");
        }

        public override double GetArea()
        {
            return (_b * _h) / 2;
        }

        public override double GetPerimiter()
        {
            return _a + _b + _c;
        }
    }

    publis class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        public Paralellogram(double a, double b, double h) : base(a, b)
        {
            H = h;
        }

        private void ValidateH(double h)
        {
            if (h <= 0)
                throw new Exception("Invalid height");
        }
        public override double GetArea()
        {
            return _b * _h;
        }
    }

    public class Trapeze : Triangle
    {
        

        public Trapeze(double a, double b, double c, double d, double h) : base("Trapeze")
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _h = h;
        }

        public override double Area()
        {
            return ((_b + _d) * _h) / 2;
        }

        public override double Perimiter()
        {
            return _a + _b + _c + _d;
        }
    }
}