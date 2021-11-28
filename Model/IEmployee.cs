using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAppWithSolid.Model
{
    public interface IEmployee
    {
        float CalculateSalary(int hours);
    }
}
