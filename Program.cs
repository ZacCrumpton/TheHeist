using System;
using System.Collections.Generic;

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

            var teamMembers = new List<TeamMember>()
            {
                new TeamMember("Zac", 10, 1.5),
                new TeamMember("Addam", 15, 2.0),
                new TeamMember("Dyllan", 13, 1.0)
            };

            //prompt the user to enter a team member's name and save that name.

            while (true)
            {
                Console.WriteLine("New to the team?\n\nWhat's your name?");
                var newTeamMemberName = Console.ReadLine();

                Console.WriteLine("What is your skill level? (Skill Levels can be -NO higher- than 20)");
                var newSkillLevel = Convert.ToInt32(Console.ReadLine());
                if (newSkillLevel <= 20)
                {
                    return;
                }
                else
                {
                    while(newSkillLevel > 20)
                    {
                        Console.WriteLine("Skill Level can be no higher than 20");
                        newSkillLevel = Convert.ToInt32(Console.ReadLine());
                    }
                    
                }

                Console.WriteLine("\nWhat is your Courage Factor?\n Must be between 1.0 and 2.0");
                var newCourageFactor = Convert.ToDouble(Console.ReadLine());
                 if (newCourageFactor <= 2.0 & newCourageFactor <= 1.0)
                {
                    return;
                } else
                {
                    while(newCourageFactor > 2.0 & newCourageFactor < 1.0)
                    {
                    Console.WriteLine("Can you read?\nI said between 1.0 and 2.0!");
                    newCourageFactor = Convert.ToDouble(Console.ReadLine());
                    }
                    
                }

                var newTeamMember = new TeamMember(newTeamMemberName, newSkillLevel, newCourageFactor);
                teamMembers.Add(newTeamMember);

                Console.WriteLine($"\nWelcome to the team:\n{newTeamMember.Name}\n\nYour Skills are impressive, for a newbie.\nSkillLevel: {newTeamMember.SkillLevel}\n\nAnalying your Courage Factor: {newTeamMember.CourageFactor}");


            }

        }
    }
}
