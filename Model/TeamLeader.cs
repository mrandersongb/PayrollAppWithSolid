using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollAppWithSolid.Model
{
    class TeamLeader
    {
        const int hourlyRate = 35;

        public float CalculateTeamLeaderSalary(int hours)
        {
            return hours * hourlyRate;
        }
    }
}
