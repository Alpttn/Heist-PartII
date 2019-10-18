using System;
using System.Collections.Generic;

namespace HeistPartTwo
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Speciality { get; } = "Lock Specialist"; 
        public LockSpecialist(string name, int skillLevel, int percentageCut) 
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;

        }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} is picking the vault lock. Decreased security by 50 points");
            if (bank.VaultScore <= 0) {
                Console.WriteLine($"{Name} has picked the vault lock!");
            }
        }
    }
}