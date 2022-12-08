using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementTool
{
    public class Program
    {
        static void Main(string[] args)
        {
            var box = new Box("A", 3, 10);
            List<Visitor> visitors = new List<Visitor>
            {
                new Visitor(1)
            };

            box.PlaceVisitor(visitors);

            Console.WriteLine(box.GetRowInfo(0));
            Console.ReadLine();
        }
    }
}
