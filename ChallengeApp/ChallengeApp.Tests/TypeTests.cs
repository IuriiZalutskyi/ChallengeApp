namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CheckTwoTypeWartosciowyIntAreNotEqual()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;
            //act

            //assert
            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void CheckTwoTypeReferncijnyStringAreEqual()
        {
            //arrange
            string user1 = "Kasper";
            string user2 = "Kasper";
            //act

            //assert
            Assert.AreEqual(user1, user2);

        }
        [Test]
        public void CheckTwoTypeReferncijnyStringAreNotEqual()
        {
            //arrange
            var user1 = GetUser("Kasper");
            var user2 = GetUser("Kasia");
            //act

            //assert
            Assert.AreNotEqual(user1.Name, user2.Name);

        }

        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}
