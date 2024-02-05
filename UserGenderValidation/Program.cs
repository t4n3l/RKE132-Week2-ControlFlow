Console.WriteLine("Sisesta oma sugu (m/n):");
char sugu = Char.Parse(Console.ReadLine());


Console.WriteLine("Sisesta oma perekonnanimi:");
string perekonnanimi = Console.ReadLine();


if (sugu == 'm')
{
    Console.WriteLine("Tere, Hr. " + perekonnanimi);
}
else if (sugu == 'n')
{
    Console.WriteLine("Tere, Pr. " + perekonnanimi);
}



//Console.WriteLine("Please, select your gender (m/f):");
//char userGender = Char.Parse(Console.ReadLine());

//Console.WriteLine("Please, enter your last name");
//string userLastName = Console.ReadLine();

//if (userGender == 'm')
//{
//    Console.WriteLine($"Welcome, Mr. {userLastName}");
//}
//else if (userGender == 'f')
//{
//    Console.WriteLine($"Welcome, Ms. {userLastName}");
//}
//else
//{
//    Console.WriteLine("Welcome!");
//}