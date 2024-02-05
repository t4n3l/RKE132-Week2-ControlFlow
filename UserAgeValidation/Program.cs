//esimene variant

//Console.WriteLine("Palun sisesta oma vanus:");
//int vanus = Int32.Parse(Console.ReadLine());

//if (vanus <= 13)
//{
//    Console.WriteLine("Sa oled liiga noor, et kasutada Instagrami");
//}
//else
//{
//    Console.WriteLine("Tere tulemast Instagrami");
//}

//teine varianut

Console.WriteLine("Palun sisesta oma vanus:");
string kasutajaVanus = Console.ReadLine();

int kasutajaNumVanus = 0;

bool kasVanusNum = Int32.TryParse(kasutajaVanus, out kasutajaNumVanus);

Console.WriteLine($"Parse tulemus {kasVanusNum}. Kasutaja on {kasutajaNumVanus}-aastane.");

if(kasVanusNum)
{
    if(kasutajaNumVanus >= 13)
    {
        Console.WriteLine("Tere tulemast Instagrami!");
    }
    else
    {
        Console.WriteLine("Sa oled liiga noor, et kasutada Instagrami!");
    }
}
else
{
    Console.WriteLine("Vanust ei tuvastatud.");
}


//videost esimene variant

//Console.WriteLine("Enter your age:");

//int userAge = Int32.Parse(Console.ReadLine());

//if (userAge > 13)
//{
//    Console.WriteLine("Welcome to Instagram!");
//}
//else
//{
//    Console.WriteLine("You are too young to use Instagram.");
//}

//Console.WriteLine("Enter your age:");
//string userAge = Console.ReadLine();

//int userAgeNum = 0;

//bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

//if (isAgeNumber)
//{
//    if (userAgeNum >= 13)
//    {
//        Console.WriteLine("Welcome to Instagram!");
//    }
//    else
//    {
//        Console.WriteLine("You are too young to use Instagram!");
//    }
//}
//else
//{
//    Console.WriteLine("Could not read your age.");
//}
