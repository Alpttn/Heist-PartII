using System;
using System.Collections.Generic;

namespace HeistPartTwo
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public Muscle(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;

        }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
        }
    }
}