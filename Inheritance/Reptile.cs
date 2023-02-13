using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{// Create a class Reptile -- DONE
 // give this class 4 members that are specific to Reptile -- DONE
 // Set this class to inherit from your Animal Class -- DONE
    public class Reptile : Animal
    {
        public string TongueShape { get; set; }
        public int EggsLayed { get; set; }
        public void Hiss()
        {
            Console.WriteLine("HISSSSS");
        }
        public void FlipTongue()
        {
            Console.WriteLine("Flsflsflsfls");
        }
    }
}
