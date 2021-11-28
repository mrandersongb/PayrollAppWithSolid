using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAppWithSolid.Model
{
    public class Developer : IEmployee
    {
        const int houlyRate = 40;

        public float CalculateSalary(int hours)
        {
            return hours * houlyRate;
        }
    }
}
