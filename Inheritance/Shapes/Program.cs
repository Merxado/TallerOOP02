using System.Drawing;

public abstract class Shapes
{
    public string Name { get; set; }

    protected Shapes(string name)
    {
        Name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();
}

public class Circle : Shapes
{
    private double _r;

    public Circle(double _r) : base("Circle")
    {
        _r = ref;
    }

    public override double Area()
    {
        return Math.PI * _r * _r;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * _r;
    }
}

public class Square : Shapes
{
    private double _a;

    public Square(double a) : base("Square")
    {
        _a* _a;
    }

    public override double Area()
    {
        return _a * _a;
    }
     
    public override double Perimeter()
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

    public override double Perimeter()
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

    public override double Perimeter()
    {
        return 2 * (_a + _b);
    }
}

public class Rectangle : Shapes
{
    private double _a;
    private double _b;

    public Rectangle(double a, double b) : base("Rectangle")
    {
        _a = a;
        _b = b;
    }

    public override double Area()
    {
        return _a * _b;
    }

    public override double Perimeter()
    {
        return 2 * (_a + _b);
    }
}

public class Triangle : Shapes
{
    private double _a;
    private double _b;
    private double _c;
    private double _h;

    public Triangle(double a, double b, double c, double h) : base("Triangle")
    {
        _a = a;
        _b = b;
        _c = c;
        _h = h;
    }

    public override double Area()
    {
        return (_b * _h) / 2;
    }

    public override double Perimeter()
    {
        return _a + _b + _c;
    }
}

publis class Parallelogram : Shapes
{
    private double _a;
    private double _b;
    private double _h;

    public Paralellogram(double a, double b, double h) : base("Paralellogram")
    {
        _a = a;
        _b = b;
        _h = h;
    }

    public override double Area()
    {
        return _b * _h;
    }

    public override double Perimeter()
    {
        return 2 * (_a + _b);
    }
}

public class Trapeze : Shapes
{
    private double _a;
    private double _b;
    private double _c;
    private double _d;
    private double _h;

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

    public override double Perimeter()
    {
        return _a + _b + _c + _d;
    }
}