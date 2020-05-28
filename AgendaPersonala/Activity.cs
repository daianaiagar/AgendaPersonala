using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    public class Activity
    {
        public string Name;
        public string Description;
        public DateTime Start;
        public DateTime End;
        private List<Person> involvedPeople;

        internal List<Person> InvolvedPeople { get => involvedPeople; set => involvedPeople = value; }

        public string Details()
        {
            return $"{Name},{Description}," + $"{Start.ToString()},{End.ToString()}";
        }
    }
    
}
