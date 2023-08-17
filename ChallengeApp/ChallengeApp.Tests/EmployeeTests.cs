namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsMax()
        {
            //arrange
            var employee = new Employee("Kasia", "Sobczak");
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(5);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(6, statistics.Max);
        }
        [Test]
        public void StatisticsMin()
        {
            //arrange
            var employee = new Employee("Kasia", "Sobczak");
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(5);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void StatisticsAvarege()
        {
            //arrange
            var employee = new Employee("Kasia", "Sobczak");
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(5);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(Math.Round(4.33,2), Math.Round(statistic.Avarege,2));
        }
    }
}
