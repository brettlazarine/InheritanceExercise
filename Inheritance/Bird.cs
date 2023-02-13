using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{// Create a class Bird -- DONE
 // give this class 4 members that are specific to Bird -- DONE
 // Set this class to inherit from your Animal Class -- DONE
    public class Bird : Animal
    {
        public string BeakSize { get; set; }
        public int NumOfTailFeathers { get; set; }
        public void LayingEggs()
        {
            Console.WriteLine("Laying eggs");
        }
        public void FeedTheYoung()
        {
            Console.WriteLine("**REGURGITATING NOISES**");
        }
    }
}
