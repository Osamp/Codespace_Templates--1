using TestConsole.Classes;
using TestConsole.Shape;

// TestClass x = new TestClass() { square = 3};

// Console.WriteLine(x.square);

// TestClass  y = new TestClass() { square = 5};

// Console.WriteLine(y.square);

// y = x;

// Console.WriteLine(y.square);

// x.square++;

// Console.WriteLine(y.square);

// TestClass x = new TestClass();

// Console.WriteLine(x.square);

// TestClass? y = new TestClass(4);

// // y=null;

// Console.WriteLine(y);

Shape s = new Square(4);
Shape t = new Triangle(4);

Shape r = new Rectangle(5,2);


List<Shape> ls =  new List <Shape>();

ls.Add(s);
ls.Add(r);
ls.Add(t);

Console.WriteLine(s.Area());

Console.WriteLine(r.Area());
