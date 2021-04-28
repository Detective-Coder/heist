namespace heist
{
  //  Start by creating an interface called IRobber
  public interface IRobber
  {
    // A string property for Name
    string Name {get;}
    // An integer property for SkillLevel
    int SkillLevel {get;}
    // An integer property for PercentageCut
    int PercentageCut {get;}
    // A method called PerformSkill that takes in a Bank parameter and doesn't return anything.
    void PerformSkill(Bank bank);
  }
}