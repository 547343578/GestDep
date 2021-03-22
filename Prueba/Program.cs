using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GestDep.Entities;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Instructor i = new Instructor("Calle Real", "ES67 7890", "Z8", "Pedro Martinez", 13456, "Ssn");
            i.Activities.Add(new Activity(Days.Mon | Days.Wed | Days.Fri, "Zumba", new TimeSpan(3), Convert.ToDateTime("09:30:00"), 4,5, 3.14, Convert.ToDateTime("09:30:00"), Convert.ToDateTime("09:30:00")));
            Console.WriteLine(i.ZipCode);

            Gym c = new Gym(Convert.ToDateTime("09:30:00"), 20, 50, 29.99, "Acero", Convert.ToDateTime("22:30:00"), 444444);
            Console.WriteLine(c.Name);
            Console.WriteLine(c.ClosingHour);

            Person p = new Person("Calle inventada 3", "12345678910", "11111111X", "Paco", 15671);
            Console.WriteLine(p.Name);
            User u = new User("Calle inventada 4", "1234567891011", "11111112X", "Pepe", 15671, Convert.ToDateTime("5/1/2008 8:30:52 AM") , false);
            Console.WriteLine(u.BirthDate);

            Console.WriteLine(c.ClosingHour);
            Console.ReadLine();

        }
    }
}
