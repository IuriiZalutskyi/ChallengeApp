namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsMax()
        {
            //arrange
            var employee = new Employee("Kasia", "Sobczak");
            employee.AddGrade(4);
            employee.AddGrade(3);
            employee.AddGrade(5);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(5, statistics.Max);
        }
        [Test]
        public void StatisticsMin()
        {
            //arrange
            var employee = new Employee("Kasia", "Sobczak");
            employee.AddGrade(4);
            employee.AddGrade(3);
            employee.AddGrade(5);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(3, statistics.Min);
        }
        [Test]
        public void StatisticsAvarege()
        {
            //arrange
            var employee = new Employee("Kasia", "Sobczak");
            employee.AddGrade(4);
            employee.AddGrade(3);
            employee.AddGrade(5);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(Math.Round(4.00,2), Math.Round(statistic.Avarege,2));
        }
    }
}
