using System;
using System.Collections.Generic;

namespace HeistPartTwo
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Speciality { get; } = "Muscle";
        public Muscle(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;

        }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{Name} is destroying the secruity guards. Decreased security by 50 points");
            if (bank.SecurityGuardScore <= 0) {
                Console.WriteLine($"{Name} has knocked out the guards");
            }
        }
    }
}