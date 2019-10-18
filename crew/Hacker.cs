using System;
using System.Collections.Generic;

namespace HeistPartTwo
{
    public class Hacker : IRobber 
    {
        public string Name { get; set; }
    
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Speciality { get; } = "Hacker"; //this will be set when user choses this specialty

        public Hacker(string name, int skillLevel, int percentageCut) 
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;

        }

        public void PerformSkill(Bank bank) {
           bank.AlarmScore = bank.AlarmScore - SkillLevel; 
           Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by 50 points");
           if (bank.VaultScore <= 0) {
                Console.WriteLine($"{Name} has disabled the alarm!");
            }
        }
    }
}