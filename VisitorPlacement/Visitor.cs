using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacement
{
    public class Visitor
    {
        public string name;
        public int visitorNumber { get; private set; }  

        public DateOnly dateOfBirth;
        public int age;
        public bool adult;

        public DateTime registerTime;
        public bool registered;

        public Visitor(int number) 
        {
            visitorNumber = number;
        }

        public void RegisterVisitor(string fullName, DateOnly birthDate)
        {
            name = fullName;
            dateOfBirth = birthDate;
            registerTime = DateTime.Now;
            registered = true;
        }

        public void GetAge(DateTime eventDate)
        {
            age = eventDate.Year - dateOfBirth.Year;
        }       
    }
}
