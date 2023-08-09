namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TypeWartosciowyInt()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;
            //act

            //assert
            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void TypeReferncijnyString()
        {
            //arrange
            string user1 = "Kasper";
            string user2 = "Kasper";
            //act

            //assert
            Assert.AreEqual(user1, user2);

        }

        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}
