using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacement
{
    public class Group
    {
        public int groupNumber;
        public List<Visitor> visitors;

        public Group()
        {
            visitors = new List<Visitor>();
        }
    }
}
