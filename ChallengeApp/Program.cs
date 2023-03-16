using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;

string name = "Ewa";
string sex = "woman";
var age = 33;

//1. Kobieta poniżej 30 lat
if (sex == "woman" && age < 30);
{
    Console.WriteLine("kobieta poniżej 30lat");
}

//2. Ewa lat 33
if (name == "Ewa" && age == 33);
{
    Console.WriteLine("Ewa, lat 33");
}

//3. Niepełnoletni mężczyzna
if (!(sex == "woman" && age > 18));
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
