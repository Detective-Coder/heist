using System;

namespace heist
{
    class Program
    {
        public class singleTeamMember
        {
          public string Name {get; set;}
          public int SkillLevel {get; set;}
          public double CourageFactor {get; set;}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            // Prompt the user to enter a team member's name and save that name.
            Console.WriteLine("Please enter the team member's name:");
            string Name = Console.ReadLine();

            // Prompt the user to enter a team member's skill level and save that skill level with the name.
            Console.WriteLine("Please enter the team member's skill level:");
            string SkillLevel = Console.ReadLine();

            // Prompt the user to enter a team member's courage factor and save that courage factor with the name.
            Console.WriteLine("Please enter the team member's courage factor:");
            string CourageFactor = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Team Member One:");
            Console.WriteLine($"{Name}, {SkillLevel}, {CourageFactor}");

        }
    }
}
