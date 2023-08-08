
namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void EmployeeCollectTwoScores1()
        {
            //arrange
            var user = new Employee("Kasia","Sobczak",21);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-11);
            //act
            var result = user.Result;
            //assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void EmployeeCollectTwoScores2()
        {
            //arrange
            var user = new Employee("Kasia", "Sobczak", 21);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(2);
            //act
            var result = user.Result;
            //assert
            Assert.AreEqual(11, result);
        }
        [Test]
        public void EmployeeCollectTwoScores3()
        {
            //arrange
            var user = new Employee("Kasia", "Sobczak", 21);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(2);
            //act
            var result = user.Result;
            //assert
            Assert.AreEqual(13, result);
        }
    } 
}