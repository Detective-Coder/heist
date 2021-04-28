// The global::System will always refer to the namespace "System" of .Net Framework.The using keyword can be used so that the complete name is not required
using System;
// Contains interfaces and classes that define generic collections, which allow users to create strongly typed collections
using System.Collections.Generic;
// Use the namespace keyword to declare a namespace
using System.Linq;

namespace heist
{
    class Program
    {
    
        static void Main(string[] args)
        {
            // Print the message "Plan Your Heist!".
            Console.WriteLine("########################################");
            Console.WriteLine("########### Plan Your Heist! ###########");
            Console.WriteLine("########################################");        
      
            // At the beginning of the program, propmt the user to enter the difficulty level of the bank
            Console.WriteLine();
            Console.WriteLine("How difficult is the bank to rob? (Enter an integer)");
            int bankLevel = Convert.ToInt32(Console.ReadLine());

            // Make an empty crew list
            CrewList manifest = new CrewList();

            // Refactor to collect several team members' information and stop collecting team members when a blank name is entered
            bool askUser = true;
            while (askUser == true)
            {
              // Prompt the user to enter a team member's name and save that name
              Console.WriteLine();
              Console.WriteLine("Enter a name for the criminal or leave blank to move on to the next step");
              string readName = Console.ReadLine();

              // Exit if blank and set askUser to false
              if (readName != "")
              {
                // Prompt the user to enter a team member's skill level and save that skill level with the name
                Console.WriteLine($"What is {readName}'s skill level for the heist? (Enter a whole number above zero)");
                int readSkill = Convert.ToInt32(Console.ReadLine());
                // Prompt the user to enter a team member's courage factor and save that courage factor with the name
                Console.WriteLine("That's interesting...");
                Console.WriteLine($"What is {readName}'s courage factor for the heist? (Enter a decimal between 0.0 and 2.0)");
                float readCourage = float.Parse(Console.ReadLine());
                // Save the entered information as an accomplice
                TeamMember accomplice = new TeamMember()
                {
                  Name = readName,
                  SkillLevel = readSkill,
                  CourageFactor = readCourage
                };
                // Add the current accomplice to the crew list
                manifest.AddMember(accomplice);
              }
              else{
                askUser = false;
              }

            }

            // Display a message containing the number of members of the team
            int manifestCount = manifest.CountMembers();
            Console.WriteLine();
            Console.WriteLine($"Great team. You have {manifestCount} people on the crew");
            Console.WriteLine();

            // Make a copy of the crew list from the manifest to use
            List<TeamMember> crewListCopy = manifest.GetCrew();

            /* Stop displaying team member's information in phase 3
            // Display each team member's information
            foreach (TeamMember x in crewListCopy)
            {
              Console.WriteLine($"Welcome aboard, {x.Name}");
              Console.WriteLine($"Skill level: {x.SkillLevel}, Courage factor: {x.CourageFactor}");
            }
            */

            // Sum the skill levels of the team. Save that number
            // Make a list of just the skill values to add
            List<int> skillIndex = new List<int>() {};
            foreach (TeamMember x in crewListCopy)
            {
              skillIndex.Add(x.SkillLevel);
            }

            int teamSkillLevel = skillIndex.Sum();

            // Update to run the scenario multiple times with different luck.
            // Prompt user to enter the number of trial runs the program should perform.
            Console.WriteLine();
            Console.WriteLine("########################################");
            Console.WriteLine("How many trials do you want to run? (Enter a number)");
            int trials = Convert.ToInt32(Console.ReadLine());

            // Make an index to count how many successes and failures there are
            List<int> heistSuccess = new List<int>() {};
            List<int> heistFailure = new List<int>() {};

            for (int i = 0; i < trials; i++)
            {
              // Create a new bank and store a value for the bank's difficulty level. Set this value to 100.
              // Update to create a rancom number between -10 and 10 for the heist's luck value
              int heistLuck = new Random().Next(-10, 10);
              Bank localBranch = new Bank() {DifficultyLevel = bankLevel + heistLuck};

              /* Compare the team skill with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, display a success message, otherwise display a failure message.
              */

              /*
              In phase 6, change report to show count of successes and failures

              Before displaying the success or failure message, display a report that shows:
                - the team's combined skill level
                - the bank's difficulty level
              */
              if (teamSkillLevel >= localBranch.DifficultyLevel)
              {
                // Console.WriteLine("$$$$$$$$$$$);
                // Console.WriteLine($"The team's combined skill is {teamSkillLevel}");
                // Console.WriteLine($"The bank's difficulty is only {localBranch.DifficultyLevel}");
                // Console.WriteLine("The heist will be a success");
                heistSuccess.Add(1);
              }
              else
              {
                // Console.WriteLine($$$$$$$$$$$);
                // Console.WriteLine($"The team's combined skill is {teamSkillLevel}");
                // Console.WriteLine($"The bank's difficulty is {localBranch.DifficultyLevel}");
                // Console.WriteLine($"The heist will be a failure");
                heistFailure.Add(1);
              }
            }
            // At the end of the program, display a report showing the number of successful runs and the number of failed runs.
            Console.WriteLine();
            Console.WriteLine($"Thanks, the heist succeeded {heistSuccess.Sum()} times and failed {heistFailure.Sum()} times");

            // In the Main method, create a List<IRobber> and store it in a variable named rolodex
            // pre-populate the list with 5 or 6 robbers (give it a mix of Hackers, Lock Specialists, and Muscle)
            List<IRobber> rolodex = new List<IRobber>
            {
              new Hacker
              {
                Name = "Todd",
                SkillLevel = 50,
                PercentageCut = 5
              },
              new Hacker
              {
                Name = "Patti",
                SkillLevel = 42,
                PercentageCut = 5
              },
              new Muscle
              {
                Name = "Gabe",
                SkillLevel = 10,
                PercentageCut = 5
              },
              new Muscle
              {
                Name = "Aaron",
                SkillLevel = 77,
                PercentageCut = 5
              },
              new LockSpecialist
              {
                Name = "Jordan",
                SkillLevel = 20,
                PercentageCut = 5
              },
              new LockSpecialist
              {
                Name = "Tommy",
                SkillLevel = 15,
                PercentageCut = 5
              }
            };

            // When the program starts, print out the number of current operatives in the roladex
            Console.WriteLine($"There are {rolodex.Count} current operatives in the roladex.");
            
            // prompt the user to enter the name of a new possible crew member
            // allow the user to enter as many crew members as they like to the rolodex until they enter a blank name
            string userName = null;
            while (userName != "")
            {
              Console.WriteLine("Enter the name of a new possible crew member. Leave blank to move on.");
              userName = Console.ReadLine();
              // Terminate the loop if the user enters nothing
              if (userName == "")
              {
                break;
              }

              // Print out a list of possible specialties and have the user select which specialty this operative has.
              // a dictionary with all 3 specialities
              Dictionary<string, string> skillsSelect = new Dictionary<string, string>()
              {
                {"A", "Hacker (Disables alarms"},
                {"B", "Muscle (Disables guards)"},
                {"C", "Lock Specialist (cracks vault)"}
              };
              Console.WriteLine("\nWhat specialty are the known for?" +
                          $"\na: {skillsSelect["A"]}" +
                          $"\nb: {skillsSelect["B"]}" +
                          $"\nc: {skillsSelect["C"]}");
              // Have the user type the letter of choice in list to save that specialty
              string cki = Console.ReadKey(true).Key.ToString();
              string userSkill = null;
              // Use error handling in case the user doesn't pick from the list.
              try
              {
                // save just the name of the class of robber from the selected pick
                userSkill = skillsSelect[cki].Substring(0, skillsSelect[cki].IndexOf("(")).Replace(" ", string.Empty);
              }
              catch (KeyNotFoundException)
              {
                Console.WriteLine("\nYou didn't pick one of the 3 options. Try again.");
                // give the user one more chance to pick from the list
                try
                {
                  Console.WriteLine("\nWhat specialty are they known for?" +
                            $"\n{skillsSelect["A"]}" +
                            $"\n{skillsSelect["B"]}" +
                            $"\n{skillsSelect["C"]}");
                  cki = Console.ReadKey(true).Key.ToString();
                  // save just the name of the class of robber from the selected pick
                  userSkill = skillsSelect[cki].Substring(0, skillsSelect[cki].IndexOf("(")).Replace(" ", string.Empty);
                }
                catch (KeyNotFoundException)
                {
                  Console.WriteLine("\nYou are trying to cause problems. Goodbye.");
                  Environment.Exit(0);
                }
              }

              // prompt the user to enter the new member's skill level
              int userLevel = -1;
              // keep asking for skill level if integer doesn't fall in required range
              while (userLevel < 1 || userLevel > 100)
              {
                Console.WriteLine($"\nWhat is {userName}'s skill level? (Enter an integer between 1-100");
                // Make sure the skill level is an integer
                try
                {
                  userLevel = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                  Console.WriteLine("Please enter only an integer value for skill level.");
                  // give second chance to enter a number
                  try
                  {
                    userLevel = Convert.ToInt32(Console.ReadLine());
                  }
                  catch (FormatException)
                  {
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                  }
                }
              }

              // Once all data has been gathered, add the new member to the rolodex.
              // Use if statement to add different classes.
              if (userSkill == "Hacker")
              {
                Hacker newMember = new Hacker
                {
                  Name = userName,
                  SkillLevel = userLevel
                };
                // Add newly created member to rolodex
                rolodex.Add(newMember);
              }
              else if (userSkill == "Muscle")
              {
                Muscle newMember = new Muscle
                {
                  Name = userName,
                  SkillLevel = userLevel
                };
                // add newly created member to rolodex
                rolodex.Add(newMember);
              }
              else
              {
                LockSpecialist newMember = new LockSpecialist
                {
                  Name = userName,
                  SkillLevel = userLevel
                };
                // Add newly created member to rolodex
                rolodex.Add(newMember);
              }
            }
          
        } 
    }
}
