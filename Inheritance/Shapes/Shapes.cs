using System.Globalization;

namespace _ShapesBackend;

    public abstract class Shapes
    {
        public string Name { get; }

        protected Shapes(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {

            var culture = CultureInfo.InvariantCulture;
            return String.Format(culture, "{0, -15} => Area.....: {1,12:N5}    Perimeter: {2,12:N5}",
                Name,
                GetArea(), 
                GetPerimeter());
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
                if (value <= 0)
                    throw new Exception("Invalid radius");

            _r = value;
            }
        }
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }
        public override double GetArea()
        {
            return Math.PI * _r * _r;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _r;
        }
    }

    public class Square : Shapes
    {
        protected double _a;

        public double A
        {
            get => _a;
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid side");

                _a = value;
            }
        }

    public Square(string name, double a) : base(name)
    {
        A = a;
    }
        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }
    }

    public class Rhombus : Square
    {
        protected double _d1;
        protected double _d2;

        public double D1
        {
            get => _d1;
            set => _d1 = value;
        }

        public double D2
        {
            get => _d2;
            set => _d2 = value;
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            _d1 = d1;
            _d2 = d2;
        }

        public override double GetArea()
        {
            return (_d1 * _d2) / 2;
        }
    }

    public class Kite : Rhombus
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = value;
        }

        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            B = b;
        }
        public override double GetPerimeter()
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

        public Rectangle(string name, double a, double b) : base(name, a)
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

        public override double GetPerimeter()
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
                ValidateC(value);
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

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
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

        public override double GetPerimeter()
        {
            return _a + _b + _c;
        }
    }

    public class Parallelogram : Rectangle
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

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
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
        private double _d;

        public double D
        {
            get => _d;
            set
            {
                ValidateD(value);
                _d = value;
            }
        }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }

        private void ValidateD(double d)
        {
            if (d <= 0)
                throw new Exception("Invalid side D");
        }

        public override double GetArea()
        {
            return ((_b + _d) * _h) / 2;
        }

        public override double GetPerimeter()
        {
            return _a + _b + _c + _d;
        }
    }