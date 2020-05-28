using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    public class Agend
    {
        public List<Activity> Activities;
        private Person owner;

        internal Person Owner { get => owner; set => owner = value; }
    }
}
