using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal -- DONE
            // give this class 4 members that all Animals have in common -- DONE


            // Create a class Bird -- DONE
            // give this class 4 members that are specific to Bird -- DONE
            // Set this class to inherit from your Animal Class -- DONE

            // Create a class Reptile -- DONE
            // give this class 4 members that are specific to Reptile -- DONE
            // Set this class to inherit from your Animal Class -- DONE




            /*Create an object of your Bird class -- DONE
             *  give values to your members using the object of your Bird class -- DONE
             *
             * Creatively display the class member values -- DONE
             */
            var cardinal = new Bird()
            {
                Legs = 2,
                Name = "Ozzy",
                BeakSize = "small",
                NumOfTailFeathers = 5
            };
            Console.WriteLine($"I am {cardinal.Name} the bird. I have {cardinal.Legs} legs, a {cardinal.BeakSize} beak and {cardinal.NumOfTailFeathers} tailfeathers.");
            cardinal.Eats();
            cardinal.FeedTheYoung();
            cardinal.LayingEggs();
            cardinal.Sleeps();

            /*Create an object of your Reptile class -- DONE
             *  give values to your members using the object of your Reptile class -- DONE
             *  
             * Creatively display the class member values -- DONE
             */
            var rattler = new Reptile()
            {
                Legs = 0,
                Name = "Bitey",
                TongueShape = "forked",
                EggsLayed = 5
            };
            Console.WriteLine($"I am {rattler.Name} the snake. I have {rattler.Legs} legs, a {rattler.TongueShape} tongue, and layed {rattler.EggsLayed} eggs.");
            rattler.Hiss();
            rattler.Eats();
            rattler.FlipTongue();
            rattler.Sleeps();
        }
    }
}
