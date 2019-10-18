using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistPartTwo
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; } //get is a method that returns whatever type you give it. set takes an integer
        //I can call bank.strongestsystem and the get method will be run and the string
        public string StrongestSystem   
        {
            get
            {
                List<int> scores = new List<int> {
                    AlarmScore,
                    VaultScore,
                    SecurityGuardScore
                };

                int highestScore = scores.Max();

                if (AlarmScore == highestScore) {
                    return "Alarm";
                } else if (VaultScore == highestScore) {
                    return "Vault";
                } else {
                    return "Security Guard";
                }
            }
        }
         public string WeakestSystem   
        {
            get
            {
                List<int> scores = new List<int> {
                    AlarmScore,
                    VaultScore,
                    SecurityGuardScore
                };

                int weakestScore = scores.Min();

                if (AlarmScore == weakestScore) {
                    return "Alarm";
                } else if (VaultScore == weakestScore) {
                    return "Vault";
                } else {
                    return "Security Guard";
                }
            }
        }


        public bool IsSecure
        {
            get
            {
                if (AlarmScore <= 0 || VaultScore <= 0 || SecurityGuardScore <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}