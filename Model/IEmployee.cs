using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAppWithSolid.Model
{
    interface IEmployee
    {
        float CalculateSalary(int hours);
    }
}
