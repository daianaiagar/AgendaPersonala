using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Daiana = Create.CreatPerson("Iagăr","Daiana", new DateTime(2000, 8, 30), "daianaiagar@gmail.com");        
            Activity working = Daiana.CreateActivity("daily job", "work at home", DateTime.Now, DateTime.Now.AddHours(4));
            Activity cooking = Daiana.CreateActivity("prepare lunch", "prepare dinner", DateTime.Now, DateTime.Now.AddHours(2));
           
            Console.WriteLine();

            Person Teodora = Create.CreatPerson("Leucea", "Teodora", new DateTime(2000, 5, 18), "teodora.leucea@yahoo.com");
            Activity gym = Create.CreateActivity("jogging", "train", DateTime.Now, DateTime.Now.AddHours(2));
            Teodora.AddActivity(gym);
           
            Console.WriteLine();

            List<Activity> allactivities = Daiana.FindActivitiesByName("working");
            Teodora.FindActivitiesByInterval(new DateTime(2020, 5, 28), new DateTime(2020, 5, 28));
            Console.WriteLine();

            Create.DeleteActivity(working);
            Console.WriteLine();
            Create.FindActivityWithGroup(2, Daiana, Teodora);

            Console.ReadLine();
        }
    }
}

