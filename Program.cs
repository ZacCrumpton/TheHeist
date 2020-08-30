using System;
using System.Collections.Generic;
using System.Dynamic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            //create a way to store a single team member.
            //a team member will have a NAME, SKILL LEVEL, and COURAGE FACTOR
            //the SKILL LEVEL will be a positive int
            //COURAGE FACTOR will be a decimal between 0.0 and 2.0

            var heistRoster = new HeistRoster();

            heistRoster.AddTeamMember();

            Console.WriteLine("Display Team Information? (Enter y or n)");
            var displayInfo = Console.ReadLine();

            if (displayInfo == "y")
            {
                heistRoster.DisplayTeamInfo();
            } else
            {
                Console.WriteLine("Let's start the heist.");
            }

            string key = Console.ReadKey().Key.ToString();
            if(key == "")
            {
              
            }


            //PHASE ONE - FINISHED

                //PHASE TWO - FINSIHED

                    //PHASE THREE

                    //1. Stop displauing each team member's information
                    //2. Store a value for the bank's difficulty level. Set this value to 100
                    //3. Sum the skill levels of the team. Save that number.
                    //4. Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message otherwise display failuer message.

            





                //PHASE FOUR
                //1. Create a random number between -10 and 10 for the heist's luck value.
                //2. Add this number o the bank's difficulty level.
                //3. Before displaying the success or failure message display a report that shows.
                //        -Team's Combined Skill Level
                //        -The Bank's Difficulty Level

                //Phase Five
                //1. Run the scenario multiple times
                //2. After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
                //3. Loop through the difficulty/skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.

                //Phase Six
                //1. At the behinning of the program, prompt the user to enter the diffculty level of the bank.
                //2. At the end of the prgram, display a report showing the bumber of successful runs and the number of failed runs.
         

        }
    }
}
