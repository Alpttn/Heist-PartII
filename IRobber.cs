namespace HeistPartTwo
{
    public interface IRobber
    {
        string Name { get; set; }
    
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }
        string Speciality { get; } //we don't want to set it because it's being entered by the user

        void PerformSkill(Bank bank);
       
    }
}