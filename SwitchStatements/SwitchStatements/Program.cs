string favSubject;
//Taking input from user
Console.WriteLine("What is your favorite subject in school?");

favSubject = Console.ReadLine();
Console.WriteLine();

//Switch statement
switch(favSubject.ToLower())
{
    case "science":
        Console.WriteLine("Me too!");
        break;
    case "math":
        Console.WriteLine($"{favSubject} is cool!");
        break;
    case "spanish":
        Console.WriteLine($"{favSubject} is cool!");
        break;
    case "english":
        Console.WriteLine($"{favSubject} is cool!");
        break;
    case "art":
        Console.WriteLine($"{favSubject} is cool!");
        break;
    case "health":
        Console.WriteLine($"{favSubject} is cool!");
        break;
    case "computer science":
        Console.WriteLine($"{favSubject} is cool!");
        break;
    case "gym":
        Console.WriteLine($"{favSubject} is cool!");
        break;
    default:
        Console.WriteLine("Are you sure you don't have a favorite?");
        break;
}




