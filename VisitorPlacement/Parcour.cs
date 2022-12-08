using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacement
{
    public class Parcour
    {
        public List<Box> boxes;
        private int numberOfBoxes;
        private int numberOfChairs;

        private string[] abc = {"A","B","C","D","E","F","G","H","I","J","K","L","M","n","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        private Random randomRow = new Random();
        private Random randomChairsPerRow = new Random();
        
        public Parcour() 
        {
            boxes = new List<Box>();
            numberOfBoxes = boxes.Count;
        }

        /*public void SetRandomNumberOfBoxes(int number)
        { 
            numberOfBoxes = number;
            for (int i = 0; i < number; i++)
            {
                boxes.Add(new Box(abc[i], randomRow.Next(0,4), randomChairsPerRow.Next(0,11)));
            }
        }*/

        public void SetBoxes(int number, int numberOfRows, int numberOfChairsPerRow)
        {
            for (int i = 0; i < number; i++)
            {
                boxes.Add(new Box(abc[i], numberOfRows, numberOfChairsPerRow));
            }
        }

        public void GetNumberOfChairs()
        {
            //TODO: loop through list boxes to get total number of chairs, with chairs.length
            foreach (Box box in boxes)
            {
                numberOfChairs += box.chairs.Length;
            }
        }
    }
}
