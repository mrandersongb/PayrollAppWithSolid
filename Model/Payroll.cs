using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAppWithSolid.Model
{
    class Payroll
    {
        readonly IEmployee m_employee;

        public Payroll(IEmployee employee)
        {
            m_employee = employee;
        }

        public float CalculateSalary(int hours)
        {
            return m_employee.CalculateSalary(hours);        
        }
    }
}
