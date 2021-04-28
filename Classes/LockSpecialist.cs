using System;

namespace heist
{
  public class LockSpecialist : IRobber
  {
    public string Name {get; set;}

    public int SkillLevel {get; set;}

    public int PercentageCut {get; set;}

    public void PerformSkill(Bank bank)
    {
      Console.WriteLine($"Lockpicker {Name} is breaking into the vault. Subtract {SkillLevel} points from the bank.");
      bank.VaultScore = bank.VaultScore = SkillLevel;

      if (bank.VaultScore <= 0)
      {
        Console.WriteLine($"Lockpicker {Name} has opened the vault.");
      }
      else 
      {}
    }
  }
}