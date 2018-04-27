using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        //so we can use it throughout
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            while (true)
            {
                //ask user for dice sides
                Console.WriteLine("How many sides? ");

                string sides = Console.ReadLine();
                int numberSides = int.Parse(sides);

                //prompt user for dice roll
                Console.WriteLine("Do you want to roll the dice or exit?");
                string response = Console.ReadLine();
                if (response == "exit")
                {
                    return;

                }


                int rolledNum = RollDice(numberSides);
                int rolledNumTwo = RollDice(numberSides);

                //display what they have rolled
                Console.WriteLine($"1st number {rolledNum} 2nd number {rolledNumTwo}");

                //ask if user s to continue
                Console.WriteLine("play again?");
                response = Console.ReadLine();

                while (true)
                {
                
                    //Prompt user to enter the a valid input
                    if (response.ToLower() == "y")
                    {
                        break;
                    }
                    else if (response == "n")
                    {
                        return;
                    }
                    else
                    {
                        //if they don't say yes or no
                        Console.WriteLine("This is an invalid input. Please enter y or exit");

                        //is whatever the user inputs
                        response = Console.ReadLine();
                        if (response == "exit")
                        {
                            return;

                        }
                    }
                }
                
                
               

            }

        }

        static int RollDice(int numberSides)
        {

            int num = rnd.Next(1, numberSides);

            //have to return an int
            return num;


        }

    }
}
