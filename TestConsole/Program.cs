
using System.Collections;
using System.Net.Http.Headers;
using TestConsole.Classes;
using TestConsole.Shape;
using System.Collections;
using System.Collections.Generic;

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

// Shape s = new Square(4);
// Shape t = new Triangle(4);

// Shape r = new Rectangle(5,2);


// List<Shape> ls =  new List <Shape>();

// ls.Add(s);
// ls.Add(r);
// ls.Add(t);

// Console.WriteLine(s.Area());

// Console.WriteLine(r.Area());



// Person p = new Person("Obed", "Sampong");
// Person p2 = p with { FirstName = "Example 2"};

// Person p3 = p with { LastName = "Person 2"};

// Console.WriteLine(p);
// Console.WriteLine(p2);
// Console.WriteLine(p3);

// Console.WriteLine($"{p} == {p2} = {p == p2}");
// Console.WriteLine(ReferenceEquals(p, p2));

// public record Person(string FirstName, string LastName);

//IEnumerable<int> e = new System.Collections.Concurrent.ConcurrentQueue<int>(); //new List<int>(); // new int[5]

// foreach(IGeometry x in ig)
// {

// }
// interface IGeometry
// {
//     double Area();
//     double Perimeter();
// }

// public class Square :IGeometry,IPostionable2D
// {
//     public double Size { get; set; } 

//     public double Area()
//     {
//         return Size * Size;
//     }

//     public double Perimeter()
//     {
//         return Size * 4;
//     }
//    public class Circle :IGeometry
//    {
//          public double Radius { get; set; }

//          public int
//    }
   
// }


// int x = 5;

// ArrayList l = new ArrayList();

// l.Add(x);

// int y = int.Parse(l[0]?.ToString() ?? "");

// int x = 5;

// List<int> 12 = new List<int>();

// 12.Add(x);

// var y =12[0];

// TestGenerics<int> i = new(4);
// Console.WriteLine(i.X);
// Console.WriteLine(i.GetString());

// TestGenerics<String> s = new("Hello");
// Console.WriteLine(s.X);
// Console.WriteLine(s.GetString());

Singleton<int> i = new();

Singleton<int> y = new();

var x = i.GetInstance();
var z = i.GetInstance();
