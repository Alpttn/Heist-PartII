using System;

namespace HeistPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker hacker = new Hacker("Phil", 60, 40);
            Muscle muscle = new Muscle("Stephen", 40, 30);
            LockSpecialist lockSpecialist = new LockSpecialist("Ryan", 30, 30);

            Console.WriteLine($"{hacker.Name} is hacking the alarm system. Decreased security by 50 points");
            Console.WriteLine($"{muscle.Name} is destroying the secruity guards. Decreased security by 50 points");
            Console.WriteLine($"{lockSpecialist.Name} is picking the vault lock. Decreased security by 50 points");
        }
    }
}
