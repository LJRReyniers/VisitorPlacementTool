using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementTool
{
    public class Parcour
    {
        public List<Box> boxes;
        public int numberOfBoxes;
        
        public Parcour() 
        {
            boxes= new List<Box>();
            numberOfBoxes = boxes.Count;
        }

        public void SetNumberOfBoxes(int number) 
        { 
            numberOfBoxes = number; 
        }

        public void GetNumberOfChairs()
        {
            //TODO: loop through list boxes to get total number of chairs, with chairs.length
        }
    }
}
