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
                
            }
        }
    }
}
