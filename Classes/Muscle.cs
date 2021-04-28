using System;

namespace heist
{
  public class Muscle : IRobber
  {
    public string Name {get; set;}

    public int SkillLevel {get; set;}

    public int PercentageCut {get; set;}

    public void PerformSkill(Bank bank)
    {
      Console.WriteLine($"Beefcake {Name} is fighting security. Subtract {SkillLevel} points from the bank");
      bank.SecurityGuardScore = bank.SecurityGuardScore = SkillLevel;

      if (bank.SecurityGuardScore <= 0)
      {
        Console.WriteLine($"Beefcake {Name} has taken out security.");
      }
      else
      {}
    }
  }
}