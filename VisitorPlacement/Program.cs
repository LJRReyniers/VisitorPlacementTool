// See https://aka.ms/new-console-template for more information
using VisitorPlacement;

var box = new Box("A", 3, 10);
List<Visitor> visitors = new List<Visitor>
            {
                new Visitor(1),
                new Visitor(2),
                new Visitor(3),
            };

box.PlaceVisitor(visitors);

Console.WriteLine(box.GetRowInfo(0));
Console.ReadLine();
