namespace ChallengeApp
{
    public class Employee
    {

        private List<int> score = new List<int>();


        public Employee(string name, string nazwisko, uint wiek)
        {
            this.Name = name;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }
        public string Name { get; private set; }
        public string Nazwisko { get; private set; }
        public uint Wiek { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
            
        }

    }
}
