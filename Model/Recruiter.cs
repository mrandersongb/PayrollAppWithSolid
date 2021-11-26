using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAppWithSolid.Model
{
    class Recruiter
    {
        const int hourlyRate = 22;
        const int hiredBonus = 500;

        float CalculateBonus(int hoursWorked)
        {
            // bonus condition
            return hoursWorked > 100 ? hiredBonus : 0;
        }

        public float CalculateTotalSalary(int hours)
        {
            return hours * hourlyRate + CalculateBonus(hours);
        }

    }
}
