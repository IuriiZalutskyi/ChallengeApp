using ChallengeApp;

var employee = new Employee("Adam", "Kasperski");
employee.AddGrade("4000");
employee.AddGrade("Adam");
employee.AddGrade(-5);
employee.AddGrade(3000);
employee.AddGrade(5);
employee.AddGrade(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"Avarege:{statistics.Avarege:N2}");
Console.WriteLine($"Max:{statistics.Max}");
Console.WriteLine($"Min:{statistics.Min}");

