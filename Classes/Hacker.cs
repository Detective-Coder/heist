using System;

namespace heist
{
  public class Hacker : IRobber
  {
    public string Name {get; set;}

    public int SkillLevel {get; set;}

    public int PercentageCut {get; set;}

    public void PerformSkill(Bank bank)
    {
      // Take the Bank parameter and decrement its appropriate security score by the SkillLevel
      Console.WriteLine($"Hacker {Name} is hacking the bank. Subtract {SkillLevel} points from the bank");
      bank.AlarmScore = bank.AlarmScore - SkillLevel;

      // If the appropriate security score has be reduced to 0 or below, print a message to the console
      if (bank.AlarmScore <= 0)
      {
        Console.WriteLine($"Hacker {Name} has disabled the alarm system.");
      }
      else
      {}
    }
  }
}