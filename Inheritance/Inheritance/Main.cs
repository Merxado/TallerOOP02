using _ShapesBackend;

var circle = new Circle(5);
var square = new Square(10);
var rhombus = new Rhombus(5, 7, 10);
var kite = new Kite(7, 8, 6, 5);
var rectangle = new Rectangle(4.568, 67.790);
var paralellogram = new Parallelogram(14.65, 54.67, 23.09);
var triangle = new Triangle(45.56, 12.34, 27.09, 15);
var trapeze = new Trapeze(10, 20, 30, 40, 20);

var shapes = new List<Shapes>
{
    circle, square, rhombus, kite, rectangle, paralellogram, triangle, trapeze
};

foreach (var shape in shapes)
{
    Console.WriteLine(shape);
}