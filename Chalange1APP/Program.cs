// To są moje początki
using System.ComponentModel.Design;

var name = "EWA";
var age = 13;
var sex1 = "mężczyzna";
var sex2 = "kobieta";
string tinager = "Niepełnoletni";
if (age == 33)
{
    if (name == "EWA")
    {
        Console.WriteLine("Ewa lat 33");
    }
}
else if (age < 18)
{
    if (sex1 == "mężczyzna")
    {
        Console.WriteLine("jestem niepełnoletni Adam");
    }
}
else if (age < 30)
{
    if (sex2 == "kobieta") ;
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}