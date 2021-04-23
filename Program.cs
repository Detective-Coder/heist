using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
    
        static void Main(string[] args)
        {
            // // phase one
            // Console.WriteLine("Plan Your Heist!");          
      
            // Console.WriteLine("What is the team member's name?");
            // string CriminalName = Console.ReadLine();

            // Console.WriteLine("What is the team member's skill level?");
            // int SkillLevel = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("What is the team member's courage?");
            // string Courage = Console.ReadLine();

            // Console.WriteLine();
            // Console.WriteLine("Team Member One:");
            // Console.WriteLine($"Name: {CriminalName}, skill level: {SkillLevel}, Courage: {Courage}");

            // phase 2
            List<SingleTeamMember> criminalList = new List<SingleTeamMember>();

            while(true)
            {
              Console.WriteLine("What is the team member's name?");
              string CriminalName;
              CriminalName = Console.ReadLine();
              if(CriminalName == "")
              {
                break;
              }
              Console.WriteLine("What is the team member's skill level?");
              int SkillLevel;
              SkillLevel = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("What is the team member's courage?");
              double CourageFactor;
              CourageFactor = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine();
              Console.WriteLine($"Name: {CriminalName}, Skill Level: {SkillLevel}, Courage: {CourageFactor}");

              SingleTeamMember criminal = new SingleTeamMember();
              criminal.Name = CriminalName;
              criminal.SkillLevel = SkillLevel;
              criminal.CourageFactor = CourageFactor;
              
              criminalList.Add(criminal);
            }

        } 
    }
}
