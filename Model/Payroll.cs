using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAppWithSolid.Model
{
    class Payroll
    {
        public float CalculateSalary(String employee,int hours)
        {
            float salary = 0;

            if (employee == "developer" )
            {
                salary = new Developer().CalculateSalary(hours);
            }

            else if (employee == "teamLeader")
            {
                salary = new TeamLeader().CalculateTeamLeaderSalary(hours);
            }

            else if (employee == "recruiter")
            {
                salary = new Recruiter().CalculateTotalSalary(hours);
            }

            return salary;
        }
    }
}
