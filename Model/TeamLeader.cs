using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAppWithSolid.Model
{
    class TeamLeader : IEmployee
    {
        const int hourlyRate = 35;

        public float CalculateSalary(int hours)
        {
            return hours * hourlyRate;
        }
    }
}
