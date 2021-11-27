using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAppWithSolid.Model
{
    class Recruiter : IEmployee
    {
        const int hourlyRate = 22;
        const int hiredBonus = 500;

        float CalculateBonus(int hoursWorked)
        {
            // bonus condition
            return hoursWorked > 100 ? hiredBonus : 0;
        }

        public float CalculateSalary(int hours)
        {
            return hours * hourlyRate + CalculateBonus(hours);
        }
    }
}
