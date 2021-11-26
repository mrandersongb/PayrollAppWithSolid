using System;

using PayrollAppWithSolid.Model;

namespace PayrollAppWithSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Payroll payroll = new Payroll();

                Console.WriteLine("Fill the employeer [developer|teamLeader|recruiter]: ");

                string employeer = Console.ReadLine();

                Console.WriteLine("Fill the amount hours: ");

                int hours = int.Parse(Console.ReadLine());

                float salary = payroll.CalculateSalary(employeer, hours);

                Console.WriteLine($"Salary value: {salary}");
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
