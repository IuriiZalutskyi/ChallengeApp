using ChallengeApp;

Employee user1 = new Employee("Kasia", "Sobczak", 37);
Employee user2 = new Employee("Kasper", "Glodny", 23);
Employee user3 = new Employee("Lulu", "Strabuszewska", 41);

user1.AddScore(9);
user2.AddScore(2);
user3.AddScore(3);

user1.AddScore(3);
user2.AddScore(7);
user3.AddScore(4);

user1.AddScore(8);
user2.AddScore(9);
user3.AddScore(1);

user1.AddScore(1);
user2.AddScore(4);
user3.AddScore(8);

user1.AddScore(7);
user2.AddScore(3);
user3.AddScore(6);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee userwithMaxResult = null;
foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userwithMaxResult = user;
        maxResult = userwithMaxResult.Result;
    }
}
Console.WriteLine(userwithMaxResult.Name+" "+ userwithMaxResult.Nazwisko+" "+"wiek:"+ userwithMaxResult.Wiek+"lat"+"," +"punkty:"+ userwithMaxResult.Result);