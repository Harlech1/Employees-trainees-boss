namespace inheritchall
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Boss boss1 = new Boss("Boss","Türker",50000,"Mazda");
          boss1.Lead();
          boss1.Work();
          boss1.Pause();
          Trainees trainee1 = new Trainees("Trainee","Ahmet", 10000, 6);
          trainee1.Work();
          trainee1.Learn();
          trainee1.Pause();
          Employees employee1 = new Employees("Employee", "Ali", 20000, 3);
          employee1.Work();
          employee1.Pause();
        }
    }
}