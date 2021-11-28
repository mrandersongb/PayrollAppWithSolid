using Microsoft.VisualStudio.TestTools.UnitTesting;

using PayrollAppWithSolid.Model;

namespace PayrollAppWithSolidTest
{
    [TestClass]
    public class PayrollTest
    {
        [TestMethod]
        public void CalculateSalaryDeveloperTest()
        {
            Developer developer = new Developer();

            Payroll payroll = new Payroll(developer);

            Assert.AreEqual(payroll.CalculateSalary(10), 400);
        }

        [TestMethod]
        public void CalculateSalaryTeamLeaderTest()
        {
            TeamLeader teamLeader = new TeamLeader();

            Payroll payroll = new Payroll(teamLeader);

            Assert.AreEqual(payroll.CalculateSalary(10), 350);
        }

        [TestMethod]
        public void CalculateSalaryRecruiterTest()
        {
            Recruiter teamLeader = new Recruiter();

            Payroll payroll = new Payroll(teamLeader);

            Assert.AreEqual(payroll.CalculateSalary(10), 220);
        }

        [TestMethod]
        public void CalculateSalaryRecruiterWithBonusTest()
        {
            Recruiter teamLeader = new Recruiter();

            Payroll payroll = new Payroll(teamLeader);

            Assert.AreEqual(payroll.CalculateSalary(101), 2722);
        }
    }
}
