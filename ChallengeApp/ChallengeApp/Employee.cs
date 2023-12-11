using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            //3.99
            //3
            int valueInInt = (int)grade;
            float f = valueInInt;
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(double grade)
        {
            float valueinfloat = (float)grade;
            this.AddGrade(valueinfloat);
        }

        public void AddGrade(long grade)
        {
            float valueinfloat = (float)grade;
            this.AddGrade(valueinfloat);
        }


        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
       
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avarege = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0) 
                { 
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avarege += grade;
                }
            }

            statistics.Avarege = statistics.Avarege / this.grades.Count;
            return statistics;
        }
    }
}
