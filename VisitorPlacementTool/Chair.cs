using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementTool
{
    public class Chair
    {
        private bool isOccupied;
        public Visitor assignedVisitor { get; private set; }    

        public Chair() 
        {
            isOccupied = false;
        }

        public void AssignVisitor(Visitor visitor)
        {
            assignedVisitor = visitor;
            isOccupied = true;
        }
    }
}
