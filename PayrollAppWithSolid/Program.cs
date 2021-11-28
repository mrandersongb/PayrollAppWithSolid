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
                Console.WriteLine("Fill the employeer [0-developer|1-teamLeader|2-recruiter]: ");

                int employee = int.Parse(Console.ReadLine());

                Payroll payroll = employee switch
                {
                    0 => new Payroll(new Developer()),
                    1 => new Payroll(new TeamLeader()),
                    2 => new Payroll(new Recruiter()),
                    _ => null
                };

                if (payroll != null)
                {
                    Console.WriteLine("Fill the amount hours: ");

                    int hours = int.Parse(Console.ReadLine());

                    float salary = payroll.CalculateSalary(hours);

                    Console.WriteLine($"Salary value: {salary}");
                }  
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
