using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee()
        {

        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
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
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String in not float");

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

            switch (statistics.Avarege)
            {
                case var averege when averege >= 80:
                    statistics.AvaregeLetter = 'A';
                    break;
                case var averege when averege >= 60:
                    statistics.AvaregeLetter = 'B';
                    break;
                case var averege when averege >= 40:
                    statistics.AvaregeLetter = 'C';
                    break;
                case var averege when averege >= 20:
                    statistics.AvaregeLetter = 'D';
                    break;
                default:
                    statistics.AvaregeLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
