using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacement
{
    public class Event
    {
        public int maxNumberOfVisitors;
        public DateTime date;

        public Parcour parcour = new Parcour();

        public Event()
        {

        }

        public void SetParcour(int number)
        {
            /*parcour.SetRandomNumberOfBoxes(number);*/
        }

        public void StartEvent(DateTime begin, DateTime end)
        {

        }
    }
}
