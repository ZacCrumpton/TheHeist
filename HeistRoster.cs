using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TheHeist
{
    class HeistRoster
    {
        public List<TeamMember> TeamMembers = new List<TeamMember>();

        public void AddTeamMember()
        {
            while (true)
            {
                Console.WriteLine("Enter a team member's name:");
                var newTeamMemberName = Console.ReadLine();

                Console.WriteLine("\nWhat is your skill level? (Max Skill Level Is 100):");
                var newSkillLevel = Convert.ToInt32(Console.ReadLine());
                if (newSkillLevel <= 100)
                {

                }
                else
                {
                    while (newSkillLevel > 100)
                    {
                        Console.WriteLine("\nSkill Level can be no higher than 100");
                        newSkillLevel = Convert.ToInt32(Console.ReadLine());
                    }

                }

                Console.WriteLine("\nWhat is your Courage Factor? (Must Be Between 0.0 and 2.0):");
                var newCourageFactor = Convert.ToDouble(Console.ReadLine());


                var newTeamMember = new TeamMember(newTeamMemberName, newSkillLevel, newCourageFactor);
                TeamMembers.Add(newTeamMember);

                Console.WriteLine($"\nWelcome to the team: {newTeamMember.Name}");

                Console.WriteLine("\nWould you like to add another heist member? (Enter y or n)");

                var conInput = Console.ReadLine();

                if (conInput == "n")
                {
                    Console.WriteLine($"\nYour team is ready for the Heist\n");
                    break;
                }

            }

        }

        public void DisplayTeamInfo()
        {
            Console.WriteLine($"    >--| Total Members: {TeamMembers.Count} |--<");
            foreach (var member in TeamMembers)
            {
                Console.WriteLine($"        {TeamMembers.IndexOf(member) + 1}. {member.Name} | {member.SkillLevel} | {member.CourageFactor}");
            }
        }
    }
}