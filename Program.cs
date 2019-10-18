using System;
using System.Collections.Generic;

namespace HeistPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker hacker1 = new Hacker("Phil", 60, 40);
            Hacker hacker2 = new Hacker("Allie", 60, 40);
            Muscle muscle1 = new Muscle("Stephen", 40, 30);
            Muscle muscle2 = new Muscle("Katie", 40, 30);
            LockSpecialist lockSpecialist1 = new LockSpecialist("Ryan", 30, 30);
            LockSpecialist lockSpecialist2 = new LockSpecialist("Whitney", 30, 30);

            List<IRobber> rolodex = new List<IRobber>();
            rolodex.Add(hacker1);
            rolodex.Add(hacker2);
            rolodex.Add(muscle1);
            rolodex.Add(muscle2);
            rolodex.Add(lockSpecialist1);
            rolodex.Add(lockSpecialist2);

            //start the program
            Console.WriteLine($"There are {rolodex.Count} operatives in the rolodex");
            Console.Write("New Crew Member> ");
            string newCrewMember = Console.ReadLine();

            while (newCrewMember != "") //when no name is entered its false
            {
                Console.WriteLine("Choose a specialty for your crew member");
                Console.WriteLine("Hacker (Disables alarms)");
                Console.WriteLine("Muscle (Disarms guards)");
                Console.WriteLine("Lock Specialist (Cracks vault)");
                Console.Write("Specialty> ");
                string specialty = Console.ReadLine();
                Console.WriteLine("Enter a number between 1-100 to give your crew member a skill level");
                Console.Write("Skill Level> ");
                int skillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Get paid to raid! Enter what percent of the cut your robber wants");
                Console.Write("Percentage Cut> ");
                int percentageCut = int.Parse(Console.ReadLine());

                if (specialty == "Hacker")
                {
                    rolodex.Add(new Hacker(newCrewMember, skillLevel, percentageCut));
                } 
                if (specialty == "Muscle") 
                {
                    rolodex.Add(new Muscle(newCrewMember, skillLevel, percentageCut));
                }
                if (specialty == "LockSpecialist") 
                {
                    rolodex.Add(new LockSpecialist(newCrewMember, skillLevel, percentageCut));
                }
                Console.WriteLine();
                Console.Write("New crew member> ");
                newCrewMember = Console.ReadLine();
            }

            Bank bank = new Bank() {
                AlarmScore = 30,
                VaultScore = 50,
                SecurityGuardScore = 60,
                CashOnHand = 55_000
            };

            Console.WriteLine($"The bank's most secure system is the {bank.StrongestSystem} system");
            Console.WriteLine($"The bank's least secure system is the {bank.WeakestSystem} system");
            Console.WriteLine();
            Console.WriteLine("Here's your team:");
            foreach (IRobber robber in rolodex) 
            {
                Console.WriteLine($"Name: {robber.Name}, Speciality: {robber.Speciality}, Skill Level {robber.SkillLevel}, Percentage cut: {robber.PercentageCut}");
            }
        }
    }
}

