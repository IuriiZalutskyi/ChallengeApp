using ChallengeApp;

var employee = new Employee("Adam", "Kasperski");
employee.AddGrade("4000");
employee.AddGrade("Adam");
employee.AddGrade(-5);
employee.AddGrade(3000);
employee.AddGrade(5);
employee.AddGrade(6);

//var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();


Console.WriteLine($"Avarege:{statistics1.Avarege:N2}");
Console.WriteLine($"Max:{statistics1.Max}");
Console.WriteLine($"Min:{statistics1.Min}");

Console.WriteLine($"Avarege:{statistics2.Avarege:N2}");
Console.WriteLine($"Max:{statistics2.Max}");
Console.WriteLine($"Min:{statistics2.Min}");

Console.WriteLine($"Avarege:{statistics3.Avarege:N2}");
Console.WriteLine($"Max:{statistics3.Max}");
Console.WriteLine($"Min:{statistics3.Min}");

Console.WriteLine($"Avarege:{statistics4.Avarege:N2}");
Console.WriteLine($"Max:{statistics4.Max}");
Console.WriteLine($"Min:{statistics1.Min}");

