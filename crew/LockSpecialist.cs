using System;
using System.Collections.Generic;

namespace HeistPartTwo
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public LockSpecialist(string name, int skillLevel, int percentageCut) 
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;

        }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - SkillLevel;
        }
    }
}