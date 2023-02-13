using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{// Create a class Animal -- DONE
 // give this class 4 members that all Animals have in common -- DONE
    public class Animal
    {
        public int Legs { get; set; }
        public string Name { get; set; }
        public void Sleeps()
        {
            Console.WriteLine("zzzzzz");
        }
        public void Eats()
        {
            Console.WriteLine("NomNom");
        }
    }
}
