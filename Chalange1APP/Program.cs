int number = 8336;
string numer = number.ToString();
var charLiczba = numer.ToArray();

Console.WriteLine("Wyniki dla liczby: " + numer);
Console.WriteLine("Ilość cyfr = " + charLiczba.Length);

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in charLiczba)
{
    if(letter == '0')
    { 
        
        Console.WriteLine("0 => " + counter0);
        counter0++;
        
    }
    else if(letter == '1')
    {
        
        Console.WriteLine("1 => " + counter1);
        counter1++;
    }
    else if(letter == '2')
    {
        
        Console.WriteLine("2 => " + counter3);
        counter2++;
    }
    else if(letter == '3')
    {
        
        Console.WriteLine(" => " + counter3);
        counter3++;
    }
    else if (letter == '4')
    {
        
        Console.WriteLine("4 => ");
        counter4++;
    }
    else if(letter == '5')
    {
        
        Console.WriteLine("5 => ");
        counter5++;
    }
    else if(letter == '6')
    {
        
        Console.WriteLine("6 => " + counter6);
        counter6++;
    }
    else if(letter == '7')
    {
        
        Console.WriteLine("7 => ");
        counter7++;
    }
    else if(letter == '8')
    {
        
        Console.WriteLine("8 => " + counter8);
        counter8++;
    }
    else if(letter == '9')
    {
        
        Console.WriteLine("9 => ");
        counter9++;
    }
    Console.WriteLine(letter);
}
// OPERATORY RELACYJNE 
// ==   równe
// <=  lub
// >=
// !=  są różne

// operator logiczny 
// && i 
// || lub 
// ! not - negacja