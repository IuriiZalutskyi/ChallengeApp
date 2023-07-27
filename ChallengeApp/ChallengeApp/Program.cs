var name = "Kasper";
var age = 18;
var sex = "man";

if (sex == "man")
{
    if (age > 30)
    {
        Console.WriteLine(name + ", powyzej 30 lat");
    }
    else if (age > 20)
    {
        Console.WriteLine("Mezczyzna ponizej 30 lat");
    }
    else if (age < 20)
    {
        Console.WriteLine("Niepelnoliatek meczyzna");
    }
}
else
{
    Console.WriteLine("Kobieta lat " + age);
}
