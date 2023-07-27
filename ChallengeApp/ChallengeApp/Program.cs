var name = "Ewa";
var age = 18;
var sex = "man";

if (sex == "woman")
{
    if (age <= 30)
    {
        Console.WriteLine("Kobieta ponizej 30 lat");
    }
    else if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa,  lat 33");
    }
}
else
{
   if (age>=18)
    { 
        Console.WriteLine("Pelnolietni meczyzna");
    }
   else
    Console.WriteLine("Niepelnoliatek meczyzna");
}
