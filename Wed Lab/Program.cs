using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Lab3
{

    class Program

    {

        static void Main()



        {

            do

            {

                int Squared, Cubed, Number;



                Console.WriteLine("Learn Your Squares & Cubes!");

                Console.WriteLine(" Enter an Integer: ");



                Number = int.Parse(Console.ReadLine());

                Squared = Number * Number;

                Cubed = Number * Number * Number;



                Console.WriteLine(Squared + " Is your number squared.");

                Console.WriteLine(Cubed + " Is your number cubed.");

            }

            while (Continue() == true);



        }

        public static Boolean Continue()

        {

            bool run;

            Console.WriteLine("Continue: y/n?");

            string answer = Console.ReadLine();



            if ((answer == "Y") || (answer == "y"))

            {

                run = true;

            }

            else if ((answer == "N") || (answer == "n"))

            {

                run = false;

                Console.WriteLine("see ya soon");

            }

            else

            {

                Console.WriteLine("Blah Blah");

                run = Continue();

            }

            return run;

        }

    }

}


