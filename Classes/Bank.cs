using System;

namespace heist
{
  public class Bank
  {
    /* Create a way to store a value for the bank's difficulty level. Make a class to allow for expanding banks in the future.
    */
    public int DifficultyLevel {get; set;}

    // An integer property for CashOnHand
    public int CashOnHand {get; set;}
    // An integer property for AlarmScore
    public int AlarmScore {get; set;}
    // An integer property for VaultScore
    public int VaultScore {get; set;}
    // An integer property for SecurityGuardScore
    public int SecurityGuardScore {get; set;}
    /* A computed boolean property called IsSecure. If all the scores are less than or equal to 0, this should be false. If any of the scores are above 0, this should be true
    */
    // public bool IsSecure {get; set;}
    // Calculated property that has no setter. It is readonly.
    public bool IsSecure
    {
      get
      {
        /* 
        If all the scores are less than or equal to 0, this should be false. If any of the scores are above 0, this should be true. Evaluate each individually instead of as a sum to account for the possibility of negative integers on some properties.
        */
        if (CashOnHand > 0 || AlarmScore > 0 || VaultScore > 0 || SecurityGuardScore > 0)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
    }
  }
}