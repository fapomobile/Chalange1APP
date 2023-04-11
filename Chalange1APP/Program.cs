// To są moje początki
using System.ComponentModel.Design;

var name = "EWA";
var age = 30;
var sex1 = "mężczyzna";
var sex2 = "kobieta";

if (age == 33 && sex2 == "kobieta")
{
    if (name == "EWA")
    {
        Console.WriteLine("Ewa lat 33");
    }
    else
    {
        Console.WriteLine("To jest jakaś kobieta");
    }
}
else if (age < 18)
{
    if (sex1 == "mężczyzna")
    {
        Console.WriteLine("jestem niepełnoletni Adam");
    }
    else
    {
        Console.WriteLine("To może być kobieta");
    }
}
else if (age < 30)
{
    if (sex2 == "kobieta") ;
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}