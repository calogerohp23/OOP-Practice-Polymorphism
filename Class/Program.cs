namespace OOP_Practice___Polymorphism.Class;

internal class Program
{
    static void Main(string[] args)
    {
        int type = 0;
        bool validOption =false;
        Console.WriteLine("Welcome to the Salary Calculator for ITLA!\nHow many employees do you want to calculate?");
        int employees = Int32.Parse(Console.ReadLine());
        for (int i = 1; i < employees + 1; i++)
        {
            Console.WriteLine($"What type of employee is the employee {i}?");
            Console.WriteLine("1. Fix Contract Teacher\n2. Hour Contrat Teacher\n3. Administrative Employee");
            type = Int32.Parse(Console.ReadLine());

            while (!validOption)
            {
                switch (type)
                {
                    case 1:

                        TeacherFixContract tfc = new();
                    
                        Console.WriteLine($"What's the first name of the teacher {i}?");
                        tfc.FirstName= Console.ReadLine();
                        Console.WriteLine($"What's the last name of the teacher {i}?");
                        tfc.LastName= Console.ReadLine();
                        Console.WriteLine($"How was the academic average of {tfc.FirstName} {tfc.LastName}");
                        tfc.AcademicAverage = Double.Parse(Console.ReadLine());
                        Console.WriteLine($"For {tfc.FirstName} {tfc.LastName},\nSalary: {tfc.SalaryCalculator()}\nBonus:{tfc.BonusCalculator()}");
                        
                        validOption = true;
                        break;
                    case 2:
                        TeacherPerHour tph = new();

                        Console.WriteLine($"What's the first name of the teacher {i}?");
                        tph.FirstName = Console.ReadLine();
                        Console.WriteLine($"What's the last name of the teacher {i}?");
                        tph.LastName = Console.ReadLine();
                        Console.WriteLine($"How many hours did {tph.FirstName} {tph.LastName} worked?");
                        tph.Hour = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"For {tph.FirstName} {tph.LastName},\nSalary: {tph.SalaryCalculator()}");
                        Console.WriteLine("");
                        
                        validOption = true;
                        break;
                    case 3:
                        AdministrativeEmployee ae = new();

                        Console.WriteLine($"What's the first name of the administrative employee {i}?");
                        ae.FirstName = Console.ReadLine();
                        Console.WriteLine($"What's the last name of the administrative employee {i}?");
                        ae.LastName = Console.ReadLine();
                        Console.WriteLine($"How much is the productivity for {ae.FirstName} {ae.LastName}");
                        ae.Productivity = Double.Parse(Console.ReadLine());
                        Console.WriteLine($"For {ae.FirstName} {ae.LastName},\nSalary: {ae.SalaryCalculator()}\nBonus:{ae.BonusCalculator()}");
                        
                        validOption = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid option.");
                        break;                   
                }
            }
            validOption = false;
        }
    }
}
